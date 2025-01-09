using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        private TodoList _todoList;

        [SetUp]
        public void SetUp()
        {
            _todoList = new TodoList();
            _todoList.AddTask(1, new TodoList.Task("Buy bread"));
            _todoList.AddTask(2, new TodoList.Task("Buy cereal", true));
        }
        [Test]
        public void TaskAdded()
        {
            _todoList.AddTask(3, new TodoList.Task("Brush Teeth"));
            var result = _todoList.Count();
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void TaskRemoved()
        {
            _todoList.RemoveTask(1);
            var result = _todoList.Count();
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]

        public void SuccesfulSearch()
        {
            var result = _todoList.SearchTaskById(1);

            Assert.IsInstanceOf<TodoList.Task>(result);
            var task = result as TodoList.Task;
            Assert.NotNull(task);
            Assert.That(task.Description, Is.EqualTo("Buy bread"));
        }

        [Test]
        public void ErrorSearch()
        {
            var result = _todoList.SearchTaskById(133);

            Assert.That(result, Is.EqualTo("Task not found"));
        }

        [Test]
        public void TaskMarkedCompleted()
        {
            _todoList.UpdateTaskStatus(1, true);
            var task = _todoList.SearchTaskById(1) as TodoList.Task;
            Assert.NotNull(task);
            var result = task.IsCompleted;
            Assert.That(result, Is.True);
        }


        [Test]
        public void CompletedTasksTest()
        {
            var completedList = _todoList.GetCompletedTasks();
            var task = _todoList.SearchTaskById(2) as TodoList.Task;
            Assert.NotNull(task);
            var result = task.Description;
            Assert.That(completedList.Count, Is.EqualTo(1));
            Assert.That(result, Is.EqualTo("Buy cereal"));

        }

        [Test]
        public void InCompletedTasksTest()
        {
            var incompletedList = _todoList.GetInCompletedTasks();
            var task = _todoList.SearchTaskById(1) as TodoList.Task;
            Assert.NotNull(task);
            var result = task.Description;
            Assert.That(incompletedList.Count, Is.EqualTo(1));
            Assert.That(result, Is.EqualTo("Buy bread"));

        }

        [Test]

        public void DescendingOrderTest()
        {
            TodoList todoList = new TodoList();
            
            todoList.AddTask(1, new TodoList.Task("Bread", false));
            todoList.AddTask(2, new TodoList.Task("Laundry", true));
            todoList.AddTask(3, new TodoList.Task("Clean", true));
            var expected = "Laundry";

            var result = todoList.OrderByDescending();

            Assert.AreEqual(expected, result.First().Description);
        }

        [Test]
        public void AscendingOrderTest()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask(1, new TodoList.Task("Clean", true));
            todoList.AddTask(2, new TodoList.Task("Laundry", true));
            todoList.AddTask(3, new TodoList.Task("Bread", false));
            var expected = "Bread";

            var result = todoList.OrderByAscending();

            Assert.AreEqual(expected, result.First().Description);
        }




    }
}