using Main;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {

        public Todo GetTodoById(int id)
        {
            Todo result = new Todo();

            foreach(var todo in TodosList)
            {
                if (todo.Id == id)
                {
                    result = todo;
                } 
            }

            return result;

        }

        public bool UpdateTodoDescriptionById(int id, string description) 
        {
            bool result = false;

            foreach(var todo in TodosList)
            {
                if (todo.Id == id)
                {
                    todo.Description = description;     
                    result = true;
                } 
            }

            return result;
        }

        public bool UpdateTodoStatusById(int id, string status) 
        {
            bool result = false;

            foreach (var todo in TodosList)
            {
                if ( todo.Id == id)
                {
                    todo.Status = status;
                    result = true;
                }
            }


            return result;
        }

        public void AllTodosDateAndTimeAdded()
        {
            foreach(var todo in TodosList)
            {
                Console.WriteLine($"Id: {todo.Id}, Description: {todo.Description}, Status: {todo.Status}, DateTime: {todo.DateTime}");
            }
        }

        public List<Todo> TodosList { get; set; } = new List<Todo>();


    }
}
