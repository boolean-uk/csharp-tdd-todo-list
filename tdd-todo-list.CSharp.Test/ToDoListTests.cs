using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Xml.Linq;
using System.ComponentModel;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ToDoListTests
    {
        [TestCase("Do the dishes", "The dishes shall be clean, but i dont like doing the work")]
        public void TestAddJob(string name, string description)
        {
            TodoList list = new TodoList();
            Job job = new Job(name, description);
            bool addedExpected = true;

            bool addedResult = list.AddToList(job);

            Assert.That(addedResult, Is.EqualTo(addedExpected));
        }

        [TestCase("Do the dishes", "The dishes shall be clean, but i dont like doing the work")]
        [TestCase("Go for a run", "Run 1 km, its hard, but its good for you!")]
        public void TestPrintJobs(string name, string description)
        {
            TodoList list = new TodoList();
            Job job1 = new Job(name, description);
            Job job2 = new Job(name, description);
            list.AddToList(job1);
            list.AddToList(job2);

            bool printJobsExpected = true;

            bool printJobsResult = list.PrintJobs(list.Jobs);

            Assert.That(printJobsResult, Is.EqualTo(printJobsExpected));
        }

        [TestCase(true, "Do the dishes", "The dishes shall be clean, but i dont like doing the work")]
        public void TestChangeStatus(bool newStatus, string name, string description)
        {
            Job job1 = new Job(name, description);
            bool statusChangedExpected = true;

            bool statusChangedResult = job1.ChangeStatus(newStatus);
            Assert.That(statusChangedResult, Is.EqualTo(statusChangedExpected));

            newStatus = false;
            statusChangedResult = job1.ChangeStatus(newStatus);
            Assert.That(statusChangedResult, Is.EqualTo(statusChangedExpected));
        }

        [Test]
        public void TestGetCompleteJobs()
        {
            TodoList list = new TodoList();
            Job job1 = new Job("Do the dishes", "The dishes shall be clean, but i dont like doing the work");
            Job job2 = new Job("Go for a run", "Run 1 km, its hard, but its good for you!");
            list.AddToList(job1);
            job2.ChangeStatus(true);
            list.AddToList(job2);

            List<Job> expectedJobList = new List<Job>() { job2 };

            List<Job> actualJobList = list.GetJobs(true);

            Assert.That(actualJobList, Is.EquivalentTo(expectedJobList));
        }

        [Test]
        public void TestGetIncompleteJobs()
        {
            TodoList list = new TodoList();
            Job job1 = new Job("Do the dishes", "The dishes shall be clean, but i dont like doing the work");
            Job job2 = new Job("Go for a run", "Run 1 km, its hard, but its good for you!");
            list.AddToList(job1);
            job2.ChangeStatus(true);
            list.AddToList(job2);

            List<Job> expectedJobList = new List<Job>() { job1 };

            List<Job> actualJobList = list.GetJobs(false);

            Assert.That(actualJobList, Is.EquivalentTo(expectedJobList));
        }
    }
}