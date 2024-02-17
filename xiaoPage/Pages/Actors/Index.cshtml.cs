using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.Diagnostics;
using xiaoPage.Data;
using xiaoPage.Model;

namespace xiaoPage.Pages.Actors
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDb db;
        public List<Actor> ActorsList { get; set; }

        public IndexModel(ApplicationDb dbcontext)
        {
            this.db = dbcontext;
        }

        public void OnGet()
        {
            ActorsList = db.actors.ToList();
        }
    }
}
