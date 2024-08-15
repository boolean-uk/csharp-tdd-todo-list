using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [TestCase("vacum")]
        [TestCase("clean")]
        [TestCase("make dinner")]
        [TestCase("sleep")]
        [TestCase("take out trash")]
        public void AddtoListTest(string task)
        {
            TodoList todoList = new TodoList();

            bool result = todoList.Add(task);
            Assert.That(result, Is.True);
        }

        [Test]
        public void ChangeTaskTest()
        {

            TodoList todoList = new TodoList();
            string task = "brush teeth";
            todoList.Add(task);

            bool result = todoList.ChangeTask(task);

            Assert.That(result, Is.True);
        }

        [Test]
        public void ChangeNonExistingTaskTest()
        {
            TodoList todoList = new TodoList();
            string task = "go for walk";

            bool result = todoList.ChangeTask(task);

            Assert.That(result, Is.False);
        }
    }
}