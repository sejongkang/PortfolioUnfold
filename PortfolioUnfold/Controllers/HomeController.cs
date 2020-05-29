using PortfolioUnfold.Contracts;
using PortfolioUnfold.Models;
using PortfolioUnfold.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace PortfolioUnfold.Controllers
{
    public class HomeController : Controller
    {
        IRepository<PortfolioItem> _portfolioItemContext;
        IRepository<Category> _categoryContext;
        public HomeController(IRepository<PortfolioItem> portfolioItemContext, IRepository<Category> categoryContext)
        {
            _portfolioItemContext = portfolioItemContext;
            _categoryContext = categoryContext;
        }
        // 포트폴리오에 필터 적용 안함
        // 할때는 매개변수에 (string Category=null)
        public ActionResult Index()
        {
            List<PortCatViewModel> portCatViewModels = new List<PortCatViewModel>();
            List<PortfolioItem> portfolios = _portfolioItemContext.Collection().ToList();
            List<Category> categories = _categoryContext.Collection().ToList();
            
            for (int idx = 0; idx < portfolios.Count; idx++)
            {
                PortCatViewModel portCatViewModel = new PortCatViewModel()
                {
                    Id = portfolios[idx].Id
                ,
                    Title = portfolios[idx].Title
                ,
                    Category = categories.FirstOrDefault(i => i.Id == portfolios[idx].CategoryId).Type
                ,
                    Image = portfolios[idx].ImageItems.ToList()[0].Path
                };

                portCatViewModels.Add(portCatViewModel);
            }
            return View(portCatViewModels);
        }
        public ActionResult GetPortfolio(string Id)
        {
            PortfolioItem portfolios = _portfolioItemContext.Find(Id);

            return View(portfolios);
        }
    }
}