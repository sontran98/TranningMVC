using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComeBackMVC.Data.Ifrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ComeBackMVCDbContext dbContext;

        public ComeBackMVCDbContext Init()
        {
            return dbContext ?? (dbContext = new ComeBackMVCDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
