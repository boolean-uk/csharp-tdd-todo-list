using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
       
        [TestCase(true)]
        [TestCase(false)]
        public void GetTaskByIdTest(bool success)
        {
            TodoList core = new TodoList();
            Guid id1 = core.Add("Sometask1");
            Guid id2 = core.Add("Sometask2");
            Guid id3 = core.Add("Sometask3");


            Main.Task retrievedTask = core.GetTaskById(success ? id2 : Guid.NewGuid());
            if (success) Assert.That(retrievedTask.GetTaskText(), Is.EqualTo("Sometask2"));
            else Assert.That(retrievedTask, Is.EqualTo(null));
            
        }

        [TestCase("Koko")]
        public void UpdateNameByIdTest(string NewName)
        {
            TodoList core = new TodoList();
            Guid id = core.Add("Sometask");

            core.ChangeTaskName(id, NewName);

            Assert.That(core.GetTaskById(id).GetTaskText(), Is.EqualTo(NewName));
        }

        [Test]
        public void ChangeStatusByIdTest()
        {
            TodoList core = new TodoList();
            Guid id = core.Add("Sometask1");

            core.ChangeTaskCompletion(id);
            Assert.That(core.GetTaskCompletion(id), Is.EqualTo(true));
        }

        [Test]
        public void GetLongestCompletionTest()
        {
            TodoList core = new TodoList();
            Guid id1 = core.Add("Sometask1");
            Guid id2 = core.Add("Sometask2");
            Guid id3 = core.Add("Sometask3");

            core.ChangeTaskCompletion(id3);
            core.ChangeTaskCompletion(id2);

            Main.Task task = core.GetLongestCompletionTask();

            Assert.That(task.GetTaskText(), Is.EqualTo("Sometask2"));
        }

        [Test]
        public void GetShortestCompletionTest()
        {
            TodoList core = new TodoList();
            Guid id1 = core.Add("Sometask1");
            Guid id2 = core.Add("Sometask2");
            Guid id3 = core.Add("Sometask3");

            core.ChangeTaskCompletion(id3);
            core.ChangeTaskCompletion(id2);

            Main.Task task = core.GetShortestCompletionTask();

            Assert.That(task.GetTaskText(), Is.EqualTo("Sometask3"));
        }

        [Test]
        public void Get5DaysToCompleteTest()
        {
            TodoList core = new TodoList();
            Guid id1 = core.Add("Sometask1", category: "study");
            Guid id2 = core.Add("Sometask2", category: "work");
            Guid id3 = core.Add("Sometask3", category: "admin");
            Guid id4 = core.Add("Sometask3", category: "work");

            core.SetCustomTaskCompletion(id1, new DateTime(3000,4,4));
            core.SetCustomTaskCompletion(id3, new DateTime(2975, 4, 4));

            List<Main.Task> retrievedTasks = core.Get5DayCompletionList();
            Assert.That(retrievedTasks.Count, Is.EqualTo(2));

        }

        [Test]
        public void GetListByCategoryTest()
        {
            TodoList core = new TodoList();
            Guid id1 = core.Add("Sometask1", category: "study");
            Guid id2 = core.Add("Sometask2", category: "work");
            Guid id3 = core.Add("Sometask3", category: "admin");
            Guid id4 = core.Add("Sometask3", category: "work");

            List<Main.Task> retrievedTasks = core.GetCategoryList();

            Assert.That(retrievedTasks[0].GetCategory(), Is.EqualTo("admin"));
            Assert.That(retrievedTasks[1].GetCategory(), Is.EqualTo("study"));
            Assert.That(retrievedTasks[2].GetCategory(), Is.EqualTo("work"));
            Assert.That(retrievedTasks[3].GetCategory(), Is.EqualTo("work"));
        }

    }
}
