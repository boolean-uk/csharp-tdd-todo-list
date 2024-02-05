using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void TestAddTask()
        {
            // Arrange
            TodoList todoList = new TodoList();

            TodoTask task = new TodoTask { Id = 1, Title = "Complete assignment", IsComplete = false };

            // Act
            todoList.AddTask(task);

            // Assert
            Assert.Contains(task, todoList.GetTasks());
        }


        [Test]
        public void SeeAllTask()
        {
            // Arrange
            TodoList todoList = new TodoList();

            TodoTask task1 = new TodoTask { Id = 1, Title = "assignment1", IsComplete = true };
            TodoTask task2 = new TodoTask { Id = 2, Title = "assignment2", IsComplete = true };
            TodoTask task3 = new TodoTask { Id = 3, Title = "assignment3", IsComplete = false };

            // Act
            todoList.AddTask(task1);
            todoList.AddTask(task2);
            todoList.AddTask(task3);

            // Assert
            Assert.Contains(task1, todoList.GetTasks());
        }

        [Test]
        public void TestChangeStatus()
        {
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask { Id = 1, Title = "Task 1", IsComplete = true };
            todoList.AddTask(task);

            // Act
            todoList.ChangeTaskStatus(1, false);

            // Assert
            Assert.False(task.IsComplete);
        }

        [Test]
        public void TestGetCompleteTasks()
        {
            TodoList todoList = new TodoList();

            todoList.AddTask(new TodoTask { Id = 1, Title = "Task 1", IsComplete = true });
            todoList.AddTask(new TodoTask { Id = 2, Title = "Task 2", IsComplete = false });
            todoList.AddTask(new TodoTask { Id = 3, Title = "Task 3", IsComplete = true });
            todoList.AddTask(new TodoTask { Id = 4, Title = "Task 4", IsComplete = false });

            // Act
            var completeTasks = todoList.GetCompleteTasks();

            // Assert
            Assert.That(completeTasks.Count, Is.EqualTo(2)); // Ensure only 2 incomplete tasks are present
                                                               // Check that all incomplete tasks are returned
            Assert.That(completeTasks, Has.Some.Matches<TodoTask>(task => task.Id == 1 && task.Title == "Task 1"));
            Assert.That(completeTasks, Has.Some.Matches<TodoTask>(task => task.Id == 3 && task.Title == "Task 3"));

        }


        [Test]
        public void TestGetIncompletedTasks()
        {
            // Arrange
            TodoList todoList = new TodoList();
            todoList.AddTask(new TodoTask { Id = 1, Title = "Task 1", IsComplete = true });
            todoList.AddTask(new TodoTask { Id = 2, Title = "Task 2", IsComplete = false });
            todoList.AddTask(new TodoTask { Id = 3, Title = "Task 3", IsComplete = true });
            todoList.AddTask(new TodoTask { Id = 4, Title = "Task 4", IsComplete = false });

            // Act
            var incompleteTasks = todoList.GetIncompleteTasks();

            // Assert
            Assert.That(incompleteTasks.Count, Is.EqualTo(2)); // Ensure only 2 incomplete tasks are present
                                                               // Check that all incomplete tasks are returned
            Assert.That(incompleteTasks, Has.Some.Matches<TodoTask>(task => task.Id == 2 && task.Title == "Task 2"));
            Assert.That(incompleteTasks, Has.Some.Matches<TodoTask>(task => task.Id == 4 && task.Title == "Task 4"));
        }

        [Test]
        public void TestSearch()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask(new TodoTask { Id = 1, Title = "Task 1", IsComplete = false });
            todoList.AddTask(new TodoTask { Id = 2, Title = "Task 2", IsComplete = false });

            var foundTask = todoList.SearchTaskById(1);
            Assert.NotNull(foundTask); // Ensure a task was found
            Assert.AreEqual(1, foundTask.Id); // Ensure the correct task is found
            Assert.AreEqual("Task 1", foundTask.Title);
            Assert.IsFalse(foundTask.IsComplete);
        }

        [Test]
        public void TestRemovTask()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask(new TodoTask { Id = 1, Title = "Task 1", IsComplete = false });
            todoList.AddTask(new TodoTask { Id = 2, Title = "Task 2", IsComplete = false });
            var removedTask = todoList.RemoveTaskById(2);

            Assert.NotNull(removedTask); 
            Assert.AreEqual(2, removedTask.Id);

            var remainingTasks = todoList.GetTasks();
            Assert.That(remainingTasks, Has.Exactly(1).Matches<TodoTask>(task => task.Id == 1));

        }

        [Test]
        public void TestAscendingOrder()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask(new TodoTask { Id = 1, Title = "Banana", IsComplete = false });
            todoList.AddTask(new TodoTask { Id = 2, Title = "Apple", IsComplete = true });
            todoList.AddTask(new TodoTask { Id = 1, Title = "Pear", IsComplete = false });
            todoList.AddTask(new TodoTask { Id = 2, Title = "Kiwi", IsComplete = true });
            var ascendingOrder = todoList.AscendingOrder();

            Assert.AreEqual(4, ascendingOrder.Count);

            CollectionAssert.AreEqual( 
                new List<string> { "Apple", "Banana", "Kiwi", "Pear"},
                ascendingOrder.ConvertAll(task => task.Title),
                "Tasks are in the expected order"
                );
        }


        [Test]
        public void TestDescendingOrder()
        {
            TodoList todoList = new TodoList();
 
            todoList.AddTask(new TodoTask { Id = 1, Title = "Banana", IsComplete = false });
            todoList.AddTask(new TodoTask { Id = 2, Title = "Apple", IsComplete = true });
            todoList.AddTask(new TodoTask { Id = 3, Title = "Pear", IsComplete = false });
            todoList.AddTask(new TodoTask { Id = 4, Title = "Kiwi", IsComplete = true });

            //List<TodoTask> descendingOrderTasks = todoList.DescendingOrder();

            var descendingOrderTasks = todoList.DescendingOrder();
            Assert.AreEqual(4, descendingOrderTasks.Count); // Ensure all tasks are present in the result

            // Check the order
            CollectionAssert.AreEqual(
                new List<string> { "Pear", "Kiwi", "Banana", "Apple" },
                descendingOrderTasks.ConvertAll(task => task.Title),
                "Tasks are not in the expected order"
            );

        }


    }
}