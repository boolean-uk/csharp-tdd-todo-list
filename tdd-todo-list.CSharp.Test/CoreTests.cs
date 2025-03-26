using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Collections.Generic;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [TestCase("taskName", Status.COMPLETE)]
        [TestCase("Amøbe", Status.INCOMPLETE)]
        [TestCase("Brannslukningsapparat", Status.COMPLETE)]
        public void AddTaskTest(string a, Status b)
        {
            TodoList tl = new TodoList();
            TodoTask task = new TodoTask(a, b);
            tl.AddTask(task);

            Assert.That(tl.todoList.Contains(task), Is.True);
        }

        [TestCase(10)]
        [TestCase(0)]
        [TestCase(5)]
        public void AllTasksTest(int amount)
        {
            TodoList tl = new TodoList();

            for (int i = 0; i < amount; i++)
            {
                tl.AddTask(new TodoTask($"task{i}", Status.COMPLETE));
            }

            Assert.That(tl.AllTasks().Count(), Is.EqualTo(amount));
        }

        [TestCase("babababa", Status.INCOMPLETE)]
        [TestCase("femtito", Status.INCOMPLETE)]
        [TestCase("beredskap", Status.COMPLETE)]
        public void FetchTaskTest(string a, Status b)
        {
            TodoList tl = new TodoList();
            TodoTask originalTask = new TodoTask(a, b);

            tl.AddTask(originalTask);
            TodoTask foundTask = tl.FetchTask(a);

            Assert.That(foundTask, Is.EqualTo(originalTask));
        }

        [TestCase(Status.COMPLETE, Status.INCOMPLETE)]
        [TestCase(Status.INCOMPLETE, Status.COMPLETE)]
        [TestCase(Status.INCOMPLETE, Status.INCOMPLETE)]
        [TestCase(Status.COMPLETE, Status.COMPLETE)]
        public void ChangeStatusTest(Status startStatus, Status endStatus)
        {
            TodoList tl = new TodoList();
            TodoTask newTask = new TodoTask("SomeTaskName", startStatus);
            tl.AddTask(newTask);

            tl.ChangeStatus("SomeTaskName", endStatus);
            Assert.That(tl.FetchTask("SomeTaskName").status, Is.EqualTo(endStatus));
        }

        [TestCase(10)]
        [TestCase(0)]
        [TestCase(4)]
        public void FetchTasksWithStatusTest(int amount)
        {
            TodoList tl = new TodoList();

            for (int i = 0; i < 10; i++)
            {
                if (i < amount) tl.AddTask(new TodoTask("SomeTaskName", Status.COMPLETE));
                else tl.AddTask(new TodoTask("SomeTaskName", Status.INCOMPLETE));
            }

            Assert.That(tl.FetchTasksWithStatus(Status.COMPLETE).Count(), Is.EqualTo(amount));
        }

        [TestCase("Task1", "Does exist")]
        [TestCase("Task2", "Doesn't exist")]
        public void DoesExistTest(string a, string b)
        {
            TodoList tl = new TodoList();
            tl.AddTask(new TodoTask("Task1", Status.COMPLETE));

            Assert.That(tl.DoesExist(a), Is.EqualTo(b));
        }

        [TestCase("jobb", Status.INCOMPLETE)]
        [TestCase("st. mirren", Status.INCOMPLETE)]
        [TestCase("hansa", Status.COMPLETE)]
        public void RemoveTaskTest(string a, Status b)
        {
            TodoList tl = new TodoList();
            TodoTask task = new TodoTask(a, b);
            tl.AddTask(task);
            tl.RemoveTask(a);

            Assert.That(tl.todoList.Contains(task), Is.False);
        }

        [TestCase("asc")]
        [TestCase("desc")]
        [TestCase("skrivefeil")]
        public void AllTaskSortedTest(string a)
        {
            TodoList tl = new TodoList();
            List<TodoTask> tasks = new List<TodoTask>();
            tasks.Add(new TodoTask("Corona", Status.COMPLETE));
            tasks.Add(new TodoTask("Apekatt", Status.COMPLETE));
            tasks.Add(new TodoTask("Enigma", Status.COMPLETE));
            tasks.Add(new TodoTask("Dumpapp", Status.COMPLETE));
            tasks.Add(new TodoTask("Banan", Status.COMPLETE));

            tl.todoList = tasks;
            if (a.Equals("asc")) tasks.Sort((t1, t2) => t1.name.CompareTo(t2.name));
            else if (a.Equals("desc")) tasks.Sort((t1, t2) => t2.name.CompareTo(t1.name));

            Assert.That(tl.AllTasksSorted(a), Is.EqualTo(tasks));
        }
    }
}