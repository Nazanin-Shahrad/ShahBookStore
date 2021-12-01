using ShahBookStore.DataAccess.Data;
using ShahsBooks.DataAccess.Repository.IRepository;
using ShahsBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType> , ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            throw new NotImplementedException();
        }
    }
}
