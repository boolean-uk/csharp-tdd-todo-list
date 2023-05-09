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
        public Dictionary<string, bool> _myList;
        private Dictionary<string, bool> myList
        {
            get { return _myList; }
            set { _myList = value; }
        }

        public TodoList()
        {
            myList = new Dictionary<string, bool>();
            myList.Add("A", true);
            myList.Add("B", false);
            myList.Add("C", false);
            myList.Add("D", false);
        }

        public void AddTask(string key, bool value)
        {
            if (myList.ContainsKey(key) == false)
            {
                myList.Add(key, value);
            }
            else
            {
                Console.WriteLine("Task with that name already exist");
            }
        }

        public Dictionary<string, bool> GetList()
        {
            return myList;
        }

        public void changeStatus(string key)
        {
            if (myList.ContainsKey(key))
            {
                if (myList[key] == false)
                {
                    myList[key] = true;
                }
                else
                {
                    myList[key] = false;
                }
            }
        }

        public Dictionary<string, bool> GetCompletedTasks()
        {
            Dictionary<string, bool> completed = new Dictionary<string, bool>();
            foreach (KeyValuePair<string, bool> kvp in myList)
            {
                if (kvp.Value == true)
                {
                    completed.Add(kvp.Key, kvp.Value);
                }
            }
            return completed;
        }

        public Dictionary<string, bool> GetIncompletedTasks()
        {
            Dictionary<string, bool> incompleted = new Dictionary<string, bool>();
            foreach (KeyValuePair<string, bool> kvp in myList)
            {
                if (kvp.Value == false)
                {
                    incompleted.Add(kvp.Key, kvp.Value);
                }
            }
            return incompleted;
        }

        public string searchTask(string key)
        {
            if (myList.ContainsKey(key) == false)
            {
                return "The task you are looking for doesnt exist";
            }
            return "The task you are looking for exist in the to do list";
        }

        public void removeTask(string key)
        {
            if (myList.ContainsKey(key))
            {
                myList.Remove(key);
            }
        }

        public List<string> getAscending()
        {
            List<string> tasks = _myList.Keys.ToList();
            tasks.Sort();
            
            return tasks;
        }

        public List<string> getDescending()
        {
            List<string> tasks = _myList.Keys.ToList();
            tasks.Sort();
            tasks.Reverse();
            return tasks;
        }
    }
}
