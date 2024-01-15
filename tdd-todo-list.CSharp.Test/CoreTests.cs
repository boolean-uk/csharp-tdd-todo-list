using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void addTaskTodo()
        {
            TodoList core = new TodoList();

            string task = "Feed the Fishes";
            core.addTask(task);

            Assert.IsTrue(core.TaskList.Keys.Contains(task));

        }

        [Test]
        public void getList()
        {
            TodoList core = new TodoList();
            string task = "Feed the Fishes";
            core.addTask(task);
            List<string> Result = core.getTotalList();
            
            Assert.IsTrue(Result.Count > 0);
            Assert.IsTrue(core.TaskList.Count == Result.Count);
        }

        [Test]
        public void getIncomplete()
        {
            TodoList core = new TodoList();

            core.addTask("Something fishy", true);
            core.addTask("Something nice", false);

            Dictionary<string, bool> testList = core.TaskList;
            List<string> Result = core.getIncomplete();
            if (core.TaskList.TryGetValue != null && core.TaskList.Values.Contains(true))
            {
                Assert.IsTrue(core.TaskList.Count != Result.Count);
            } else if (core.TaskList.Values.Contains(false) && (core.TaskList.Values.Contains(true) == false))
            {
                Assert.IsTrue(core.TaskList.Count == Result.Count);
            }

            Assert.AreEqual(false, Result.Contains("Something fishy"));
            Assert.AreEqual(true, Result.Contains("Something nice"));


        }
        
        [TestCase("Eat icecream", false)]
        [TestCase("Ice skating", true)]
        [TestCase("", false)]
        [TestCase("Something fishy", true)]
        [TestCase("Something nice", false)]
        public void getCompletedTasks(string task, bool completed)
        {
            TodoList core = new TodoList();

            
            core.addTask(task, completed);

            Dictionary<string, bool> testList = core.TaskList;
            List<string> Result = core.getCompleted();
            if (core.TaskList.TryGetValue != null && core.TaskList.Values.Contains(false))
            {
                Assert.IsTrue(core.TaskList.Count != Result.Count);
            }
            else if (core.TaskList.Values.Contains(true) && (core.TaskList.Values.Contains(false) == false))
            {
                Assert.IsTrue(core.TaskList.Count == Result.Count);
            }

            Assert.AreEqual(completed == true , Result.Contains(task));
            Assert.AreNotEqual(completed == false, Result.Contains(task));


        }

        [TestCase("sand the flowers", false)]
        [TestCase("Buy milk", true)]
        [TestCase("", false)]
        [TestCase("Something fishy", true)]
        [TestCase("Have a coffe break", false)]
        public void SearchForTask(string task, bool addOrNot)
        {
            TodoList core = new TodoList();

            if (addOrNot) {
                core.addTask(task);
            }

            List<string> TotalList = core.getTotalList();
            string Result = core.findTask(task);


            Assert.AreEqual(addOrNot, TotalList.Contains(task));
            Assert.That((addOrNot == true).Equals(Result == $"You have the task {task} in your list") || (addOrNot == false).Equals(Result == "The requested task wasn't found in your list"));
 

        }


        [TestCase("sand the flowers")]
        [TestCase("Buy milk")]
        [TestCase("")]
        [TestCase("Something fishy")]
        [TestCase("Have a coffe break")]
        public void RemoveTaskFromList(string task)
        {
            TodoList core = new TodoList();
     
                core.addTask(task);
            Assert.IsTrue(core.TaskList.Keys.Contains(task));
           
            List<string> TotalList = core.getTotalList();

           core.removeTask(task);

            List<string> Result = core.getTotalList();
            
            Assert.IsFalse(Result.Contains(task));
            Assert.IsFalse(TotalList == Result);
            Assert.IsFalse(core.removeTask(task));
            
        }

        [Test]
        public void SortListAscending()
        {
            TodoList core = new TodoList();

            core.addTask("sand");
            core.addTask("Buy");
            core.addTask("Run");
            core.addTask("Alter");
            core.addTask("Have a coffe break");

            List<string> AscendingList = ["Alter","Buy","Have a coffe break", "Run", "sand"];

            List<string> Result = core.getListAscending();
                 
            Assert.IsTrue(Result.Count == AscendingList.Count);
            Assert.IsTrue(Result[0] == AscendingList[0]);

        }


        [Test]
        public void SortListDescending()
        {
            TodoList core = new TodoList();

            core.addTask("sand");
            core.addTask("Buy");
            core.addTask("Run");
            core.addTask("Alter");
            core.addTask("Have a coffe break");

            List<string> AscendingList = ["Alter", "Buy", "Have a coffe break", "Run", "sand"];
            List<string> DescendingList = AscendingList.OrderByDescending(x => x).ToList();

            List<string> Result = core.getListDescending();

            Assert.IsTrue(Result.Count == AscendingList.Count);
            Assert.IsTrue(Result[0] == DescendingList[0]);

        }



    }
}