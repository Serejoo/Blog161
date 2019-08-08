//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using WebApplication2.Data;

//namespace WebApplication2.Repositorio
//{
//    public class GenericRepository<Tentity> : IGenericRepository<Tentity> where Tentity : class, IEntity
//    {
//        private readonly BlogContext _db;
//        public GenericRepository(BlogContext db)
//        {
//            _db = db;
//        }
//        public async Task<Tentity> BuscarPorId(int id)
//        {
//            return await _db.Set<Tentity>().FirstOrDefaultAsync(e => e.Id == id);
//        }
//    }
//}
