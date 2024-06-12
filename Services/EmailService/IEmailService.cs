using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.EmailService
{
    public interface IEmailService
    {
        Task<ServiceResponse<GetEmailDto>> SendEmail(SendEmailDto email);
    }
}