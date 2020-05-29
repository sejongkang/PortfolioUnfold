using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioUnfold.Models
{
    public class ImageItem : BaseEntity
    {
        public string PortfolioItemId { get; set; }
        public string Path { get; set; }
    }
}