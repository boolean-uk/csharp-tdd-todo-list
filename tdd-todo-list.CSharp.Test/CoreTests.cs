using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Runtime.CompilerServices;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddItem()
        {
            //Arrange
            TodoList core = new TodoList();
            //Dictionary<string, bool> list = new Dictionary<string, bool>();

            //Act
            var result = core.AddTodo("Feed the dog", false);

            //Assert
            Assert.IsTrue(result.ContainsKey("Feed the dog") == true);
            
        }

        [Test]
        public void ListAllItems()
        {
            TodoList myList = new TodoList();

            myList.AddTodo("Feed the dog", false);
            myList.AddTodo("Call my wife", true);
            myList.AddTodo("Pay taxes", false);

            myList.GetAllItems();

            Assert.IsTrue(myList.GetAllItems().Count == 3);

        }
        [Test]
        public void StatusChange()
        {
            TodoList myList = new TodoList();

            myList.AddTodo("Feed the dog", false);
            myList.AddTodo("Call my wife", true);
            myList.AddTodo("Pay taxes", false);

            var result = myList.SetStatus("Feed the dog", true);

            Assert.IsTrue(result);

        }

        [Test]

        public void GetCompleted()
        {

            TodoList myList = new TodoList();

            myList.AddTodo("Feed the dog", false);
            myList.AddTodo("Call my wife", true);
            myList.AddTodo("Pay taxes", false);
            myList.AddTodo("Find a friend", true);
            myList.AddTodo("Wash the car", true);
            myList.AddTodo("Pay the rent", false);

            


            List<string> result = myList.GetCompletedTasks();


            Assert.That(result.Count == 3);


        }

        [Test]
        public void GetIncomplete()
        {

            TodoList myList = new TodoList();

            myList.AddTodo("Feed the dog", false);
            myList.AddTodo("Call my wife", true);
            myList.AddTodo("Pay taxes", false);
            myList.AddTodo("Find a friend", true);
            myList.AddTodo("Wash the car", true);
            myList.AddTodo("Pay the rent", false);
            myList.AddTodo("Buy groceries", false);




            List<string> result = myList.GetIncompleteTasks();


            Assert.That(result.Count == 4);

            
        }

        [Test]

        public void FindItem()
        {

            TodoList myList = new TodoList();

            myList.AddTodo("Feed the dog", false);
            myList.AddTodo("Call my wife", true);
            myList.AddTodo("Pay taxes", false);
            myList.AddTodo("Find a friend", true);
            myList.AddTodo("Wash the car", true);
            myList.AddTodo("Pay the rent", false);
            myList.AddTodo("Buy groceries", false);


            var house = myList.SearchTask("Buy a house");
            var dog = myList.SearchTask("Feed the dog");


            Assert.That(house == false);

        }

        [Test]
        public void TestAscending()
        {
            TodoList myList = new TodoList();

            myList.AddTodo("Feed the dog", false);
            myList.AddTodo("Call my wife", true);
            myList.AddTodo("Pay taxes", false);
            myList.AddTodo("Find a friend", true);
            myList.AddTodo("Wash the car", true);
            myList.AddTodo("Pay the rent", false);
            myList.AddTodo("Buy groceries", false);

            var sortedList = myList.SortByAscending();

            Assert.That(sortedList.Last() == "Wash the car");
        }

        [Test] 
        public void TestDescending()
        {
            TodoList myList = new TodoList();

            myList.AddTodo("Feed the dog", false);
            myList.AddTodo("Call my wife", true);
            myList.AddTodo("Pay taxes", false);
            myList.AddTodo("Find a friend", true);
            myList.AddTodo("Wash the car", true);
            myList.AddTodo("Pay the rent", false);
            myList.AddTodo("Buy groceries", false);

            var descendingList = myList.SortByDescending();

            Assert.That(descendingList.Last() == "Buy groceries");
        }

        [Test]

        public void removeTask()
        {
            TodoList myList = new TodoList();

            myList.AddTodo("Feed the dog", false);
            myList.AddTodo("Call my wife", true);
            myList.AddTodo("Pay taxes", false);
            myList.AddTodo("Find a friend", true);
            myList.AddTodo("Wash the car", true);
            myList.AddTodo("Pay the rent", false);
            myList.AddTodo("Buy groceries", false);

            bool isRemoved = myList.RemoveTask("Find a friend");

            Assert.IsTrue(isRemoved == true);
        }
    }
}