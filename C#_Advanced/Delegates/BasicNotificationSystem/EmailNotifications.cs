using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Delegates.BasicNotificationSystem
{
    public class EmailNotifications : INotification
    {
        public void Send(string title, string message)
        {
            Console.WriteLine("=== Email Notification ===");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
