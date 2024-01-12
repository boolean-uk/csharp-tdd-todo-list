using System.Collections.Generic;
using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        //input ("Walk Dog") ==> out should be true
        [Test]
        public void FirstTest()
        {
            TodoList core = new TodoList();
            bool result = core.AddTask("Walk Dog");
            Assert.IsTrue(result);
        }

        //input ("Walk Dog"), ("Walk Dog") ==> out should be false
        [Test]
        public void SecondTest()
        {
            TodoList core = new TodoList();
            core.AddTask("Walk Dog");
            bool result = core.AddTask("Walk Dog");
            Assert.IsFalse(result);
        }

        //input ("Walk Dog") ==> out should be true
        [Test]
        public void ThirdTest()
        {
            TodoList core = new TodoList();
            core.AddTask("Walk Dog");
            bool result = core.ToggleComplete("Walk Dog");
            Assert.IsTrue(result);
        }
        //input ("Walk Dog") ==> out should be false
        [Test]
        public void FourthTest()
        {
            TodoList core = new TodoList();
            core.AddTask("Walk Dog");
            bool result = core.ToggleComplete("Walk Cat");
            Assert.IsFalse(result);
        }
        //input ("Walk Dog")("Clean Room")("Cook Food") ==> out should be List
        [Test]
        public void FifthTest()
        {
            TodoList core = new TodoList();
            core.AddTask("Walk Dog");
            core.AddTask("Clean Room");
            core.AddTask("Cook Food");
            List<TodoTask> expectedTasks = new List<TodoTask>
                {
                    new TodoTask("Walk Dog", false),
                    new TodoTask("Clean Room", false),
                    new TodoTask("Cook Food", false)
                };

            List<TodoTask> resultTasks = core.ShowAllTasks();
            CollectionAssert.AreEqual(expectedTasks, resultTasks);
        }

        //input ("Walk Dog") ==> out should be true
        [Test]
        public void SixthTest()
        {
            TodoList core = new TodoList();
            core.AddTask("Walk Dog");
            bool result = core.RemoveTask("Walk Dog");
            Assert.IsTrue(result);
        }
        //input ("Walk Dog") ==> out should be false
        [Test]
        public void SeventhTest()
        {
            TodoList core = new TodoList();
            bool result = core.RemoveTask("Walk Dog");
            Assert.IsFalse(result);
        }
        //input ("Walk Dog") ==> out should be string "Task found in todo list"
        [Test]
        public void EigthTest()
        {
            TodoList core = new TodoList();
            core.AddTask("Walk Dog");
            string result = core.TaskExists("Walk Dog");
            Assert.AreEqual(result, "Task found in todo list");
        }
        //input ("Walk Dog") ==> out should be string "Task not found in list"
        [Test]
        public void NinthTest()
        {
            TodoList core = new TodoList();
            string result = core.TaskExists("Walk Dog");
            Assert.AreEqual(result, "Task not found in list");
        }
        //input ("Walk Dog")("Clean Room")("Cook Food") ==> out should be List
        [Test]
        public void TenthTest()
        {
            TodoList core = new TodoList();
            core.AddTask("Walk Dog");
            core.AddTask("Clean Room");
            core.AddTask("Cook Food");
            core.AddTask("Feed Fish");
            core.ToggleComplete("Walk Dog");
            core.ToggleComplete("Clean Room");
            core.ToggleComplete("Cook Food");
            List<TodoTask> expectedTasks = new List<TodoTask>
                {
                    new TodoTask("Walk Dog", true),
                    new TodoTask("Clean Room", true),
                    new TodoTask("Cook Food", true) 
                };

            List<TodoTask> resultTasks = core.ShowCompletedTasks();
            CollectionAssert.AreEqual(expectedTasks, resultTasks);
        }
                //input ("Walk Dog")("Clean Room")("Cook Food") ==> out should be List
        [Test]
        public void EleventhTest()
        {
            TodoList core = new TodoList();
            core.AddTask("Walk Dog");
            core.AddTask("Clean Room");
            core.AddTask("Cook Food");
            core.AddTask("Feed Fish");
            core.ToggleComplete("Walk Dog");
            core.ToggleComplete("Clean Room");
            core.ToggleComplete("Cook Food");
            List<TodoTask> expectedTasks = new List<TodoTask>
                {
                    new TodoTask("Feed Fish", false),
                };

            List<TodoTask> resultTasks = core.ShowIncompletedTasks();
            CollectionAssert.AreEqual(expectedTasks, resultTasks);
        }
        //input ("Walk Dog")("Clean Room")("Acrobat Practice") ==> out should be List
        [Test]
        public void TwelfthTest()
        {
            TodoList core = new TodoList();
            core.AddTask("Walk Dog");
            core.AddTask("Clean Room");
            core.AddTask("Acrobat Practice");

            List<TodoTask> expectedTasks = new List<TodoTask>
                {
                    new TodoTask("Walk Dog", false),
                    new TodoTask("Clean Room", false),
                    new TodoTask("Acrobat Practice", false),
                };

            List<TodoTask> resultTasks = core.SortedTasksDesc();
            CollectionAssert.AreEqual(expectedTasks, resultTasks);
        }
        //input ("Walk Dog")("Clean Room")("Acrobat Practice") ==> out should be List
        [Test]
        public void thirteenthTest()
        {
            TodoList core = new TodoList();
            core.AddTask("Clean Room");
            core.AddTask("Acrobat Practice");
            core.AddTask("Walk Dog");

            List<TodoTask> expectedTasks = new List<TodoTask>
                {
                    new TodoTask("Acrobat Practice", false),
                    new TodoTask("Clean Room", false),
                    new TodoTask("Walk Dog", false),
                };

            List<TodoTask> resultTasks = core.SortedTasksAsc();
            CollectionAssert.AreEqual(expectedTasks, resultTasks);
        }
    }
}