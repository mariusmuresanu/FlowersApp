using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowersApp.Models
{
    public class Comment
    {
        public long Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public Flower Flower { get; set; }
    }
}
