using NUnit.Framework;
using System.Xml.Linq;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        // 1. I want to add tasks to my todo list.
        [Test]
        public void AddTaskToToDoList()
        {
            // arrange
            TodoList todolist = new TodoList();
            var task = new TaskItem { Name = "Do the dishes" };

            // act
            todolist.MyList.Add(task);

            //assert
            Assert.IsTrue(todolist.MyList.Count == 1);
            Assert.That(todolist.MyList[0].Name, Is.EqualTo("Do the dishes"));
        }

        // 2. I want to see all the tasks in my todo list.
        [Test]
        public void SeeAllTasksInToDoList()
        {
            // arrange
            TodoList todolist = new TodoList();
            var task1 = new TaskItem { Name = "Do the dishes" };
            var task2 = new TaskItem { Name = "Clean the bathroom" };
            todolist.MyList.Add(task1);
            todolist.MyList.Add(task2);

            //act
            var result = todolist.MyList;

            //assert
            Assert.IsTrue(todolist.MyList.Count == 2);
            Assert.That(todolist.MyList[0].Name, Is.EqualTo(result[0].Name));
            Assert.That(todolist.MyList[1].Name, Is.EqualTo(result[1].Name));
        }

        // 3. I want to change the status of a task between incomplete and complete.
        [Test]
        public void ChangeStatusOfTask()
        {
            // arrange
            TodoList todolist = new TodoList();
            var task1 = new TaskItem { Name = "Do the dishes" };
            var task2 = new TaskItem { Name = "Clean the bathroom", IsCompleted = true };
            todolist.MyList.Add(task1);
            todolist.MyList.Add(task2);

            // act
            todolist.MyList[0].IsCompleted = true;
            todolist.MyList[1].IsCompleted = false;

            // assert
            Assert.IsTrue(todolist.MyList[0].IsCompleted == true);
            Assert.IsTrue(todolist.MyList[1].IsCompleted == false);
        }

        // 4. I want to be able to get only the complete tasks.
        [Test]
        public void GetCompleteTasks()
        {
            // arrange
            TodoList todolist = new TodoList();
            var task1 = new TaskItem { Name = "Do the dishes" };
            var task2 = new TaskItem { Name = "Clean the bathroom", IsCompleted = true };
            todolist.MyList.Add(task1);
            todolist.MyList.Add(task2);

            // act
            var result = todolist.CompletedTasks;

            // assert
            Assert.IsTrue(result.Count == 1);
            Assert.That(result[0].Name, Is.EqualTo(todolist.MyList[1].Name));
        }

        // 5. I want to be able to get only the incomplete tasks.
        [Test]
        public void GetInompleteTasks()
        {
            // arrange
            TodoList todolist = new TodoList();
            var task1 = new TaskItem { Name = "Do the dishes" };
            var task2 = new TaskItem { Name = "Clean the bathroom", IsCompleted = true };
            todolist.MyList.Add(task1);
            todolist.MyList.Add(task2);

            // act
            var result = todolist.IncompletedTasks;

            // assert
            Assert.IsTrue(result.Count == 1);
            Assert.That(result[0].Name, Is.EqualTo(todolist.MyList[0].Name));
        }

        // 6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
        [Test]
        public void SearchForTask()
        {
            // arrange
            TodoList todolist = new TodoList();
            var task = new TaskItem { Name = "Do the dishes" };
            todolist.MyList.Add(task);

            // act
            var result1 = todolist.Search(todolist, "Do the dishes");
            var result2 = todolist.Search(todolist, "Walk the dog");

            // assert
            Assert.IsTrue(result1 == "Do the dishes");
            Assert.IsTrue(result2 == "Task not found");
        }

        // 7. I want to remove tasks from my list.
        [Test]
        public void RemoveTaskFromToDoList()
        {
            // arrange
            TodoList todolist = new TodoList();
            var task1 = new TaskItem { Name = "Do the dishes" };
            var task2 = new TaskItem { Name = "Clean the bathroom" };
            todolist.MyList.Add(task1);
            todolist.MyList.Add(task2);

            // act
            todolist.MyList.Remove(task1);

            //assert
            Assert.IsTrue(todolist.MyList.Count == 1);
            Assert.That(todolist.MyList[0].Name, Is.EqualTo("Clean the bathroom"));
        }

        // 8. I want to see all the tasks in my list ordered alphabetically in ascending order.
        [Test]
        public void GetTasksAlphabeticallyInAscendingOrder()
        {
            // arrange
            TodoList todolist = new TodoList();
            var task1 = new TaskItem { Name = "Do the dishes" };
            var task2 = new TaskItem { Name = "Clean the bathroom" };
            todolist.MyList.Add(task1);
            todolist.MyList.Add(task2);

            // act
            var result = todolist.TasksSortedAscending;

            // assert
            Assert.IsTrue(result.Count == 2);
            Assert.That(result[0].Name, Is.EqualTo(todolist.MyList[1].Name));
            Assert.That(result[1].Name, Is.EqualTo(todolist.MyList[0].Name));
        }

        // 9. I want to see all the tasks in my list ordered alphabetically in descending order.
        [Test]
        public void GetTasksAlphabeticallyInDescendingOrder()
        {
            // arrange
            TodoList todolist = new TodoList();
            var task1 = new TaskItem { Name = "Clean the bathroom" };
            var task2 = new TaskItem { Name = "Do the dishes" };
            todolist.MyList.Add(task1);
            todolist.MyList.Add(task2);

            // act
            var result = todolist.TasksSortedDescending;

            // assert
            Assert.IsTrue(result.Count == 2);
            Assert.That(result[0].Name, Is.EqualTo(todolist.MyList[1].Name));
            Assert.That(result[1].Name, Is.EqualTo(todolist.MyList[0].Name));
        }

        // 10. I want to prioritise tasks e.g. low, medium, high
        [Test]
        public void PrioritiseTask()
        {
            // arrange
            TodoList todolist = new TodoList();
            var task1 = new TaskItem { Name = "Clean the bathroom" };
            var task2 = new TaskItem { Name = "Do the dishes" };
            var task3 = new TaskItem { Name = "Walk the dog" };
            todolist.MyList.Add(task1);
            todolist.MyList.Add(task2);
            todolist.MyList.Add(task3);

            // act
            todolist.MyList[0].Priority = Priority.Low;
            todolist.MyList[1].Priority = Priority.High;
            todolist.MyList[2].Priority = Priority.Medium;

            // assert
            Assert.IsTrue(todolist.MyList[0].Priority == Priority.Low);
            Assert.IsTrue(todolist.MyList[1].Priority == Priority.High);
            Assert.IsTrue(todolist.MyList[2].Priority == Priority.Medium);
        }

        // 11. I want to list all tasks by priority
        [Test]
        public void GetTasksInPriorityOrder()
        {
            // arrange
            TodoList todolist = new TodoList();
            var task1 = new TaskItem { Name = "Clean the bathroom", Priority = Priority.Low };
            var task2 = new TaskItem { Name = "Do the dishes", Priority = Priority.High };
            var task3 = new TaskItem { Name = "Walk the dog", Priority = Priority.Medium };
            todolist.MyList.Add(task1);
            todolist.MyList.Add(task2);
            todolist.MyList.Add(task3);

            // act
            var result = todolist.TasksSortedByPriority;

            // assert
            Assert.IsTrue(result.Count == 3);
            Assert.That(result[0].Priority, Is.EqualTo(todolist.MyList[1].Priority));
            Assert.That(result[1].Priority, Is.EqualTo(todolist.MyList[2].Priority));
            Assert.That(result[2].Priority, Is.EqualTo(todolist.MyList[0].Priority));
        }
    }
}
