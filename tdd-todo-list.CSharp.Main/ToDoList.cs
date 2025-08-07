using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }

        public IEnumerable<Task> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Task> GetCompletedTasks()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Task> GetIncompleteTasks()
        {
            throw new NotImplementedException();
        }

        public Task SearchForTask(string taskContent)
        {
            throw new NotImplementedException();
        }

        public void RemoveTaskByName(string taskContent) 
        {

        }

        public void RemoveTaskById(int id)
        {

        }

        public IEnumerable<Task> GetAlphabeticallySortedTasks(bool ascending) 
        {  
            throw new NotImplementedException(); 
        }

        public void ChangeTaskPriorityByName(string name, TaskPriorityEnum priority) 
        { 
        
        }

        public void ChangeTaskPriorityById(int id, TaskPriorityEnum priority)
        {

        }

        public IEnumerable<Task> GetAllTasksByPriority(TaskPriorityEnum priority)
        {
            throw new NotImplementedException();
        }

        public Task GetTaskByName(string name) 
        { 
            throw new NotImplementedException(); 
        }

        public Task GetTaskById(int id) 
        { 
            throw new NotImplementedException(); 
        }

        public void UpdateTaskNameById(int id, string name) 
        {  
            throw new NotImplementedException(); 
        }

        public void UpdateTaskStatusById(int id) 
        {  
            throw new NotImplementedException();
        }

        public Task GetTaskLongestToComplete()
        {
            throw new NotImplementedException();
        }

        public Task GetTaskShortestToComplete() 
        { 
            throw new NotImplementedException(); 
        }

        public IEnumerable<Task> GetTasksWhichTookLongerToCompleteThan(int time) 
        { 
            throw new NotImplementedException(); 
        }

        public void AssignCategoryToTaskById(int id, TaskCategoryEnum category) 
        { 
            throw new NotImplementedException(); 
        }

        public IEnumerable<Task> GetTasksByCategory(TaskCategoryEnum category)
        {
            throw new NotImplementedException();
        }

    }
}
