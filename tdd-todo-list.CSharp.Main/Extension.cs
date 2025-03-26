using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{

    public class TodoTaskExtension
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Iscomplete { get; set; }
        public DateTime Date { get; set; }
    }
    public class TodoListExtension
    {
        private List<TodoTaskExtension> tasks;
        public TodoListExtension() => tasks = new List<TodoTaskExtension>();

        public void AddTask(TodoTaskExtension task)
        {
           tasks.Add(task);
        }


        public TodoTaskExtension GetTaskByID(int id)
        {
            var task = tasks.FirstOrDefault(x => x.Id == id);
            if (task == null)
            {
                throw new Exception("task does not exist");
            }
            return task;
        }

       

        public TodoTaskExtension UpdateTask(int id, string newName)
        {
            var task = GetTaskByID(id);
            task.Name = newName;

            return task;

        }



        public TodoTaskExtension UpdateStaus(int id, bool status)
        {
            var task = GetTaskByID(id);
            task.Iscomplete = status;
            return task;
        }



        public void AddTaskWithDate(TodoTaskExtension task, DateTime date)
        {
            task.Date = date; // Set the creation date and time of the task
            tasks.Add(task);
        }

        public object CreatedTime(int id)
        {
            var task = GetTaskByID(id);
            return task.Date.ToString("dd,MM,yyyy");
        }
    }
}
