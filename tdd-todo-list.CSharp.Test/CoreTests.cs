using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private TodoList _core;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [SetUp]
        public void Setup() 
        {
            TodoList _core = new TodoList();
        }

        
        [Test]
        [TestCase("This should be on the todolist!")]
        [TestCase("Short")]
        [TestCase("THIS IS ALL CAPS, I AM SHOUTING RIGHT NOW.")]
        [TestCase("Hello World")]
        [TestCase("Hello, World")]
        public void AddTaskToList(string task)
        {
            // Arrange

            // Act
            bool res = _core.Add(task);

            // Assert
            Assert.That(res, Is.EqualTo(true));
        }

        [Test]
        public void RetrieveAllTasks()
        {
            // Arrange
            string string1 = "Hello world";
            string string2 = "Goodbye world";
            string string3 = "What to write there?";
            _core.Add(string1);
            _core.Add(string2);
            _core.Add(string3);

            // Act
            Dictionary<string, bool> res = _core.ListTasks();
            string[] res2 = res.Keys.ToArray();
            bool[] res3 = res.Values.ToArray();

            // Assert
            Assert.That(string1, Is.SubsetOf(res2));
            Assert.That(string2, Is.SubsetOf(res2));
            Assert.That(string3, Is.SubsetOf(res2));

            Assert.That(res3[0], Is.EqualTo(true));
            Assert.That(res3[1], Is.EqualTo(true));
            Assert.That(res3[2], Is.EqualTo(true));
        }
    }
}