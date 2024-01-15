using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void FirstTest()
        {
            TodoList core = new TodoList();
            Assert.Pass();
        }
        [Test]
        public void SecondTest()
        {
            TodoList core = new TodoList();
            bool addTest = core.addTask("Cleaning");
            Assert.IsTrue(addTest);
        }
        [Test]
        public void ThirdTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cleaning");
            Assert.IsTrue(core.viewTasks() == "Cleaning,False");
        }
        [Test]
        public void FourthTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cleaning");
            core.addTask("Cooking");
            Assert.IsTrue(core.viewTasks() == "Cleaning,False,Cooking,False");
        }
        [Test]
        public void FifthTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cleaning");
            core.addTask("Cooking");
            core.switchStatus("Cooking");
            Assert.IsTrue(core.viewTasks() == "Cleaning,False,Cooking,True");
        }
        [Test]
        public void SixthTest()
        {
            TodoList core = new TodoList();
            TodoList core2 = new TodoList();
            core.addTask("Cleaning");
            core.addTask("Cooking");
            core.addTask("Dusting");
            core.switchStatus("Cooking");
            core.switchStatus("Dusting");

            core2.addTask("Cooking");
            core2.addTask("Dusting");
            core2.switchStatus("Cooking");
            core2.switchStatus("Dusting");

            Assert.IsTrue(core.onlyCompleted()[0].Name == core2.onlyCompleted()[0].Name);
            Assert.IsTrue(core.onlyCompleted()[1].Name == core2.onlyCompleted()[1].Name);
            Assert.IsTrue(core.onlyCompleted()[0].IsCompleted == core2.onlyCompleted()[0].IsCompleted);
            Assert.IsTrue(core.onlyCompleted()[1].IsCompleted == core2.onlyCompleted()[1].IsCompleted);
        }
        [Test]
        public void SeventhTest()
        {
            TodoList core = new TodoList();
            TodoList core2 = new TodoList();
            core.addTask("Cleaning");
            core.addTask("Cooking");
            core.addTask("Dusting");
            core.switchStatus("Cooking");

            core2.addTask("Cleaning");
            core2.addTask("Dusting");


            Assert.IsTrue(core.onlyIncomplete()[0].Name == core2.onlyIncomplete()[0].Name);
            Assert.IsTrue(core.onlyIncomplete()[1].Name == core2.onlyIncomplete()[1].Name);
            Assert.IsTrue(core.onlyIncomplete()[0].IsCompleted == core2.onlyIncomplete()[0].IsCompleted);
            Assert.IsTrue(core.onlyIncomplete()[1].IsCompleted == core2.onlyIncomplete()[1].IsCompleted);
        }
        [Test]
        public void EigthTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cleaning");
            string searchTest = core.search("Cleaning");

            Assert.IsTrue(searchTest == "Task exists.");
        }
        [Test]
        public void NinthTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cleaning");
            string searchTest = core.search("Cooking");

            Assert.IsTrue(searchTest == "Task does not exist.");
        }
        [Test]
        public void TenthTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cleaning");
            bool removeTest = core.removeTask("Cleaning");

            Assert.IsTrue(removeTest);
            Assert.IsTrue(core.viewTasks() == "");
        }
        [Test]
        public void EleventhTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cleaning");
            bool removeTest = core.removeTask("Cooking");

            Assert.IsFalse(removeTest);
            Assert.IsTrue(core.viewTasks() == "Cleaning,False");
        }
        [Test]
        public void TwelthTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cleaning");
            core.addTask("Cooking");
            core.addTask("Dusting");
            
            Assert.IsTrue(core.viewAlphabet() == "Cleaning,False,Cooking,False,Dusting,False");
        }
        [Test]
        public void ThirteenthTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cleaning");
            core.addTask("Cooking");
            core.addTask("Dusting");

            Assert.IsTrue(core.viewDescend() == "Dusting,False,Cooking,False,Cleaning,False");
        }




    }
}