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

    }
}