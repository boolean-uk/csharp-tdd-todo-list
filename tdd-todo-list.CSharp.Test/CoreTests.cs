using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void addTask()
        {
            //Arrange:
            TodoList core = new TodoList();


            // Act:
            core.addTask("Help me");
            core.addTask("Help me2");
            Dictionary<string, string> testList = new Dictionary<string, string> {
                {"Help me","incompleted" },
                {"Help me2","incompleted" }
            };
            var result = core._toDoList;

            //Assert:
            Assert.AreEqual(testList, result);
            Assert.Pass();
        }

        [Test]
        public void testRemoveTask()
        {
            //Arrange:
            TodoList core = new TodoList();


            // Act:
            core.addTask("Help me");
            core.addTask("Help me2");
            Dictionary<string, string> testList = new Dictionary<string, string> {
                {"Help me","incompleted" },
                
            };
            core.removeTask("Help me2");
            var result = core._toDoList;

            //Assert:
            Assert.AreEqual(testList, result);
            Assert.Pass();
        }

        [Test]
        public void testSeraching1()
        {
            //Arrange:
            TodoList core = new TodoList();


            // Act:
            core.addTask("Help me");
            core.addTask("Help me2");
            Dictionary<string, string> testList = new Dictionary<string, string> {
                {"Help me","incompleted" },
                {"Help me2","incompleted" }
            };
            var result = core._toDoList;

            //Assert:
            Assert.IsTrue(core.searchingTask("Help me") == "In the toDoList");
            Assert.Pass();
        }

        [Test]
        public void testSeraching2()
        {
            //Arrange:
            TodoList core = new TodoList();


            // Act:
            core.addTask("Help me");
            core.addTask("Help me2");
            Dictionary<string, string> testList = new Dictionary<string, string> {
                {"Help me","incompleted" },
                {"Help me2","incompleted" }
            };
            var result = core._toDoList;

            //Assert:
            Assert.IsTrue(core.searchingTask("Help meee") == "it wasn't found");
            Assert.Pass();
        }

        [Test]
        public void testChangeStatus()
        {
            //Arrange:
            TodoList core = new TodoList();


            // Act:
            core.addTask("Help me");
            core.addTask("Help me2");
            Dictionary<string, string> testList = new Dictionary<string, string> {
                {"Help me","completed" },
                {"Help me2","incompleted" }
            };
            core.changeStatus("Help me", "completed");
            var result = core._toDoList;

            //Assert:
            Assert.AreEqual(testList, result);
            Assert.Pass();
        }

        [Test]
        public void testSortCompleted()
        {
            //Arrange:
            TodoList core = new TodoList();


            // Act:
            core.addTask("Help me");
            core.addTask("Help me2");
            core.addTask("Help me3");
            core.addTask("Help me4");
            core.addTask("Help me5");
            List<string> testList = new List<string> {
                {"Help me3"},
                {"Help me5" },
                {"Help me" },
                {"Help me2" },
                {"Help me4" },

            };
            core.changeStatus("Help me5", "completed");
            core.changeStatus("Help me3", "completed");
            var result = core.showTask("completed");

            //Assert:
            Assert.AreEqual(testList, result);
            Assert.Pass();
        }

        [Test]
        public void testSortInCompleted()
        {
            //Arrange:
            TodoList core = new TodoList();


            // Act:
            core.addTask("Help me");
            core.addTask("Help me2");
            core.addTask("Help me3");
            core.addTask("Help me4");
            core.addTask("Help me5");
            List<string> testList = new List<string> {
                {"Help me"},
                {"Help me2" },
                {"Help me4" },
                {"Help me3" },
                {"Help me5" }

            };
            core.changeStatus("Help me5", "completed");
            core.changeStatus("Help me3", "completed");
            var result = core.showTask("incompleted");

            //Assert:
            Assert.AreEqual(testList, result);
            Assert.Pass();
        }


        [Test]
        public void testSortAscending()
        {
            //Arrange:
            TodoList core = new TodoList();


            // Act:
            core.addTask("EHelp me");
            core.addTask("DHelp me2");
            core.addTask("CHelp me3");
            core.addTask("BHelp me4");
            core.addTask("AHelp me5");
            List<string> testList = new List<string> {
                {"AHelp me5"},
                {"BHelp me4" },
                {"CHelp me3" },
                {"DHelp me2" },
                {"EHelp me" }

            };
      
            var result = core.showTask("ascending");

            //Assert:
            Assert.AreEqual(testList, result);
            Assert.Pass();
        }

        [Test]
        public void testSortDescending()
        {
            //Arrange:
            TodoList core = new TodoList();


            // Act:
            core.addTask("EHelp me");
            core.addTask("DHelp me2");
            core.addTask("CHelp me3");
            core.addTask("BHelp me4");
            core.addTask("AHelp me5");
            List<string> testList = new List<string> {
                {"EHelp me" },
                {"DHelp me2" },
                {"CHelp me3" },
                {"BHelp me4" },
                {"AHelp me5"}

            };

            var result = core.showTask("descending");

            //Assert:
            Assert.AreEqual(testList, result);
            Assert.Pass();
        }


    }
}