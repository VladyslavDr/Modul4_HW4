using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Shop.Services
{
    public class NotificationService
    {
        private readonly ILogger<NotificationService> _loggerService;
        public NotificationService(ILogger<NotificationService> loggerService)
        {
            _loggerService = loggerService;
        }
    }
}
