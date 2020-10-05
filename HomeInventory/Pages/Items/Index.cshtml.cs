using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HomeInventory.Data;
using HomeInventory.Models;

namespace HomeInventory.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly HomeInventory.Data.HomeInventoryContext _context;

        public IndexModel(HomeInventory.Data.HomeInventoryContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Item.ToListAsync();
        }
    }
}
