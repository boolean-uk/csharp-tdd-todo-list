using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void AddTestTrue()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
      
            //Assess
            Assert.IsTrue(core.AddTask("test1"));
        }
        [Test]
        public void AddTestFalse()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act

            //Assess
            Assert.IsFalse(core.AddTask(""));
        }
        [Test]
        public void getList()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
            core.AddTask("Test1");
            core.AddTask("Test2");
            var result = core.GetList();
            //Assess
            Assert.NotNull(result);
        }
        [Test]
        public void getListNull()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
            var result = core.GetList();
            //Assess
            Assert.Null(result);
        }
        [Test]
        public void Edit()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
            core.AddTask("Test1");
            core.EditTask("Test1",true);
            //Assess
            Assert.IsTrue(core.todoList["Test1"] == true);
        }
        [Test]
        public void EditNonExistant()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
            core.AddTask("Test10000");
            
            //Assess
            Assert.IsFalse(core.EditTask("Test1", true));
        }

    }
}