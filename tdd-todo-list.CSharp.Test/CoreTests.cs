using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;
using System.Xml.Linq;

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
        //I want to change the status of a task between incomplete and complete.
        //I want to be able to get only the complete tasks.
        //I want to be able to get only the incomplete tasks.
        [Test]
        public void CompleteOneTask() 
        {
            var todoList = new Todo();
            List<string> todos = ["Backflip", "Cook", "Fill the car", "Walk the turtle"];

            foreach(var todo in todos) todoList.Add(todo);
            var result = todoList.ChangeTodoStatus(todos[1]);
            var incomplete = todoList.GetIncomplete();
            var complete = todoList.GetComplete();

            Assert.That(result, Is.True);
            Assert.AreEqual(complete.Count, 1);
            Assert.AreEqual(incomplete.Count, 3);
        }
        [Test]
        public void CompleteNoTask() 
        {
            var todoList = new Todo();
            List<string> todos = ["Backflip", "Cook", "Fill the car", "Walk the turtle"];

            foreach (var todo in todos) todoList.Add(todo);
            var incomplete = todoList.GetIncomplete();
            var complete = todoList.GetComplete();

            Assert.AreEqual(complete.Count, 0);
            Assert.AreEqual(incomplete.Count, 4);
        }
        [Test]
        public void CompleteSomeTasks()
        {
            var todoList = new Todo();
            List<string> todos = ["Backflip", "Cook", "Fill the car", "Walk the turtle"];

            foreach (var todo in todos) todoList.Add(todo);
            var result1 = todoList.ChangeTodoStatus(todos[1]);
            var result2 = todoList.ChangeTodoStatus(todos[2]);
            var result3 = todoList.ChangeTodoStatus(todos[3]);
            var incomplete = todoList.GetIncomplete();
            var complete = todoList.GetComplete();

            Assert.That(result1, Is.True);
            Assert.That(result2, Is.True);
            Assert.That(result3, Is.True);
            Assert.AreEqual(complete.Count, 3);
            Assert.AreEqual(incomplete.Count, 1);
        }

        //I want to see all the tasks in my list ordered alphabetically in ascending order.
        [Test]
        public void OrderByAscendingWrongOrderList()
        {
            var todoList = new Todo();
            List<string> todos = ["Walk the turtle", "Fill the car", "Cook", "Backflip" ];
            List<string> expected = ["Backflip", "Cook", "Fill the car", "Walk the turtle"];

            foreach (var todo in todos) todoList.Add(todo);
            var result = todoList.OrderByAscending();


            for (int i = 0; i < todos.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);   
            }

        }
        [Test]
        public void OrderByAscendingCorrectOrderList()
        {
            var todoList = new Todo();
            List<string> todos = ["Backflip", "Cook", "Fill the car", "Walk the turtle"];
            List<string> expected = ["Backflip", "Cook", "Fill the car", "Walk the turtle"];

            foreach (var todo in todos) todoList.Add(todo);
            var result = todoList.OrderByAscending();


            for (int i = 0; i < todos.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }

        }
        //I want to see all the tasks in my list ordered alphabetically in descending order.
        [Test]
        public void OrderByDescendingWrongOrderList()
        {
            var todoList = new Todo();
            List<string> todos = ["Backflip", "Cook", "Fill the car", "Walk the turtle"];
            List<string> expected = ["Walk the turtle", "Fill the car", "Cook", "Backflip"];

            foreach (var todo in todos) todoList.Add(todo);
            var result = todoList.OrderByDescending();


            for (int i = 0; i < todos.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }

        }
        [Test]
        public void OrderByDescendingCorrectOrderList()
        {
            var todoList = new Todo();
            List<string> todos = ["Walk the turtle", "Fill the car", "Cook", "Backflip"];
            List<string> expected = ["Walk the turtle", "Fill the car", "Cook", "Backflip"];

            foreach (var todo in todos) todoList.Add(todo);
            var result = todoList.OrderByDescending();


            for (int i = 0; i < todos.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }

        }

        //I want to be able to get a task by a unique ID.
        [Test]
        public void SearchByUniqueID() 
        {
            var todoList = new Todo();
            string todo = "Backflip";

            todoList.Add(todo);
            var result = todoList.SearchTodo(todo.GetHashCode());

            Assert.That(result, Is.True);
        }

        [Test]
        public void SearchByNullID()
        {
            var todoList = new Todo();
            string todo = "Backflip";

            todoList.Add(todo);
            var result = todoList.SearchTodo(null);

            Assert.That(result, Is.False);
        }
        [Test]
        public void SearchByIDOfEmptyString() { 
        var todoList = new Todo();
        string todo = "";

        todoList.Add(todo);
        var result = todoList.SearchTodo(todo.GetHashCode());

        Assert.That(result, Is.False);
        }
    //I want to update the name of a task by providing its ID and a new name.
    //I want to be able to change the status of a task by providing its ID.
    //I want to be able to see the date and time that I created each task.
}
}