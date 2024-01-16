using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
    }

    public class BetterTask : Task
    {
        private int _id;
        private DateTime _dateTime;

        public BetterTask(string description, bool completed, int id, DateTime dateTime) : base(description, completed)
        {
            _id = id;
            _dateTime = DateTime.Now;
        }

        public int id { get { return _id; } }
        public DateTime dateTime { get { return _dateTime; } }

    }

    public class ToDo : TodoList
    {
        public ToDo() { 
        }
        
        public Task GetTaskById(int id)
        {
            foreach (BetterTask bt in _tasks)
            {
                if (bt.id == id)
                {
                    return bt;
                }
            }
            return null;    
        }

        public void UpdateTaskById(int id, string description)
        {
            foreach(BetterTask bt in _tasks)
            {
                if (bt.id == id)
                {
                    bt.description = description;
                } 
            }
        }

        public void UpdateTaskById(int id)
        {
            foreach (BetterTask bt in _tasks)
            {
                if (bt.id == id)
                {
                    bt.completed = !bt.completed;
                }
            }
        }

        public DateTime DisplayDateAndTime(BetterTask t)
        {
            return t.dateTime;
        }

    }
}
