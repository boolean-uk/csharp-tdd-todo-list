using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {

        public List<TOTask> tasks;

        public TodoListExtension()
        {

            tasks = new List<TOTask>();
        }

        public TOTask Add(string item)
        {
            TOTask task = new TOTask(item, tasks.Count);

            tasks.Add(task);
            return task;
        }
        public string ShowTaskList(List<TOTask> tasks)
        {
            StringBuilder sb = new StringBuilder();
            foreach (TOTask task in tasks)
            {
                sb.Append($"{task.name}, ");
            }

            return sb.ToString();
        }

        public bool UpdateStatus(int id)
        {
            TOTask task = tasks.Where(task => task.id == id).ToList()[0];
            task.toggleStatus();
            return task.status;

        }


        public List<TOTask> filterItems(bool status)
        {
            List<TOTask> filteredTOTasks = tasks.Where(task => task.status == status).ToList();

            return filteredTOTasks;

        }

        public string Search(string taskName)
        {

            string errorMessage = "There is no such task.";
            List<TOTask> tasksSearch = tasks.Where(task => task.name == taskName).ToList();
            if (tasksSearch.Count == 0) { return errorMessage; }

            return ShowTaskList(tasksSearch);

        }

        public bool deleteTask(int id)
        {
            TOTask task = tasks.Where(task => task.id == id).ToList()[0];

            return tasks.Remove(task);

        }

        public bool sortTasksAscending()
        {

            tasks.Sort((task1, task2) => task1.name.CompareTo(task2.name));

            return true;
        }

        public bool sortTasksDescending()
        {

            tasks.Sort((task1, task2) => -task1.name.CompareTo(task2.name));

            return true;
        }

        public TOTask getTaskById(int id)
        {
            string errorMessage = "There is no such task to update.";
            TOTask task = tasks.FirstOrDefault(t => t.id == id);

            return task;
        }

        public bool updateTaskName(int id, string name)
        {
            TOTask task = getTaskById(id);
            task.name = name;

            return true;
        }

    }

    public class TOTask
    {
        public string name { get; set; }
        public bool status;
        public int id;

        public TOTask(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public void toggleStatus()
        {
            status = !status;
        }
    }
}
