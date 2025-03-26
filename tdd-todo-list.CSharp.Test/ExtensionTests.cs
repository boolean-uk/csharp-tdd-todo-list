using tdd_todo_list.CSharp.Main;
using NUnit.Framework;


namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        TodoListExtension _extension;        

        [SetUp]
        public void Setup()
        {
            _extension = new TodoListExtension();
            _extension.AddTask("Task1");
            _extension.AddTask("Task2");
        }

        [Test]
        public void addingTask()
        {
            _extension.AddTask("Task3");
            List<TaskExtension> tasks = _extension.ListOfTasks();
            Assert.That(tasks.Count, Is.EqualTo(3));
        }

        [Test]
        public void updatingTaskTitle()
        {
            Assert.That(_extension.UpdateTask(1, "Test"), Is.True);
        }

        [Test]
        public void updatingTaskTitleWithInvalidId()
        {
            Assert.AreEqual(_extension.UpdateTask(2, "Test"), false);
        }

        [Test]
        public void settingTaskCompleted()
        {
            Assert.AreEqual(_extension.ChangeTaskStatus(1, true), true);
        }

        [Test]
        public void settingTaskCompletedWithInvalidId()
        {
            Assert.AreEqual(_extension.ChangeTaskStatus(2, true), false);
        }

        [Test]
        public void gettingTaskCreatedAt()
        {
            Assert.That(_extension.GetTaskCreatedAt(1), Is.Not.Null);
        }
    }
}
