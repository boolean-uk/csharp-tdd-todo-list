using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main.Extension;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        private TodoListManager todoList;

        [SetUp]
        public void SetUp()
        {
            todoList = new TodoListManager();
            TodoItem todo1 = new TodoItem("Set up the tests");
            TodoItem todo2 = new TodoItem("Refactor the code");
            TodoItem todo3 = new TodoItem("Check that the tests pass");
            TodoItem todo4 = new TodoItem("Repeat");
            todoList.AddTodoItem(todo1);
            todoList.AddTodoItem(todo2);
            todoList.AddTodoItem(todo3);
            todoList.AddTodoItem(todo4);
        }

        [Test]
        public void TodoListSetUpTest()
        {
            Assert.That(todoList.GetAllTodoItems().Count == 4);
            Assert.That(todoList.GetCompletedTodoItems().Count == 0);
        }

        [Test]
        public void GetByUniqueIDTest()
        {
            TodoItem firstItem = todoList.GetAllTodoItems()[0];
            Assert.That(todoList.GetTodoItemById(firstItem.ID) == firstItem);
            List<int> allIDs = todoList.GetAllTodoItems().Select(item => item.ID).ToList();
            Assert.That(allIDs.Count == allIDs.Distinct().ToList().Count);
        }

        [Test]
        public void TodoItemRenameByIDTest()
        {
            string description = "Old description";
            string newDescription = "New description";
            TodoItem todo = new TodoItem(description);
            todoList.AddTodoItem(todo);
            Assert.That(todoList.GetTodoItemById(todo.ID).Description == description);
            todoList.GetTodoItemById(todo.ID).Description = newDescription;
            Assert.That(todoList.GetTodoItemById(todo.ID).Description == newDescription);
        }

        [Test]
        public void TodoItemChangeStatusByIDTest()
        {
            string description = "Mark this item as done";
            TodoItem todo = new TodoItem(description);
            todoList.AddTodoItem(todo);
            Assert.That(todoList.GetTodoItemById(todo.ID).IsDone == false);
            todoList.GetTodoItemById(todo.ID).MarkDone();
            Assert.That(todoList.GetTodoItemById(todo.ID).IsDone == true);
        }

        [Test]
        public void SeeTodoItemCreationTime()
        {
            todoList.AddTodoItem(new TodoItem("Last item"));
            foreach (TodoItem item in todoList.GetAllTodoItems())
            {
                Assert.That(item.CreationTime.Length > 0);
                Console.WriteLine($"{item.ID}\t{item.CreationTime}\t{item.Description}");
            }
        }
    }
}
