using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class MockTodoTask : ITodoTask
    {
        private int _id;
        private string _taskContent = "";
        private bool _isCompleted = false;
        private TaskPriorityEnum _priority = TaskPriorityEnum.Medium;
        private DateTime _timeCompleted;
        private TimeSpan _timeToComplete;
        private TaskCategoryEnum _category;

        private DateTime _timeCreated;

        public MockTodoTask(int id, string taskContent, bool isCompleted, TaskPriorityEnum priority, 
            DateTime timeCompleted, TimeSpan timeToComplete, TaskCategoryEnum category,
            DateTime timeCreated) 
        { 
            _id = id;
            _taskContent = taskContent;
            _isCompleted = isCompleted;
            _priority = priority;
            _timeCompleted = timeCompleted;
            _timeToComplete = timeToComplete;
            _category = category;
            _timeCreated = timeCreated;

        }

        public int Id { get { return _id; } }

        public bool IsCompleted { get { return _isCompleted; } }

        public string TaskContent {  get { return _taskContent; } }

        public TaskPriorityEnum Priority {  get { return _priority; } }

        public DateTime TimeCreated {  get { return _timeCreated; } }

        public DateTime TimeCompleted {  get { return _timeCompleted; } }

        public TimeSpan TimeToComplete {  get { return _timeToComplete; } }

        public TaskCategoryEnum Category {  get { return _category; } }

        public void ChangeTaskCategory(TaskCategoryEnum category)
        {
            _category = category;
        }

        public void ChangeTaskContent(string content)
        {
            _taskContent = content;
        }

        public void ChangeTaskPriority(TaskPriorityEnum priority)
        {
            _priority = priority;
        }

        public void CompleteTask()
        {
            _isCompleted = true;
        }
    }
}
