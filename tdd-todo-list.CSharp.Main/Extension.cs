using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private List<ExtendedTask> _tasks = new List<ExtendedTask>();
        
        public ExtendedTask GetTask(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTaskName(Guid id, string name)
        {
            throw new NotImplementedException();
        }

        public void SetTaskStatus(Guid id, TaskStatus status)
        {
            throw new NotImplementedException();
        }

        public DateTime GetTaskTimeOfCreation(Guid id)
        {
            throw new NotImplementedException();
        }

        public DateTime? GetTaskTimeOfCompletion(Guid id)
        {
            throw new NotImplementedException();
        }

        public ExtendedTask FindLongestCompletedTask(Guid id)
        {
            throw new NotImplementedException();
        }

        public ExtendedTask FindShortestCompletedTask(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ExtendedTask> FindTasksCompletedInMoreThan5Days()
        {
            throw new NotImplementedException();
        }

        public void CategoriseTask(Guid id, TaskCategory category)
        {
            throw new NotImplementedException();
        }

        public List<ExtendedTask> ListTasksByCategory(TaskCategory category)
        {
            throw new NotImplementedException();
        }
    }
}
