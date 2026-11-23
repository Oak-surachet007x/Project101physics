
using System;
using System.Threading;
using System.Threading.Tasks;
using CodingLabpro.Tracking_scan;

public class ScanController
{
    private readonly Func<double, double, CancellationToken, Task>
        _moveMotorAsync;

    public event Action<ScanPoint> PointStatusChanged;

    public ScanController(
        Func<double, double, CancellationToken, Task> moveMotorAsync)
    {
        _moveMotorAsync = moveMotorAsync
            ?? throw new ArgumentNullException(nameof(moveMotorAsync));
    }

    public async Task StartScanAsync(
        ScanSettings settings,
        CancellationToken token)
    {
        settings.Validate();

        int rows = settings.Rows;
        int columns = settings.Columns;

        for (int y = 0; y < rows; y++)
        {
            token.ThrowIfCancellationRequested();

            // Zigzag: แถวคู่เดินซ้ายไปขวา
            // แถวคี่เดินขวาไปซ้าย
            if (y % 2 == 0)
            {
                for (int x = 0; x < columns; x++)
                {
                    await ScanPointAsync(settings, y, x, token);
                }
            }
            else
            {
                for (int x = columns - 1; x >= 0; x--)
                {
                    await ScanPointAsync(settings, y, x, token);
                }
            }
        }
    }

    private async Task ScanPointAsync(
        ScanSettings settings,
        int row,
        int column,
        CancellationToken token)
    {
        var point = new ScanPoint
        {
            Row = row,
            Column = column,
            PositionX = settings.StartX + column * settings.StepX,
            PositionY = settings.StartY + row * settings.StepY,
            Status = ScanCellStatus.Scanning
        };

        // สีเหลือง: เริ่มเคลื่อนที่
        PointStatusChanged?.Invoke(point);

        try
        {
            // ต้องรอจน MoveMotorAsync ทำงานเสร็จจริง
            await _moveMotorAsync(
                point.PositionX,
                point.PositionY,
                token);

            token.ThrowIfCancellationRequested();

            // สีเขียว: มอเตอร์ถึงตำแหน่งเป้าหมายแล้ว
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
