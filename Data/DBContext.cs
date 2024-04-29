using SezwanNew.Models;
using Microsoft.EntityFrameworkCore;


namespace SezwanNew.Data

{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
    }
}

