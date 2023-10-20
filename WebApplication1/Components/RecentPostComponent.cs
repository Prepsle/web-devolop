using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Components
{
    [ViewComponent(Name = "RecentPost")]
    public class RecentPostComponent : ViewComponent
    {
        private readonly DataContext _context;
        public RecentPostComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofMenu = (from p in _context.Posts
                              where (p.IsActive == true) && (p.Status == 1)
                              orderby p.PostID descending
                              select p).Take(6).ToList();

            return await Task.FromResult((IViewComponentResult)View("Default", listofMenu));
        }
    }
}
