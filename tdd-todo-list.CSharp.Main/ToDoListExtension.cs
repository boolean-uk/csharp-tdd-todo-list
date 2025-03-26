
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{

   public class ToDoListExtension { 

        private List<ToDoTask> _tasks = new List<ToDoTask>();

        public ToDoTask GetTaskById(int id)
        {
            return _tasks.Where(t => t.id == id).FirstOrDefault();
        }

        public void AddTask(ToDoTask task)
        {
            _tasks.Add(task);
        }

        public bool ChangeTaskStatus(int taskId)
        {
            ToDoTask task = GetTaskById(taskId);
            if (task != null)
            {
                task.ChangeStatus();
                return true;
            }
            return false;
        }

        public bool UpdateTaskName(int taskId, string newName)
        {
            ToDoTask taskToUpdate = GetTaskById(taskId);

            if (taskToUpdate != null)
            {
                taskToUpdate.Name = newName;
                return true;
            }

            return false;
        }


        /*
        public DateTime GetTaskCreationDateTime(int taskId)
        {
            // Implement using taskManager
            ToDoTask task = taskManager.GetTaskById(taskId);
            if (task != null)
            {
                return task.dateTime;
            }
            return DateTime.MinValue; // or handle the case when the task is not found
        }
        */

        public List<ToDoTask> Tasks { get {  return _tasks; } }

   }
}
