using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using xiaoPage.Data;
using xiaoPage.Model;

namespace xiaoPage.Pages.Actors
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDb db;

        public Actor actor { get; set; }

        public DeleteModel(ApplicationDb db)
        {
            this.db = db;
        }
        public void OnGet(int ID)
        {
            if (ID != null && ID != 0)
            {
                actor = db.actors.Find(ID);
            }
        }
        public IActionResult OnPost()
        {
            Actor? obj=db.actors.Find(actor.ID);
            if(obj == null)
             { return NotFound(); }
                db.Remove(obj);
                db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToPage("Index");
           
        }
    }
}
