using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public static class TodoListExtension
    {
        public static ToDoTask GetById(this TodoList todoList, string id)
        {
            ToDoTask task = todoList.Search(id)
                ?? throw new Exception($"No ToDoTask with id: {id}");
            return task;
        }

        public static void UpdateTask(this TodoList todoList, string id, string name)
        {
            ToDoTask task = todoList.GetById(id);
            task.Name = name;
        }

        public static void UpdateTask(this TodoList todoList, string id, Status status)
        {
            ToDoTask task = todoList.GetById(id);
            task.Status = status;
        }

        public static List<DateTime> ViewTaskCreationDates(this TodoList todoList)
        {
            List<DateTime> dateList = new();
            foreach (ToDoTask task in todoList)
            {
                Console.WriteLine($"{task.Name}: {task.DateCreated}");
                dateList.Add(task.DateCreated);
            }
            return dateList;
        }
    }
}
