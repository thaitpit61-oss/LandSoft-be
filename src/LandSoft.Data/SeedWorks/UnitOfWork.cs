using LandSoft.Core.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandSoft.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LandSoftContext _context;

        public UnitOfWork(LandSoftContext context)
        {
            _context = context; 
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose() 
        { 
            _context.Dispose();
        }
    }
}
