using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Todo
    {
		public int id;
		public string description;
		public bool done;
		public DateTime creationDateTime;

		// Construct that gets called when creating a Todo
		public Todo(string taskDesc, int taskId)
		{ 
            this.description = taskDesc;
			this.id = taskId;
            this.done = false;
			this.creationDateTime = DateTime.Now;
        }
    }
    public class TodoList
    {
		private int _lastId = 0;
		public List<Todo> tasks = new List<Todo>();


		public void Add(string taskDesc)
		{
			_lastId++;
			Todo todo =  new Todo(taskDesc, _lastId);
			tasks.Add(todo);
		}

		public List<Todo> Tasks()
		{
			return tasks;
		}

		public void ChangeStatus(int id)
		{
			foreach (Todo todo in tasks)
			{
				if (todo.id == id)
				{
					if(todo.done == false) todo.done = true;
					else todo.done = false;
					break;
				}
			}
		}

		public List<Todo> CompletedTasks()
		{
			List<Todo> completedTasks = new List<Todo>();
			foreach(Todo todo in tasks)
			{
				if(todo.done == true)
				{
					completedTasks.Add(todo);
				}
			}
			return completedTasks;
		}

        public List<Todo> IncompleteTasks()
        {
            List<Todo> incompleteTasks = new List<Todo>();
			
            foreach (Todo todo in tasks)
            {
                if (todo.done == false)
                {
                    incompleteTasks.Add(todo);
                }
            }
			
            return incompleteTasks;
        }

		public string SearchTask(int id)
		{
			
            foreach (Todo todo in tasks)
            {
				if (todo.id == id)
				{
					return "";
				}
            }
            return $"Id:{id} was not found";
		}

		public void Remove(int id)
		{
			for(int i = 0; i < tasks.Count; i++)
			{
				if (tasks[i].id == id) 
				{
					tasks.RemoveAt(i);
					break;
				}
			}
		}

		public List<Todo> TasksAcending()
		{
			return tasks.OrderBy(t => t.description).ToList();
        }

        public List<Todo> TasksDecending()
        {
            return tasks.OrderByDescending(t => t.description).ToList();
        }
    }
}