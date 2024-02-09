using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;

namespace tdd_todo_list.CSharp.Extension
{
    public class TodoListExtension
    {
        public class TodoList
        {
            public List<TodoTask> Tasks { get; }
            public TodoList()
            {
                Tasks = new List<TodoTask>();
            }

            public TodoTask AddTask(string name)
            {
                TodoTask task = new TodoTask(name);
                Tasks.Add(task);
                return task;
            }

            public TodoTask GetTask(int id)
            {
                TodoTask? result = Tasks.Where(t => t.Id == id).SingleOrDefault();
                return result;
            }

            public TodoTask UpdateTaskName(int id, string name)
            {
                TodoTask task = GetTask(id);
                if (task == null)
                {
                    return null;
                }
                
                if (name != null)
                {
                    task.SetName(name);
                }
                return task;
            }

            public TodoTask ToggleTaskStatus(int id)
            {
                TodoTask task = GetTask(id);
                if (task == null)
                {
                    return null;
                }

                task.ToggleStatus();


                return task;
            }
        }
        public class TodoTask
        {
            public int Id { get; }
            public string Name { get; set; }
            public bool IsCompleted { get; set; }
            public DateTime Time { get; }

            public TodoTask(string name)
            {
                this.Id = Guid.NewGuid().GetHashCode();
                this.Name = name;
                this.IsCompleted = false;
                this.Time = DateTime.Now;
            }

            public void ToggleStatus()
            {
                this.IsCompleted = !this.IsCompleted;
            }

            public void SetName(string name)
            {
                this.Name = name;
            }


        }
    }
}
