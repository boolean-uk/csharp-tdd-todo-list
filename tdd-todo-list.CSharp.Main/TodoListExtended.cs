using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtended
    {
        private int _count;
        public List<TodoTaskExtended> todoList { get; set; }

        public TodoListExtended()
        {
            _count = 0;
            todoList = new List<TodoTaskExtended>();
        }

        public bool AddTask(string taskName, Status status)
        {
            try
            {
                todoList.Add(new TodoTaskExtended(_count, taskName, status));
                _count++;
                return true;

            }
            catch
            {
                return false;
            }
        }

        public TodoTaskExtended FetchTaskByID(int id)
        {
            foreach (TodoTaskExtended task in todoList)
            {
                if (task.id == id)
                {
                    return task;
                }
            }
            return null;
        }
        public bool UpdateTaskNameByID(int id, string newName)
        {
            foreach (TodoTaskExtended task in todoList)
            {
                if (task.id == id)
                {
                    task.name = newName;
                    return true;
                }
            }
            return false;
        }
        public bool UpdateTaskStatusByID(int id, Status newStatus)
        {
            foreach (TodoTaskExtended task in todoList)
            {
                if (task.id == id)
                {
                    task.status = newStatus;
                    return true;
                }
            }
            return false;
        }

        public void PrintTaskList(List<TodoTaskExtended> tasks)
        {
            foreach (TodoTaskExtended task in todoList)
            {
                Console.WriteLine($"{task.id} - {task.name}, time:{task.time} ({task.status})");
            }
        }
    }
}
