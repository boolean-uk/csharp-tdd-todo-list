using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public bool AddTodo(string description)
        {
            if (Todos.ContainsKey(description))
            {
                return false;
            } else
            {
                this.Todos.Add(description, "Incomplete");
                return true;
            }
            
        }

        public void ShowAllTodos()
        {
         
            foreach (var todo in Todos)
            {
                Console.WriteLine($"Description: {todo.Key}, Status: {todo.Value}");
            }
        }

        public void ChangeTodoStatus(string description, string status)
        {
            foreach (var todo in Todos)
            {
                if(todo.Key ==  description)
                {
                    Todos[description] = status;
                }
            }
        }

        public void ShowCompletedTasks()
        {
            foreach(var todo in Todos)
            {
                if(todo.Value == "Complete")
                {
                    Console.WriteLine($"Description: {todo.Key}, Status: {todo.Value}");
                }
            }
        }

        public void ShowIncompleteTasks()
        {
            foreach (var todo in Todos)
            {
                if (todo.Value == "Incomplete")
                {
                    Console.WriteLine($"Description: {todo.Key}, Status: {todo.Value}");
                }
            }
        }

        public bool SearchForTask(string description)
        {
            if(Todos.ContainsKey(description))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool RemoveTodo(string description)
        {
            if (Todos.ContainsKey(description))
            {
                Todos.Remove(description);
                return true;
            } else
            {
                return false;
            }
        }

        public void ShowTodosAlphabeticallyAscending()
        {
            Dictionary<string, string> todosAscending = Todos.Keys.OrderBy(k => k).ToDictionary(k => k, k => Todos[k]);

            foreach(var todo in todosAscending)
            {
                Console.WriteLine($"Description: {todo.Key}, Status: {todo.Value}");
            }
        }

        public void ShowTodosAlphabeticallyDescending()
        {
            Dictionary<string, string> todosDescending = Todos.Keys.OrderByDescending(k => k).ToDictionary(k => k, k => Todos[k]);

            foreach (var todo in todosDescending)
            {
                Console.WriteLine($"Description: {todo.Key}, Status: {todo.Value}");
            }
        }

        public Dictionary<string, string> Todos { get; set; } = new Dictionary<string, string>();
    }
}
