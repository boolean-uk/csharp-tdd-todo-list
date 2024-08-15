using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class ToDoList
    {
        private Dictionary<string, Status> _list = new Dictionary<string, Status>();

        public Dictionary<string, Status> List { get { return _list; } }
       



        public bool AddTasks(string task)
        {
            if (!_list.ContainsKey(task))
            {
                _list.Add(task, Status.INCOMPLETE);
                return true;

            }
            return false;
        }

        public Status ChangeStatus(string task)
        {

           if (_list.ContainsKey(task))
            {
                if (_list[task] == Status.COMPLETE)
                {
                    _list[task] = Status.INCOMPLETE;

                }else if (_list[task] == Status.INCOMPLETE)
                {
                    _list[task] = Status.COMPLETE;

                }
            }
            return _list[task];



        }

        public Dictionary<string, Status> GetCompletedTask()
        {
            Dictionary<string,Status> completedTasks= new Dictionary<string,Status>();

            foreach (string task in _list.Keys)
            {
                if (_list[task] == Status.COMPLETE)
                {
                    completedTasks.Add(task, Status.COMPLETE);
                }
            }

            return completedTasks;
            
        }

        public Dictionary<string, Status> GetInCompletedTask()
        {
            Dictionary<string, Status> inCompletedTasks = new Dictionary<string, Status>();

            foreach (string task in _list.Keys)
            {
                if (_list[task] == Status.INCOMPLETE)
                {
                    inCompletedTasks.Add(task, Status.INCOMPLETE);
                }
            }

            return inCompletedTasks;
        }

        public Dictionary<string, Status> OrderAscending()
        {

         return _list.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        public Dictionary<string, Status> OrderDescending() {
            return _list.OrderByDescending(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);

            
        }

        public bool RemoveTask(string task)

        {
            bool removed = false;

            if (_list.ContainsKey(task))
            {
                _list.Remove(task);
                removed = true;
            }


            return removed;
        }
        

        public string SearchForTask(string task)
        {
            string output = "";
            if (!_list.ContainsKey(task))
            {
                output = "Task not found in list";
            }
              

            return output;

        }

        public Dictionary<string, Status> ShowList()
        {
            return _list;
        }
    }
}
