using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void BaseTest()
        {
            TodoList core = new TodoList();
            Assert.IsTrue(core != null);
        }

        [Test]
        public void TestOne() //1: I want to add tasks to my todo list.
        {
            //arrange
            TodoList core = new TodoList();

            //act
            core.AddTask("Buy wine");

            //assert
            Assert.IsTrue(core.ToDoList.Count > 0);
        }

        [Test]
        public void TestTwo() //2: I want to see all the tasks in my todo list.
        {
            //arrange
            TodoList core = new TodoList();
            core.AddTask("Buy cheese");
            core.AddTask("Drink coffee");

            //act
            string output = core.ViewList();

            //assert
            Assert.IsTrue(output.Contains("Drink coffee"));
        }

        [Test]
        public void TestThree() //3: I want to change the status of a task between incomplete and complete.
        {
            //arrange
            TodoList core = new TodoList();
            
            core.AddTask("Learn more C#");
            core.AddTask("Eat the chocolate");

            //act
            core.SetStatus("Eat the chocolate", true);

            //assert
            Assert.That(core.ToDoList[1].Complete == true);
        }

        [Test]
        public void TestFour() //4: I want to be able to get only the complete tasks.
        {
            //arrange
            TodoList core = new TodoList();
            core.AddTask("Learn more C#");
            core.AddTask("Build some projects");
            core.AddTask("Make a nice coffee");
            core.SetStatus("Make a nice coffee", true);

            //act
            string result = core.GetCompletedTasks();

            //assert
            Assert.IsTrue(result.Contains("Make a nice coffee"));
        }

        [Test]
        public void TestFive() //5: I want to be able to get only the incomplete tasks.
        {
            //arrange
            TodoList core = new TodoList();
            core.AddTask("Learn more C#");
            core.AddTask("Read about domain models");
            core.AddTask("Drink tea");
            core.AddTask("Train horses");
            core.SetStatus("Drink tea", true);
            core.SetStatus("Learn more C#", true);

            //act
            string result = core.GetIncompleteTasks();

            //assert
            Assert.IsTrue(result.Contains("Train horses"));
        }

        [Test]
        public void TestSix() //6: I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
        {
            //arrange 
            TodoList core = new TodoList();
            core.AddTask("Go to market");

            //act
            string result = core.Search("Go fishing");
            string result2 = core.Search("Go to market");

            //assert
            Assert.IsTrue(result.Contains("Task not found"));
            Assert.IsTrue(result2.Contains("Task found"));
        }

        [Test]
        public void TestSeven() //7: I want to remove tasks from my list.
        {
            //arrange
            TodoList core = new TodoList();
            core.AddTask("Go to a fancy restaurant");
            core.AddTask("Only eat desserts");
            core.AddTask("Study some more C#");

            //act
            core.RemoveTask("Only eat desserts");

            //assert
            Assert.That(core.ToDoList[1].Task.Contains("Only eat dessert") == false);
        }

        [Test]
        public void TestEight() //8: I want to see all the tasks in my list ordered alphabetically in ascending order.
        {
            //arrange
            TodoList core = new TodoList();
            core.AddTask("Go to a fancy restaurant");
            core.AddTask("Arrange desserts");
            core.AddTask("Excel at C#");

            //act
            string result = core.ListAscending();

            //assert
            Assert.IsTrue(result.StartsWith("Arrange desserts"));
        }

        [Test]
        public void TestNine() //9: I want to see all the tasks in my list ordered alphabetically in descending order.
        {
            //arrange
            TodoList core = new TodoList();
            core.AddTask("Go to a fancy restaurant");
            core.AddTask("Arrange desserts");
            core.AddTask("Zwemmen in de zee");

            //act
            string result = core.ListDescending();

            //assert
            Assert.IsTrue(result.StartsWith("Zwemmen in de zee"));
        }
    }
}