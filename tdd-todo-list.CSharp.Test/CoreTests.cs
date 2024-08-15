using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

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
            bool result = core.Add(task);

            //assert
        }
    }
}