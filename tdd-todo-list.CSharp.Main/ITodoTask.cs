using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public interface ITodoTask
    {
        public int Id { get; }
        public bool IsCompleted { get; }
        public string TaskContent { get; }
        public TaskPriorityEnum Priority { get; }
        public DateTime TimeCreated { get; }
        public DateTime TimeCompleted { get; }
        public TimeSpan TimeToComplete { get; }
        public TaskCategoryEnum Category { get; }

        public void CompleteTask();
        public void ChangeTaskPriority(TaskPriorityEnum priority);
        public void ChangeTaskContent(string content);
        public void ChangeTaskCategory(TaskCategoryEnum category);


    }
}
