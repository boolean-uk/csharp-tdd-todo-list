using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        [Test]
        public void TestgetById()
        {
            TodoList ToDoList = new TodoList();

            ToDoList.Add("wash");
            ToDoList.Add("trash");
            ToDoList.Add("clean");

            ToDoTask givenTask = ToDoList.getById(1);

            Assert.That(givenTask.getName() == "wash");
            Assert.IsTrue(ToDoList.getById(4) == null);
        }

        [Test]
        public void TestUpdateById()
        {
            TodoList ToDoList = new TodoList();

            ToDoList.Add("wash");
            ToDoList.Add("trash");
            ToDoList.Add("clean");

            ToDoList.UpdateById(1, "car wash");

            Assert.That(ToDoList.Todo[1].getName() == "car wash");

        }

        [Test]
        public void TestUpdateStatusById()
        {
            TodoList ToDoList = new TodoList();

            ToDoList.Add("wash");
            ToDoList.Add("trash");
            ToDoList.Add("clean");

            ToDoList.UpdateStatusById(1, true);

            Assert.IsTrue(ToDoList.Todo[1].getStatus());
        }
    }
}
