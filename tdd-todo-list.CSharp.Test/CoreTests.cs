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
            Assert.IsTrue (task == core.ToDoDict[core.TaskIDs[0]].TaskHolder);
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
            string[] resulted = core.PrintAll();


            //assert
            Assert.AreEqual(expected, resulted.ToList());

        }
        
        [Test]
        public void AditionalTestPrint()
        {
            //This test checks that method returns 
            TodoList core = new TodoList();


            string expected = "There is no tasks in the todo list";
            

            //run
            string[] resulted = core.PrintAll();


            //assert
            Assert.AreEqual(expected, resulted[0]);

        }
        [TestCase("task1", true)]
        public void ChangeStatusTest(string task, bool status)
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
            Assert.IsTrue(core.ToDoDict[core.TaskIDs[1]].IsComplete == status);
        }
        
        [TestCase (new[] { "1", "3" }, false)]
        [TestCase(new[] { "2" }, true)]
        public void ShowTest(string[] expected, bool status)
        {
            //init
            TodoList core = new TodoList();
            core.Add("1");
            core.Add("2");
            core.Add("3");
            core.ChangeStatus("2");
            
            List<string> expectedList = expected.ToList();

            //run
            List<string> computed = core.Show(status);

            //assert
            Assert.IsTrue(expected.SequenceEqual(computed));
        }
        [TestCase("1", "Task is not found")]
        public void SearchTest(string searchParameter, string computedMessage)
        {
            //init
            TodoList core = new TodoList();
            core.Add("task 1");
            core.Add("task 2");
            core.Add("task 3");

            //run
            string computed = core.Search(searchParameter);

            //assert

            Assert.That(computed, Is.EqualTo(computedMessage));
        }
        
        [TestCase("task 4", false)]
        [TestCase("task 2", true)]
        public void Remove(string task, bool expected)
        {
            //init
            TodoList core = new TodoList();
            core.Add("task 1");
            core.Add("task 2");
            core.Add("task 3");

            //run
            bool computed = core.Remove(task);


            //assert
            Assert.IsTrue(expected == computed);
        }
        
        [TestCase("Ascend", new[] { "A", "B", "C" })]
        [TestCase("Descend", new[] { "C", "B", "A" })]
        public void Sort(string order, string[] expected)
        {
            //init
            TodoList core = new TodoList();
            core.Add("B");
            core.Add("C");
            core.Add("A");
            List<string> list = expected.ToList();

            //run
            List<string> sortedTasks = core.Sort(order);

            //assert
            Assert.IsTrue(list.SequenceEqual(sortedTasks));

        }
       

    }
}