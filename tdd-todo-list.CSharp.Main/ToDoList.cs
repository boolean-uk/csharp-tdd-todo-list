using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        private List<TodoTask> _tasks = [];
        public List<TodoTask> Tasks { get { return _tasks; } set { _tasks = value; } }   

        public void AddTask(TodoTask task)
        {
            Tasks.Add(task);
        }

        public void RemoveTask(TodoTask task)
        {
            Tasks.Remove(task);
        }

        public void ShowTasks()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var task in _tasks)
            {
                sb.AppendFormat("{0}:              {1},", task.Name, task.Description);
                sb.AppendLine();


            }
            Console.WriteLine(sb.ToString());
        }

        public List<TodoTask> RetrieveCompleted()
        {
            return Tasks.FindAll(t => t.Complete ==  true);
        }        

        public List<TodoTask> RetrieveUncompleted()
        {
            return Tasks.FindAll(t => t.Complete ==  false);
        }

        public string Search(TodoTask task)
        {
            if(Tasks.Contains(task))
            {
                return $"The task {task.Name} is in your to-do-list. Have a nice life!";
            }
            return $"The task {task.Name} was not found in your to-do-list";
        }


        public List<TodoTask> ListTaskAlphabetically()
        {
            IEnumerable<TodoTask> query = Tasks.OrderBy(task => task.Name);
            foreach (var task in query)
            {
                Console.WriteLine($"Task name: {task.Name}");
            }
            return query.ToList();
        }

        public List<TodoTask> ListTaskDescending()
        {
            IEnumerable<TodoTask> query = Tasks.OrderByDescending(task => task.Name);
            foreach (var task in query)
            {
                Console.WriteLine(task.Name);
            }
            return query.ToList();
        }
    }

}
