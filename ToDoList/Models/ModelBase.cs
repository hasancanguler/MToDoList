using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ModelBase
    {
        IScreenBase screen;

        public ModelBase(IScreenBase _screen)
        {
            screen = _screen;
        }

        public void Insert(IScreenBase _Screen)
        {
            //screen.Insert(toDoList);
        }

        public void Delete(int Id)
        {
            screen.Delete(Id);
        }

        public List<ToDoList> GetToDoList()
        {
            return screen.GetToDoList();
        }

    }
}