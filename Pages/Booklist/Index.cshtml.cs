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
    public class IndexModel : PageModel
    {
        public IEnumerable<Book> Books { get; set;} 
                                                  
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet()
        {
            Books = await _db.Livre.ToListAsync();
        }
       
    }
}