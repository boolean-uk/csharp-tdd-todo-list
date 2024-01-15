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
            Assert.IsNotEmpty(result);
            Assert.IsEmpty(result2);
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
            Assert.IsTrue(core.todoList.FirstOrDefault(p => p.ptask == "Test1").isComplete);

        }
        

        [Test]
        public void getComplete()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
            core.addTask("t1");
            core.addTask("t2");
            var result2 = core.getCompleted();
            core.editTask("t1", true);
            var result1 = core.getCompleted();

            //Assess
            Assert.IsNotEmpty(result1);
            Assert.IsEmpty(result2);

        }
        
        [Test]
        public void getIncomplete()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
            core.addTask("t1");
            core.addTask("t2");
            var result1 = core.getIncompleted();
            core.editTask("t1", true);
            core.editTask("t2", true);

            var result2 = core.getIncompleted();

            //Assess
            Assert.IsNotEmpty(result1);
            Assert.IsEmpty(result2);
        }
        
        [Test]
        public void Search()
        {
            //Arrange
            TodoList core = new TodoList();
            //Act
            core.addTask("t1");

            var result1 = core.search("t1");
            var result2 = core.search("t2");

            //Assess
            Assert.IsNotNull(result1);
            Assert.IsNull(result2);
        }
        [Test]
        public void SortAlphabetInc()
        {
            //Arrange
            TodoList core = new TodoList();
            List<pTask> Correct = new List<pTask>()
            {
                new pTask { ptask = "a", isComplete = false },
                new pTask { ptask = "b", isComplete = false },
                new pTask { ptask = "c", isComplete = false }
            };
            //Act
            core.addTask("b");
            core.addTask("a");
            core.addTask("c");

            var result = core.sortAplhabetInc();

            //Assess
            Assert.AreEqual(Correct.Count, result.Count);

            for (int i = 0; i < Correct.Count; i++)
            {
                Assert.AreEqual(Correct[i].ptask, result[i].ptask);
                Assert.AreEqual(Correct[i].isComplete, result[i].isComplete);
            }
        }
        [Test]
        public void SortAlphabetDesc()
        {
            //Arrange
            TodoList core = new TodoList();
            List<pTask> Correct = new List<pTask>()
            {
                new pTask { ptask = "c", isComplete = false },
                new pTask { ptask = "b", isComplete = false },
                new pTask { ptask = "a", isComplete = false }
            };
            //Act
            core.addTask("b");
            core.addTask("a");
            core.addTask("c");

            var result = core.sortAplhabetInc();

            //Assess
            Assert.AreEqual(Correct.Count, result.Count);

            for (int i = 0; i < Correct.Count; i++)
            {
                Assert.AreEqual(Correct[i].ptask, result[i].ptask);
                Assert.AreEqual(Correct[i].isComplete, result[i].isComplete);
            }
        }
        [Test]
        public void Delete()
        {
            TodoList core = new TodoList();
            core.addTask("a");
            core.addTask("b");
            core.addTask("c");

            // Act
            bool removalResult = core.remove("b");

            // Assert
            Assert.IsTrue(removalResult);
            Assert.AreEqual(2, core.todoList.Count);

            // Verify that "b" is not in the list anymore
            Assert.IsFalse(core.todoList.Any(task => task.ptask == "b"));
        }

    }
}