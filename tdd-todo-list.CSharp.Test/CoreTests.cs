using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddOneTaskTest()
        {
            TodoList core = new TodoList();
            bool result = core.add("Walk the dog");
            List<Todo> list = core.listTasks();
            int listSize = core.listTasks().Count;

            Assert.IsTrue(result);
            Assert.That(listSize == 1); // check if list increased in size by 1
            Assert.That(list.First().id == 1);
        }

        [Test]
        public void AddTwoTasksTest()
        {
            TodoList core = new TodoList();
            bool result1 = core.add("Walk the dog");
            bool result2 = core.add("Walk the cat?");
            List<Todo> list = core.listTasks();
            int listSize = core.listTasks().Count;

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.That(listSize == 2); // check if list increased in size by 1
            Assert.That(list.First().id == 1);
            Assert.That(list.Last().id == 2);
        }

        [Test]
        public void AddThreeTasksTest()
        {
            TodoList core = new TodoList();
            bool result1 = core.add("Walk the dog");
            bool result2 = core.add("Walk the cat?");
            bool result3 = core.add("Walk the tree!?");
            List<Todo> list = core.listTasks();
            int listSize = core.listTasks().Count;

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);
            Assert.That(listSize == 3); // check if list increased in size by 1
            Assert.That(list.First().id == 1);
            Assert.That(list.Last().id == 3);
        }

        [Test]
        public void CompleteTaskTest()
        {
            TodoList core = new TodoList();
            bool result = core.add("Walk the dog");
            List<Todo> list = core.listTasks();
            int listSize = core.listTasks().Count;

            Assert.IsFalse(list.First().Complete);

            core.taskStatus(1);

            Assert.IsTrue(result);
            Assert.That(listSize == 1); // check if list increased in size by 1
            Assert.That(list.First().id == 1);
            Assert.IsTrue(list.First().Complete);
        }

    }
}