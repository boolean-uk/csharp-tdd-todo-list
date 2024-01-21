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
        private void SetUp()
        {
            todoList = new TodoListManager();
            TodoItem todo1 = new TodoItem("Set up the tests");
            TodoItem todo2 = new TodoItem("Refactor the code");
            TodoItem todo3 = new TodoItem("Check that the tets pass");
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
            Assert.That(allIDs == allIDs.Distinct().ToList());
        }
    }
}
