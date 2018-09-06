namespace ToDoList.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MToDoList : DbContext
    {
        public MToDoList()
            : base("name=MToDoList")
        {
        }

        public virtual DbSet<ToDoList> ToDoList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
