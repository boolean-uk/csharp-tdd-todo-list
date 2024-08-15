using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [TestCase("Clean bathroom", true)]
        [TestCase("", false)]
        public void TestAddTask(string str, bool expected)
        {
            TodoList core = new TodoList();
            TodoTask t = new TodoTask(str);
            
            bool isAdded = core.AddTask(t);
            
            Assert.That(isAdded == expected);
        }



        [TestCase("Go fishing", true)]
        [TestCase("Take out garbage", false)]
        public void TestDeleteTask(string str, bool expected)
        {
            TodoList core = new TodoList();

            // Creates and adds a base of two tasks 
            TodoTask t1 = new TodoTask("Clean the car");
            TodoTask t2 = new TodoTask("Vacuum the shower");
            core.AddTask(t1);
            core.AddTask(t2);

            // Only add the testcase task if it is expected to be removed
            TodoTask t3 = new TodoTask(str);
            if (expected)
            {
                core.AddTask(t3);
            }

            // Checks to see if removing testcase task is successfull or not
            bool isDeleted = core.RemoveTask(t3);
            
            Assert.That(isDeleted == expected);

        }
    }
}