using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.ComponentModel.Design;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        /*
        [Test]
        public void FirstTest()
        {
            TodoList core = new TodoList();
            Assert.Pass();
        }
        */
        
        [Test]
        public void AddTask()
        {
            //arrange
            TodoList core = new TodoList();
            

            //act
            core.Add("task1");

            //assert
            Assert.IsTrue(1 == core._tasks.Count);
        }
        
        [Test]
        public void RemoveTask()
        {
            //arrange
            TodoList core = new TodoList();


            //act
            core.Add("task1");
            core.Add("task2");
            core.RemoveTask("task1");

            //assert
            Assert.IsTrue(1 == core._tasks.Count);
        }
        
        [Test]
        public void GetAll()
        {
            //arrange
            TodoList core = new TodoList();
            core.Add("task1");
            core.Add("task2");


            List<TaskItem> result = core.GetAll();

            //act / assert

            for (int i = 0; i < core._tasks.Count; i++)
            {
                Assert.That(core._tasks[i].TaskName, Is.EqualTo(result[i].TaskName));
            }

        }


        [Test]
        public void ChangeStatus()
        {


            //arrange
            TodoList core = new TodoList();
            core.Add("task1");
            core.Add("task2");

            //act
            core.ChangeStatus("task1", true);


            //assert
            Assert.That(core._tasks[0].Status, Is.True);
            Assert.That(core._tasks[1].Status, Is.False);


        }

        
        [Test]
        public void GetCompleted()
        {
            //arrange
            TodoList core = new TodoList();
            core.Add("task1");
            core.Add("task2");

            //act
            core.ChangeStatus("task1", true);

            List<TaskItem> tasks = core.GetCompleted();
            TaskItem result = tasks[0];

            //assert
            Assert.IsTrue(result.TaskName == "task1");
        }



        
        [Test]
        public void GetIncomplete()
        {
            //arrange
            TodoList core = new TodoList();
            core.Add("task1");
            core.Add("task2");

            //act
            core.ChangeStatus("task1", true);

            List<TaskItem> tasks = core.GetIncomplete();
            TaskItem result = tasks[0];

            //assert
            Assert.IsTrue(result.TaskName == "task2");
        }

        
        [Test]
        public void SearchTask()
        {
            //arrange
            TodoList core = new TodoList();
            core.Add("task1");
            core.Add("task2");

            //act
            core.RemoveTask("task1");


            //assert
            Assert.That(core.SearchTask("task1"), Is.False);
            Assert.That(core.SearchTask("task2"), Is.True);
        }


        
        [Test]
        public void ShowAlpAscending()
        {
            //arrange
            TodoList core = new TodoList();
            core.Add("b");
            core.Add("a");
            core.Add("c");

            //act
            TodoList result = core.ShowAlpAscending();


            //assert
            Assert.That(result._tasks[0].TaskName, Is.EqualTo("a"));
            Assert.That(result._tasks[1].TaskName, Is.EqualTo("b"));
            Assert.That(result._tasks[2].TaskName, Is.EqualTo("c"));

        }
        
        [Test]
        public void ShowAlpDecending()
        {
            //arrange
            TodoList core = new TodoList();
            core.Add("b");
            core.Add("a");
            core.Add("c");

            //act
            TodoList result = core.ShowAlpDecending();


            //assert
            Assert.That(result._tasks[0].TaskName, Is.EqualTo("c"));
            Assert.That(result._tasks[1].TaskName, Is.EqualTo("b"));
            Assert.That(result._tasks[2].TaskName, Is.EqualTo("a"));


        }

        [Test]
        public void SetPriority()
        {
            //arrange
            TodoList core = new TodoList();
            core.Add("task1");
            core.Add("task2");

            //act
            core.SetPriority("task1", Priority.High);


            //assert
            Assert.That(core._tasks[0].Priority, Is.EqualTo(Priority.High));
            Assert.That(core._tasks[1].Priority, Is.EqualTo(Priority.Low));
        }

        [Test]
        public void ShowByPriority()
        {
            //arrange
            TodoList core = new TodoList();
            core.Add("task1");
            core.Add("task2");
            core.Add("task3");
            core.Add("task4");

            core.SetPriority("task1", Priority.Low);
            core.SetPriority("task2", Priority.High);
            core.SetPriority("task3", Priority.Medium);
            core.SetPriority("task4", Priority.High);


            //act
            List<TaskItem> result = core.ShowByPriority();

            TodoList expected = new TodoList();
            expected.Add("task1");
            expected.Add("task3");
            expected.Add("task2");
            expected.Add("task4");


            //assert
            for (int i = 0; i < result.Count; i++)
            {
                Assert.That(result[i].TaskName, Is.EqualTo(expected._tasks[i].TaskName));
            }
        }

    }
}