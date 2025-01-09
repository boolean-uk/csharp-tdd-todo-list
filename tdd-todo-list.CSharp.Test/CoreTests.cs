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
    }
}