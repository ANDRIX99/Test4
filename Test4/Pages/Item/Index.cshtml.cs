using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Test4.Data;
using Test4.Model;

namespace Test4.Pages.Item
{
    public class IndexModel : PageModel
    {
        private readonly Test4.Data.ApplicationDbContext _context;

        public IndexModel(Test4.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Test4.Model.Item> Item { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Item = await _context.Item.ToListAsync();
        }
    }
}
