using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Security.Cryptography;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void TestAdd()
        {
            //arrange
            TodoList todoList = new TodoList();

            //act
            todoList.Add("I'm a task!");

            //assert
            Assert.That(todoList.todoList.ContainsKey("I'm a task!"));
        }

        [TestCase("I'm a task!", "I'm another task!")]
        public void TestListAllTasks(string c1, string c2)
        {
            //arrange
            TodoList todoList = new TodoList();

            //act
            todoList.Add(c1);
            todoList.Add(c2);

            List<string> expected = new List<string> { c1, c2 };
            List<string> notExpected = new List<string> { "c1", "c2" };

            //assert
            Assert.That(todoList.ListAllTasks(), Is.EqualTo(expected));
            Assert.That(todoList.ListAllTasks(), !Is.EqualTo(notExpected));
        }

        [TestCase("I'm a task!")]
        public void TestChangeStatus(string c)
        {
            //arrange
            TodoList todoList = new TodoList();

            //act
            todoList.Add(c);

            //assert
            Assert.That(!todoList.todoList[c]);
            todoList.ChangeStatus(c);
            Assert.That(todoList.todoList[c]);
        }

        [TestCase("T1", "T2", "T3", "T4")]
        public void TestGetComplete(string c1, string c2, string c3, string c4)
        {
            //arrange
            TodoList todoList = new TodoList();

            //act
            todoList.Add(c1);
            todoList.ChangeStatus(c1);
            todoList.Add(c2);
            todoList.Add(c3);
            todoList.ChangeStatus(c3);
            todoList.Add(c4);

            List<string> expected = new List<string> { c1, c3 };

            //assert
            Assert.That(todoList.GetComplete(), Is.EqualTo(expected));
        }

        [TestCase("T1", "T2", "T3", "T4")]
        public void TestGetIncomplete(string c1, string c2, string c3, string c4)
        {
            //arrange
            TodoList todoList = new TodoList();

            //act
            todoList.Add(c1);
            todoList.ChangeStatus(c1);
            todoList.Add(c2);
            todoList.Add(c3);
            todoList.ChangeStatus(c3);
            todoList.Add(c4);

            List<string> expected = new List<string> { c2, c4 };

            //assert
            Assert.That(todoList.GetIncomplete(), Is.EqualTo(expected));
        }

        [Test]
        public void TestSearchTask()
        {
            TodoList todoList = new TodoList();

            todoList.Add("T1");

            Assert.That(todoList.SearchTask("T1"), Is.EqualTo("Task found."));
            Assert.That(todoList.SearchTask("T2"), Is.EqualTo("Task not found."));
        }

        [TestCase("T1")]
        public void TestRemove(string c1)
        {
            TodoList todoList = new TodoList();

            todoList.Add(c1);

            Assert.That(todoList.todoList.ContainsKey(c1));
            todoList.Remove(c1);
            Assert.That(!todoList.todoList.ContainsKey(c1));
        }

        [Test]
        public void TestOrderAsc()
        {
            TodoList todoList = new TodoList();

            todoList.Add("B");
            todoList.Add("E");
            todoList.Add("A");
            todoList.Add("C");
            todoList.Add("D");

            List<string> expected = new List<string> { "A", "B", "C", "D", "E" };

            Assert.That(todoList.ListAllTasks(), !Is.EqualTo(expected));
            Assert.That(todoList.OrderAsc(), Is.EqualTo(expected));
        }

        [Test]
        public void TestOrderDesc()
        {
            TodoList todoList = new TodoList();

            todoList.Add("B");
            todoList.Add("E");
            todoList.Add("A");
            todoList.Add("C");
            todoList.Add("D");

            List<string> expected = new List<string> { "E", "D", "C", "B", "A" };

            Assert.That(todoList.ListAllTasks(), !Is.EqualTo(expected));
            Assert.That(todoList.OrderDesc(), Is.EqualTo(expected));
        }
    }
}