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
            ToDoList core = new ToDoList(); // switched to ToDoList instead of TodoList :S learning now to test underway!!
            Assert.Pass();
        }

        [Test]
        public void AddTask()
        {
            //Arrange
            ToDoList todoList = new ToDoList();

            //Act
            todoList.AddTask("Task 1", "Do dishes");
            todoList.AddTask("Task 2", "Go for a walk");

            //Assert
            Assert.AreEqual(2, todoList.GetAllTasks().Count);
            Assert.AreEqual("Task 1", todoList.GetAllTasks()[0].Title);

            /*
             * 
             FIRST TEST OUTPUT
              Standard Output: 
              Added task: Title: Task 1, Description: Do dishes, Status: Incomplete
              Added task: Title: Task 2, Description: Go for a walk, Status: Incomplete
             *
             */
        }

        [Test]
        public void RemoveTask()
        {
            //Arrange
            ToDoList todoList = new ToDoList();
            todoList.AddTask("Task 3", "Play football");

            //Act
            todoList.RemoveTask("Task 3");

            //Assert
            Assert.AreEqual(0, todoList.GetAllTasks().Count);

            //Takes the added task "Task 3", then removes it. Output says Added task: ... && Removed task: ...
        }

        [Test]
        public void GetCompletedTasks()
        {
            // Arrange
            ToDoList todoList = new ToDoList();
            Console.WriteLine("Tasks added:");
            todoList.AddTask("Task 4", "Eat icecream in the sunshine");
            todoList.AddTask("Task 5", "Go to the cinema with Anette Mari");

            // Act
            string[] taskTitles = { "Task 4", "Task 5" };
            var completedTasks = todoList.ToggleStatusAndGetCompletedTasks(taskTitles);

            Console.WriteLine("Setting status as complete...");

            // Print details of each task after toggling
            foreach (var task in todoList.GetAllTasks())
            {
                Console.WriteLine($"Title: {task.Title}, Description: {task.Description}, Status: {(task.IsComplete ? "Complete" : "Incomplete")}");
            }

            Console.WriteLine("Great, you've completed your tasks!");

            // Assert
            Assert.AreEqual(2, completedTasks.Count);
            Assert.AreEqual("Task 4", completedTasks[0].Title);
            Assert.AreEqual("Task 5", completedTasks[1].Title);
        }

        [Test]
        public void GetIncompleteTasks()
        {
            // Arrange
            ToDoList todoList = new ToDoList();
            todoList.AddTask("Task 6", "Read a book");
            todoList.AddTask("Task 7", "Write code");

            // Act
            var incompleteTasks = todoList.GetIncompleteTasks();

            // Assert
            Assert.AreEqual(2, incompleteTasks.Count);
            Assert.AreEqual("Task 6", incompleteTasks[0].Title);
            Assert.AreEqual("Task 7", incompleteTasks[1].Title);
        }

        [Test]
        public void SearchTask_NotFound_Test()
        {
            // Arrange
            ToDoList todoList = new ToDoList();
            todoList.AddTask("Task 8", "Go for a run");

            // Act
            tdd_todo_list.CSharp.Main.Task task = todoList.SearchTask("Nonexistent Task");

            // Assert
            Assert.IsNull(task);
        }


        [Test]
        public void OrderTasks_AlphabeticalAscending()
        {
            // Arrange
            ToDoList todoList = new ToDoList();
            todoList.AddTask("Task B", "Do something");
            todoList.AddTask("Task A", "Do something else");

            // Act
            var orderedTasks = todoList.OrderByTitleAscending();

            // Assert
            Assert.AreEqual(2, orderedTasks.Count);
            Assert.AreEqual("Task A", orderedTasks[0].Title);
            Assert.AreEqual("Task B", orderedTasks[1].Title);
        }

        [Test]
        public void OrderTasks_AlphabeticalDescending()
        {
            // Arrange
            ToDoList todoList = new ToDoList();
            todoList.AddTask("Task D", "Do something");
            todoList.AddTask("Task C", "Do something else");

            // Act
            var orderedTasks = todoList.OrderByTitleDescending();

            // Assert
            Assert.AreEqual(2, orderedTasks.Count);
            Assert.AreEqual("Task D", orderedTasks[0].Title);
            Assert.AreEqual("Task C", orderedTasks[1].Title);
        }

    }

}
