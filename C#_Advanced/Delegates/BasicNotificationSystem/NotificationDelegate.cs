using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Delegates.BasicNotificationSystem
{
    /// <summary>
    /// Represents methods responsible for sending notifications.
    /// </summary>
    public delegate void Notify(string title,string message);
}
