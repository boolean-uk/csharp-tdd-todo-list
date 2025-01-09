using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using Task = tdd_todo_list.CSharp.Main.Task;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void GetTaskByNameTest()
        {
            //arrange
            TodoList tasks = new TodoList();
            Task newTask = new Task("Task1");
            //act
            tasks.AddTask(newTask);
            Task task = tasks.GetTask("Task1");

            //assert
            Assert.That(task, Is.Not.Null);
            Assert.That(task, Is.EqualTo(newTask));
        }

        [Test]
        public void GetTasksTest()
        {
            //arrange
            TodoList tasks = new TodoList();
            Task newTask = new Task("Task1");
            Task newTask2 = new Task("Task2");
            //act
            tasks.AddTask(newTask);
            tasks.AddTask(newTask2);

            var allTasks = tasks.GetTasks();

            //assert
            Assert.That(allTasks, Has.Count.EqualTo(2));
        }

        [Test]
        public void ChangeStatusTest()
        {
            //arrange
            Task newTask = new Task("Task1");
            //act
            newTask.Status = "Complete";

            //assert
            Assert.That(newTask.Status, Is.EqualTo("Complete"));
        }

        [Test]
        public void GetCompleteTasksTest()
        {
            //arrange
            TodoList tasks = new TodoList();
            Task newTask = new Task("Task1");
            Task newTask2 = new Task("Task2");
            //act
            tasks.AddTask(newTask);
            tasks.AddTask(newTask2);

            newTask2.Status = "Complete";

            var completeTasks = tasks.GetCompleteTasks();

            //assert
            Assert.That(completeTasks, Has.Count.EqualTo(1));
        }

        [Test]
        public void GetIncompleteTasksTest()
        {
            //arrange
            TodoList tasks = new TodoList();
            Task newTask = new Task("Task1");
            Task newTask2 = new Task("Task2");
            //act
            tasks.AddTask(newTask);
            tasks.AddTask(newTask2);

            newTask2.Status = "Complete";

            var completeTasks = tasks.GetCompleteTasks();

            //assert
            Assert.That(completeTasks, Has.Count.EqualTo(1));
        }

        [Test]
        public void SearchForTaskTest()
        {
            //arrange
            TodoList tasks = new TodoList();
            Task newTask = new Task("Task1");
            Task newTask2 = new Task("Task2");
            //act
            tasks.AddTask(newTask);
            tasks.AddTask(newTask2);

            string foundTask = tasks.FindTask("Task1");

            //assert
            Assert.That(foundTask, Is.EqualTo("Found task"));
        }

        [Test]
        public void RemoveTaskTest()
        {
            //arrange
            TodoList tasks = new TodoList();
            Task newTask = new Task("Task1");
            Task newTask2 = new Task("Task2");
            //act
            tasks.AddTask(newTask);
            tasks.AddTask(newTask2);

            tasks.RemoveTask(2);

            //assert
            Assert.That(tasks.GetTasks(), Has.Count.EqualTo(1));
        }

        [Test]
        public void GetTasksOrderedAlphabetically()
        {
            //arrange
            TodoList tasks = new TodoList();
            Task newTask = new Task("ATask1");
            Task newTask2 = new Task("BTask2");
            Task newTask3 = new Task("CTask2");
            //act
            tasks.AddTask(newTask);
            tasks.AddTask(newTask2);
            tasks.AddTask(newTask3);

            var ascendingTasks = tasks.GetOrdered(true);
            var descendingTasks = tasks.GetOrdered(false);

            //assert
            Assert.That(ascendingTasks.First().Value, Is.EqualTo(newTask));
            Assert.That(descendingTasks.First().Value, Is.EqualTo(newTask3));

        }
    }
}