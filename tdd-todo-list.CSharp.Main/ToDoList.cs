using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        internal SortedDictionary<string, string> toDo = new SortedDictionary<string, string>();

        public void addTask(string v)
        {
            toDo.Add(v, "incomplete");
        }

        public bool changeStatus(string v)
        {
            if (!toDo.ContainsKey(v)) return false;

            toDo[v] = (toDo[v] == "incomplete" ? "complete" : "incomplete");
            return true;
        }

        public bool findTask(string v)
        {
            return toDo.ContainsKey(v);
        }

        public void removeTask(string v)
        {
            toDo.Remove(v);
        }

        public List<string> viewTasks(string order = "alphabetical", string status = "all")
        {
            List<string> list;
            switch ( status)
            {
                case "incomplete":
                case "complete":
                    list = new List<string>();
                    foreach( var elm in toDo)
                    {
                        if ( elm.Value == status ) list.Add(elm.Key);
                    }
                    break;
                default:
                    list = new List<string>(toDo.Keys);
                    break;
            }

            if ( order != "alphabetical")
            {
                list.Reverse();
            }


            return list;
        }
    }
}
