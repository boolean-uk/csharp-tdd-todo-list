using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        // I want to add tasks to my todo list.
        // 
        [Test]
        public void AddTask()
        {
            TodoList todoList = new TodoList();
            var result = todoList.AddTask("Groceries", false);
            Assert.That(result, Is.True); 
        }

        // I want to remove tasks from my list.
        [Test]
        public void RemoveTask()
        {
            // arrange
            TodoList todoList = new TodoList();
            todoList.AddTask("Groceries", false);

            // act
            bool result = todoList.RemoveTask("Groceries");

            // arrange
            Assert.That(result, Is.True);
        }


        // I want to see all the tasks in my todo list.
        [Test]
        public void SeeAllTasks()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Groceries", false);
            todoList.AddTask("Walking the dog", false);
            int expectedCount = 2;

            var actualCount = todoList.GetAllTasks.Count;

            Assert.That(actualCount == expectedCount);
        }


        // I want to change the status of a task between incomplete and complete.
        [Test]
        public void TestChangeStatus()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Groceries", false);
            bool result = todoList.ChangeStatus("Groceries", true);
            Assert.That(result, Is.True);

        }

        // I want to be able to get only the completed tasks.
        [Test]
        public void GetCompletedTasks()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Groceries", false);
            todoList.AddTask("Walk the dog", true);

            Dictionary<string, bool> result = todoList.GetCompletedTasks;

            Assert.That(result.Count == 1);
        }
        

        // I want to be able to get only the incomplete tasks.
        [Test]
        public void GetIncompletedTasks()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Groceries", false);
            todoList.AddTask("Vacuume", false);
            todoList.AddTask("Walking the dog", true);

            Dictionary<string, bool> result = todoList.GetInCompletedTasks;

            Assert.That(result.Count == 2);
        }

        // I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
        [Test]
        public void FindTask()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Groceries", false);
            todoList.AddTask("Walking the dog", true);

            var result = todoList.SearchTask("Buy flowers");

            Assert.That(result, Is.False);
        }

        //  I want to see all the tasks in my list ordered alphabetically in ascending order.
        [Test]
        public void TestIfAscending()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Walking the dog", true);
            todoList.AddTask("Groceries", false);
            var expected = "Groceries";

            var result = todoList.SortByAscending();

            Assert.AreEqual(expected, result.First());  
        }

        // I want to see all the tasks in my list ordered alphabetically in descending order.
        [Test]
        public void TestIfDescending()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Hiking", true);
            todoList.AddTask("Groceries", false);
            todoList.AddTask("Walking", true);
            var expected = "Walking";

            var result = todoList.SortByDescending();

            Assert.AreEqual(expected, result.First());
        }
    }
}



