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
            Job expected = job;
            Job result = todoList.getJob(1);
            Assert.That(expected == result);
        }
        /*
        [Test]
        public void changeStatusTest()
        {
            TodoList todoList = new TodoList();
            Job job = new Job(1, "shoot", Status.INCOMPLETE, DateTime.Now);
            todoList.addJob(job);
            Status expected = Status.COMPLETE;
            //todoList.changeStatus(int id);


        }

        */
    }
}