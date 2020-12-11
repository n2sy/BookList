using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using booklist.Model;

namespace booklist.Pages.Booklist
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Book Book { get; set; }

        public CreateModel(ApplicationDbContext db) {
            _db = db;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost() {
            if(!ModelState.IsValid)
                return Page();

            _db.Livre.Add(this.Book);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");


        }
    }
}