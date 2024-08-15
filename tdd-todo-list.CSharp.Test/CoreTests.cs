using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [TestCase("Todo List")]
        public void addTaskTest(UserTask taskname)
        {
            //arrange
            TodoList todo = new TodoList();
            string expected = "Todo List";

            //act
            string result = todo.add(taskname);

            //assert
            Assert.IsTrue(expected == result);
            
        }
        
    }
}