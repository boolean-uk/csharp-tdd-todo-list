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
        public readonly List<Task> tasks = new();

        public void AddTask(string taskContent)
        {
            int id = tasks.Count;
            var task = new Task(id, taskContent);
            tasks.Add(task);
        }

        public void ChangeTaskStatus(string taskName)
        {
            tasks.Where(t => t.TaskContent == taskName).First().CompleteTask();
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return tasks;
        }

        public IEnumerable<Task> GetCompletedTasks()
        {
            return tasks.Where(t => t.IsCompleted == true).ToList();
        }

        public IEnumerable<Task> GetIncompleteTasks()
        {
            return tasks.Where(t => t.IsCompleted == false).ToList();
        }

        public Task SearchForTask(string taskContent)
        {
            return tasks.Where(t => t.TaskContent == taskContent).First();
        }

        public void RemoveTaskByName(string taskContent) 
        {
            var taskToRemove = tasks.Where(t => t.TaskContent == taskContent).First();
            tasks.Remove(taskToRemove);
        }

        public void RemoveTaskById(int id)
        {
            var taskToRemove = tasks.Where(t => t.Id == id).First();
            tasks.Remove(taskToRemove);
        }

        public IEnumerable<Task> GetAlphabeticallySortedTasks(bool ascending) 
        {  
            if (ascending)
                return tasks.OrderByDescending(task  => task.TaskContent).ToArray();

            return tasks.OrderBy(task => task.TaskContent).ToArray();
        }

        public void ChangeTaskPriorityByName(string name, TaskPriorityEnum priority) 
        {
            tasks.Where(t => t.TaskContent == name).First().ChangeTaskPriority(priority);
        }

        public void ChangeTaskPriorityById(int id, TaskPriorityEnum priority)
        {
            tasks.Where(t => t.Id == id).First().ChangeTaskPriority(priority);
        }

        public IEnumerable<Task> GetAllTasksByPriority(TaskPriorityEnum priority)
        {
            return tasks.Where(t => t.Priority == priority).ToList();
        }

        public Task GetTaskByName(string name) 
        { 
            var task = tasks.Where(t => t.TaskContent == name).FirstOrDefault(); 

            if (task != null)
                return task;

            else 
                throw new TaskNotFoundException();
        }

        public Task GetTaskById(int id) 
        {
            return tasks.Where(t => t.Id == id).First();
        }

        public void UpdateTaskNameById(int id, string newName) 
        {  
            var task = GetTaskById(id);
            task.ChangeTaskContent(newName);
        }

        public void UpdateTaskStatusById(int id) 
        {
            var task = GetTaskById(id);
            task.CompleteTask();
        }

        public Task GetTaskLongestToComplete()
        {
            var task = tasks.OrderByDescending(t => t.TimeToComplete).First();
            return task;
        }

        public Task GetTaskShortestToComplete() 
        {
            var task = tasks.Where(task => task.TimeToComplete > TimeSpan.MinValue).OrderBy(t => t.TimeToComplete).FirstOrDefault();
            return task;
        }

        public IEnumerable<Task> GetTasksWhichTookLongerToCompleteThan(int seconds) 
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            return tasks.Where(task => task.TimeToComplete > timeSpan).OrderByDescending(t => t.TimeToComplete).ToList();            
        }

        public void AssignCategoryToTaskById(int id, TaskCategoryEnum category) 
        {
            var task = GetTaskById(id);
            task.ChangeTaskCategory(category);
        }

        public IEnumerable<Task> GetTasksByCategory(TaskCategoryEnum category)
        {
            return tasks.Where(task => task.Category == category).ToList();
        }

    }
}
