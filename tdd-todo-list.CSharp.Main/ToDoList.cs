using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private SortedDictionary<string, string> toDo = new SortedDictionary<string, string>();

        private Dictionary<int, string> IDToTask = new Dictionary<int, string>();
        private Dictionary<int, (string, DateTime)> IDToInfo= new Dictionary<int, (string, DateTime)>();

        private int counter = 0;

        public void addTask(string v)
        {
            IDToTask.Add(counter, v);
            IDToInfo.Add(counter++, ("incomplete", DateTime.Now));
        }

        public bool changeStatus(string v)
        {
            if (!IDToTask.ContainsValue(v)) return false;
            int ID = IDToTask.First(x => x.Value == v).Key;

            IDToInfo[ID] = ((IDToInfo[ID].Item1 == "incomplete" ? "complete" : "incomplete"), IDToInfo[ID].Item2);
            return true;
        }

        public bool findTask(string v)
        {
            return IDToTask.ContainsValue(v);
        }

        public void removeTask(string v)
        {
            int ID = IDToTask.FirstOrDefault(x => x.Value == v).Key;
            IDToInfo.Remove(ID);
            IDToTask.Remove(ID);
        }

        public List<string> viewTasks(string order = "alphabetical", string status = "all")
        {
            List<string> list;
            switch ( status )
            {
                case "incomplete":
                case "complete":
                    list = new List<string>();
                    foreach( var elm in IDToInfo )
                    {
                        if ( elm.Value.Item1 == status ) list.Add( IDToTask[elm.Key] );
                    }
                    break;
                default:
                    list = new List<string>(IDToTask.Values);
                    break;
            }

            list.Order();
            if ( order != "alphabetical")
            {
                list.Reverse();
            }


            return list;
        }
    }
}
