﻿namespace PortfolioUnfold.Models
{
    public class ImageItem : BaseEntity
    {
        public string PortfolioItemId { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string Cation { get; set; }
    }
}