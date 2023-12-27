using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDOPERATIONS.Data;
using CRUDOPERATIONS.Model;

namespace CRUDOPERATIONS.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly CRUDOPERATIONS.Data.CRUDOPERATIONSContext _context;

        public IndexModel(CRUDOPERATIONS.Data.CRUDOPERATIONSContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
