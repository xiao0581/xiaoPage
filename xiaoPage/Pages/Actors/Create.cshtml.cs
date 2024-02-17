using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using xiaoPage.Data;
using xiaoPage.Model;


namespace xiaoPage.Pages.Actors
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDb db;
        [BindProperty]
        public Actor actor { get; set; }

        public CreateModel(ApplicationDb db)
        {
            this.db = db;
        }

        public void OnGet()
        {
           
        }
        public IActionResult OnPost()
        {
           
                db.actors.Add(actor);
                db.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToPage("Index");
           
        }
    }
}
