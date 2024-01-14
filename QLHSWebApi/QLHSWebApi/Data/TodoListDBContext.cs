using Microsoft.EntityFrameworkCore;

namespace QLHSWebApi.Data
{
    public class TodoListDBContext:DbContext
    {
        public TodoListDBContext(DbContextOptions<TodoListDBContext> options):base(options)
        { 

        }
        public DbSet<Task> Tasks { get; set; }
    }
}
