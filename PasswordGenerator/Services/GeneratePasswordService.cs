using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasswordGenerator.Services
{
    public class GeneratePasswordService
    {
        public GeneratePasswordResult GenerateOtp(GeneratePasswordRequest request)
        {
            try
            {
                var newPassword = RandomPassword(6);

                return new GeneratePasswordResult
                {
                    Password = RandomPassword(6),
                    UserId = request.UserId,
                    RemainingSeconds = 30
                };
            }
            catch (Exception e)
            {
                return new GeneratePasswordResult
                {
                    ErrorMessage = "Ne pare rau, a intervenit o eroare",
                };
            }
        }

        public string RandomPassword(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
