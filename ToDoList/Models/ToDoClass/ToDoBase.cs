using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models.ToDoClass
{
    public class ToDoBase : IScreenBase
    {
        public List<ToDoList> GetToDoList()
        {
            using (MToDoList model = new MToDoList())
            {
                return model.ToDoList.OrderByDescending(t => t.DeadLine).ToList();
            }
        }

        

        public void Delete(int Id)
        {
            using (MToDoList model = new MToDoList())
            {
                ToDoList DeleteItem = model.ToDoList.Find(Id);
                model.ToDoList.Remove(DeleteItem);
                model.SaveChanges();
            }
        }

        public void Insert(ToDoList ToDoListItem)
        {
            using (MToDoList model = new MToDoList())
            {
                model.ToDoList.Add(ToDoListItem);
                model.SaveChanges();
            }
        }

        public void ChangeStatus(int Id)
        {
            using (MToDoList model = new MToDoList())
            {
                ToDoList ChangeItem = model.ToDoList.Find(Id);
                if (ChangeItem.Done == 0)
                    ChangeItem.Done = 1;
                else
                    ChangeItem.Done = 0;
                model.SaveChanges();
            }
        }
    }

    
}
