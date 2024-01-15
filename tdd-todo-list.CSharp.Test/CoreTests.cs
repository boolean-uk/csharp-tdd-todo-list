using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        Dictionary<string, bool> testList = new Dictionary<string, bool>
            {
                { "Banana eating contest", true },
                { "Achieve CHIM", true },
                { "Destroy the universe", false },
                { "Calculate all float values of pi", false }
            };



        [Test, Order(1)]
        public void addTest()
        {
            //Arrange
            TodoList core = new TodoList(testList);

            //Act
            bool result = core.Add("Eat a lot of pizza");

            //Assert
            Assert.That(result, Is.EqualTo(true));
        }

        [Test, Order(2)]
        public void addTestFail()
        {
            //Arrange
            TodoList core = new TodoList(testList);

            //Act
            bool result = core.Add("Achieve CHIM");

            //Assert
            Assert.That(result, Is.EqualTo(false));
        }

        [Test, Order(3)]
        public void viewAllTest()
        {
            //Arrange
            TodoList core = new TodoList(testList);

            //Act
            Dictionary<string, bool> returnDic = core.viewAll();
            int result = returnDic.Count;

            //Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test, Order(4)]
        public void setStatusTest()
        {
            //Arrange
            TodoList core = new TodoList(testList);

            //Act
            bool result = core.setStatus("Achieve CHIM", false);

            //Assert
            Assert.That(result, Is.EqualTo(true));
        }

        [Test, Order(5)]
        public void setStatusFailTest()
        {
            //Arrange
            TodoList core = new TodoList(testList);

            //Act
            bool result = core.setStatus("Forge counterfeit money", false);

            //Assert
            Assert.That(result, Is.EqualTo(false));
        }

        [Test, Order(6)]
        public void viewCompletedTest()
        {
            //Arrange
            TodoList core = new TodoList(testList);

            //Act
            core.setStatus("Achieve CHIM", true); //revert to 2. the Dictionary is not reverted for each test >_>
            List<string> completed = core.viewCompleted();

            int result = completed.Count;

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test, Order(7)]
        public void viewRemainingTest()
        {
            //Arrange
            TodoList core = new TodoList(testList);

            //Act
            List<string> remaining = core.viewCompleted();
            int result = remaining.Count;

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test, Order(8)]
        public void searchTaskTest()
        {
            //Arrange
            TodoList core = new TodoList(testList);

            //Act
            bool wantedResult = true;
            bool result = core.searchTask("Achieve CHIM");

            //Assert
            Assert.That(result, Is.EqualTo(wantedResult));
        }

        [Test, Order(9)]
        public void searchTaskFailTest()
        {
            //Arrange
            TodoList core = new TodoList(testList);

            //Act
            bool wantedResult = false;
            bool result = core.searchTask("Forge counterfeit money");

            //Assert
            Assert.That(result, Is.EqualTo(wantedResult));
        }

        [Test, Order(10)]
        public void removeTaskTest()
        {
            //Arrange
            TodoList core = new TodoList(testList);

            //Act
            bool wantedResult = true;
            bool result = core.removeTask("Eat a lot of pizza");

            //Assert
            Assert.That(result, Is.EqualTo(wantedResult));
        }

        [Test, Order(11)]
        public void removeTaskFailTest()
        {
            //Arrange
            TodoList core = new TodoList(testList);

            //Act
            bool wantedResult = false;
            bool result = core.removeTask("Forge counterfeit money");

            //Assert
            Assert.That(result, Is.EqualTo(wantedResult));
        }

        [Test, Order(12)]
        public void viewAlphabeticallyTest()
        {
            //Arrange
            TodoList core = new TodoList(testList);

            //Act
            SortedDictionary<string, bool> resultDic = core.viewAlphabetically();

            //Assert
            Assert.That(resultDic.Values.First, Is.EqualTo(true));
            Assert.That(resultDic.Keys.First , Is.EqualTo(("Achieve CHIM")));

        }

        [Test, Order(13)]
        public void viewAlphabeticallyDescendingTest()
        {
            //Arrange
            TodoList core = new TodoList(testList);

            //Act
            Dictionary<string, bool> resultDic = core.viewAlphabeticallyDescending();

            //Assert
            Assert.That(resultDic.Values.First, Is.EqualTo(false));
            Assert.That(resultDic.Keys.First, Is.EqualTo("Destroy the universe"));

        }
    }
}