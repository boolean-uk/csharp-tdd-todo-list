using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTest()
        {
            TodoList core = new TodoList();
            string task1 = "Clean Room";
            core.Add(task1);



            Assert.That(core._taskDictionary.Count > 0);
        }

        [Test]
        public void StatusTest()
        {
            TodoList core = new TodoList();
            string task1 = "Clean Room";
            string task2 = "Solve space-time continueum";
            core.Add(task1);
            core.Add(task2);

            core.SetStatus(task1);
            core.SetStatus(task2);
            core.SetStatus(task2);


            Assert.That(core._taskDictionary.First().Value == true);
            Assert.That(core._taskDictionary.Last().Value == false);

        }
        [Test]
        public void showCompleteTest()
        {
            TodoList core = new TodoList();
            string task1 = "Clean Room";
            string task2 = "Solve space-time continueum";

            core.Add(task1);
            core.Add(task2);

            core.SetStatus(task1);

            core.ShowCompleted();

            Assert.That(core.ShowCompleted().Contains(task1));

        }

        [Test]
        public void showCompleteTestFail()
        {
            TodoList core = new TodoList();
            string task1 = "Clean Room";
            string task2 = "Solve space-time continueum";

            core.Add(task1);
            core.Add(task2);

            // core.SetStatus(task1);

            core.ShowCompleted();

            Assert.That(core.ShowCompleted().Equals("There are no complete tasks"));

        }
        [Test]
        public void showIncompleteTest()
        {
            TodoList core = new TodoList();
            string task1 = "Clean Room";
            string task2 = "Solve space-time continueum";

            core.Add(task1);
            core.Add(task2);

            core.SetStatus(task1);

            core.ShowIncomplete();

            Assert.That(core.ShowIncomplete().Contains(task2));

        }

        [Test]
        public void searchTest()
        {
            TodoList core = new TodoList();
            string task1 = "Clean Room";
            string task2 = "Solve space-time continueum";

            core.Add(task1);
            core.Add(task2);

            core.SetStatus(task1);

            core.Search(task2);

            Assert.That(core.Search(task2).Equals("Solve space-time continueum"));

        }

        [Test]
        public void removeTest()
        {
            TodoList core = new TodoList();
            string task1 = "Clean Room";
            string task2 = "Solve space-time continueum";

            core.Add(task1);
            core.Add(task2);

            core.SetStatus(task1);

            core.Remove(task1);

            Assert.That(!core._taskDictionary.Keys.Contains(task1));

        }

        [Test]
        public void alphabeticalTest()
        {
            TodoList core = new TodoList();
            string task1 = "Clean Room";
            string task2 = "Solve space-time continueum";
            string task3 = "Do homework";
            string task4 = "Beat Melania in Elden Ring";

            core.Add(task1);
            core.Add(task2);
            core.Add(task3);
            core.Add(task4);
            core.ShowAlphabeticalList();

            Assert.That(!core.ShowAlphabeticalList().Equals("There are no tasks to sort"));
            Assert.That(core.ShowAlphabeticalList().First().Equals(task4));

        }

        [Test]
        public void alphabeticaDescendingTest()
        {
            TodoList core = new TodoList();
            string task1 = "Clean Room";
            string task2 = "Solve space-time continueum";
            string task3 = "Do homework";
            string task4 = "Beat Melania in Elden Ring";

            core.Add(task1);
            core.Add(task2);
            core.Add(task3);
            core.Add(task4);
            core.ShowDescendingAlphabeticalList();

            Assert.That(!core.ShowDescendingAlphabeticalList().Equals("There are no tasks to sort"));
            Assert.That(core.ShowDescendingAlphabeticalList().First().Equals(task2));

        }
    }
}