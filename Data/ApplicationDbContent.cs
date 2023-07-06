using Microsoft.EntityFrameworkCore;
using TodoL.Models;

namespace TodoL.Data
{
    public class ApplicationDbContent : DbContext
    {

        public ApplicationDbContent(DbContextOptions<ApplicationDbContent> options) : base(options)
        {

        }


         public  DbSet<TodoList> TodoLists { get; set; }
    }


}
