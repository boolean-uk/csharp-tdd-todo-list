using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {


        public Dictionary<string, bool> todo { get; set; }

        //public int testerino { get; set; } = 8;

        public List<string> getTodoList()
        {
            return todo.Keys.ToList();
        }

        public void addToList(string task)
        {
            todo.Add(task, false);
        }

        public void toggleTask(string task)
        {
            todo[task] = !todo[task];
        }

        public List<string> getFilteredTasks(bool completed)
        {
            return todo.Where(x => x.Value == completed).Select(x => x.Key).ToList();     
        }

        public void deleteTask(string task)
        {
            todo.Remove(task);
        }

        public string getTask(string task)
        {
            if (todo.ContainsKey(task))
            {
                return task; //todo.Keys.ToList().First(x => x == task).DefaultIfEmpty("Doesn't exist in Todo-list!");
            } else { return "Doesn't exist in Todo-list!"; }
        }

        public List<string> getListOrdered(bool ascending)
        {
            if (ascending)
            {
                return todo.Keys.ToList().OrderBy(x => x).ToList();
            }
            else
            {
                return todo.Keys.ToList().OrderByDescending(x => x).ToList();
            }
        }
    }
}
