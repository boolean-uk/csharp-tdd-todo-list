using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private TodoList _core;
        public CoreTests()
        {
            _core = new TodoList();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestAddTask()
        {
            TodoList _todoList = new TodoList();
            _todoList.AddTask("Do laundry", false);
            Assert.IsTrue(_todoList.TaskList.ContainsKey("Do laundry"));
        }

        [Test]
        public void TestSeeTaskList()
        {
            TodoList _todoList = new TodoList();
            string task1 = "Do laundry";
            string task2 = "Make diner";
            string task3 = "Have a meeting";
            _todoList.AddTask(task1, false);
            _todoList.AddTask(task2, false);
            _todoList.AddTask(task3, false);
            Assert.IsTrue(_todoList.TaskList.Count == 3);
            string result = _todoList.GetTasks();
            Assert.AreEqual(result, $"{task1}; {task2}; {task3}; ");
        }

        [Test]
        public void TestUpdateStatus()
        {
            TodoList _todoList = new TodoList();
            _todoList.AddTask("Do laundry", false);
            _todoList.UpdateTaskStatus("Do laundry", true);
            Assert.IsTrue(_todoList.TaskList["Do laundry"] == true);
        }

        [Test]
        public void TestCompletedTasks()
        {
            TodoList _todoList = new TodoList();
            string task1 = "Do laundry";
            string task2 = "Make diner";
            string task3 = "Have a meeting";
            _todoList.AddTask(task1, false);
            _todoList.AddTask(task2, false);
            _todoList.AddTask(task3, false);
            _todoList.UpdateTaskStatus(task2, true);
            _todoList.UpdateTaskStatus(task1, true);
            _todoList.CompletedTasks();
            Assert.IsTrue(_todoList.CompletedList.ContainsKey(task2));
            Assert.IsTrue(_todoList.CompletedList.ContainsKey(task1));
        }
        [Test]
        public void TestIncompletedTasks()
        {
            TodoList _todoList = new TodoList();
            string task1 = "Do laundry";
            string task2 = "Make diner";
            string task3 = "Have a meeting";
            _todoList.AddTask(task1, false);
            _todoList.AddTask(task2, false);
            _todoList.AddTask(task3, false);
            _todoList.UpdateTaskStatus(task2, true);
            _todoList.IncompletedTasks();
            Assert.IsTrue(_todoList.IncompletedList.ContainsKey(task3));
            Assert.IsTrue(_todoList.IncompletedList.ContainsKey(task1));
        }
    }
}