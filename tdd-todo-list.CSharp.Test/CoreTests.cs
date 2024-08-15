using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

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
        //I want to remove tasks from my list.

        [Test]
        public void RemoveSingleTodo() 
        {
            var todoList = new Todo();
            var todo = "Walk the turtle";

            todoList.Add(todo);

            var result = todoList.Remove(todo);

            Assert.That(result, Is.True);
        }

        [Test]
        public void RemoveSeveralTodo()
        {
            var todoList = new Todo();
            var todo1 = "Walk the turtle";
            var todo2 = "Backflip";


            todoList.Add(todo1);
            todoList.Add(todo2);

            var result1 = todoList.Remove(todo1);
            var result2 = todoList.Remove(todo2);

            Assert.That(result1, Is.True);
            Assert.That(result2, Is.True);
        }

        [Test]
        public void RemoveEmptyTodo()
        {
            var todoList = new Todo();
            var todo = "";

            todoList.Add(todo);
            var result = todoList.Remove(todo);

            Assert.That(result, Is.False);
        }
        [Test]
        public void RemoveNullTodo()
        {
            var todoList = new Todo();
            string todo = null;

            todoList.Add(todo);
            var result = todoList.Remove(todo);

            Assert.That(result, Is.False);
        }
        //I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
        [TestCase(true, "Walk the dog", true)]
        [TestCase(false, "Walk the turtle", false)]
        [TestCase(true, null, false)]
        [TestCase(true, "", false)]
        public void SearchTodo(bool performAdd, string todo, bool expectedResult)
        {
            var todoList = new Todo();

            if(performAdd) todoList.Add(todo);
            var result = todoList.SearchTodo(todo);
            Assert.AreEqual(result, expectedResult);

        }

        //I want to see all the tasks in my todo list.
        [Test]
        public void GetTodos()
        {
            var todoList = new Todo();
            List<string> todos= ["Backlfip", "Test", "Cook", "Walk the turtle"];
            foreach(var todo in todos) todoList.Add(todo);

            var result = todoList.TodoList();

            Assert.That(result.Count is 4);

        }

        [Test]
        public void OneEntryTodoList()
        {
            var todoList = new Todo();
            string todo = "Backflip";
            todoList.Add(todo);

            var result = todoList.TodoList();

            Assert.That(result.Count is 1);

        }

        [Test]
        public void EmptyTodoList()
        {
            var todoList = new Todo();

            var result = todoList.TodoList();

            Assert.That(result.Count is 0);

        }

        [Test]
        public void NotNullTodoList()
        {
            var todoList = new Todo();

            var result = todoList.TodoList();

            Assert.That(result is not null);

        }
        //I want to be able to get only the complete tasks.
        //I want to be able to get only the incomplete tasks.
        //I want to change the status of a task between incomplete and complete.
        //I want to see all the tasks in my list ordered alphabetically in ascending order.
        //I want to see all the tasks in my list ordered alphabetically in descending order.
    }
}