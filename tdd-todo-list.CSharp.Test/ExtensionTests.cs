using NUnit.Framework;
using tdd_todo_list.CSharp.Main.tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        private TodoListExtension _extension;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();
        }

        [SetUp]
        public void Setup()
        {
            _extension = new TodoListExtension();
        }

        [Test]
        public void AddTaskTest()
        {
            string taskName = "Task 1";
            _extension.AddTask(taskName);
            var task = _extension.GetTaskById(_extension.tasks[0].Id);
            Assert.AreEqual(taskName , task.Name);
        }

        [Test]
        public void GetTaskByIdTest()
        {
            string taskName = "Task 2";
            _extension.AddTask(taskName);
            var task = _extension.GetTaskById(_extension.tasks[0].Id);
            Assert.AreEqual(taskName , task.Name);
        }

        [Test]
        public void UpdateTaskNameTest()
        {
            string oldName = "Task 3";
            string newName = "Updated Task 3";
            _extension.AddTask(oldName);
            var task = _extension.GetTaskById(_extension.tasks[0].Id);
            _extension.UpdateTaskName(task.Id , newName);
            Assert.AreEqual(newName , task.Name);
        }

        [Test]
        public void ChangeTaskStatusTest()
        {
            string taskName = "Task 4";
            _extension.AddTask(taskName);
            var task = _extension.GetTaskById(_extension.tasks[0].Id);
            _extension.ChangeTaskStatus(task.Id , true);
            Assert.IsTrue(task.IsComplete);
        }

        [Test]
        public void GetTaskCreationTimeTest()
        {
            string taskName = "Task 5";
            _extension.AddTask(taskName);
            var task = _extension.GetTaskById(_extension.tasks[0].Id);
            Assert.LessOrEqual(task.CreatedAt , DateTime.Now);
        }
    }
}
