using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Conctrete
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string UserName { get; set; }
        public string NameSurname { get; set; }
        public string UserMail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }


        // Content <=> Heading
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }


        // Content <=> Writer

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }




    }
}
