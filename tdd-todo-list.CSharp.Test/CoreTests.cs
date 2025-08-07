using NUnit.Framework;
using NUnit.Framework.Constraints;
using System.Numerics;
using tdd_todo_list.CSharp.Main;
using Task = tdd_todo_list.CSharp.Main.Task;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddedTaskisAdded()
        {
            TodoList list = new TodoList();
            string id = "1";
            string desc = "Water plants";
            int priority = 3;
            bool completed = false;
            Task task = new(id, desc, priority, completed, "");

            list.AddTask(id, task);
            bool result = list.SearchTask(id);

            Assert.IsTrue(result);

        }

        [Test]
        public void RemovedTaskisRemoved()
        {
            TodoList list = new TodoList();
            string id = "1";
            string desc = "Water plants";
            int priority = 3;
            bool completed = false;
            Task task = new(id, desc, priority, completed, "");

            list.AddTask(id, task);
            Task result = list.RemoveTask(id);

            Assert.That(result.Id, Is.EqualTo(id));
        }


        [Test]
        public void GotTasksByStatus()
        {
            TodoList list = new TodoList();
            string id = "1";
            string desc = "Water plants";
            int priority = 3;
            bool completed = false;
            Task taskIC1 = new(id, desc, priority, completed, "");

            id = "2";
            desc = "Paint wall";
            priority = 3;
            completed = false;
            Task taskIC2 = new(id, desc, priority, completed, "");

            id = "3";
            desc = "Walk dog";
            priority = 3;
            completed = true;
            Task taskC1 = new(id, desc, priority, completed, "");

            list.AddTask(taskIC1.Id, taskIC1);
            list.AddTask(taskIC2.Id, taskIC2);
            list.AddTask(taskC1.Id, taskC1);

            List<Task> resultList = list.GetTasksByStatus(false);
            int complete = 0;
            int incomplete = 0;

            foreach (var item in resultList)
            {
                if(item.Completed) { complete++; }
                else if (!item.Completed) { incomplete++; }
            }
            Assert.That(complete, Is.EqualTo(0));
            Assert.That(incomplete, Is.EqualTo(2));
        }

        public void SearchTaskTest()
        {
            TodoList list = new TodoList();
            string id = "1";
            string desc = "Water plants";
            int priority = 3;
            bool completed = false;
            Task task = new(id, desc, priority, completed, "");

            bool result1 = list.SearchTask(id);
            bool result2 = list.SearchTask("X");

            Assert.True(result1);
            Assert.False(result2);
        }

        [Test]
        public void ListTasksAlphabeticalTest()
        {
            TodoList list = new TodoList();
            string id = "1";
            string desc = "Drive home";
            int priority = 3;
            bool completed = false;
            Task task1 = new(id, desc, priority, completed, "");

            id = "2";
            desc = "Call boss";
            priority = 3;
            completed = false;
            Task task2 = new(id, desc, priority, completed, "");

            id = "3";
            desc = "Buy apples";
            priority = 3;
            completed = false;
            Task task3 = new(id, desc, priority, completed, "");

            list.AddTask(task1.Id, task1);
            list.AddTask(task2.Id, task2);
            list.AddTask(task3.Id, task3);

            List<Task> resultList = list.ListTasksAlphabeticalOrder("Descending");

            List<string> ordered = new List<string>();
            ordered.Add("Buy apples");
            ordered.Add("Call boss");
            ordered.Add("Drive home");

            ordered.Reverse();

            bool isOrdered = true;

            for (int i = 0; i < 3; i++)
            {
                if (!resultList[i].Desc.Equals(ordered[i]))
                {
                    isOrdered = false; break;
                }
            }
            Assert.True(isOrdered);
        }

        [Test]
        public void ListTasksByPriority()
        {
            TodoList list = new TodoList();
            string id = "1";
            string desc = "Drive home";
            int priority = 2;
            bool completed = false;
            Task task1 = new(id, desc, priority, completed, "");

            id = "2";
            desc = "Call boss";
            priority = 2;
            completed = false;
            Task task2 = new(id, desc, priority, completed, "");

            id = "3";
            desc = "Buy apples";
            priority = 1;
            completed = false;
            Task task3 = new(id, desc, priority, completed, "");

            list.AddTask(task1.Id, task1);
            list.AddTask(task2.Id, task2);
            list.AddTask(task3.Id, task3);

            List<Task> resultList = list.ListTasksByPriority(2);

            int prio1 = 0;
            int prio2 = 0;

            foreach (var item in resultList)
            {
                if (item.Priority == 1) { prio1++; }
                else if (item.Priority == 2) { prio2++; }
            }
            Assert.That(prio1, Is.EqualTo(0));
            Assert.That(prio2, Is.EqualTo(2));
        }

    }
}