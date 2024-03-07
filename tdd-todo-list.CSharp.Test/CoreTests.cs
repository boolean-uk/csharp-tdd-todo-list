using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        // private TodoList
        private TodoList _todoList;
        private List<string> _tasks;

        [SetUp] 
        public void Setup()
        {  
            // setup a new TodoList for each test.
            _todoList = new TodoList();
            _tasks = new List<string>();
            _todoList.AddTaskToTodoList("A Task 1", false);
            _todoList.AddTaskToTodoList("B Task 2", false);
            _todoList.AddTaskToTodoList("C Task 3", true);
            _todoList.AddTaskToTodoList("D Task 4", false);

            _todoList.ChangedStatus("C Task 3", true);
        }


        [Test]
        public void TestAddTask()
        {
            // TodoList core = new TodoList();
            bool addTask = _todoList.AddTaskToTodoList("Finishing this exercise", false);
            Assert.That(addTask, Is.True);
        }

        [Test]
        public void TestGetAllTasks()
        {
             _todoList.GetAllTasks();

            Assert.IsTrue(_todoList.GetAllTasks().Count == 4);
        }

        [Test]
        public void TestChangeStatus() 
        {
            var statusChanged = _todoList.ChangedStatus("B Test 2", true);

            Assert.That(statusChanged, Is.True); 
        }

        [Test]
        public void TestGetCompletedTasks() 
        {
            List<string> completedTasks = _todoList.GetCompletedTasks();

            // Assert
            // Verify that there are 1 completed tasks
            Assert.AreEqual(1, completedTasks.Count);
            // Verify that "Task 3" is in the list of completed tasks
            Assert.Contains("C Task 3", completedTasks); 
        }     
        
        [Test]
        public void TestGetIncompletedTasks() 
        {
            List<string> incompletedTasks = _todoList.GetIncompletedTasks();

            // Assert
            // there is 1 completed task
            Assert.AreEqual(1, incompletedTasks.Count);
            // "Task 3" is in the list of incompleted tasks
            Assert.Contains("C Task 3", incompletedTasks); 
        }

        [TestCase("A Task 1", true)]
        [TestCase("B Task 2", true)]
        [TestCase("C Task 3", true)]
        [TestCase("Task 6", false)]
        public void TestSearchTask(string taskName, bool expectedResult)
        {
            bool searchResult = _todoList.SearchTask(taskName);

            Assert.That(searchResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestRemoveTask()
        {
            bool deleteTask = _todoList.DeleteTaskFromTodoList("A Task 1");
            Assert.That(deleteTask, Is.True);
        }

        [Test]
        public void TestOrderListAscOrder()
        {
            var ascOrderedList = _todoList.SortTodoByAscending();
            Assert.That(ascOrderedList.Last() == "D Task 4");
            
        } 
        [Test]
        public void TestOrderListDescOrder()
        {
            var descOrderedList = _todoList.SortTodoByDescending();
            Assert.That(descOrderedList.Last() == "A Task 1");
            
        }
    }
}