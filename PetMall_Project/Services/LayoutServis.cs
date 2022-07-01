using Microsoft.EntityFrameworkCore;
using PetMall_Project.DAL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetMall_Project.Services
{
    public class LayoutServis
    {
        private readonly AppDbContext _context;

        public LayoutServis(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Setting>> GetDatas()
        {
            List<Setting> settings = await _context.Settings.ToListAsync();
            return settings;
        }
    }
}
