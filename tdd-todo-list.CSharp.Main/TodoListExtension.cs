using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private List<TodoTaskExtension> _tasks { get; set; } = new List<TodoTaskExtension>();

        public TodoListExtension(List<TodoTaskExtension> tasks)
        {
            _tasks = tasks;
        }

        public TodoTaskExtension findTodoById(int id)
        {
            TodoTaskExtension task = null;
            foreach (var item in _tasks)
            {
                if (item.Id == id)
                {
                    task = item;
                }
            }

            return task;
        }

        public TodoTaskExtension ChangeName(int id, string newName)
        {
            TodoTaskExtension todo = findTodoById(id);
            todo.Name = newName;
            return todo;
        }

        public TodoTaskExtension UpdateStatus(int id, bool newStatus)
        {
            TodoTaskExtension task = findTodoById(id);
            task.Status = newStatus;
            return task;
        }
    }
}
