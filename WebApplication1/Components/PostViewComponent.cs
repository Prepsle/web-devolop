using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Components
{
    [ViewComponent(Name = "Post")]
    public class PostViewComponent : ViewComponent
    {
        private DataContext _context;
        public PostViewComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofMenu = (from m in _context.Posts
                              where (m.IsActive == true) && (m.Status == 1)
                              select m).ToList();
            //m.Position == 1 menu nằm trên
            //m.Position == 0 menu nằm dưới

            return await Task.FromResult((IViewComponentResult)View("Default", listofMenu));
        }
    }
}
