using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        TodoList core = new TodoList();

        [Test]
        public void TestGetTodoList()
        {

            core.todo = new Dictionary<string, bool>
            {
                { "Clean", false },
                { "Sleep", true }
            };

            List<string> expected = ["Clean", "Sleep"];

            Assert.That(core.getTodoList(), Is.EqualTo(expected));

        }

        [Test]
        public void TestAdd()
        {
            core.todo = new Dictionary<string, bool>
            {
                { "Clean", false },
                { "Sleep", true }
            };

            core.addToList("Workout");

            Assert.That(core.todo.ContainsKey("Workout"));

        }

        [Test]
        public void TestToggle()
        {
            core.todo = new Dictionary<string, bool>
            {
                { "Clean", false },
                { "Sleep", true }
            };

            core.toggleTask("Clean");
            Assert.That(core.todo["Clean"], Is.True);

            core.toggleTask("Clean");
            Assert.That(core.todo["Clean"], Is.False);

        }

        [Test]
        public void TestFiltered()
        {
            core.todo = new Dictionary<string, bool>
            {
                { "Clean", false },
                { "Sleep", true },
                { "Workout", false }
            };

            List<string> expectedCompleted = ["Sleep"];
            List<string> expectedIncomplete = ["Clean", "Workout"];

            Assert.That(core.getFilteredTasks(true), Is.EqualTo(expectedCompleted));
            Assert.That(core.getFilteredTasks(false), Is.EqualTo(expectedIncomplete));

        }

        [Test]
        public void TestDeleteTask()
        {
            core.todo = new Dictionary<string, bool>
            {
                { "Clean", false },
                { "Sleep", true },
                { "Workout", false }
            };

            Assert.That(core.todo.ContainsKey("Clean"), Is.True);

            core.deleteTask("Clean");

            Assert.That(core.todo.ContainsKey("Clean"), Is.False);
        }

        [Test]
        public void TestGetTask() 
        {
            core.todo = new Dictionary<string, bool>
            {
                { "Clean", false },
                { "Sleep", true }
            };

            string exists = "Sleep";
            string doesntExist = "Read";

            Assert.That(core.getTask(exists), Is.EqualTo(exists));
            Assert.That(core.getTask(doesntExist), Is.EqualTo("Doesn't exist in Todo-list!"));
        }

        [Test]  
        public void TestGetListOrdered()
        {
            core.todo = new Dictionary<string, bool>
            {
                { "Sleep", true },
                { "Workout", false },
                { "Clean", false }
            };


            List<string> ascending = ["Clean","Sleep", "Workout"];
            List<string> descending = ["Workout", "Sleep", "Clean"];

            Assert.That(core.getListOrdered(true), Is.EqualTo(ascending));
            Assert.That(core.getListOrdered(false), Is.EqualTo(descending));
        }

    }
}