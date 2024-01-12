using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{

    [TestFixture]
    public class ExtensionTests
    {
        TodoList todo;

        [SetUp]
        public void SetUp()
        {
            todo = new TodoList();

        }

        [Test]
        public void FirstTest()
        {
            todo.AddTaskToList(new TodoList.Task("Call mother", false), 1);

            Assert.That(todo.todoList.Count, Is.EqualTo(1));
        }
    }
}
