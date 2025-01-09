using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private TodoList _list;
        
        [SetUp]
        public void Setup()
        {
            _list = new TodoList();
        }
        
        [TestCase("Test Task 1")]
        [TestCase("Test Task 2")]
        [TestCase("Test Task 3")]
        public void AddTaskTest(string name)
        {
            int id = _list.AddTask(name);
            Assert.AreEqual(name, _list.GetTask(name).GetName());
        }
        
        [Test]
        public void GetTasksTest()
        {
            _list.AddTask("Test Task 1");
            _list.AddTask("Test Task 2");
            _list.AddTask("Test Task 3");
            
            var allTasks = _list.GetTasks();
            
            Assert.AreEqual(allTasks.Count, 3);
        }
        
        [Test]
        public void RemoveTaskTest()
        {
            int id = _list.AddTask("Test Remove Task");
            _list.RemoveTask(id);
            
            Assert.IsNull(_list.GetTask("Test Remove Task"));
        }
        
        [TestCase("Test Task 1")]
        [TestCase("Test Task 2")]
        public void GetTaskByNameTest(string name)
        {
            TodoList core = new TodoList();
            int id = core.AddTask(name);
            Assert.AreEqual(name, core.GetTask(name).GetName());
        }
        
        [TestCase("Change Status")]
        public void ChangeStatusTest(string name)
        {
            _list.AddTask(name);
            
            Assert.AreEqual(_list.GetTask(name).GetStatus(), false);
            _list.SetStatus(name, true);
            Assert.AreEqual(_list.GetTask(name).GetStatus(), true);
            _list.SetStatus(name, false);
            Assert.AreEqual(_list.GetTask(name).GetStatus(), false);
        }
        
        [Test]
        public void GetCompletedTasksTest()
        {
            _list.AddTask("Test Task 1");
            _list.AddTask("Test Task 2");
            _list.AddTask("Test Task 3");
            
            _list.SetStatus("Test Task 1", true);
            _list.SetStatus("Test Task 2", false);
            _list.SetStatus("Test Task 3", true);
            
            var incompleteTasks = _list.GetCompletedTasks();
            
            Assert.AreEqual(incompleteTasks.Count, 2);
        }
        
        [Test]
        public void GetIncompleteTasksTest()
        {
            _list.AddTask("Test Task 1");
            _list.AddTask("Test Task 2");
            _list.AddTask("Test Task 3");
            
            _list.SetStatus("Test Task 1", true);
            _list.SetStatus("Test Task 2", false);
            _list.SetStatus("Test Task 3", true);
            
            var incompleteTasks = _list.GetIncompleteTasks();
            
            Assert.AreEqual(incompleteTasks.Count, 1);
        }
        
        [Test]
        public void FindTaskAndPrintMessageTest()
        {
            _list.AddTask("Test Task 1");
            
            var task = _list.GetTask("Test Task 1");

            var taskMessage = task.ToString();
            Console.WriteLine("Task found: " + taskMessage);
            
            Assert.IsNotEmpty(taskMessage);
        }
        
        [Test]
        public void GetOrderedTasksAscTest()
        {
            _list.AddTask("b");
            _list.AddTask("a");
            _list.AddTask("c");
            
            var orderedTasks = _list.GetOrdered(true);
            
            Assert.AreEqual(orderedTasks[0].GetName(), "a");
            Assert.AreEqual(orderedTasks[1].GetName(), "b");
            Assert.AreEqual(orderedTasks[2].GetName(), "c");
        }
        
        [Test]
        public void GetOrderedTasksDscTest()
        {
            _list.AddTask("c");
            _list.AddTask("a");
            _list.AddTask("b");
            
            var orderedTasks = _list.GetOrdered(false);
            
            Assert.AreEqual(orderedTasks[0].GetName(), "c");
            Assert.AreEqual(orderedTasks[1].GetName(), "b");
            Assert.AreEqual(orderedTasks[2].GetName(), "a");
        }
    }
}