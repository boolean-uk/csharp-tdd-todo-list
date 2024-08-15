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
        private TodoListExtension _extension;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();
        }

        [TestCase("Do the dishes", "The dishes shall be clean, but i dont like doing the work")]
        public void TestAddJob(string name, string description)
        {
            TodoListExtension todoListExtension = new TodoListExtension();
            JobExtension job = new JobExtension(name, description);
            bool addedExpected = true;

            bool addedResult = todoListExtension.AddToList(job);

            Assert.That(addedResult, Is.EqualTo(addedExpected));
        }

        [TestCase("Do the dishes", "The dishes shall be clean, but i dont like doing the work")]
        [TestCase("Go for a run", "Run 1 km, its hard, but its good for you!")]
        public void TestPrintJobs(string name, string description)
        {
            TodoListExtension todoListExtension = new TodoListExtension();
            JobExtension job1 = new JobExtension(name, description);
            JobExtension job2 = new JobExtension(name, description);
            todoListExtension.AddToList(job1);
            todoListExtension.AddToList(job2);

            bool printJobsExpected = true;

            bool printJobsResult = todoListExtension.PrintJobs(todoListExtension.Jobs);

            Assert.That(printJobsResult, Is.EqualTo(printJobsExpected));
        }

        [TestCase(true, "Do the dishes", "The dishes shall be clean, but i dont like doing the work")]
        public void TestChangeStatus(bool newStatus, string name, string description)
        {
            JobExtension job1 = new JobExtension(name, description);
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
            TodoListExtension todoListExtension = new TodoListExtension();
            JobExtension job1 = new JobExtension("Do the dishes", "The dishes shall be clean, but i dont like doing the work");
            JobExtension job2 = new JobExtension("Go for a run", "Run 1 km, its hard, but its good for you!");
            todoListExtension.AddToList(job1);
            job2.ChangeStatus(true);
            todoListExtension.AddToList(job2);

            List<JobExtension> expectedJobList = new List<JobExtension>() { job2 };

            List<JobExtension> actualJobList = todoListExtension.GetJobs(true);

            Assert.That(actualJobList, Is.EquivalentTo(expectedJobList));
        }

        [Test]
        public void TestGetIncompleteJobs()
        {
            TodoListExtension todoListExtension = new TodoListExtension();
            JobExtension job1 = new JobExtension("Do the dishes", "The dishes shall be clean, but i dont like doing the work");
            JobExtension job2 = new JobExtension("Go for a run", "Run 1 km, its hard, but its good for you!");
            todoListExtension.AddToList(job1);
            job2.ChangeStatus(true);
            todoListExtension.AddToList(job2);

            List<JobExtension> expectedJobList = new List<JobExtension>() { job1 };

            List<JobExtension> actualJobList = todoListExtension.GetJobs(false);

            Assert.That(actualJobList, Is.EquivalentTo(expectedJobList));
        }

        [Test]
        public void TestGetJob()
        {
            TodoListExtension todoListExtension = new TodoListExtension();
            JobExtension job1 = new JobExtension("Do the dishes", "The dishes shall be clean, but i dont like doing the work");
            JobExtension job2 = new JobExtension("Go for a run", "Run 1 km, its hard, but its good for you!");
            todoListExtension.AddToList(job1);
            todoListExtension.AddToList(job2);

            JobExtension expectedJob = job1;

            JobExtension actualJob = todoListExtension.GetJob(1);

            Assert.That(actualJob, Is.EqualTo(expectedJob));
        }

        [Test]
        public void TestRemoveJob()
        {
            TodoListExtension todoListExtension = new TodoListExtension();
            JobExtension job1 = new JobExtension("Do the dishes", "The dishes shall be clean, but i dont like doing the work");
            JobExtension job2 = new JobExtension("Go for a run", "Run 1 km, its hard, but its good for you!");
            todoListExtension.AddToList(job1);
            todoListExtension.AddToList(job2);

            bool expectedResult = true;

            bool actualResult = todoListExtension.RemoveJob(1);

            Assert.That(actualResult, Is.EqualTo(expectedResult));

            expectedResult = false;

            actualResult = todoListExtension.RemoveJob(1);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestGetJobsOrderedAscending()
        {
            TodoListExtension todoListExtension = new TodoListExtension();
            JobExtension job1 = new JobExtension("Go for a run", "Run 1 km, its hard, but its good for you!");
            JobExtension job2 = new JobExtension("Do the dishes", "The dishes shall be clean, but i dont like doing the work");
            todoListExtension.AddToList(job1);
            todoListExtension.AddToList(job2);

            List<JobExtension> expectedResult = new List<JobExtension>() { job1, job2 };

            List<JobExtension> actualResult = todoListExtension.GetJobsOrdered(true);

            Assert.That(actualResult, Is.EquivalentTo(expectedResult));
        }

        [Test]
        public void TestGetJobsOrderedDescending()
        {
            TodoListExtension todoListExtension = new TodoListExtension();
            JobExtension job1 = new JobExtension("Go for a run", "Run 1 km, its hard, but its good for you!");
            JobExtension job2 = new JobExtension("Do the dishes", "The dishes shall be clean, but i dont like doing the work");
            todoListExtension.AddToList(job1);
            todoListExtension.AddToList(job2);

            List<JobExtension> expectedResult = new List<JobExtension>() { job2, job1 };

            List<JobExtension> actualResult = todoListExtension.GetJobsOrdered(false);

            Assert.That(actualResult, Is.EquivalentTo(expectedResult));
        }

        [Test]
        public void TestChangeJobStatusFromList()
        {
            TodoListExtension todoListExtension = new TodoListExtension();
            JobExtension job1 = new JobExtension("Go for a run", "Run 1 km, its hard, but its good for you!");
            JobExtension job2 = new JobExtension("Do the dishes", "The dishes shall be clean, but i dont like doing the work");
            todoListExtension.AddToList(job1);
            todoListExtension.AddToList(job2);

            bool expectedResult = true;

            bool actualResult = todoListExtension.changeJobStatus(1, true);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
