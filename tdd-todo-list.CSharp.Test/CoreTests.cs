using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private TodoList toDoList;

        [SetUp]
        public void SetUp()
        {
            toDoList = new TodoList();
        }
        

        [Test]
        public void AddTask()
        {
            toDoList.Add("Make a todolist");
            Assert.AreEqual(1, toDoList._tasks.Count);
        }

        [Test]
        public void RemoveTask()
        {
            toDoList.Add("Make a todolist");
            toDoList.Add("Make a cake");

            toDoList.Remove("Make a cake");

            Assert.AreEqual(1, toDoList._tasks.Count);
        }

        [Test]
        public void AlphabeticalAscending()
        {
            toDoList.Add("C");
            toDoList.Add("B");
            toDoList.Add("A");

            toDoList.Ascending();

            Assert.AreSame(toDoList._tasks[0]._description, "A");
            Assert.AreSame(toDoList._tasks[1]._description, "B");
            Assert.AreSame(toDoList._tasks[2]._description, "C");
        }

        [Test]
        public void AlphabeticalDesceding()
        {
            
            toDoList.Add("A");
            toDoList.Add("B");
            toDoList.Add("C");

            toDoList.Descending();

            Assert.AreSame(toDoList._tasks[0]._description, "C");
            Assert.AreSame(toDoList._tasks[1]._description, "B");
            Assert.AreSame(toDoList._tasks[2]._description, "A");
        }

        [Test]
        public void ListTasks()
        {
            toDoList.Add("Make a todolist");
            toDoList.Add("Make a cake");

            Assert.AreSame(toDoList._tasks[0]._description, "Make a todolist");
            Assert.AreSame(toDoList._tasks[1]._description, "Make a cake");

            Assert.IsFalse(toDoList._tasks[0]._done);
            Assert.IsFalse(toDoList._tasks[1]._done);

        }

        [Test]
        public void CompletionStatus()
        {
            toDoList.Add("Make a todolist");
            toDoList.MarkAsComplete("Make a todolist");
            Assert.IsTrue(toDoList._tasks[0]._done);

            toDoList.MarkAsIncomplete("Make a todolist");
            Assert.IsFalse(toDoList._tasks[0]._done);

        }

        [Test]
        public void CompletedList()
        {
            toDoList.Add("Make a todolist");
            toDoList.Add("Make a cake");
            toDoList.Add("Make a composition");
            toDoList.Add("Make haste");

            toDoList.MarkAsComplete("Make a todolist");
            toDoList.MarkAsComplete("Make haste");

            List<TodoTask> res = toDoList.GetCompleted();

            Assert.AreEqual(2, res.Count);

            Assert.AreSame(res[0]._description, "Make a todolist");
            Assert.AreSame(res[1]._description, "Make haste");

            Assert.IsTrue(res[0]._done);
            Assert.IsTrue(res[1]._done);

        }

        public void IncompletedList()
        {
            toDoList.Add("Make a todolist");
            toDoList.Add("Make a cake");
            toDoList.Add("Make a composition");
            toDoList.Add("Make a painting");
            toDoList.Add("Make haste");

            toDoList.MarkAsComplete("Make a todolist");
            toDoList.MarkAsComplete("Make haste");

            List<TodoTask> res = toDoList.GetNotCompleted();

            Assert.AreEqual(3, res.Count);

            Assert.AreSame(res[0]._description, "Make a cake");
            Assert.AreSame(res[1]._description, "Make a composition");
            Assert.AreSame(res[2]._description, "Make a painting");

            Assert.IsFalse(res[0]._done);
            Assert.IsFalse(res[1]._done);
            Assert.IsFalse(res[2]._done);

        }

        [Test]
        public void TaskPresent()
        {
            toDoList.Add("Make a todolist");

            string res1 = toDoList.search("Make a todolist");
            Assert.AreSame(res1, "Task present!");

            string res2 = toDoList.search("not here");
            Assert.AreSame(res2, "Task missing!");

        }
    }
}