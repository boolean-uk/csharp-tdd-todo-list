using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTask()
        {
            //Arrange
            TodoList core = new TodoList();

            //Act
            bool result = core.AddTask("Study");

            //Assert
            Assert.IsTrue(result);
            CollectionAssert.Contains(core.GetAllTasks(), "Study");

        }
        [Test]
        public void AddTask_ShouldNotDuplicateTask()
        {
            // Arrange
            TodoList todoList = new TodoList();
            todoList.AddTask("Study");

            // Act
            bool result = todoList.AddTask("Study");

            // Assert
            Assert.IsFalse(result);
            CollectionAssert.Contains(todoList.GetAllTasks(), "Study");
        }

        [Test]
        public void GetCompletedTask()
        {
            //Arrange
            TodoList todoList = new TodoList();

            //Act
            ToDoTask cookingTask = new ToDoTask("Cooking", true);
            ToDoTask cleaningTask = new ToDoTask("Cleaning", false);

            todoList.AddTaskToTasks(cookingTask);
            todoList.AddTaskToTasks(cleaningTask);

            List<string> completedTasks = todoList.GetCompleteTasks();

            //Assert
            CollectionAssert.Contains(completedTasks, "Cooking");
            CollectionAssert.DoesNotContain(completedTasks, "Cleaning");

        }
        [Test]
        public void GetIncompleteTasks()
        {
            // Arrange
            TodoList todoList = new TodoList();

            // Act
            ToDoTask cookingTask = new ToDoTask("Cooking", true);
            ToDoTask cleaningTask = new ToDoTask("Cleaning", false);

            todoList.AddTaskToTasks(cookingTask);
            todoList.AddTaskToTasks(cleaningTask);

            List<string> incompleteTasks = todoList.GetIncompleteTasks();

            // Assert
            CollectionAssert.Contains(incompleteTasks, "Cleaning");
            CollectionAssert.DoesNotContain(incompleteTasks, "Cooking");

        }


        [Test]
        //If Task Exists
        public void SearchTask_ShouldReturnExists()
        {
            // Arrange
            TodoList todoList = new TodoList();
            todoList.AddTask("Write Code");

            // Act
            string result = todoList.SearchTask("Write Code");

            // Assert
            Assert.AreEqual("Exists", result);
        }

        [Test]
        //If Task Does Not Exist
        public void SearchTask_ShouldReturnNotFound()
        {
            // Arrange
            TodoList todoList = new TodoList();

            // Act
            string result = todoList.SearchTask("Read Book");

            // Assert
            Assert.AreEqual("Not Found", result);
        }

        
        [Test]
        public void RemoveTask_RemoveTaskIfExists()
        {
            // Arrange
            TodoList todoList = new TodoList();
            todoList.AddTask("Clean Room");

            // Act
            bool result = todoList.RemoveTask("Clean Room");

            // Assert
            Assert.IsTrue(result);
            CollectionAssert.DoesNotContain(todoList.GetAllTasks(), "Clean Room");
        }

        [Test]
        //If it does not exis
        public void RemoveTask_ShouldNotRemoveTask()
        {
            // Arrange
            TodoList todoList = new TodoList();

            // Act
            bool result = todoList.RemoveTask("Buy birthday cake");

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void OrderTasksAscending_TasksInAscendingOrder()
        {
            // Arrange
            TodoList todoList = new TodoList();
            todoList.AddTask("C");
            todoList.AddTask("A");
            todoList.AddTask("B");

            // Act
            List<string> orderedTasks = todoList.OrderTasksAscending();

            // Assert
            Assert.AreEqual("A", orderedTasks[0]);
            Assert.AreEqual("B", orderedTasks[1]);
            Assert.AreEqual("C", orderedTasks[2]);
        }

        [Test]
        public void OrderTasksDescending_TasksInDescendingOrder()
        {
            // Arrange
            TodoList todoList = new TodoList();
            todoList.AddTask("C");
            todoList.AddTask("A");
            todoList.AddTask("B");

            // Act
            List<string> orderedTasks = todoList.OrderTasksDescending();

            // Assert
            Assert.AreEqual("C", orderedTasks[0]);
            Assert.AreEqual("B", orderedTasks[1]);
            Assert.AreEqual("A", orderedTasks[2]);
        }
    }
}