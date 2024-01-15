using NUnit.Framework;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void TestGetTaskById()
        {
            //setup
            TodoListExtension ext = new();
            TodoTask task = new("TaskName");
            TodoTask task2 = new("TaskName2");
            string taskId = task.Id;
            ext.AddTask(task);
            ext.AddTask(task2);

            //execute
            TodoTask? result = ext.GetTaskById(taskId);

            //verify
            Assert.NotNull(result);
            Assert.AreEqual(task, result);
        }

        [Test]
        public void TestUpdateTaskByIdAndName()
        {
            //setup
            TodoListExtension ext = new();
            TodoTask task = new("TaskName");
            string taskId = task.Id;
            ext.AddTask(task);

            //execute
            bool hasUpdatedName = ext.UpdateTaskName(taskId, "New name");

            //verify
            Assert.IsTrue(hasUpdatedName);
            Assert.AreEqual(ext.GetTaskById(taskId)!.Name, "New name");
        }

        [Test]
        public void TestChangeTaskStatusById()
        {
            //setup
            TodoListExtension ext = new();
            TodoTask task = new("TaskName");
            string taskId = task.Id;
            ext.AddTask(task);

            //execute
            bool hasToggledStatus = ext.ChangeTaskStatus(taskId);

            //verify
            Assert.IsTrue(hasToggledStatus);
            Assert.IsTrue(ext.GetTaskById(taskId)!.IsComplete);
        }

        [Test]
        public void TesteGetCreationTime()
        {
            //setup
            DateTime before = DateTime.Now;
            TodoListExtension ext = new();
            TodoTask task = new("TaskName");
            string taskId = task.Id;
            ext.AddTask(task);

            //execute
            DateTime? dt = ext.GetCreationTime(taskId);

            //verify
            Assert.NotNull(dt);
            Assert.True(dt > before);
            Assert.True(dt < DateTime.Now);
            Assert.NotNull(dt.Value.Date);
            Assert.NotNull(dt.Value.Millisecond);
        }
    }
}

