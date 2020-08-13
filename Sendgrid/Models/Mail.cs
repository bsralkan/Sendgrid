using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sendgrid.Models
{
    public class Mail
    {
        public int Id { get; set; }
        public string emailAdresi { get; set; }
        public string mesaj { get; set; }
        public string konu { get; set; }

    }
}
