using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public List<TodoTask> todoList { get; set; }

        public TodoList()
        {
            this.todoList = new List<TodoTask>();
        }

        public bool AddTask(TodoTask task)
        {
            try
            {
                todoList.Add(task);
                return true;

            }
            catch
            {
                return false;
            }
        }

        public List<TodoTask> AllTasks()
        {
            return todoList;
        }

        public TodoTask FetchTask(string taskName)
        {
            foreach (TodoTask task in todoList)
            {
                if (task.name == taskName) return task;
            }
            return null;
        }

        public bool ChangeStatus(string taskName, Status newStatus)
        {
            foreach (TodoTask task in todoList)
            {
                if (task.name == taskName)
                {
                    task.status = newStatus;
                    return true;
                }
            }
            return false;
        }

        public List<TodoTask> FetchTasksWithStatus(Status status)
        {
            List<TodoTask> result = new List<TodoTask>();
            foreach (TodoTask task in todoList)
            {
                if (task.status == status)
                {
                    result.Add(task);
                }
            }
            return result;
        }

        public string DoesExist(string taskName)
        {
            foreach (TodoTask task in todoList)
            {
                if (task.name == taskName)
                {
                    return "Does exist";
                }
            }
            return "Doesn't exist";
        }

        public bool RemoveTask(string taskName)
        {
            foreach (TodoTask task in todoList)
            {
                if (task.name == taskName)
                {
                    todoList.Remove(task);
                    return true;
                }
            }
            return false;
        }

        public List<TodoTask> AllTasksSorted(string order)
        {
            if (order.Equals("asc")) todoList.Sort((t1, t2) => t1.name.CompareTo(t2.name));
            else if (order.Equals("desc")) todoList.Sort((t1, t2) => t2.name.CompareTo(t1.name));

            return todoList;
        }

        public void PrintTaskList(List<TodoTask> tasks)
        {
            foreach (TodoTask task in todoList)
            {
                Console.WriteLine($"{task.name} ({task.status})");
            }
        }
    }
}
