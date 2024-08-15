using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void addTaskToList()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task", false);
            core.AddTaskToList(task);
            Assert.That(core.getListLenght() == 1);
        }

        [Test]
        public void seeAllTasktInList()
        {
            TodoList core = new TodoList();
            TodoTaskObj task1 = new TodoTaskObj("First task");
            TodoTaskObj task2 = new TodoTaskObj("Second task");
            core.AddTaskToList(task1);
            core.AddTaskToList(task2);
            string s = core.ToString();
            Assert.That(s.Contains("First task => Inomplete: Second task => Inomplete:"));
        }

        [Test]
        public void changeStatusOfTask()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task");
            core.AddTaskToList(task);
            core.ChangeObjStatus(task);
            Assert.True(core.getIndividualTasks("First task").Complete);
        }
        [Test]
        public void getCompleteTasks()
        {
            TodoList core = new TodoList();
            TodoTaskObj task1 = new TodoTaskObj("First task");
            TodoTaskObj task2 = new TodoTaskObj("Second task", true);
            core.AddTaskToList(task1);
            core.AddTaskToList(task2);
            var list = core.getSomeTasks(true);
            Assert.True(list.Contains(task2));
            Assert.False(list.Contains(task1));
        }

        [Test]
        public void getInCompleteTasks()
        {
            {
                TodoList core = new TodoList();
                TodoTaskObj task1 = new TodoTaskObj("First task");
                TodoTaskObj task2 = new TodoTaskObj("Second task", true);
                core.AddTaskToList(task1);
                core.AddTaskToList(task2);
                var list = core.getSomeTasks(false);
                Assert.True(list.Contains(task1));
                Assert.False(list.Contains(task2));
            }
        }
        [Test]
        public void getIndividualTask()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task");
            core.AddTaskToList(task);
            TodoTaskObj taskReturn = core.getIndividualTasks("First task");
            Assert.That(task.Equals(taskReturn));
        }

        [Test]
        public void removeTask()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task");
            core.AddTaskToList(task);
            core.removeTask();
            Assert.Fail();
        }
        [Test]
        public void orderedTasksAlphabeticaly()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task");
            core.getOrderedTasks();
            Assert.Fail();
        }
        [Test]
        public void orderedTasksReversedAlphabeticaly()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task");
            core.getOrderedTasksReversed();
            Assert.Fail();
        }



    }
}