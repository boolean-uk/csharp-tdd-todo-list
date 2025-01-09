using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension 
    {
        public List<TaskExtension> tasks { get; set; }

        public TodoListExtension()
        {
            tasks = new List<TaskExtension>();

        }

        public List<long> GetIDs()
        {
            List<long> ids = new List<long>();
            foreach (TaskExtension t in tasks)
            {
                ids.Add(t.id);
            }
            return ids;
        }

        public TaskExtension Add(string title, string description)
        {
          
            // TaskExtensions needs different titles
            if (tasks.Where(x => x.title == title).Any() || title == "")
            {
                return new TaskExtension("", "", GetIDs());
            }
            TaskExtension taskToAdd = new TaskExtension(title, description, GetIDs());
            tasks.Add(taskToAdd);
            return new TaskExtension(taskToAdd);
        }

        public List<TaskExtension> GetTasks()
        {
            return new List<TaskExtension>(tasks);
        }

        public TaskExtension GetTask(string title)
        {
            TaskExtension? queried_task = tasks.FirstOrDefault(x => x.title == title) ?? new TaskExtension("", "", GetIDs());

            return new TaskExtension(queried_task);
        }

        public TaskExtension ChangeTask(string title, bool status)
        {
            TaskExtension? taskToUpdate = tasks.FirstOrDefault(x => x.title == title) ?? new TaskExtension("", "", GetIDs());
            taskToUpdate.status = status;
            return new TaskExtension(taskToUpdate);
        }

        public List<TaskExtension> GetCompletedTasks()
        {
            List<TaskExtension>? completedTasks = tasks.Where(x => x.status).ToList() ?? new List<TaskExtension>();
            return new List<TaskExtension>(completedTasks);
        }

        public List<TaskExtension> GetIncompleteTasks()
        {
            List<TaskExtension>? completedTasks = tasks.Where(x => !x.status).ToList() ?? new List<TaskExtension>();
            return new List<TaskExtension>(completedTasks);
        }



        public TaskExtension RemoveTask(string title)
        {
            TaskExtension? taskToRemove = tasks.FirstOrDefault(x => x.title == title) ?? new TaskExtension("", "", GetIDs());
            if (taskToRemove.title == "")
            {
                return taskToRemove;
            }
            tasks.Remove(taskToRemove);
            return new TaskExtension(taskToRemove);
        }

        public List<TaskExtension> SortTasksAlphabetically(bool ascending)
        {
            List<TaskExtension> sortedTasks = new List<TaskExtension>();
            if (ascending)
            {
                sortedTasks = tasks.OrderBy(x => x.title).ToList();
            }
            else
            {
                sortedTasks = tasks.OrderByDescending(x => x.title).ToList();
            }

            return new List<TaskExtension>(sortedTasks);
        }
        public TaskExtension GetTaskByID(long id)
        {
            TaskExtension? retrievedTask = tasks.FirstOrDefault(x => x.id == id) ?? new TaskExtension("", "", GetIDs());
            return new TaskExtension(retrievedTask);
        }

        public TaskExtension UpdateTaskTitle(long id, string title)
        {
            TaskExtension? taskToUpdate = tasks.FirstOrDefault(x => x.id == id) ?? new TaskExtension("", "", GetIDs());
            taskToUpdate.title = title;
            return new TaskExtension(taskToUpdate);
        }

        public TaskExtension UpdateTaskStatus(long id, bool status)
        {
            TaskExtension? taskToUpdate = tasks.FirstOrDefault(x => x.id == id) ?? new TaskExtension("", "", GetIDs());
            taskToUpdate.status = status;
            return new TaskExtension(taskToUpdate);
        }

        public string GetCreationTime()
        {
            string creationTime = "";
            foreach (TaskExtension task in tasks)
            {
                creationTime += task.id + " " + task.title + " " + task.creationTime.ToString() + "\n";
            }
            return creationTime;
        }
    }


    public class TaskExtension
    {
        public string title { get; set; }
        public string description { get; set; }
        public bool status { get; set; }
        public long id { get; }
        public DateTime creationTime = DateTime.Now;
        public Random rng = new Random();

        public TaskExtension(string title, string description, List<long> usedIDs)
        {
            this.title = title;
            this.description = description;
            status = false;
            long id = 0;
            while (usedIDs.Contains(id))
            {
                id = rng.NextInt64(0, 1000);
            }
            this.id = id;
        }

        public TaskExtension(TaskExtension t)
        {
            this.title = t.title;
            this.description = t.description;
            this.status = t.status;
            this.id = id;

        }


        public bool Equals(TaskExtension other)
        {
            return this.title == other.title && this.id == other.id; //Check whether the identifier of a task are equal
        }
    }
}
