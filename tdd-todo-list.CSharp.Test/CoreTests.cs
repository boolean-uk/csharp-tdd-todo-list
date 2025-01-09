using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using Task = tdd_todo_list.CSharp.Main.Task;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTaskToList()
        {
            var task = "Clean your room";
            TodoList core = new TodoList();
            core.Add(task);
            Assert.That(core.todolist.Count(), Is.EqualTo(1));
        }
        [Test]
        public void AddTaskToList2()
        {
            var task = "Clean your room";
            TodoList core = new TodoList();
            core.Add(task);
            Assert.That(core.todolist[0].task, Is.EqualTo("Clean your room"));
        }

        [Test]
        public void ViewTasks()
        {
            var tasks = new List<string>
            {
                "Clean your room",
                "Do the laundry",
                "Buy groceries",
                "Prepare dinner",
                "Read a book"
            };
            TodoList core = new TodoList();

            foreach (var task in tasks)
            {
                core.Add(task);
            }

            var viewTask = core.ViewTasks();
            var expected = tasks;

            Assert.That(expected, Is.EqualTo(viewTask));
        }
        [Test]
        public void ChangeStatusToCompleted()
        {
            var tasks = new List<string>
            {
                "Clean your room",
                "Do the laundry",
                "Buy groceries",
                "Prepare dinner",
                "Read a book"
            };
            TodoList core = new TodoList();

            foreach (var task in tasks)
            {
                core.Add(task);
            }
            core.ChangeStatus("Prepare dinner");

            Assert.That(core.todolist[3].isCompleted, Is.True);
        }

        [Test]
        public void ViewCompletedTasks()
        {
            
            var task1 = new Task("clean your room", false);
            var task2 = new Task("do the laundry", false);
            var task3 = new Task("buy groceries", true);
            var task4 = new Task("prepare dinner", false);
            var task5 = new Task("read a book", true);
            List<Task> tasks = new List<Task> { task1, task2, task3, task4, task5 };

            TodoList core = new TodoList();

            foreach (var task in tasks)
            {
                core.Add(task);
            }

            var completedTasks = core.ViewCompletedTasks();

            Assert.That(completedTasks.Count, Is.EqualTo(2));

        }
        [Test]
        public void ViewIncompletedTasks()
        {

            var task1 = new Task("clean your room", false);
            var task2 = new Task("do the laundry", false);
            var task3 = new Task("buy groceries", true);
            var task4 = new Task("prepare dinner", false);
            var task5 = new Task("read a book", true);
            List<Task> tasks = new List<Task> { task1, task2, task3, task4, task5 };

            TodoList core = new TodoList();

            foreach (var task in tasks)
            {
                core.Add(task);
            }

            var inCompletedTasks = core.ViewInCompletedTasks();

            Assert.That(inCompletedTasks.Count, Is.EqualTo(3));

        }

        [Test]
        public void SearchForTaskSuccessfully()
        {
            var task1 = new Task("clean your room", false);
            var task2 = new Task("do the laundry", false);
            var task3 = new Task("buy groceries", true);
            var task4 = new Task("prepare dinner", false);
            var task5 = new Task("read a book", true);
            List<Task> tasks = new List<Task> { task1, task2, task3, task4, task5 };

            TodoList core = new TodoList();

            foreach (var task in tasks)
            {
                core.Add(task);
            }

            var searchResult = core.Search("read a book");
            Assert.That(searchResult, Is.EqualTo(tasks[4]));
        }
        [Test]
        public void SearchForTaskUnsuccessfully()
        {
            var task1 = new Task("clean your room", false);
            var task2 = new Task("do the laundry", false);
            var task3 = new Task("buy groceries", true);
            var task4 = new Task("prepare dinner", false);
            var task5 = new Task("read a book", true);
            List<Task> tasks = new List<Task> { task1, task2, task3, task4, task5 };

            TodoList core = new TodoList();

            foreach (var task in tasks)
            {
                core.Add(task);
            }
            var searchResult = core.Search("exercise for 30 min");
            Assert.That(searchResult, Is.EqualTo("Task not found"));
        }

        [Test]
        public void RemoveTask()
        {
            var task1 = new Task("clean your room", false);
            var task2 = new Task("do the laundry", false);
            var task3 = new Task("buy groceries", true);
            var task4 = new Task("prepare dinner", false);
            var task5 = new Task("read a book", true);
            List<Task> tasks = new List<Task> { task1, task2, task3, task4, task5 };

            TodoList core = new TodoList();

            foreach (var task in tasks)
            {
                core.Add(task);
            }
            core.Remove("buy groceries");

            Assert.That(tasks.Count, Is.EqualTo(5));
            Assert.That(core.todolist.Count, Is.EqualTo(4));

            Assert.That(core.Search("buy groceries"), Is.EqualTo("Task not found"));
        }

        [Test]
        public void OrderAlphabeticallyAscending()
        {
            var task1 = new Task("clean your room", false);
            var task2 = new Task("do the laundry", false);
            var task3 = new Task("buy groceries", true);
            var task4 = new Task("prepare dinner", false);
            var task5 = new Task("read a book", true);
            List<Task> tasks = new List<Task> { task1, task2, task3, task4, task5 };

            TodoList core = new TodoList();

            foreach (var task in tasks)
            {
                core.Add(task);
            }

            //var sortedTasks = core.todolist.OrderBy(t => t.task).ToList();
            var sortedTasks = core.SortAsc();
            Assert.That(sortedTasks.First().task, Is.EqualTo(tasks[2].task));
            Assert.That(sortedTasks.Last().task, Is.EqualTo(tasks[4].task));

        }
        [Test]
        public void OrderAlphabeticallyDescending()
        {
            var task1 = new Task("clean your room", false);
            var task2 = new Task("do the laundry", false);
            var task3 = new Task("buy groceries", true);
            var task4 = new Task("prepare dinner", false);
            var task5 = new Task("read a book", true);
            List<Task> tasks = new List<Task> { task1, task2, task3, task4, task5 };

            TodoList core = new TodoList();

            foreach (var task in tasks)
            {
                core.Add(task);
            }

            var sortedTasks = core.SortDesc();
            Assert.That(sortedTasks.First().task, Is.EqualTo(tasks[4].task));
            Assert.That(sortedTasks.Last().task, Is.EqualTo(tasks[2].task));

        }
    }
}