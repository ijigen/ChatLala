using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT
{
    public class Request
    {
        public string model { set; get; }
        public List<Message> messages { set; get; }
        public float temperature { set; get; }
    }
}
