using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        List<Tuple<string, bool>> _tasks;
        /// <summary>
        /// initiating the dictionray of tasks inside the constructor
        /// </summary>
        public TodoList()
        {
            _tasks = new List<Tuple<string, bool>>();
            _tasks.Add(Tuple.Create("walking", false));
            _tasks.Add(Tuple.Create("shopping", false));






        }

       // public List<Tuple<string, bool>> tasks { get { return _tasks; } }


        public bool add(string todo, bool completed)
        {
            foreach (var task in _tasks)
            {
                if (task.Item1.ToUpper() == todo.ToUpper() )
                {

                    return false;

                }
                
            }
            _tasks.Add(Tuple.Create(todo, completed));

            return true;
        }
    }
}
