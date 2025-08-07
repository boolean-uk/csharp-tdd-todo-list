using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public readonly List<ITodoTask> tasks = new();

        public void AddTask(ITodoTask task)
        {
            tasks.Add(task);
        }

        public IEnumerable<ITodoTask> GetAllTasks()
        {
            return tasks;
        }

        public IEnumerable<ITodoTask> GetCompletedTasks()
        {
            return tasks.Where(t => t.IsCompleted == true).ToList();
        }

        public IEnumerable<ITodoTask> GetIncompleteTasks()
        {
            return tasks.Where(t => t.IsCompleted == false).ToList();
        }

        public void RemoveTaskByName(string taskContent) 
        {
            var taskToRemove = tasks.Where(t => t.TaskContent == taskContent).FirstOrDefault();
            tasks.Remove(taskToRemove);
        }

        public void RemoveTaskById(int id)
        {
            var taskToRemove = tasks.Where(t => t.Id == id).FirstOrDefault();
            tasks.Remove(taskToRemove);
        }

        public IEnumerable<ITodoTask> GetAlphabeticallySortedTasks(bool ascending) 
        {  
            if (ascending)
                return tasks.OrderBy(task  => task.TaskContent).ToArray();

            return tasks.OrderByDescending(task => task.TaskContent).ToArray();
        }

        public void ChangeTaskPriorityByName(string name, TaskPriorityEnum priority) 
        {
            tasks.Where(t => t.TaskContent == name).FirstOrDefault().ChangeTaskPriority(priority);
        }

        public void ChangeTaskPriorityById(int id, TaskPriorityEnum priority)
        {
            tasks.Where(t => t.Id == id).FirstOrDefault().ChangeTaskPriority(priority);
        }

        public IEnumerable<ITodoTask> GetAllTasksByPriority()
        {
            return tasks.OrderByDescending(t => t.Priority).ToArray();
        }

        public ITodoTask GetTaskByName(string name) 
        { 
            var task = tasks.Where(t => t.TaskContent == name).FirstOrDefault(); 

            if (task != null)
                return task;

            else 
                throw new TaskNotFoundException();
        }

        public ITodoTask GetTaskById(int id) 
        {
            return tasks.Where(t => t.Id == id).FirstOrDefault();
        }

        public void UpdateTaskNameById(int id, string newName) 
        {  
            var task = GetTaskById(id);
            task.ChangeTaskContent(newName);
        }

        public void CompleteTaskById(int id) 
        {
            var task = GetTaskById(id);
            task.CompleteTask();
        }

        public void CompleteTaskByName(string name)
        {
            var task = GetTaskByName(name);
            task.CompleteTask();
        }

        public ITodoTask GetTaskLongestToComplete()
        {
            var task = tasks.OrderByDescending(t => t.TimeToComplete).FirstOrDefault();
            return task;
        }

        public ITodoTask GetTaskShortestToComplete() 
        {
            var task = tasks.Where(t => t.IsCompleted == true).OrderBy(t => t.TimeToComplete).FirstOrDefault();
            return task;
        }

        public IEnumerable<ITodoTask> GetTasksWhichTookLongerToCompleteThan(int seconds) 
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            return tasks.Where(task => task.TimeToComplete > timeSpan).OrderByDescending(t => t.TimeToComplete).ToList();            
        }

        public void AssignCategoryToTaskById(int id, TaskCategoryEnum category) 
        {
            var task = GetTaskById(id);
            task.ChangeTaskCategory(category);
        }

        public IEnumerable<ITodoTask> GetTasksByCategory(TaskCategoryEnum category)
        {
            return tasks.Where(task => task.Category == category).ToList();
        }

    }
}
