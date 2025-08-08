using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension : TodoList
    {
        public void Add(string v, DateTime createDate)
        {
            throw new NotImplementedException();
        }

        public void CompleteTask(int v, DateTime completeDate)
        {
            throw new NotImplementedException();
        }

        public TodoObject GetByID(int v)
        {
            throw new NotImplementedException();
        }

        public DateTime SeeCompletedDate(int v)
        {
            throw new NotImplementedException();
        }

        public DateTime SeeCreatedDate(int v)
        {
            throw new NotImplementedException();
        }

        public void UpdateName(int v, string newName)
        {
            throw new NotImplementedException();
        }

        public TimeSpan? GetCompleteLength(int id)
        {
            TodoObject todoObject = GetByID(id);
            try
            {
                return todoObject.CompleteDate.Subtract(todoObject.CreateDate);

            }
            catch {  return null; }
        }

        public List<TodoObject> ListByCategory(string v)
        {
            throw new NotImplementedException();
        }

        public List<TodoObject> GetTasksOver5Days()
        {
            throw new NotImplementedException();
        }

        public TodoObject GetShortestCompletedTask()
        {
            throw new NotImplementedException();
        }

        public TodoObject GetLongestCompletedTask()
        {
            throw new NotImplementedException();
        }
    }
}
