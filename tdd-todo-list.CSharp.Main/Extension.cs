using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private static Dictionary<int, TodoListExtension> tasks = new Dictionary<int, TodoListExtension>();
        public int id { get; set; }
        public string name {  get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }

        public TodoListExtension() { 
            }

        public TodoListExtension(int id, string name, string status, DateTime createdAt)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            this.createdAt = createdAt;
            tasks[id] = this;
        }

        // Extension User Story 1 - I want to be able to get a task by a unique ID.
        public TodoListExtension GetTaskById(int id)
        {
            if (tasks.ContainsKey(id))
            {
                return tasks[id];
            }
            else
            {
                return null;
            }
        }

        // Extension User Story 2 -I want to update the name of a task by providing its ID and a new name
        public bool UpdateTaskName(int id, string updatedName)
        {
            TodoListExtension task = GetTaskById(id);
            if (task != null)
            {
                task.name = updatedName;
                return true;
            }
            return false;
        }

        // Extension User Story 3 - I want to be able to change the status of a task by providing its ID.
        public bool UpdateTaskStatus(int id, string updatedStatus)
        {
            TodoListExtension task = GetTaskById(id);
            if (task != null)
            {
                task.status = updatedStatus;
                return true;
            }
            return false;
        }

        // Extension User Story 4 - I want to be able to see the date and time that I created each task.
        public DateTime? GetTaskCreationDateTime(int id)
        {
            TodoListExtension task = GetTaskById(id);
            if (task != null)
            {
                return task.createdAt;
            }
            return null;
        }

    }
}
