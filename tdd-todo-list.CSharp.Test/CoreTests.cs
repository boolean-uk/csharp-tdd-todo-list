using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTaskTest()
        {
            TodoList core = new TodoList();
            Tasks task = new Tasks("Task 1");
            Assert.That(core.Add(task));
        }

        [Test]
        public void GetTodoListTest()
        {
            TodoList core = new TodoList();
            Tasks task = new Tasks("Task 1");
            List<Tasks> tasks = new List<Tasks>();
            tasks.Add(task);
            core.Add(task);
            Assert.That(core.GetTodoList(), Is.EquivalentTo(tasks));
        }

        [Test]
        public void ChangeStatusTest()
        {
            TodoList todoList = new TodoList();
            Tasks task = new Tasks("Task 1");
            todoList.Add(task);
            Assert.That(todoList.ChangeStatus(task.name), Is.EqualTo(true));
        }

        [Test]
        public void GetCompletedTest()
        {
            TodoList todoList = new TodoList();
            Tasks task = new Tasks("Task 1");
            todoList.Add(task);
            todoList.ChangeStatus(task.name);
            List<Tasks> completed = todoList.GetCompleted();
            Assert.That(completed.Contains(task));
        }

        [Test]
        public void GetIncompletedTest()
        {
            TodoList todoList = new TodoList();
            Tasks task = new Tasks("Task 1");
            todoList.Add(task);
            List<Tasks> incompleted = todoList.GetIncompleted();
            Assert.That(incompleted.Contains(task));
        }

        [TestCase("Task 2", "Failed")]
        [TestCase("Task 1", "Success")]
        [TestCase("Task 2466", "Failed")]
        public void FindTaskTest(string taskName, string expResult)
        {
            TodoList todoList = new TodoList();
            Tasks task = new Tasks("Task 1");
            todoList.Add(task);
            string result = todoList.FindTask(taskName);
            Assert.That(expResult, Is.EqualTo(result));
        }

        [Test]
        public void RemoveTaskTest()
        {
            TodoList todoList = new TodoList();
            Tasks task = new Tasks("Task 1");
            todoList.Add(task);
            Assert.That(todoList.GetTodoList().Contains(task));
            todoList.RemoveTask(task.name);
            Assert.That(!todoList.GetTodoList().Contains(task));
        }

        [Test]
        public void SortAscendingTest()
        {
            string[] names = ["a", "b", "c"];
            string[] shufflednames = ["b", "c", "a"];
            TodoList todoList1 = new TodoList();
            TodoList todoList2 = new TodoList();
            List<Tasks> tasks1 = new List<Tasks>();
            List<Tasks> tasks2 = new List<Tasks>();
            for (int i = 0; i < names.Length; i++)
            {
                tasks1.Add(new Tasks(names[i]));
                tasks2.Add(new Tasks(shufflednames[i]));
            }
            todoList1.SetTasks(tasks1);
            todoList2.SetTasks(tasks2);
            List<Tasks> sortedTasks = todoList2.SortAscending();
            List<Tasks> expectedResult = todoList1.GetTodoList();
            for (int i = 0; i<names.Length; i++)
            {
                Assert.That(expectedResult[i].name, Is.EqualTo(sortedTasks[i].name));
            }
        }

        [Test]
        public void SortDescendingTest()
        {
            string[] names = ["c", "b", "a"];
            string[] shufflednames = ["b", "c", "a"];
            TodoList todoList1 = new TodoList();
            TodoList todoList2 = new TodoList();
            List<Tasks> tasks1 = new List<Tasks>();
            List<Tasks> tasks2 = new List<Tasks>();
            for (int i = 0; i < names.Length; i++)
            {
                tasks1.Add(new Tasks(names[i]));
                tasks2.Add(new Tasks(shufflednames[i]));
            }
            todoList1.SetTasks(tasks1);
            todoList2.SetTasks(tasks2);
            List<Tasks> sortedTasks = todoList2.SortDescending();
            List<Tasks> expectedResult = todoList1.GetTodoList();
            for (int i = 0; i < names.Length; i++)
            {
                Assert.That(expectedResult[i].name, Is.EqualTo(sortedTasks[i].name));
            }
        }
    }
}