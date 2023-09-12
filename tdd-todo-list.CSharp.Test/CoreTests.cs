using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddATaskTest()
        {
            TodoList core = new TodoList();
            Assert.IsTrue(core.add("write code"));
            Assert.IsTrue(core.Tasks.Count == 1);
        }

        [Test]
        public void AddATaskTwiceTest()
        {
            TodoList core = new TodoList();
            Assert.IsTrue(core.add("write code"));
            Assert.IsFalse(core.add("write code"));
            Assert.IsTrue(core.Tasks.Count == 1);
        }

        [Test]
        public void AddTasksTest()
        {
            TodoList core = new TodoList();
            Assert.IsTrue(core.add("write code"));
            Assert.IsTrue(core.add("git commit"));
            Assert.IsTrue(core.add("git push"));
            Assert.IsTrue(core.add("create a pull request"));
            Assert.IsFalse(core.add("create a pull request"));
            Assert.IsTrue(core.Tasks.Count == 4);
        }

        [Test]
        public void TaskTest()
        {
            string[] tasks = {"write code", "git commit", "git push", "create a pull request"};
            TodoList core = new TodoList();

            foreach (string task in tasks)
            {
                core.add(task);
            }

            Dictionary<string, bool> result = core.tasks();

            foreach (string task in tasks)
            {
                Assert.IsTrue(result[task] == false);
            }
        }

        [Test]
        public void ChangeStatusTest()
        {
            string[] tasks = {"write code", "git commit", "git push", "create a pull request"};
            TodoList core = new TodoList();

            foreach (string task in tasks)
            {
                core.add(task);
            }

            Assert.IsTrue(core.changeStatus(tasks[0]));
            Assert.IsTrue(core.changeStatus(tasks[3]));
            Assert.IsTrue(core.changeStatus(tasks[0]));
            Assert.IsFalse(core.changeStatus("sth not in todo list"));
        }

        [Test]
        public void CompleteTasksTest()
        {
            string[] tasks = {"write code", "git commit", "git push", "create a pull request"};
            TodoList core = new TodoList();
            Dictionary<string, bool> result;

            foreach (string task in tasks)
            {
                core.add(task);
            }

            core.changeStatus(tasks[0]);
            core.changeStatus(tasks[3]);
            result = core.completeTasks();
            Assert.IsTrue(result.Count == 2);
            Assert.IsTrue(result.ContainsKey("write code"));
            Assert.IsTrue(result.ContainsKey("create a pull request"));
            Assert.IsFalse(result.ContainsKey("git commit"));
            Assert.IsFalse(result.ContainsKey("git push"));

            core.changeStatus(tasks[0]);
            result = core.completeTasks();
            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result.ContainsKey("create a pull request"));
            Assert.IsFalse(result.ContainsKey("write code"));
            Assert.IsFalse(result.ContainsKey("git commit"));
            Assert.IsFalse(result.ContainsKey("git push"));
        }

        [Test]
        public void IncompleteTasksTest()
        {
            string[] tasks = {"write code", "git commit", "git push", "create a pull request"};
            TodoList core = new TodoList();
            Dictionary<string, bool> result;

            foreach (string task in tasks)
            {
                core.add(task);
            }

            core.changeStatus(tasks[0]);
            core.changeStatus(tasks[3]);
            result = core.incompleteTasks();
            Assert.IsTrue(result.Count == 2);
            Assert.IsFalse(result.ContainsKey("write code"));
            Assert.IsFalse(result.ContainsKey("create a pull request"));
            Assert.IsTrue(result.ContainsKey("git commit"));
            Assert.IsTrue(result.ContainsKey("git push"));

            core.changeStatus(tasks[0]);
            result = core.incompleteTasks();
            Assert.IsTrue(result.Count == 3);
            Assert.IsFalse(result.ContainsKey("create a pull request"));
            Assert.IsTrue(result.ContainsKey("write code"));
            Assert.IsTrue(result.ContainsKey("git commit"));
            Assert.IsTrue(result.ContainsKey("git push"));
        }

        [Test]
        public void SearchTest()
        {
            string[] tasks = {"write code", "git commit", "git push", "create a pull request"};
            TodoList core = new TodoList();

            foreach (string task in tasks)
            {
                core.add(task);
            }

            foreach (string task in tasks)
            {
                Assert.IsTrue(core.search(task) == task);
            }

            Assert.IsTrue(core.search("write code for extensions") == "task not found");

            core.add("write code for extensions");
            Assert.IsTrue(core.search("write code for extensions") == "write code for extensions");
        }

        [Test]
        public void RemoveTest()
        {
            string[] tasks = {"write code", "git commit", "git push", "create a pull request"};
            TodoList core = new TodoList();

            foreach (string task in tasks)
            {
                core.add(task);
            }

            Assert.IsFalse(core.remove("write code for extensions"));
            Assert.IsTrue(core.remove("write code"));
        }

        [Test]
        public void TasksInAscOrderTest()
        {
            TodoList core = new TodoList();
            core.add("write code");
            core.add("git commit");
            core.add("git push");
            core.add("create a pull request");

            var result = core.tasksInAscOrder();

            Assert.IsTrue(result[0].Key == "create a pull request");
            Assert.IsTrue(result[1].Key == "git commit");
            Assert.IsTrue(result[2].Key == "git push");
            Assert.IsTrue(result[3].Key == "write code");
        }

        [Test]
        public void TasksInDescOrderTest()
        {
            TodoList core = new TodoList();
            core.add("write code");
            core.add("git commit");
            core.add("git push");
            core.add("create a pull request");

            var result = core.tasksInDescOrder();

            Assert.IsTrue(result[0].Key == "write code");
            Assert.IsTrue(result[1].Key == "git push");
            Assert.IsTrue(result[2].Key == "git commit");
            Assert.IsTrue(result[3].Key == "create a pull request");
        }
    }
}