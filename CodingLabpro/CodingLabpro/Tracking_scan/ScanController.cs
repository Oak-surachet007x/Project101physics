using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CodingLabpro.Tracking_scan;

namespace CodingLabpro.Tracking_scan
{
    public class ScanController
    {

        private readonly Func<double, double, CancellationToken, Task> _moveMotorAsync;
        private readonly Func<CancellationToken, Task> _measureAsync;
        public event Action<ScanPoint> PointStatusChanged;

        public ScanController(Func<double, double, CancellationToken, Task> moveMotorAsync, Func<CancellationToken, Task> measureAsync)
        {
            _moveMotorAsync = moveMotorAsync;
            _measureAsync = measureAsync;
        }

        public async Task StartScanAsync(ScanSettings settings,  CancellationToken token)
        {
            settings.Validate();

            int rows = settings.Rows;
            int columns = settings.Columns;

            for (int y = 0; y < rows; y++)
            {
                token.ThrowIfCancellationRequested();

                if (y % 2 == 0)
                {
                    // ซ้ายไปขวา
                    for (int x = 0; x < columns; x++)
                    {
                        await ScanPointAsync(
                            settings, y, x, token);
                    }
                }
                else
                {
                    // ขวาไปซ้าย
                    for (int x = columns - 1; x >= 0; x--)
                    {
                        await ScanPointAsync(settings, y, x, token);
                    }
                }
            }
        }

        private async Task ScanPointAsync(ScanSettings settings, int row, int column, CancellationToken token)
        {
            var point = new ScanPoint
            {
                Row = row,
                Column = column,
                PositionX = settings.StartX + (column * settings.StepX),
                PositionY = settings.StartY + (row * settings.StepY),
                Status = ScanCellStatus.Scanning
            };

            PointStatusChanged?.Invoke(point);

            try
            {
                // Move Motor
                await _moveMotorAsync(point.PositionX, point.PositionY, token);

                token.ThrowIfCancellationRequested();

                // Measurement
                await _measureAsync(token);

                token.ThrowIfCancellationRequested();

                // Completed
                point.Status = ScanCellStatus.Completed;

                PointStatusChanged?.Invoke(point);
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch
            {
                point.Status = ScanCellStatus.Error;

                PointStatusChanged?.Invoke(point);

                throw;
            }
        }


    }


}
