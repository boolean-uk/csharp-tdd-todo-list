using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        public List<TODOItem> tasks;

        public TodoList() {
        
            tasks = new List<TODOItem>();
        }

        public TODOItem Add(string item)
        {
            TODOItem task = new TODOItem(item, tasks.Count);

            tasks.Add(task);
            return task;
        }
        public string ShowTaskList(List<TODOItem> tasks)
        {
            StringBuilder sb = new StringBuilder();
            foreach (TODOItem task in tasks)
            {
                sb.Append($"{task.name}, ");
            }

            return sb.ToString();
        }

        public bool UpdateStatus(int id)
        {
            TODOItem task = tasks.Where(task => task.id == id).ToList()[0];
            task.toggleStatus();
            return task.status;

        }


        public List<TODOItem> filterItems(bool  status)
        {
            List<TODOItem> filteredTasks = tasks.Where(task => task.status == status).ToList();

            return filteredTasks;

        }

        public string Search(string taskName)
        {
            
            string errorMessage = "There is no such task.";
            List<TODOItem> tasksSearch = tasks.Where(task => task.name == taskName).ToList();
            if(tasksSearch.Count == 0) { return errorMessage; }

            return ShowTaskList(tasksSearch);

        }

        public bool deleteTask(int id)
        {
            TODOItem task = tasks.Where(task => task.id == id).ToList()[0];

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

    }

    public class TODOItem
    {
        public string name;
        public bool status;
        public int id;

        public TODOItem(string name, int id)
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
