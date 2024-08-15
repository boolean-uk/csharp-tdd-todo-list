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


        [Test]
        public void GetAllJobsTest()
        {
            TodoList todoList = new TodoList();
            Job job = new Job(1, "Lunsj", Status.INCOMPLETE, DateTime.Now);

            todoList.addJob(job);
            List<Job> expected = [job];

            List<Job> result = todoList.getAllJobs();

            Assert.That(expected.SequenceEqual(result));
        }


         [Test]
         public void ChangeJobStatusTest()
        {
            TodoList todoList = new TodoList();
            Job job = new Job(1, "Vaske", Status.INCOMPLETE, DateTime.Now);

            todoList.addJob(job);

            bool result = todoList.changeJobStatus(job.Id);
            bool expected = true;

            Assert.That(expected == result);
        }

        
        [Test]
        public void GetJobByStatusTest()
        {
            TodoList todoList = new TodoList();
            Job job1 = new Job(1, "Kode", Status.INCOMPLETE, DateTime.Now);
            Job job2 = new Job(2, "Teste", Status.COMPLETE, DateTime.Now);

            todoList.addJob(job1);
            todoList.addJob(job2);

            List<Job> expected = [job2];

            List<Job> result = todoList.getJobByStatus(job2.Status);

            Assert.That(expected.SequenceEqual(result));

        }

        [Test]
        public void SearchJobByNameTest()
        {
            TodoList todoList = new TodoList();

            Job job1 = new Job(1, "Kode", Status.INCOMPLETE, DateTime.Now);
            Job job2 = new Job(2, "Teste", Status.COMPLETE, DateTime.Now);

           // todoList.addJob(job1);
            todoList.addJob(job2);

            string expected = $"Job with name {job1.Name} not found!";
            string expected2 = $"Job with name {job2.Name} found!";

            string result = todoList.searchJobByName(job1.Name);
            string result2 = todoList.searchJobByName(job2.Name);

            Assert.That(expected == result);
            Assert.That(expected2 == result2);
        }


        [Test]
        public void RemoveJobTest()
        {
            TodoList todoList = new TodoList();

            Job job1 = new Job(1, "Kode", Status.INCOMPLETE, DateTime.Now);
            Job job2 = new Job(2, "Teste", Status.COMPLETE, DateTime.Now);

            todoList.addJob(job1);
            todoList.addJob(job2);

            int expected = 1;

            todoList.removeJob(job1.Id);

            int result = todoList.Count;

            Assert.That(expected == result);

        }

        [Test]
        public void AllJobsSortedTest()
        {
            TodoList todoListUnsorted = new TodoList();

            Job job1 = new Job(1, "Kode", Status.INCOMPLETE, DateTime.Now);
            Job job2 = new Job(2, "Teste", Status.COMPLETE, DateTime.Now);
            Job job3 = new Job(3, "Handle", Status.COMPLETE, DateTime.Now);
            Job job4 = new Job(4, "Poker", Status.COMPLETE, DateTime.Now);

            todoListUnsorted.addJob(job1);
            todoListUnsorted.addJob(job2);
            todoListUnsorted.addJob(job3);
            todoListUnsorted.addJob(job4);

            TodoList todoListSortedAsc = new TodoList();

            todoListSortedAsc.addJob(job3);
            todoListSortedAsc.addJob(job1);
            todoListSortedAsc.addJob(job4);
            todoListSortedAsc.addJob(job2);

            List<Job> expectedAsc = todoListSortedAsc.getAllJobs();
            string orderAsc = "ascending";
            // string orderDesc = "descending";

            todoListUnsorted.allJobsSorted(orderAsc);
            // todoListUnsorted.allJobsSorted(orderDesc);

            List<Job> resultAsc = todoListUnsorted.getAllJobs();

            Assert.That(expectedAsc.SequenceEqual(resultAsc));
        }

        [Test]
        public void GetJobByIdTest()
        {
            TodoList todoList = new TodoList();

            Job job1 = new Job(1, "Kode", Status.INCOMPLETE, DateTime.Now);
            Job job2 = new Job(2, "Teste", Status.COMPLETE, DateTime.Now);

            todoList.addJob(job1);
            todoList.addJob(job2);

            Job expected = job1;

            Job result = todoList.getJobById(job1.Id);
            Assert.That(expected == result);
        }


        [Test]
        public void UpdateJobNameTest()
        {
            TodoList todoList = new TodoList();

            Job job1 = new Job(1, "Kode", Status.INCOMPLETE, DateTime.Now);
            Job job2 = new Job(2, "Teste", Status.COMPLETE, DateTime.Now);

            todoList.addJob(job1);
            todoList.addJob(job2);

            string expected = "Handle";

            Job result = todoList.updateJobName(job1.Id, "Handle");

            Assert.That(expected == result.Name);

        }

    }
}