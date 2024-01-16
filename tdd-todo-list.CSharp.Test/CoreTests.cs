using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void IsCompleteTest()
        {
            //arrange
            TodoTask task = new TodoTask();

            //act
            bool complete = task.IsComplete();

            //assert
            Assert.That(complete, Is.False);
        }
        [Test]
        public void ChangeCompleteStatusTest()
        {
            //arrange
            TodoTask task = new TodoTask();

            //act
            task.ChangeCompleteStatus();
            bool complete = task.IsComplete();

            //assert
            Assert.That(complete, Is.True);
        }

        [Test]
        public void AddTaskTest()
        {
            //arrange
            TodoTask task = new TodoTask();
            TodoList list = new TodoList();

            //act
            list.AddTask(task);

            //assert
            Assert.That(list.GetAllTasksDecending().Count(), Is.EqualTo(1));
        }

        [Test]
        public void RemoveTaskTest()
        {
            //arrange
            TodoTask task = new TodoTask();
            TodoList list = new TodoList();

            //act
            list.AddTask(task);
            list.RemoveTask(task);

            //assert
            Assert.That(list.GetAllTasksDecending().Count(), Is.EqualTo(0));
        }

        [Test]
        public void GetAllTasksDecendingTest()
        {
            //arrange
            TodoList list = new TodoList();
            TodoTask taskA = new TodoTask("A");
            TodoTask taskB = new TodoTask("B");
            TodoTask taskC = new TodoTask("C");

            //act
            list.AddTask(taskC);
            list.AddTask(taskA);
            list.AddTask(taskB);

            List<TodoTask> decendingTasks = list.GetAllTasksDecending();
            List<TodoTask> decendingTasksActual = new List<TodoTask>() 
            { 
                taskC,taskB,taskA
            };

            //assert
            Assert.That(decendingTasks, Is.EqualTo(decendingTasksActual));
        }

        [Test]
        public void GetAllTasksAcendingTest()
        {
            //arrange
            TodoList list = new TodoList();
            TodoTask taskA = new TodoTask("A");
            TodoTask taskB = new TodoTask("B");
            TodoTask taskC = new TodoTask("C");

            //act
            list.AddTask(taskC);
            list.AddTask(taskA);
            list.AddTask(taskB);

            List<TodoTask> acendingTasks = list.GetAllTasksAcending();
            List<TodoTask> acendingTasksActual = new List<TodoTask>()
            {
                taskA,taskB,taskC
            };

            //assert
            Assert.That(acendingTasks, Is.EqualTo(acendingTasksActual));
        }

        [Test]
        public void GetCompletedTasksTest()
        {
            //arrange
            TodoList list = new TodoList();
            TodoTask taskA = new TodoTask("A");
            TodoTask taskB = new TodoTask("B");
            TodoTask taskC = new TodoTask("C");

            //act
            taskA.ChangeCompleteStatus();
            list.AddTask(taskC);
            list.AddTask(taskA);
            list.AddTask(taskB);

            List<TodoTask> completedTasks = list.GetCompletedTasks();
            
            //assert
            Assert.That(completedTasks.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetIncompletedTasksTest()
        {
            //arrange
            TodoList list = new TodoList();
            TodoTask taskA = new TodoTask("A");
            TodoTask taskB = new TodoTask("B");
            TodoTask taskC = new TodoTask("C");

            //act
            taskA.ChangeCompleteStatus();
            list.AddTask(taskC);
            list.AddTask(taskA);
            list.AddTask(taskB);

            List<TodoTask> incompletedTasks = list.GetIncompletedTasks();

            //assert
            Assert.That(incompletedTasks.Count, Is.EqualTo(2));
        }

        [Test]
        public void FindTaskTestPosistive()
        {
            //arrange
            TodoList list = new TodoList();
            TodoTask taskA = new TodoTask("A");
            TodoTask taskB = new TodoTask("B");
            TodoTask taskC = new TodoTask("C");

            //act
            list.AddTask(taskC);
            list.AddTask(taskA);
            list.AddTask(taskB);

            string taskString = list.FindTask("A");

            //assert
            Assert.That(taskString, Is.EqualTo("A"));
        }

        [Test]
        public void FindTaskTestNegative()
        {
            //arrange
            TodoList list = new TodoList();
            TodoTask taskA = new TodoTask("A");
            TodoTask taskB = new TodoTask("B");
            TodoTask taskC = new TodoTask("C");

            //act
            list.AddTask(taskC);
            list.AddTask(taskA);
            list.AddTask(taskB);

            string taskString = list.FindTask("D");

            //assert
            Assert.That(taskString, Is.EqualTo("There was no match"));
        }
    }
}