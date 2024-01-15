using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        public TodoList _todoList;
        public TodoListExtension(TodoList todoList)
        {
            _todoList = todoList;
        }
        public TodoTask GetTaskById(int id)
        {
            return _todoList.GetTask().FirstOrDefault(task => task.Id == id); //returns task with the id or null when the task is not found
        }
        public void UpdateTaskName(int taskId, string newName)
        {
            var taskToUpdate = GetTaskById(taskId);
            if (taskToUpdate != null)
            {
                taskToUpdate.Title = newName;
            }
            else
            {
                throw new ArgumentException("no task with the id found");
            }
        }
        public void ChangeTaskState(int taskId, bool isComplete)
        {
            var taskToUpdate = GetTaskById(taskId);
            if (taskToUpdate != null)
            {
                taskToUpdate.IsCompleted = isComplete;
            }
            else
            {
                throw new ArgumentException("no task with the id found");
            }
        }
    }
}
