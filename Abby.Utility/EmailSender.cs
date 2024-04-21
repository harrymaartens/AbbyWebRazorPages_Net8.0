using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby.Utility
{
    public class EmailSender : IEmailSender
    {
        // Dit is een FAKE emailsender
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}
