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
            Assert.Contains(task, core.ToDoList.Keys);
        }
        [Test]
        public void TestPrint()
        {
            //init
            TodoList core = new TodoList();
            core.Add("task");
            core.Add("task1");
            core.Add("task3");
            core.Add("task4");

            List<string> expected = new List<string>()
            {
                "task1",
                "task2",
                "task3",
                "task4"
            };

            //run
            string[] resulted = core.Print();


            //assert
            Assert.Contains(expected, resulted);

        }
    }
}