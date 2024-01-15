using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void TestAdd()
        {
            TodoList core = new TodoList();
            TodoTask todo = new TodoTask("Sleep", "ZZZ");
            core.AddTask(todo);

            Assert.NotNull(todo);

        }
        [Test]
        public void TestToggle()
        {
            TodoTask todo = new TodoTask("Sleep", "ZZZ");
            
            todo.ToggleComplete();

            Assert.IsTrue(todo.Complete);
        }

        [Test]
        public void TestShowComplete()
        {
            TodoList core = new TodoList();
            TodoTask todo1 = new TodoTask("Sleep", "ZZZ");
            TodoTask todo2 = new TodoTask("Wake up", "Good morning");
            TodoTask todo3 = new TodoTask("Hustle", "Lesgo");

            core.AddTask(todo1);
            core.AddTask(todo2);
            core.AddTask(todo3);

            todo1.ToggleComplete();
            todo2.ToggleComplete();

            List<TodoTask> completedTasks = core.RetrieveCompleted();

            Assert.AreEqual(completedTasks.Count, 2);
        }

        [Test]
        public void TestShowUncompleted()
        {
            TodoList core = new TodoList();
            TodoTask todo1 = new TodoTask("Sleep", "ZZZ");
            TodoTask todo2 = new TodoTask("Wake up", "Good morning");
            TodoTask todo3 = new TodoTask("Hustle", "Lesgo");
            TodoTask todo4 = new TodoTask("Bustle", "Lesgo");

            core.AddTask(todo1);
            core.AddTask(todo2);
            core.AddTask(todo3);
            core.AddTask(todo4);

            todo1.ToggleComplete();

            List<TodoTask> unCompletedTasks = core.RetrieveUncompleted();

            Assert.AreEqual(unCompletedTasks.Count, 3);
        }
        
        [Test]
        public void TestSearchAndOutput()
        {
            TodoList core = new TodoList();
            TodoTask todo1 = new TodoTask("Sleep", "ZZZ");
            TodoTask todo2 = new TodoTask("Wake up", "Good morning");
            TodoTask todo3 = new TodoTask("Hustle", "Lesgo");
            TodoTask todo4 = new TodoTask("Bustle", "Lesgo");

            core.AddTask(todo1);
            core.AddTask(todo2);
            core.AddTask(todo3);

            string search = core.Search(todo4);

            Assert.AreEqual(search, "The task Bustle was not found in your to-do-list");
        }

        [Test]
        public void TestRemove()
        {
            TodoList core = new TodoList();

            TodoTask todo1 = new TodoTask("Sleep", "ZZZ");
            TodoTask todo2 = new TodoTask("Wake up", "Good morning");
            TodoTask todo3 = new TodoTask("Hustle", "Lesgo");
            TodoTask todo4 = new TodoTask("Bustle", "Lesgo");

            core.AddTask(todo1);
            core.AddTask(todo2);
            core.AddTask(todo3);
            core.AddTask(todo4);

            core.RemoveTask(todo1);

            Assert.AreEqual(core.Tasks.Count, 3);

        }

        [Test]
        public void TestAlphabeticalOrder()
        {
            TodoList core = new TodoList();
            TodoTask todo1 = new TodoTask("Sleep", "ZZZ");
            TodoTask todo2 = new TodoTask("Wake up", "Good morning");
            TodoTask todo3 = new TodoTask("Hustle", "Lesgo");
            TodoTask todo4 = new TodoTask("Bustle", "Lesgo");

            core.AddTask(todo1);
            core.AddTask(todo2);
            core.AddTask(todo3);
            core.AddTask(todo4);

            List<TodoTask> alph = core.ListTaskAlphabetically();

            Assert.AreEqual(alph[0].Name, "Bustle");
        }

        [Test]
        public void TestReverseAlphabeticalOrder()
        {
            TodoList core = new TodoList();
            TodoTask todo1 = new TodoTask("Sleep", "ZZZ");
            TodoTask todo2 = new TodoTask("Wake up", "Good morning");
            TodoTask todo3 = new TodoTask("Hustle", "Lesgo");
            TodoTask todo4 = new TodoTask("Bustle", "Lesgo");

            core.AddTask(todo1);
            core.AddTask(todo2);
            core.AddTask(todo3);
            core.AddTask(todo4);

            List<TodoTask> alph = core.ListTaskDescending();

            Assert.AreEqual(alph[0].Name, "Wake up");
        }
    }
}