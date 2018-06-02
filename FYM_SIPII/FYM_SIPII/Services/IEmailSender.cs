using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYM_SIPII.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
