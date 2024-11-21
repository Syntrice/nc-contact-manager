using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class ValidationResult
    {
        public bool Success { get; }
        public string Message { get; }

        public ValidationResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public ValidationResult(bool success)
        {
            Success = success;
            if (success)
            {
                Message = "success";
            }
            else
            {
                Message = "failed";
            }
        }
    }
}
