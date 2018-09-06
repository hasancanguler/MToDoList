using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public interface IScreenBase
    {
        List<ToDoList> GetToDoList();
        void Delete(int Id);
        void Insert(ToDoList mToDoList);
        void ChangeStatus(int Id);
    }
}
