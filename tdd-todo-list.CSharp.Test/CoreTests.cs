using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void FirstTest()
        {
            TodoList core = new TodoList();
            Assert.Pass();
        }

        private TodoList todoList;

        [SetUp]
        public void SetUp()
        {
            todoList = new TodoList(); //Arrange part for all tests
        }

        [Test]
        public void Add()
        {
            //Act
            var result = todoList.Add("Task 1");

            //Assert
            Assert.AreEqual("Task added to todo list.", result);
        }

        [Test]
        public void ShowTasks()
        {
            //Act
            todoList.Add("Task 1");
            todoList.Add("Task 2");

            //Assert
            var result = todoList.ShowTasks();
            Assert.AreEqual("Task 1, Task 2", result);
        }

        [Test]
        public void ChangeTaskStatus()
        {
            //Act
            todoList.Add("Task 1");
            todoList.Add("Task 2");
            todoList.ChangeTaskStatus("Task 1", "Complete");
            var completedTasks = todoList.GetCompletedTasks();

            //Assert
            Assert.AreEqual("Task 1", completedTasks);

            //Act
            todoList.ChangeTaskStatus("Task 1", "Incomplete");
            var incompleteTasks = todoList.GetIncompleteTasks();

            //Assert
            Assert.AreEqual("Task 1, Task 2", incompleteTasks);
        }

        [Test]
        public void GetCompletedTasks()
        {
            //Act
            todoList.Add("Task 1");
            todoList.ChangeTaskStatus("Task 1", "Complete");
            var result = todoList.GetCompletedTasks();

            //Assert
            Assert.AreEqual("Task 1", result);
        }

        [Test]
        public void GetIncompleteTasks()
        {
            //Act
            todoList.Add("Task 1");
            todoList.Add("Task 2");
            todoList.ChangeTaskStatus("Task 1", "Complete");
            var result = todoList.GetIncompleteTasks();

            //Assert
            Assert.AreEqual("Task 2", result);
        }

        [Test]
        public void FindTask()
        {
            //Act
            todoList.Add("Task 1");
            var result = todoList.FindTask("Task 1");

            //Assert
            Assert.AreEqual("Task exists in todo list.", result);

            //Act
            result = todoList.FindTask("Task 2");

            //Assert
            Assert.AreEqual("Task does not exist in list.", result);
        }

        [Test]
        public void Remove()
        {
            //Act
            todoList.Add("Task 1");
            var result = todoList.Remove("Task 1");

            //Assert
            Assert.AreEqual("Task successfully removed from todo list.", result);

            //Act
            result = todoList.Remove("Task 2");

            //Assert
            Assert.AreEqual("Task not in todo list.", result);
        }

        [Test]
        public void OutputListAscending()
        {
            //Act
            todoList.Add("Task 1");
            todoList.Add("Task 2");
            var result = todoList.OutputListAscending();

            //Assert
            Assert.AreEqual("Task 1, Task 2", result);
        }

        [Test]
        public void OutputListDescending()
        {
            //Act
            todoList.Add("Task A");
            todoList.Add("Task B");
            var result = todoList.OutputListDescending();

            //Assert
            Assert.AreEqual("Task B, Task A", result);
        }
    }
}