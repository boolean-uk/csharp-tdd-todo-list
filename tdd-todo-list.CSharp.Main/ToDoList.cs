using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        Dictionary<string, bool> _TodoList = new Dictionary<string, bool>();

        public Dictionary<string, bool> AddTodo(string todo, bool isCompleted)
        {
            if (_TodoList.ContainsKey(todo))
            {
                Console.WriteLine("You already have this on your list");
            }
            else
            {
                _TodoList.Add(todo, isCompleted);
            }
            return _TodoList;

        }

       

        public Dictionary<string, bool> GetAllItems()
        {
            foreach (var item in _TodoList.Keys)
            {
                Console.WriteLine(item);
            }

            return _TodoList;

        }

       

        public bool SetStatus(string key, bool status)
        {
            _TodoList[key] = status;

            return status;
        }

        public List<string> GetCompletedTasks()
        {
            List<string> completedTasks = _TodoList.Where(task => task.Value == true).Select(task => task.Key).ToList();

            return completedTasks;

            
        }

        public List<string> GetIncompleteTasks()
        {
            List<string> incompleteTasks = _TodoList.Where(task => task.Value == false).Select(task => task.Key).ToList();

            return incompleteTasks;


        }

        public bool SearchTask(string taskName)
        {
            if (_TodoList.ContainsKey(taskName))
            {
                return _TodoList[taskName];
            }
            else
            {
                return false;
            }
        }

        public List<string> SortByAscending()
        {
            var sortedTasks = _TodoList.OrderBy(task => task.Key).Select(task => task.Key).ToList();

            return sortedTasks;
        }

        public List<string> SortByDescending()
        {
            var descendingTasks = _TodoList.OrderByDescending(task => task.Key).Select(task => task.Key).ToList();

            return descendingTasks;
        }

        public bool RemoveTask(string taskName)
        {

            bool removed = false;
            
           if (_TodoList.ContainsKey(taskName))
            {
                _TodoList.Remove(taskName);
                removed = true;
            }
           else
            {
                throw new Exception("This task does not exist in the list");
            }
                

            
            return removed;
        }
    }
}
