using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioUnfold.Models
{
    public class PortfolioItem : BaseEntity
    {
        /// <summary>
        /// 포트폴리오 아이템
        /// </summary>
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Date { get; set; }
        public string Role { get; set; }
        public string Client { get; set; }
        public string Visit { get; set; }
        public string Place { get; set; }
        public string CategoryId { get; set; }
        public virtual ICollection<ImageItem> ImageItems { get; set; }
        public virtual ICollection<TextItem> TextItems { get; set; }
        public virtual ICollection<VideoItem> VideoItems { get; set; }
        public PortfolioItem()
        {
            this.ImageItems = new List<ImageItem>();
            this.TextItems = new List<TextItem>();
            this.VideoItems = new List<VideoItem>();
        }
    }
}