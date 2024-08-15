using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, string> _toDoList = new Dictionary<string, string>();

        public Dictionary<string, string> ToDoDict { get => _toDoList; }

        public void Add(string task)
        {
            string status = "notComplete";
            _toDoList.Add(task, status);
        }

        public string[] Print()
        {
            if (_toDoList.Count != 0)
            {
                string[] keys = new string[ToDoDict.Count];
                int counter = 0;
                foreach (string key in _toDoList.Keys)
                {
                    //Console.WriteLine(key);
                    keys[counter] = key;
                    counter++;

                }
                return keys;

            }
            else
            {
                string[] keys = new string[1];
                keys[0] = "There is no tasks in the todo list";

                return keys;

            }

        }
        public void ChangeStatus(string task)
        {
            if (_toDoList.ContainsKey(task))
                _toDoList[task] = "complete";
        }

        public List<string> Show(string status)
        {
            /*
            List<string> list = new List<string>();
            foreach (string key in _toDoList.Keys)
            {
                if (_toDoList[key] == status)
                    list.Add(key);
            }
            */
            
            List<string> list = _toDoList.Where(x => x.Value == status).Select(x => x.Key).ToList();
            return list;
        }

        public string Search(string task)
        {
            if (_toDoList.ContainsKey(task))
            {
                return "Task is found";
            }
            else
            {
                return "Task is not found";
            }
        }

        public bool Remove(string task)
        {
            throw new NotImplementedException();
        }
    }
}
