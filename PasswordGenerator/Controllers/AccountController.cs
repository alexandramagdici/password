using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PasswordGenerator.Models;
using PasswordGenerator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasswordGenerator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        public GeneratePasswordResult GenerateOtp(GeneratePasswordRequest request)
        {
            try
            {
                var generatePasswordService = new GeneratePasswordService();
                var generateotpResult = generatePasswordService.GenerateOtp(request);

                return generateotpResult;
            }
            catch (Exception e)
            {
                return new GeneratePasswordResult
                {
                    ErrorMessage = "Ne pare rau, a intervenit o eroare la generarea OTP-ului",
                };
            }
        }

    }
}
