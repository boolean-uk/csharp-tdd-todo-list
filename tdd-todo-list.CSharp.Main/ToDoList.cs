using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public List<string> _list;
        public List<bool> _status;

        public TodoList()
        {
            _list = new List<string>();
            _status = new List<bool>();
        }

        public bool AddTask(string task)
        {
            _list.Add(task);
            _status.Add(false);
            return true;
        }

        public bool ShowAllTasks()
        {
            for (int i = 0; i < _list.Count; i++)
            {
                Console.WriteLine($"Task: {_list[i]}, Status: {_status[i]}");
            }
            return true;
        }

        public bool UpdateStatus(string task)
        {
            int inx = _list.IndexOf(task);

            if (inx == -1) { return false; }

            _status[inx] = true;
            return true;
        }

        public bool ShowCompleteTasks()
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_status[i])
                {
                    Console.WriteLine($"Task: {_list[i]}, Status: {_status[i]}");
                }
            }
            return true;
        }

        public bool ShowInCompleteTasks()
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (!_status[i])
                {
                    Console.WriteLine($"Task: {_list[i]}, Status: {_status[i]}");
                }
            }
            return true;
        }

        public string SearchTask(string task)
        {
            string result = "Task Not Found";

            int inx = _list.IndexOf(task);

            if (inx == -1) { return result; }

            result = $"The task, {task}, has been found at index {inx}";
            return result;
        }


        public bool RemoveTask(string task)
        {
            int inx = _list.IndexOf(task);

            if (inx == -1) { return false; }

            _list.RemoveAt(inx);
            _status.RemoveAt(inx);
            return true;
        }

        public bool ShowAllTasksAlphabeticallyAcending()
        {
            List<string> alphabeticalList = new List<string>(_list);
            alphabeticalList.Sort(StringComparer.OrdinalIgnoreCase);
            for (int i = 0; i < _list.Count; i++)
            {
                Console.WriteLine($"Task: {alphabeticalList[i]}");
            }
            return true;
        }

        public bool ShowAllTasksAlphabeticallyDecending()
        {
            List<string> alphabeticalList = new List<string>(_list);
            alphabeticalList.Sort(StringComparer.OrdinalIgnoreCase);
            alphabeticalList.Reverse();
            for (int i = 0; i < _list.Count; i++)
            {
                Console.WriteLine($"Task: {alphabeticalList[i]}");
            }
            return true;
        }
    }
}
