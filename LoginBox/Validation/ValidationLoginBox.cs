using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LoginBox.Validation
{
    public class ValidationLoginBox : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is string result && !string.IsNullOrEmpty(result))
            {
                return ValidationResult.ValidResult;
            }
            return new ValidationResult(false,"Error");
        }
    }
}
