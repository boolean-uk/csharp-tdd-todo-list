using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using Task = tdd_todo_list.CSharp.Main.Task;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void FirstTest()
        {
            TodoList core = new TodoList();

            core.Add("test");

            Assert.IsTrue(core.Tasks.Count > 0);
        }

        [Test] 
        public void SecondTest() 
        {
            TodoList core = new TodoList();

            core.Add("test");

            Assert.IsTrue("test\nFalse\n" == core.PrintAll());
        }

        [Test]
        public void ThirdTest()
        {
            TodoList core = new TodoList();

            Task testTask = core.Add("test");
            core.Complete(testTask);

            Assert.IsTrue(testTask.Completed);
            
        }

        [Test]
        public void FourthTest()
        {
            TodoList core = new TodoList();
            core.Add("test");
            Task testTask = core.Add("test2");
            core.Complete(testTask);

            List<Task> tasks = core.GetComplete();

            Assert.IsTrue(tasks.Count == 1 && tasks[0] == testTask);
        }

        [Test]
        public void FifthTest()
        {
            TodoList core = new TodoList();
            Task testTask = core.Add("test");
            core.Complete(testTask);
            testTask = core.Add("test2");

            List<Task> tasks = core.GetIncomplete();

            Assert.IsTrue(tasks.Count == 1 && tasks[0] == testTask);
        }

        [Test]
        public void SixthTest()
        {
            TodoList core = new TodoList();
            core.Add("test1");
            Task testTask = core.Add("test2");
            core.Add("test3");

            Assert.IsTrue(testTask == core.Search("test2"));
        }

        [Test]
        public void SeventhTest()
        {
            TodoList core = new TodoList();
            Task testTask = core.Add("test1");
            core.Remove(testTask);

            Assert.IsTrue(core.Tasks.Count == 0 && !core.Remove(testTask));
        }

        [Test]
        public void EightTest()
        {
            TodoList core = new TodoList();

            core.Add("b");
            core.Add("z");
            core.Add("a");
            core.Add("g");

            Assert.IsTrue("a\nFalse\nb\nFalse\ng\nFalse\nz\nFalse\n" == core.PrintOrderASC());
        }

        [Test]
        public void NinthTest()
        {
            TodoList core = new TodoList();

            core.Add("b");
            core.Add("z");
            core.Add("a");
            core.Add("g");

            Assert.IsTrue("z\nFalse\ng\nFalse\nb\nFalse\na\nFalse\n" == core.PrintOrderDESC());
        }
    }
}