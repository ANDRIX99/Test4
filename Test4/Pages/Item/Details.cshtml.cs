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
    public class DetailsModel : PageModel
    {
        private readonly Test4.Data.ApplicationDbContext _context;

        public DetailsModel(Test4.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Test4.Model.Item Item { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item.FirstOrDefaultAsync(m => m.Id == id);

            if (item is not null)
            {
                Item = item;

                return Page();
            }

            return NotFound();
        }
    }
}
