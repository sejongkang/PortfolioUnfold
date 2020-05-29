using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioUnfold.Models
{
    public class VideoItem : BaseEntity
    {
        public string PortfolioItemId { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string Cation { get; set; }
    }
}