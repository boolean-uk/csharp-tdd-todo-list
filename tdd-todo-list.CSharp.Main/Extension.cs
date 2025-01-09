using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension : TodoList
    {

        public Task GetTaskById(int id)
        {
            return GetTasks().FirstOrDefault(x => x.Key == id).Value;
        }

        public void UpdateTaskNameById(int id, string newName)
        {
            Task task = GetTaskById(id);
            task.TaskName = newName;
        }

        public void UpdateTaskStatusById(int id, string newStatus)
        {
            Task task = GetTaskById(id);
            task.Status = newStatus;
        }

        public DateTime GetDateTimeStamp(Task task)
        {
            return task.GetDateTime;
        }
    }
}
