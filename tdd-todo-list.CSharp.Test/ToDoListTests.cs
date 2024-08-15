using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ToDoListTests
    {
        [Test]
        public void TestAddJob()
        {
            TodoList list = new TodoList();
            Job job = new Job("Do the dishes", "The dishes shall be clean, but i dont like doing the work");
            bool addedExpected = true;

            bool addedResult = list.AddToList(job);

            Assert.That(addedResult, Is.EqualTo(addedExpected));
        }

        [Test]
        public void TestPrintJobs()
        {
            TodoList list = new TodoList();
            Job job1 = new Job("Do the dishes", "The dishes shall be clean, but i dont like doing the work");
            Job job2 = new Job("Go for a run", "Run 1 km, its hard, but its good for you!");

            bool printJobsExpected = true;

            bool printJobsResult = list.PrintJobs(list.Jobs);

            Assert.That(printJobsResult, Is.EqualTo(printJobsExpected));
        }
    }
}