using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class SearchBase
    {

        ISearchBase _searchBase;
        public SearchBase(ISearchBase searchBase)
        {
            _searchBase = searchBase;
        }

        public List<ToDoList> Search(string Keyword)
        {
            return _searchBase.Search(Keyword);
        }

    }

    public class SearchToDoList : ISearchBase
    {
        public List<ToDoList> Search(string Keyword)
        {
            List<ToDoList> list;
            using (MToDoList model = new MToDoList())
            {
                list = model.ToDoList.OrderByDescending(t => t.DeadLine).Where(t => t.ItemName.Contains(Keyword)).ToList();
            }

            return list;
        }
    }

    public interface ISearchBase
    {
        List<ToDoList> Search(string Keyword);
    }
}