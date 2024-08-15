using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using tdd_todo_Slist.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddJobTest()
        {
            TodoList todolist = new TodoList();
            Job job = new Job(1, "Middag", Status.INCOMPLETE, DateTime.Now);

            bool expected = true;

            bool result = todolist.addJob(job);

            Assert.That(expected == result);
        }
    }
}