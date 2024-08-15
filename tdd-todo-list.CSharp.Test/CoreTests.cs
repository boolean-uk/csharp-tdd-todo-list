using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

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
            TodoTaskObj task = new TodoTaskObj("First task");
            core.AddTaskToList(task);
            core.ToString();
            Assert.Fail();
        }

        [Test]
        public void changeStatusOfTask()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task");
            core.AddTaskToList(task);
            core.ChangeObjStatus(task);
            Assert.Fail();
        }
        [Test]
        public void getCompleteTasks()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task");
            core.getSomeTasks(true);
            Assert.Fail();
        }

        public void getInCompleteTasks()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task");
            core.getSomeTasks(false);
            Assert.Fail();
        }

        public void getIndividualTask()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task");
            core.getIndividualTasks("First");
            Assert.Fail();
        }


        public void removeTask()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task");
            core.removeTask();
            Assert.Fail();
        }

        public void orderedTasksAlphabeticaly()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task");
            core.getOrderedTasks();
            Assert.Fail();
        }

        public void orderedTasksReversedAlphabeticaly()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task");
            core.getOrderedTasksReversed();
            Assert.Fail();
        }




    }
}