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
        /*
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