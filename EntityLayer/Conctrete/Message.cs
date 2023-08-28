using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Conctrete
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        [StringLength(50)]
        public string MessageSender { get; set; }
        [StringLength(50)]
        public string MessageReceiver { get; set; }
        [StringLength(250)]
        public string MessageSubject { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
