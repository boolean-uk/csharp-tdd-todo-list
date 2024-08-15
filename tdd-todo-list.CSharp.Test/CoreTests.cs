using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
           

        [TestCase("solve three gods problem")]
        public void AddTaskTest(string task)
        {
            //init
            TodoList core = new TodoList();

            //run
            core.Add(task);

            //assert
            Assert.Contains(task, core.ToDoDict.Keys);
        }
        [Test]
        public void TestPrint()
        {
            //This test checks that method returns all of the tasks in the list
            //init
            TodoList core = new TodoList();
            core.Add("task");
            core.Add("task1");
            core.Add("task2");
            core.Add("task3");

            List<string> expected = new List<string>()
            {
                "task",
                "task1",
                "task2",
                "task3"
            };

            //run
            string[] resulted = core.Print();


            //assert
            Assert.AreEqual(expected, resulted.ToList());

        }
        [Test]
        public void AditionalTestPrint()
        {
            //This test checks that method returns 
            TodoList core = new TodoList();
           

            List<string> expected = new List<string>()
            {
                "There is no tasks in the todo list"
            };

            //run
            string[] resulted = core.Print();


            //assert
            Assert.AreEqual(expected, resulted.ToList());

        }
        [TestCase("task1", "complete")]
        public void ChangeStatusTest(string task, string status)
        {
            //init
            TodoList core = new TodoList();
            core.Add("task");
            core.Add("task1");
            core.Add("task2");
            core.Add("task3");

            //run
            core.ChangeStatus(task);

            //assert
            Assert.IsTrue(core.ToDoDict[task] == status);
        }
        [TestCase(new[] { "1", "3" }, "Complete")]
        public void ShowTest(string[] expected, string status)
        {
            //init
            TodoList core = new TodoList();
            core.Add("1");
            core.Add("2");
            core.Add("3");
            core.ChangeStatus("1");
            core.ChangeStatus("3");
            List<string> expectedList = new List<string>();

            foreach (string item in expected)
            {
                expectedList.Add(item);
            }

            //run
            List<string> computed = core.Show(status);

            //assert
            Assert.IsTrue(computed == expectedList);
        }
    }
}