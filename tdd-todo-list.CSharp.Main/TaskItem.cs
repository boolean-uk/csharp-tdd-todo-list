using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TaskItem
    {
        private string _description;
        private bool _isDone;
        private int _priority;

        public TaskItem(string description, int priority = 2)
        {
            _description = description;
            _isDone = false;
            _priority = priority;
        }

        public string GetDescription()
        {
            return _description;
        }

        public bool GetStatus()
        {
            return _isDone;
        }

        public int GetPriority()
        {
            return _priority;
        }

        public void SetStatus()
        {
            _isDone = true; 
        }

        public void SetPriority(int priority)
        {
            _priority = priority;
        }
    }
}



