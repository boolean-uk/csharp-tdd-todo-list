using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private readonly List<ExtendedTask> _tasks = new();

        public void AddTask(ExtendedTask task)
        {
            _tasks.Add(task);
        }
        
        public ExtendedTask? GetTask(Guid id)
        {
            ExtendedTask? task = _tasks.Find(task => task.Id == id);
            return task;
        }

        public void UpdateTaskName(Guid id, string name)
        {
            int taskIndex = _tasks.FindIndex(task => task.Id == id);
            if (taskIndex != -1)
            {
                _tasks[taskIndex].Name = name;
            }
        }

        public void SetTaskStatus(Guid id, TaskStatus status)
        {
            int taskIndex = _tasks.FindIndex(task => task.Id == id);
            if (taskIndex != -1)
            {
                if (status == TaskStatus.Complete && _tasks[taskIndex].Status == TaskStatus.Incomplete)
                {
                    _tasks[taskIndex].Complete();
                }
            }
        }

        public DateTime? GetTaskTimeOfCreation(Guid id)
        {
            var task = _tasks.Find(task => task.Id == id);
            return task?.CreateTime;
        }

        public DateTime? GetTaskTimeOfCompletion(Guid id)
        {
            var task = _tasks.Find(task => task.Id == id);
            return task?.CompleteTime;        }

        public ExtendedTask FindLongestCompletedTask()
        {
            return _tasks.OrderByDescending(task => task.GetDuration()).First();
        }

        public ExtendedTask FindShortestCompletedTask()
        {
            return _tasks.OrderByDescending(task => task.GetDuration()).Last();

        }

        public List<ExtendedTask> FindTasksCompletedInMoreThan5Days()
        {
            return _tasks.Where(task => task.GetDuration()?.Days >= 5).ToList();
        }

        public void CategoriseTask(Guid id, TaskCategory category)
        {
            int index = _tasks.FindIndex(task => task.Id == id);
            if (index != -1)
            {
                _tasks[index].Category = category;
            }
        }

        public List<ExtendedTask> ListTasksByCategory()
        {
            return _tasks.OrderBy(task => task.Category).ToList();
        }
    }
}
