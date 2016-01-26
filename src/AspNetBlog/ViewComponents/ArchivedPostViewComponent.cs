using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetBlog.Models;

namespace AspNetBlog.ViewComponents
{
    [ViewComponent]
    public class ArchivedPostViewComponent : ViewComponent
    {
        private readonly BlogDataContext _db;

        public ArchivedPostViewComponent(AspNetBlog.Models.BlogDataContext db) {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var archivedPosts = _db.GetArchivedPosts().ToArray();
            return View(archivedPosts);
        }

    }
}
