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

        [Test]
        public void sortJobTest()
        {

            //jobs that will be sorted
            TodoList todoListUnsorted = new TodoList();

            Job job1 = new Job(1, "shoot", Status.INCOMPLETE, DateTime.Now);
            Job job2 = new Job(2, "experis academy", Status.COMPLETE, DateTime.Now);
            Job job3 = new Job(3, "beer", Status.COMPLETE, DateTime.Now);
            Job job4 = new Job(4, "code", Status.INCOMPLETE, DateTime.Now);

            todoListUnsorted.addJob(job1);
            todoListUnsorted.addJob(job2);
            todoListUnsorted.addJob(job3);
            todoListUnsorted.addJob(job4);

            //already sorted
            TodoList todoListSorted = new TodoList();
            todoListSorted.addJob(job3);
            todoListSorted.addJob(job4);
            todoListSorted.addJob(job2);
            todoListSorted.addJob(job1);

            todoListUnsorted.sortJob("asc");




        }

    }
}