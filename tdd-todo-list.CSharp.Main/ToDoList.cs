using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        Dictionary<string, bool> _TodoList = new Dictionary<string, bool>();
        public Dictionary<string, bool> GetAllTasks { get { return _TodoList; } }
        public Dictionary<string, bool> GetCompletedTasks { get { return _TodoList.Where(task => task.Value == true).ToDictionary<string, bool>(); } }
        public Dictionary<string, bool> GetInCompletedTasks { get { return _TodoList.Where(task => task.Value == false).ToDictionary<string, bool>(); } }


        public bool AddTask(string task, bool isCompleted)
        {
            if (!_TodoList.ContainsKey(task))
            {
                _TodoList.Add(task, isCompleted);
                return true;
            }
            else
            {
                Console.WriteLine("You already have this in your list");
                return false;
            }
        }

        public bool RemoveTask(string task)
        {
            if (_TodoList.ContainsKey(task))
            {
                _TodoList.Remove(task);
                return true;
            }
            return false;
        }


        public bool ChangeStatus(string task, bool isCompleted)
        {
            bool prevStatus = _TodoList[task];
            _TodoList[task] = isCompleted;
            if (prevStatus != _TodoList[task])
            {
                return true;
            }
            return false;

        }
  
        public bool SearchTask(string task)
        {
            foreach (var t in _TodoList)
            {
                if (t.Key == task)
                {
                    return true;
                } 
                else
                {
                    Console.WriteLine($"{task} was not found");
                    return false; 
                }
            }
            return true;
        }

        public List<string> SortByAscending()
        {
            return _TodoList.OrderBy(task => task.Key).Select(task => task.Key).ToList();
        }

        public List<string> SortByDescending()
        {
            return _TodoList.OrderByDescending(task => task.Key).Select(task => task.Key).ToList();
        }
    }
}

 












