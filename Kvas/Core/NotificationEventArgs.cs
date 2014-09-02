using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvas.Core
{
    public class NotificationEventArgs : EventArgs
    {
        public String Status { get; set; }
        public NotificationEventArgs(String status)
        {
            this.Status = status;
        }
    }
}
