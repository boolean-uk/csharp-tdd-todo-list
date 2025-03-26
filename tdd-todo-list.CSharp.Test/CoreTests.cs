using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        /*        I want to add tasks to my todo list.
                I want to see all the tasks in my todo list.
        I want to change the status of a task between incomplete and complete.
        I want to be able to get only the complete tasks.
        I want to be able to get only the incomplete tasks.
        I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
        I want to remove tasks from my list.
        I want to see all the tasks in my list ordered alphabetically in ascending order.
        I want to see all the tasks in my list ordered alphabetically in descending order.*/

        [Test]
        public void addTask()
        {
            TodoList core = new TodoList();
            core.addTask("name");
            Assert.Pass();
        }

        [Test]
        public void viewTasks()
        {
            TodoList core = new TodoList();
            core.addTask("name");
            Assert.IsTrue(core.viewTasks().SequenceEqual(new List<string>() { "name" }));
        }

        [Test]
        public void alterStatus()
        {
            TodoList core = new TodoList();
            core.addTask("name");
            Assert.IsTrue(core.changeStatus("name"));
        }

        [Test]
        public void onlyComplete()
        {
            TodoList core = new TodoList();
            core.addTask("name");
            core.changeStatus("name");
            core.addTask("otherName");
            Assert.IsTrue(core.viewTasks("", "complete").SequenceEqual(new List<string>() { "name" }));
        }

        [Test]
        public void onlyIncomplete()
        {
            TodoList core = new TodoList();
            core.addTask("name");
            core.changeStatus("name");
            core.addTask("otherName");
            Assert.IsTrue(core.viewTasks("", "incomplete").SequenceEqual(new List<string>() { "otherName" }));
        }

        [Test]
        public void findTest()
        {
            TodoList core = new TodoList();
            core.addTask("name");
            Assert.IsTrue(core.findTask("name"));
        }

        [Test]
        public void notFindTest()
        {
            TodoList core = new TodoList();
            core.addTask("name");
            Assert.IsFalse(core.findTask("differentName"));
        }

        [Test]
        public void removeTest()
        {
            TodoList core = new TodoList();
            core.addTask("name");
            core.removeTask("name");
            Assert.IsFalse(core.findTask("name"));

        }

        [Test]
        public void alphabeticalOrder()
        {
            TodoList core = new TodoList();
            core.addTask("name");
            core.addTask("otherName");
            Assert.IsTrue(core.viewTasks("alphabetical").SequenceEqual(
                new List<string>() { "name", "otherName" })
                );
        }

        [Test]
        public void invertedAlphabeticalOrder()
        {
            TodoList core = new TodoList();
            core.addTask("name");
            core.addTask("otherName");
            Assert.IsTrue(core.viewTasks("inverseAlphabetical").SequenceEqual(
                new List<string>() { "otherName", "name" })
                );
        }
    }
}