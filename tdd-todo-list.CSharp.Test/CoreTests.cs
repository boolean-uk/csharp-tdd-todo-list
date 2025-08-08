using Microsoft.VisualBasic;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using tdd_todo_list.CSharp.Main;

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
        public void AddTest()
        {
            TodoList ToDoList = new TodoList();

            Assert.That(ToDoList.Todo.Count == 0);

            ToDoList.Add("wash");

            Assert.That(ToDoList.Todo.Count == 1);

        }

        [Test]
        public void TestViewAll()
        {
            TodoList ToDoList = new TodoList();

            ToDoList.Add("wash");
            ToDoList.Add("trash");
            ToDoList.Add("clean");

            List<ToDoTask> tasks = ToDoList.ViewAll();

            Assert.That(tasks.Count == ToDoList.Todo.Count);
        }

        [Test]
        public void TestChangeStatus()
        {
            TodoList todo = new TodoList();

            todo.Add("wash");
            todo.Add("trash");

            bool original = todo.Todo[1].Status;
            todo.Todo[1].ChangeStatus(true);
            bool afterChange = todo.Todo[1].Status;

            Assert.That(original, Is.False);
            Assert.IsTrue(afterChange);
        }

        [Test]
        public void TestViewCompleted()
        {
            TodoList todo = new TodoList();
            List<ToDoTask> completed = new List<ToDoTask>();

            todo.Add("wash");
            todo.Add("trash");

            todo.Todo[1].ChangeStatus(true);

            completed = todo.ViewCompleted();

            Assert.That(completed.Count == 1);

            todo.Todo[1].ChangeStatus(false);
            completed = todo.ViewCompleted();

            Assert.That(completed.Count == 0);

        }
        [Test]
        public void TestViewIncompleted()
        {
            TodoList todo = new TodoList();
            List<ToDoTask> incompleted = new List<ToDoTask>();

            todo.Add("wash");
            todo.Add("trash");

            todo.Todo[1].ChangeStatus(true);

            incompleted = todo.ViewIncompleted();

            Assert.That(incompleted.Count == 1);

            todo.Todo[1].ChangeStatus(false);
            incompleted = todo.ViewIncompleted();

            Assert.That(incompleted.Count == 2);

        }


        [Test]
        public void TestIsPresent()
        {
            TodoList todo = new TodoList();

            todo.Add("wash");
            todo.Add("trash");

            bool isPresent = todo.IsPresent(1);
            Assert.That(isPresent, Is.True);
            bool isPresent2 = todo.IsPresent(3);
            Assert.That(isPresent2, Is.False);
        }


        [Test]
        public void TestRemove()
        { 
            TodoList todo = new TodoList();

            todo.Add("wash");
            todo.Add("trash");

            todo.Remove(2);
            Assert.IsFalse(todo.IsPresent(2));
        }

        [Test]
        public void TestChangePriority()
        {
            TodoList todo = new TodoList();

            todo.Add("wash");

            todo.Todo[1].ChangePriority(2);

            Assert.That(todo.Todo[1].getPriority() == 2);
        }

        [Test]
        public void TestViewByPriority()
        {
            TodoList todo = new TodoList();

            todo.Add("bbb");
            todo.Add("aaa");
            todo.Add("ccc");

            todo.Todo[1].ChangePriority(1);
            todo.Todo[2].ChangePriority(2);

            List<ToDoTask> strings = todo.ViewByPriority();
            List<string> target = new List<string> { "aaa", "bbb", "ccc" };

            for (int i = 0; i < strings.Count; i++)
            {
                Assert.That(strings[i].Name == target[i]);
            }

           
        }

        [Test]
        public void TestViewAlphabetical()
        {
            TodoList todo = new TodoList();

            todo.Add("charlie");
            todo.Add("bravo");
            todo.Add("alpha");

            List<ToDoTask> toDoTasks = todo.ViewAlphabetical();
            List<string> target = new List<string> { "alpha", "bravo", "charlie" };

            for (int i = 0; i < toDoTasks.Count; i++)
            {
                Assert.That(toDoTasks[i].Name == target[i]);
            }
        }
        [Test]
        public void TestViewDescedingAlphabetical()
        {
            TodoList todo = new TodoList();

            todo.Add("charlie");
            todo.Add("bravo");
            todo.Add("alpha");

            List<ToDoTask> toDoTasks = todo.ViewDescendingAlphabetical();
            List<string> target = new List<string> { "charlie", "bravo", "alpha"  };

            for (int i = 0; i < toDoTasks.Count; i++)
            {
                Assert.That(toDoTasks[i].Name == target[i]);
            }
        }

    }
}