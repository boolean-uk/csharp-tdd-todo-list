using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void AddTest()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act

            //Assess
            Assert.IsTrue(core.addTask("t1"));
            Assert.IsFalse(core.addTask("t1"));
            Assert.IsTrue(core.addTask("t2"));

        }
        
        [Test]
        public void getList()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
            var result2 = core.getList(); //empty list
            core.addTask("Test1");
            core.addTask("Test2");
            var result = core.getList();
            //Assess
            Assert.NotNull(result);
            Assert.Null(result2);
        }
        
        [Test]
        public void Edit()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
            core.addTask("Test1");
            var result = core.editTask("Test1", true);
            var result2 = core.editTask("t2", true);
            //Assess
            Assert.IsTrue(result);
            Assert.IsFalse(result2);
            //Assert.IsTrue()
        }
        /*
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

        [Test]
        public void getComplete()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
            core.AddTask("t1");
            core.AddTask("t2");
            core.EditTask("t1", true);
            var result = core.getCompleteTasks();

            //Assess
            Assert.IsTrue(result.ContainsKey("t1"));
        }
        [Test]
        public void getCompleteFalse()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
            core.AddTask("Test1");
            core.AddTask("t2");
            var result = core.getCompleteTasks();

            //Assess
            Assert.IsNull(result);
        }
        [Test]
        public void getIncomplete()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
            core.AddTask("t1");
            core.AddTask("t2");
            core.EditTask("t1", true);
            var result = core.getIncompleteTasks();

            //Assess
            Assert.IsTrue(result.ContainsKey("t2"));
        }
        [Test]
        public void getIncompleteFalse()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
            core.AddTask("t1");
            core.EditTask("t1", true);

            var result = core.getIncompleteTasks();

            //Assess
            Assert.IsNull(result);
        }
        [Test]
        public void Search()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
            core.AddTask("t1");

            var result = core.Search("t1");

            //Assess
            Assert.IsTrue(result);
        }*/

    }
}