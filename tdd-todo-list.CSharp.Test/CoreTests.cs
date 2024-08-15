using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [TestCase("task1")]
        public void addTaskTest(string taskname)
        {
            //arrange
            UserTask task1 = new UserTask();
            task1.taskname = taskname;

            TodoList todo = new TodoList();
            string expected = "task1";

            //act
            string result = todo.Add(task1);

            //assert
            Assert.IsTrue(expected == result);
            
        }
        
    }
}