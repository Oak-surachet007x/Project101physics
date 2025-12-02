using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingLabpro.CommandDevice
{
    public class EntityValidator : IDataErrorInfo
    {
        [Browsable(false)]
        public bool EnableValidation { get; set; } = false;  // 🛑 ไม่ตรวจทันที

        [Browsable(false)]
        public string this[string property]
        {
            get
            {
                if (!EnableValidation) return string.Empty;

                var propertyDescriptor = TypeDescriptor.GetProperties(this)[property];
                if (propertyDescriptor == null)
                {
                    return string.Empty;
                }
                var results = new List<ValidationResult>();
                var result = Validator.TryValidateProperty(propertyDescriptor.GetValue(this), new ValidationContext(this, null, null) { MemberName = property }, results);
                if (!result)
                {
                    return results.First().ErrorMessage;
                }
                return string.Empty;

            }
        }



        [Browsable(false)]
        public string Error
        {
            get
            {

                var errors = new List<ValidationResult>();
                var result = Validator.TryValidateObject(this, new ValidationContext(this, null, null), errors, true);
                if (!result)
                {
                    return string.Join(Environment.NewLine, errors.Select(e => e.ErrorMessage));

                }
                return null;
            }
        }

        [Browsable(false)]
        public bool IsValid
        {
            get
            {
                return string.IsNullOrEmpty(Error);
            }
        }

    }
}
