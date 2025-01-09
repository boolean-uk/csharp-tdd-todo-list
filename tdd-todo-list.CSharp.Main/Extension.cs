using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private int id_counter = 0;
        List<ExtensionTask> tasks = new List<ExtensionTask>();

        public ExtensionTask GetTask(int id)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].id == id)
                {
                    return tasks[i];
                }
            }
            return new ExtensionTask();// if no found return default no description task
        }
        public void AddTask(string description)
        {
            ExtensionTask newtask = new ExtensionTask();
            newtask.description = description;
            newtask.id = id_counter++;
            tasks.Add(newtask);
        }
        public void UpdateTask(int id, string newDescription)
        {
            ExtensionTask? task = GetTask(id);
            if (task != null)
            {
                task.description = newDescription;
            }
        }
        public void UpdateCompleted(int id, bool completed)
        {
            ExtensionTask? task = GetTask(id);
            if (task != null)
            {
                task.completed = completed;
            }
        }
        public DateTime? TimeCreated(int id) 
        {
            ExtensionTask? task = GetTask(id);
            if (task != null)
            {
                return task.time;
            }
            return null;
        }
        public class ExtensionTask
        {
            private string? _description;
            public string? description
            {
                get { return _description; }
                set { _description = value; }
            }
            private bool _completed;
            public bool completed
            {
                get { return _completed; }
                set { _completed = value; }
            }
            private int? _id;
            public int? id
            { get { return _id; } set { _id = value; } }

            private DateTime? _time;
            public DateTime? time
            { get { return _time; } set { _time = value; } }

            public ExtensionTask()
            {
                _description = "no description";
                _completed = false;
                time = DateTime.Now;
            }


        }
    }
}
