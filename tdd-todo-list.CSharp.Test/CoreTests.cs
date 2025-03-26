using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        TodoList _core = new TodoList();
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [SetUp]
        public void SetUp() 
        {
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
            _core = new TodoList();
            // Act
            bool res = _core.Add(task);

            // Assert
            Assert.That(res, Is.EqualTo(true));
        }

        [Test]
        public void RetrieveAllTasks()
        {
            // Arrange
            _core = new TodoList();
            string string1 = "Hello world";
            string string2 = "Goodbye world";
            string string3 = "What to write there?";
            _core.Add(string1);
            _core.Add(string2);
            _core.Add(string3);

            Dictionary<string, bool> expected = new Dictionary<string, bool>();
            expected.Add(string1, false);
            expected.Add(string2, false);    
            expected.Add(string3, false);

            // Act
            Dictionary<string, bool> res = _core.ListTasks();
            string[] res2 = res.Keys.ToArray();
            bool[] res3 = res.Values.ToArray();

            // Assert
            CollectionAssert.AreEquivalent(expected, res);
            Assert.That(res2, Contains.Item(string1).And.Contains(string2).And.Contains(string3));
            Assert.That(res3, Is.All.False);

        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void SetTaskStatus(bool status) 
        {
            // Arrange
            _core = new TodoList();
            string todoString = "Hello, this is a string";
            string notAddedString = "This should not be in the todolist";
            _core.Add(todoString);

            // Act
            bool res = _core.SetTaskStatus(todoString, status); // Should return true
            bool res2 = _core.SetTaskStatus(notAddedString, status); // Should return false

            // Assert
            Assert.That(res, Is.EqualTo(true));
            Assert.That(res2, Is.EqualTo(false));

        }

        [Test]
        public void RetrieveCorrectStatusLists() 
        {
            // Arrange
            _core = new TodoList();
            string todoString = "This task is complete";
            string todoString2 = "This task is also complete";

            string todoString3 = "This task is not complete";
            string todoString4 = "This task is also not complete";

            _core.Add(todoString);
            _core.Add(todoString2);
            _core.Add(todoString3);
            _core.Add(todoString4);

            _core.SetTaskStatus(todoString, true);
            _core.SetTaskStatus(todoString2, true);

            // Act
            Dictionary<string, bool> complete = _core.GetCompleteTasks();
            Dictionary<string, bool> incomplete = _core.GetIncompleteTasks();

            // Assert
            Assert.That(complete.All(t => t.Value == true));
            Assert.That(incomplete.All(t => t.Value == false));
        }

        [Test]
        public void FindTask() 
        {
            // Arrange
            _core = new TodoList();
            string task1 = "What?";
            string task2 = "Why?";
            string task3 = "Find this";
            string task4 = "How?";
            string notAdded = "Not there";
            _core.Add(task1);
            _core.Add(task2);
            _core.Add(task3);
            _core.Add(task4);

            // Act
            bool res1 = _core.FindTask(task3); // True

            bool res2 = _core.FindTask(notAdded); // False

            // Assert
            Assert.That(true, Is.EqualTo(res1));

            Assert.That(false, Is.EqualTo(res2));

        }

        [Test]
        public void RemoveTask() 
        {
            // Arrange
            _core = new TodoList();
            string string1 = "This should remain";
            string string2 = "This should be removed";
            string string3 = "Dont mind this string";
            _core.Add(string1);
            _core.Add(string2);
            _core.Add(string3);


            // Act
            bool res1 = _core.RemoveTask(string2);
            bool res2 = _core.RemoveTask("This string does not exist");

            // Assert
            Assert.That(res1, Is.EqualTo(true));
            Assert.That(res2, Is.EqualTo(false));

        }
        [Test]
        public void TestSorter()
        {
            // Arrange
            _core = new TodoList();
            string stringA = "abc";
            string stringB = "def";
            string stringC = "ghi";
            _core.Add(stringB);
            _core.Add(stringA);
            _core.Add(stringC);

            Dictionary<string, bool> List = _core.ListTasks();

            // Act
            Dictionary<string, bool> resAsc = TodoSorter.SortAscending(List);
            Dictionary<string, bool> resDesc = TodoSorter.SortDescending(List);

            // Assert
            Assert.That(stringA, Is.EqualTo(resAsc.First().Key));
            Assert.That(stringC, Is.EqualTo(resAsc.Last().Key));

            Assert.That(stringC, Is.EqualTo(resDesc.First().Key));
            Assert.That(stringA, Is.EqualTo(resDesc.Last().Key));
        }
    }
}