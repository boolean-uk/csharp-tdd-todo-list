using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void addingTasks()
        {
            TodoList core = new TodoList();

            core.addTask("clean your room");
            int result = core.listSize();
            int expected = 1;



            Assert.IsTrue(result == expected);
        }

        [Test]
        public void viewTasks()
        {
            TodoList core = new TodoList();


            core.addTask("clean your room");
            core.addTask("do dishes");
            core.addTask("do homework");
            core.addTask("do groceries");
            core.changeStatus("do dishes");

            string result = core.showList();
            string expected =

                " clean your room: incomplete\n" + " "
               + "do dishes: complete\n" + " "
                + "do homework: incomplete\n" + " "
               + "do groceries: incomplete\n";



            Assert.IsTrue(result == expected);
        }
        [Test]

        public void SetStatus()
        {
            TodoList core = new TodoList();
            core.addTask("clean your room");
            core.addTask("do dishes");
            core.addTask("do homework");
            core.addTask("do groceries");
            string result = core.changeStatus("do homework");
            result = core.changeStatus("do homework");
            string expected = "incomplete";
            Assert.IsTrue(result == expected);

        }

        [Test]
        public void OnlyCompleted()
        {
            //arrange
            TodoList core = new TodoList();


            //action
            core.addTask("clean your room");
            core.addTask("do dishes");
            core.addTask("do homework");
            core.addTask("do groceries");

            core.changeStatus("clean your room");
            core.changeStatus("do homework");
            core.changeStatus("do groceries");
            //her er resultat
            List<ToDoTask> result = core.GetCompletedList();
            // hva skal fasiten være 
            //hva faen skal jeg sammenlikne resultatet med,
            //






            Assert.That(result.Count == 3);




        }
        [Test]
        public void OnlyInCompleted()
        {
            //arrange
            TodoList core = new TodoList();


            //action
            core.addTask("clean your room");
            core.addTask("do dishes");
            core.addTask("do homework");
            core.addTask("do groceries");

            core.changeStatus("clean your room");
            core.changeStatus("do homework");
            core.changeStatus("do groceries");

            core.changeStatus("do homework");
            core.changeStatus("do groceries");

            //her er resultat
            List<ToDoTask> result = core.GetIncompletedList();
            // hva skal fasiten være 
            //hva faen skal jeg sammenlikne resultatet med,
            //






            Assert.That(result.Count == 3);




        }

        [Test]
        public void TaskNotExists()
        {
            TodoList core = new TodoList();
            core.addTask("clean your room");
            core.addTask("do dishes");
            core.addTask("do homework");
            core.addTask("do groceries");
            string taskname = "do push ups";


            string result = core.SearchTask(taskname);
            string expected = "this task does not exist";

            Assert.That(result == expected);

        }
        [Test]
        public void TaskExists()
        {
            TodoList core = new TodoList();
            core.addTask("clean your room");
            core.addTask("do dishes");
            core.addTask("do homework");
            core.addTask("do groceries");
            string taskname = "do groceries";


            string result = core.SearchTask(taskname);
            string expected = "do groceries";

            Assert.That(result == expected);

        }
        [Test]
        public void RemovingFromList()
        {
            TodoList core = new TodoList();
            core.addTask("clean your room");
            core.addTask("do dishes");
            core.addTask("do homework");
            core.addTask("do groceries");
            string expected = "do dishes";


            string result = core.RemoveTask("do dishes");

            Assert.That(result == expected && core.listSize() == 3);


        }
        [Test]

        public void AlphabeticalAscending()
        {
            TodoList core = new TodoList();
            core.addTask("clean your room");
            core.addTask("do dishes");
            core.addTask("a little nap");
            core.addTask("do groceries");

            List<ToDoTask> tempresult = core.SortAlphabetical();
            List<string> result = new List<string>();

            foreach (ToDoTask task in tempresult)
            {
                result.Add(task.Name);
            }


            List<string> expected = new List<string>()
            {
                "a little nap",
                "clean your room",
                "do dishes",
                "do groceries",
            };
            Assert.AreEqual(expected, result);



        }
        [Test]
        public void AlphabeticalDescending()
        {
            TodoList core = new TodoList();
            core.addTask("clean your room");
            core.addTask("do dishes");
            core.addTask("a little nap");
            core.addTask("do groceries");

            List<ToDoTask> tempresult = core.SortAlphabeticalDescending();
            List<string> result = new List<string>();

            foreach (ToDoTask task in tempresult)
            {
                result.Add(task.Name);
            }


            List<string> expected = new List<string>()
            {

                "do groceries",
                "do dishes",
                "clean your room",
                "a little nap",
            };
            Assert.AreEqual(expected, result);


        }
    }

    }