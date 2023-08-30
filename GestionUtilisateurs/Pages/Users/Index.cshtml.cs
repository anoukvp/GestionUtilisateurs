using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GestionUtilisateurs.Data;

namespace GestionUtilisateurs.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly GestionUtilisateurs.Data.UserContext _context;

        public IndexModel(GestionUtilisateurs.Data.UserContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Users != null)
            {
                User = await _context.Users.ToListAsync();
            }
        }
    }
}
