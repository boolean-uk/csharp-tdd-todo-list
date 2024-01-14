using tdd_todo_list.CSharp.Main;

using NUnit.Framework;
using Task = tdd_todo_list.CSharp.Main.Task;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
            Dictionary<int, Task> toDoList;
            Extension extension;

        public ExtensionTests()
        {
            toDoList = new Dictionary<int, Task>();
            extension = new Extension(toDoList);
        }
       [Test]
        public void TestShouldAddTaskToToDoList()
        {
            Dictionary<int, Task> toDoList = new Dictionary<int, Task>();
            Extension extension = new Extension(toDoList);
            Assert.IsTrue(extension.Add("Clean"));
            Assert.AreEqual(1, toDoList.Count);
        }

        [Test]
        public void TestShouldGetTaskById()
        {
            Dictionary<int, Task> toDoList = new Dictionary<int, Task>();
            extension = new Extension(toDoList);
            extension.Add("Work");
            Task task = extension.GetTaskById(1);
            Assert.AreEqual("Work", task.Name);
        }

        [Test]
        public void TestShouldUpdateTaskName()
        {
            Dictionary<int, Task> toDoList = new Dictionary<int, Task>();
            extension = new Extension(toDoList);
            extension.Add("Relax");
            Assert.IsTrue(extension.UpdateTask(1, "Train"));
            Task task = extension.GetTaskById(1);
            Assert.AreEqual("Train", task.Name);
        }

        [Test]
        public void TestShouldUpdateTaskStatus()
        {
            Dictionary<int, Task> toDoList = new Dictionary<int, Task>();
            extension = new Extension(toDoList);
            extension.Add("Work");
            Assert.IsTrue(extension.UpdateTask(1, "Clean", true));
            Task task = extension.GetTaskById(1);
            Assert.AreEqual("Clean", task.Name);
            Assert.AreEqual(true, task.Status);
        }

        [Test]
        public void TestShouldNotUpdateTaskIfIdNotFound()
        {
            Dictionary<int, Task> toDoList = new Dictionary<int, Task>();
            extension = new Extension(toDoList);
            Assert.IsFalse(extension.UpdateTask(100, "Cook", true));
            Assert.AreEqual(0, toDoList.Count);
        }
    }
}