using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    /*
    Extension Requirements:
    I want to be able to get a task by a unique ID.
    I want to update the name of a task by providing its ID and a new name.
    I want to be able to change the status of a task by providing its ID.
    I want to be able to see the date and time that I created each task.
    */

    /*
    Extension Domain Model:
    Class TaskExtension
        id
        title
        isComplete
        createdAt
    Class TodoListExtension
        getTask(taskId)
            if taskId < 0 or taskId >= tasks.count or taskId != tasks[taskId].id
                return null
            return tasks[taskId]
        updateTask(taskId, title)
            task = getTask(taskId)
            if task is null
                return false
            task.title = title
            return true
        setTaskCompleted(taskId, isCompleted)
            task = getTask(taskId)
            if task is null
                return false
            task.isComplete = isCompleted
            return true
        getTaskCreatedAt(taskId)
            task = getTask(taskId)
            if task is null
                return null
            return task.createdAt
    */


    public class TaskExtension
    {
        public int id { get; set; }
        public string title { get; set; }
        public bool isComplete { get; set; }
        public DateTime createdAt { get; set; }
    
        public TaskExtension(int id, string title, bool isComplete, DateTime createdAt)
        {
            this.id = id;
            this.title = title;
            this.isComplete = isComplete;
            this.createdAt = createdAt;
        }
    }

    
    public class TodoListExtension
    {
        private List<TaskExtension> tasks;
        public TodoListExtension()
        {
            tasks = new List<TaskExtension>();
        }

        public TaskExtension AddTask(string newtitle)
        {
            TaskExtension task = new TaskExtension(tasks.Count, newtitle, false, DateTime.Now);
            tasks.Add(task);
            return task;
        }

        public List<TaskExtension> ListOfTasks()
        {
            return tasks;
        }

        public bool ChangeTaskStatus(int taskId, bool isCompleted)
        {
            TaskExtension? task = GetTaskById(taskId);
            if (task == null)
            {
                return false;
            }
            task.isComplete = isCompleted;
            return true;
        }

        public List<TaskExtension> GetCompletedTasks()
        {
            return tasks.FindAll(t => t.isComplete == true);
        }

        public List<TaskExtension> GetIncompleteTasks()
        {
            return tasks.FindAll(t => t.isComplete == false);
        }

        private TaskExtension? GetTaskById(int taskId)
        {
            if (taskId < 0 || taskId >= tasks.Count || taskId != tasks[taskId].id)
            {
                return null;
            }  
            return tasks.FirstOrDefault(t => t.id == taskId);
        }

        public bool UpdateTask(int taskId, string title)
        {
            TaskExtension? task = GetTaskById(taskId);
            if (task == null)
            {
                return false;
            }
            task.title = title;
            return true;
        }

        public DateTime GetTaskCreatedAt(int taskId)
        {
            TaskExtension? task = GetTaskById(taskId);
            if (task == null)
            {
                return DateTime.MinValue;
            }
            return task.createdAt;
        }
    }
}
