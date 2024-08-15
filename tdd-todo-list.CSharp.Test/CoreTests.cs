using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    public class CoreTests
    {

        // I want to add tasks to my todo list.
        [Test]
        public void AddSingleTodo() 
        {
            var todoList = new Todo();
            var todo = "Walk the turlte";
        }
        //I want to see all the tasks in my todo list.
        //I want to change the status of a task between incomplete and complete.
        //I want to be able to get only the complete tasks.
        //I want to be able to get only the incomplete tasks.
        //I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
        //I want to remove tasks from my list.
        //I want to see all the tasks in my list ordered alphabetically in ascending order.
        //I want to see all the tasks in my list ordered alphabetically in descending order.
    }
}