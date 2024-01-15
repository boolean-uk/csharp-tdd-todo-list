using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> _toDoList = new Dictionary<string, bool>();
        public TodoList() { }
        public bool Add(string s, bool b)
        {
            if (!_toDoList.ContainsKey(s))
            {
                _toDoList.Add(s, b);
                return true;
            }
            return false;
        }

        public int PrintTasks()
        {
            foreach (var item in _toDoList)
            {
                Console.WriteLine($"Task: {item.Key}, Complete?: {item.Value}");
            }
            return _toDoList.Count();
        }

        public int PrintComplete()
        {
            int count = 0;
            foreach (var item in _toDoList)
            {
                if (item.Value)
                {
                    Console.WriteLine($"Task: {item.Key}");
                    count++;
                }
            }
            return count;
        }

        public int PrintInomplete()
        {
            int count = 0;
            foreach (var item in _toDoList)
            {
                if (!item.Value)
                {
                    Console.WriteLine($"Task: {item.Key}");
                    count++;
                }
            }
            return count;
        }

        public bool SearchTask(string s)
        {
            //throw new NotImplementedException();
            if (!_toDoList.ContainsKey(s))
            {
                Console.WriteLine("The list does not contain the task, did you write it correctly?");
                return false;
            }
            Console.WriteLine($"The list contains the task: \"{s}\" and its status is : {_toDoList[s]}\"");
            return true;

        }

        public bool RemoveTask(string s)
        {
            throw new NotImplementedException();
        }
    }
}
