using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class MockTask : ITodoTask
    {
        public MockTask() 
        { 

        }

        public int Id => throw new NotImplementedException();

        public bool IsCompleted => throw new NotImplementedException();

        public string TaskContent => throw new NotImplementedException();

        public TaskPriorityEnum Priority => throw new NotImplementedException();

        public DateTime TimeCreated => throw new NotImplementedException();

        public DateTime TimeCompleted => throw new NotImplementedException();

        public TimeSpan TimeToComplete => throw new NotImplementedException();

        public TaskCategoryEnum Category => throw new NotImplementedException();

        public void ChangeTaskCategory(TaskCategoryEnum category)
        {
            throw new NotImplementedException();
        }

        public void ChangeTaskContent(string content)
        {
            throw new NotImplementedException();
        }

        public void ChangeTaskPriority(TaskPriorityEnum priority)
        {
            throw new NotImplementedException();
        }

        public void CompleteTask()
        {
            throw new NotImplementedException();
        }
    }
}
