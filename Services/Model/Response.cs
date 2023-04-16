using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Model
{
    public class Response
    {
        public Currency[] data { get; set; }

        public object timestamp { get; set; }
    }
}
