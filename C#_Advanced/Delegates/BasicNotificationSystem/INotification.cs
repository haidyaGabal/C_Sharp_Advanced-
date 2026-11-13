using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Delegates.BasicNotificationSystem
{
    public interface INotification
    {
        public void Send(string title, string message);
        
       
    }
}
