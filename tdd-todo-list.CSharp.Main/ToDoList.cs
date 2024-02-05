using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main

{

    public class TodoTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsComplete { get; set; }
    }


    public class TodoList
    {


        private List<TodoTask> tasks;

        public TodoList() => tasks = new List<TodoTask>();

        // Refactored AddTask method with null check and validation
        public void AddTask(TodoTask task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task));

            tasks.Add(task);
        }

        public List<TodoTask> GetTasks()
        {
            return tasks;
        }

        public void ChangeTaskStatus(int taskId, bool isComplete)
        {
            TodoTask taskToUpdate = tasks.FirstOrDefault(task =>
            {
                return task.Id == taskId;
            });

            if (taskToUpdate != null)
            {
                taskToUpdate.IsComplete = isComplete;
            }
            else
            {
                throw new ArgumentException($"Task with ID {taskId} not found.", nameof(taskId));
            }
        }

        public List<TodoTask> GetCompleteTasks()
        {
            return tasks.Where(task => task.IsComplete).ToList();
        }

        public List<TodoTask> GetIncompleteTasks()
        {
            return tasks.Where(task => !task.IsComplete).ToList();
        }

        public TodoTask SearchTaskById(int taskId)
        {
            TodoTask foundTask = tasks.FirstOrDefault(task => task.Id == taskId);

            if (foundTask == null)
            {
                throw new ArgumentException($"Task with ID {taskId} not found.", nameof(taskId));
            }

            return foundTask;
        }

        public TodoTask RemoveTaskById(int taskId)
        {
            TodoTask taskToRemove = tasks.FirstOrDefault(task => task.Id == taskId);

            if (taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
                return taskToRemove;
            }
            else
            {
                throw new ArgumentException($"Task with ID {taskId} not found.", nameof(taskId));
            }
        }

        public List<TodoTask> AscendingOrder()
        {
            return tasks.OrderBy(task => task.Title).ToList();
        }

        public List<TodoTask> DescendingOrder()
        {
            return tasks.OrderByDescending(task => task.Title).ToList();
        }
    }
}
