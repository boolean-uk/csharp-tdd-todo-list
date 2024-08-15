using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public Dictionary<string, bool> tasks = new Dictionary<string, bool>();

        public void addTask(string toDoItem)
        {
            tasks.Add(toDoItem, false);     
        }

        public void changeStatus(string toDoItem)
        {
            bool completed = !tasks[toDoItem];

            tasks[toDoItem] = completed;
        }

        public string findTask(string toDoItem)
        {
            if (tasks.ContainsKey(toDoItem))
            {
                return toDoItem;
            }

            return "task not in todo list";
        }

        public List<string> getList(char completed = 'a')
        {
            if (completed == 'c')
            {
                List<string> completedTasks = new List<string>();

                foreach (string toDoItem in tasks.Keys)
                {
                    if (tasks[toDoItem])
                    {
                        completedTasks.Add(toDoItem);
                    }
                }
                return completedTasks;
            }
            if (completed == 'i')
            {
                List<string> incompleteTasks = new List<string>();

                foreach (string toDoItem in tasks.Keys)
                {
                    if (!tasks[toDoItem])
                    {
                        incompleteTasks.Add(toDoItem);
                    }
                }
                return incompleteTasks;
            }

            return new List<String>(tasks.Keys);
        }
    }
}
