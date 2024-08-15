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
    }
}