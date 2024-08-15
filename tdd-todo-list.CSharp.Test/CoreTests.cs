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
            var todo = "Walk the turtle";

            var result = todoList.Add(todo);
            
            Assert.That(result, Is.True);
        }

        [Test]
        public void AddSeveralTodo()
        {
            var todoList = new Todo();
            var todo1 = "Walk the turtle";
            var todo2 = "Practice backflipping";

            var result1 = todoList.Add(todo1);
            var result2 = todoList.Add(todo2);

            Assert.That(result1, Is.True);
            Assert.That(result2, Is.True);


        }
        [Test]
        public void AddEmptyTodo()
        {
            var todoList = new Todo();
            var todo = "";

            var result = todoList.Add(todo);

            Assert.That(result, Is.False);
        }
        [Test]
        public void AddNullTodo()
        {
            var todoList = new Todo();
            string todo = null;

            var result = todoList.Add(todo);

            Assert.That(result, Is.False);
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