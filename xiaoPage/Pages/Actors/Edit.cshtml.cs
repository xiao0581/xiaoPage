using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using xiaoPage.Data;
using xiaoPage.Model;

namespace xiaoPage.Pages.Actors
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDb db;
        
        public Actor actor { get; set; }

        public EditModel(ApplicationDb db)
        {
            this.db = db;
        }
        public void OnGet(int ID)
        {
            if (ID != null && ID !=0)
            {
                actor = db.actors.Find(ID);
            }
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid) {
               db.Update(actor);
                db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
