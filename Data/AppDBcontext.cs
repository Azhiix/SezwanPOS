using SezwanNew.Models;
using Microsoft.EntityFrameworkCore;


namespace SezwanNew.Data

{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options) { }
        
    }
}

