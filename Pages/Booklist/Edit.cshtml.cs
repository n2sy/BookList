using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using booklist.Model;
using Microsoft.EntityFrameworkCore;


namespace booklist.Pages.Booklist
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Book Book { get; set; }
        public async Task OnGet(int id)
        {
            Book = await _db.Livre.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
             var BookFromDb = await _db.Livre.FindAsync(Book.Id);
             BookFromDb.Id = Book.Id;
             BookFromDb.Name = Book.Name;
             BookFromDb.Author = Book.Author;
             BookFromDb.Editor = Book.Editor;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
      
    }

}