using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

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
            _extension.AddTask("Write tests");
            _extension.AddTask("Eat lunch");
            _extension.AddTask("Go home");
        }

        [TestCase("Write tests", 0)]
        [TestCase("Eat lunch", 1)]
        [TestCase("Go home", 2)]
        public void GetTaskByIdTest(string name, int id)
        {
            Assert.AreEqual(name, _extension.GetTask(id).GetName());
        }
        
        [Test]
        public void SetTaskNameTest()
        {
            _extension.SetName(0, "Write more tests");
            Assert.AreEqual("Write more tests", _extension.GetTask(0).GetName());
        }
        
        [Test]
        public void SetTaskStatusTest()
        {
            _extension.SetStatus(0, true);
            Assert.IsTrue(_extension.GetTask(0).GetStatus());
        }
        
        [Test]
        public void GetTaskDateTimeStampTest()
        {
            // A bit difficult to know the DateTime generated at the constructor, as it's a private field in the Task class
            DateTime dateTime = _extension.GetDateTimeStamp(0);
            Assert.AreEqual(dateTime, _extension.GetTask(0).GetDateTimeStamp());
        }
    }
}
