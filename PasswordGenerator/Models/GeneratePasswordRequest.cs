using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasswordGenerator.Models
{
    public class GeneratePasswordRequest
    {
        public int UserId { get; set; }
        public DateTime GenerationDate { get; set; }

    }
}
