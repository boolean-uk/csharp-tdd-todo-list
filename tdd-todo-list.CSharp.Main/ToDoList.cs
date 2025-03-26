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

        public List<string> getList(char completed = 'a', char sorted = 'n')
        {
            List<string> returnList = new List<string>();

            if (completed == 'c')
            {
                foreach (string toDoItem in tasks.Keys)
                {
                    if (tasks[toDoItem])
                    {
                        returnList.Add(toDoItem);
                    }
                }
            }
            else if (completed == 'i')
            {
                foreach (string toDoItem in tasks.Keys)
                {
                    if (!tasks[toDoItem])
                    {
                        returnList.Add(toDoItem);
                    }
                }
            }
            else
            {
                returnList = new List<string>(tasks.Keys);
            }


            if (sorted == 'a')
            {
                return returnList.OrderBy(x => x).ToList();
            }
            if (sorted == 'd')
            {
                return returnList.OrderByDescending(x => x).ToList();
            }
            return returnList;

        }

        public void removeTask(string toDoItem)
        {
            tasks.Remove(toDoItem);
        }
    }
}
