using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    public class TodoListTests
    {

        [Test]
        public void AddOneTaskTest()
        {
            TodoList TestList = new TodoList();
            string Task = "test task";
            TestList.Add(Task);
            int expectedLength = 1;
            int length = TestList.Todo.Count;

            Assert.That(length == expectedLength);
        }
        [Test]
        public void AddTwoTaskTest()
        {
            TodoList TestList = new TodoList();
            string Task1 = "test task";
            TestList.Add(Task1);
            string Task2 = "test task2";
            TestList.Add(Task2);
            int expectedLength = 2;
            int length = TestList.Todo.Count;

            Assert.That(length == expectedLength);
        }
    }
}
