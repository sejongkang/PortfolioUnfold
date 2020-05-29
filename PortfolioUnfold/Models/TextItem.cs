using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioUnfold.Models
{
    public class TextItem : BaseEntity
    {
        public string PortfolioItemId { get; set; }
        public string Text { get; set; }
    }
}