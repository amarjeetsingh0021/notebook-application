using Microsoft.EntityFrameworkCore;
using Notebook.Models;

namespace Notebook
{
    public class NotebookDbContext: DbContext
    {

        public NotebookDbContext(DbContextOptions<NotebookDbContext> options) : base(options) { }

        public DbSet<Notepad>? Notes { get; set; }
    }
}
