using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension : TodoList
    {
        private TodoList _todoList;
        public TodoListExtension()
        {
            _todoList = new TodoList();
        }
        public TodoList todoList { get { return _todoList; } }

        public object GetTaskById(int id)
        {
           var task = this.todolist.FirstOrDefault(t =>  t.id == id);
            if (task != null)
            {
                return task;
            }
            return "Task not found";
        }

        public Task? UpdateTaskById(int id, string taskName)
        {
            var task = this.todolist.FirstOrDefault(t => t.id == id);
            if (task != null)
            {
                task.task = taskName;
            }
            return task;
        }
        public Task? ChangeStatusById(int id)
        {
            var task = this.todolist.FirstOrDefault(t => t.id == id);
            if(task != null)
            {
                task.isCompleted = !task.isCompleted;
            }
            return task;
        }
    }
}
