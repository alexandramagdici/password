using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasswordGenerator.Models
{
    public class GeneratePasswordResult
    {
        public string Password { get; set; }
        public int UserId { get; set; }
        public int RemainingSeconds { get; set; }
        public string ErrorMessage { get; set; }

    }
}
