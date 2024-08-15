using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [TestCase("", false)]
        [TestCase("Clean bathroom", true)]
        public void TestAddTask(string str, bool expected)
        {
            TodoList core = new TodoList();
            TodoTask t = new TodoTask(str);
            
            bool isAdded = core.AddTask(t);
            
            Assert.That(isAdded, Is.EqualTo(expected));
        }

        [TestCase("Go fishing", true)]
        [TestCase("Take out garbage", false)]
        public void TestDeleteTask(string str, bool expected)
        {
            TodoList core = new TodoList();

            // Creates and adds a base of two tasks 
            TodoTask t1 = new TodoTask("Clean the car");
            TodoTask t2 = new TodoTask("Vacuum the shower");
            core.AddTask(t1);
            core.AddTask(t2);

            // Only add the testcase task if it is expected to be removed
            TodoTask t3 = new TodoTask(str);
            if (expected)
            {
                core.AddTask(t3);
            }

            // Checks to see if removing testcase task is successfull or not
            bool isDeleted = core.RemoveTask(t3);
            
            Assert.That(isDeleted == expected);

        }


        [Test]
        public void TestGetAllTasks()
        {
            TodoList core = new TodoList();

            // Creates and adds a base of two tasks 
            TodoTask t1 = new TodoTask("Clean the car");
            TodoTask t2 = new TodoTask("Vacuum the shower");
            core.AddTask(t1);
            core.AddTask(t2);

            List<TodoTask> allTasks = core.GetAllTasks();

            Assert.That(allTasks.Count, Is.EqualTo(2));
            Assert.That(allTasks[0], Is.EqualTo(t1));
            Assert.That(allTasks[1], Is.EqualTo(t2));
              
        }

        [Test]
        public void TestGetCompleteTasks()
        {
            TodoList core = new TodoList();

            // Creates and adds four tasks, two complete, and two incomplete
            TodoTask t1 = new TodoTask("Clean the car", Status.Incomplete);
            TodoTask t2 = new TodoTask("Vacuum the shower", Status.Incomplete);
            TodoTask t3 = new TodoTask("Grocery shopping", Status.Complete);
            TodoTask t4 = new TodoTask("Change motoroil on the car", Status.Complete);
            core.AddTask(t1);
            core.AddTask(t2);
            core.AddTask(t3);
            core.AddTask(t4);

            List<TodoTask> completedTasks = core.GetCompleteTasks();

            Assert.That(completedTasks.Contains(t1), Is.False);
            Assert.That(completedTasks.Contains(t2), Is.False);
            Assert.That(completedTasks.Contains(t3), Is.True);
            Assert.That(completedTasks.Contains(t4), Is.True);

        }

        [Test]
        public void TestGetIncompleteTasks()
        {
            TodoList core = new TodoList();

            // Creates and adds four tasks, two complete, and two incomplete
            TodoTask t1 = new TodoTask("Clean the car", Status.Incomplete);
            TodoTask t2 = new TodoTask("Vacuum the shower", Status.Incomplete);
            TodoTask t3 = new TodoTask("Grocery shopping", Status.Complete);
            TodoTask t4 = new TodoTask("Change motoroil on the car", Status.Complete);
            core.AddTask(t1);
            core.AddTask(t2);
            core.AddTask(t3);
            core.AddTask(t4);

            List<TodoTask> incompletedTasks = core.GetIncompleteTasks();

            Assert.That(incompletedTasks.Contains(t1), Is.True);
            Assert.That(incompletedTasks.Contains(t2), Is.True);
            Assert.That(incompletedTasks.Contains(t3), Is.False);
            Assert.That(incompletedTasks.Contains(t4), Is.False);
        }

        [TestCase(Status.Incomplete, Status.Complete)]
        [TestCase(Status.Complete, Status.Incomplete)]
        public void TestChangeTaskStatus(Status currentStatus, Status newStatus)
        {
            TodoList core = new TodoList();

            // Creates and adds four tasks
            TodoTask t1 = new TodoTask("Clean the car", currentStatus);
            core.AddTask(t1);

            core.ChangeTaskStatus(t1, newStatus);
            Assert.That(t1.Status, Is.EqualTo(newStatus));

        }

        [TestCase("Mow the lawn", "This task was found")]
        [TestCase("Walk the dog", "This task was not found")]
        [TestCase("Clean the car", "This task was found")]
        public void TestFindTask(string taskname, string expected)
        {
            TodoList core = new TodoList();
            core.AddTask(new TodoTask("Clean the car"));
            core.AddTask(new TodoTask("Go fishing"));
            core.AddTask(new TodoTask("Mow the lawn"));

            string message = core.FindTask(taskname);

            Assert.That(message, Is.EqualTo(expected));

        }

        [Test]
        public void TestGetSortedTasksAsc()
        {
            TodoList core = new TodoList();
            TodoTask t1 = new TodoTask("Clean the car", Status.Incomplete);
            TodoTask t2 = new TodoTask("Vacuum the shower", Status.Incomplete);
            TodoTask t3 = new TodoTask("Grocery shopping", Status.Complete);
            core.AddTask(t1);
            core.AddTask(t2);
            core.AddTask(t3);

            List<TodoTask> sortedTasks = core.GetSortedTasksAsc();
            Assert.That(sortedTasks[0], Is.EqualTo(t1));
            Assert.That(sortedTasks[1], Is.EqualTo(t3));
            Assert.That(sortedTasks[2], Is.EqualTo(t2));

        }

        [Test]
        public void TestGetSortedTasksDesc()
        {
            TodoList core = new TodoList();
            TodoTask t1 = new TodoTask("Clean the car", Status.Incomplete);
            TodoTask t2 = new TodoTask("Vacuum the shower", Status.Incomplete);
            TodoTask t3 = new TodoTask("Grocery shopping", Status.Complete);
            core.AddTask(t1);
            core.AddTask(t2);
            core.AddTask(t3);

            List<TodoTask> sortedTasks = core.GetSortedTasksDesc();
            Assert.That(sortedTasks[0], Is.EqualTo(t2));
            Assert.That(sortedTasks[1], Is.EqualTo(t3));
            Assert.That(sortedTasks[2], Is.EqualTo(t1));

        }

    }
}