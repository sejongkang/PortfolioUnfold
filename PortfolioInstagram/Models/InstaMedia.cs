using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioInstagram.Models
{
    public class InstaMedia
    {
        public string id { get; set; }
        public int MediaDataId { get; set; }
        public string caption { get; set; }
        public string media_url { get; set; }
        public int comments_count { get; set; }
        public int like_count { get; set; }
        public int impression_count { get; set; }
        public string permalink { get; set; }
        public DateTime timestamp { get; set; }
        public DateTime DateCreated { get; set; }

        public InstaMedia()
        {
        }
    }
}
