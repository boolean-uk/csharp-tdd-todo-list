using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void FirstTest()
        {
            TodoList todoList = new TodoList();
            Job job = new Job(1, "shoot", Status.INCOMPLETE, DateTime.Now);
            bool expected = true;
            bool result = todoList.addJob(job);
            Assert.That(expected == result);
        }
    }
}