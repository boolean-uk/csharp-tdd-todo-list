using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void addJobTest()
        {
            TodoList todoList = new TodoList();
            Job job = new Job(1, "shoot", Status.INCOMPLETE, DateTime.Now);
            bool expected = true;
            bool result = todoList.addJob(job);
            Assert.That(expected == result);
        }



        [Test]
        public void seeJobsTest()
        {
            TodoList todoList = new TodoList();
            DateTime time = DateTime.Now;
            Job job = new Job(1, "shoot", Status.INCOMPLETE, time);
            todoList.addJob(job);
            List<Job> expected = [job];
            List<Job> result = todoList.seeJobs();
            Console.WriteLine($"expected {expected}\nresult {result}");
            Assert.True(expected.SequenceEqual(result));
        }



        

        [Test]
        public void getJobTest()
        {
            TodoList todoList = new TodoList();
            Job job = new Job(1, "shoot", Status.INCOMPLETE, DateTime.Now);
            todoList.addJob(job);
            int expected = job.Id;
            int result = todoList.getJob(1).Id; 
            Assert.That(expected == result);
        }
        

        
        [Test]
        public void changeStatusTest()
        {
            TodoList todoList = new TodoList();
            Job job = new Job(1, "shoot", Status.INCOMPLETE, DateTime.Now);
            todoList.addJob(job);
            Status expected = Status.COMPLETE;
            todoList.changeStatus(1);
            Assert.That(expected == job.Status);

        }

        [Test]
        public void getSpecifiedJobsTest()
        {
            TodoList todoList = new TodoList();
            Job job1 = new Job(1, "casting", Status.INCOMPLETE, DateTime.Now);
            Job job2 = new Job(2, "shoot", Status.COMPLETE, DateTime.Now);

            todoList.addJob(job1);
            todoList.addJob(job2);
            List<Job> expected = [job2];
            List<Job> result = todoList.getSpecifiedJobs(Status.COMPLETE);

            Console.WriteLine($"expected {expected}\nresult {result}");

            Assert.True(expected.SequenceEqual(result));
        }

        [Test]
        public void removeJobTest() 
        {
            TodoList todoList = new TodoList();
            Job job = new Job(1, "casting", Status.INCOMPLETE, DateTime.Now);
            todoList.addJob(job);
            Job expected = null;
            todoList.removeJob(1);

            Job result = todoList.getJob(1);
            Assert.That(expected == result);
        }

        [Test]
        public void changeNameOfJobTest()
        {
            TodoList todoList = new TodoList();
            Job job = new Job(1, "casting", Status.INCOMPLETE, DateTime.Now);
            todoList.addJob(job);

            string expected = "shoot";
            todoList.updateName(1, "shoot");

            Assert.That(job.Name == expected);

        }

       


    }
}