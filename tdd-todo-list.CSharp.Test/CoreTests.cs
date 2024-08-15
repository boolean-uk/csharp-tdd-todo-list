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
            Task task = new Task("First task", "incomplete");
            core.AddTaskToList(task);
            Assert.Fail();
        }

        [Test]
        public void seeAllTasktInList()
        {
            TodoList core = new TodoList();
            Task task = new Task("First task", "incomplete");
            core.AddTaskToList(task);
            core.ToString();
            Assert.Fail();
        }

        [Test]
        public void changeStatusOfTask()
        {
            TodoList core = new TodoList();
            Task task = new Task("First task", "incomplete");
            core.AddTaskToList(task);
            core.ChangeStatus();
            Assert.Fail();
        }
        [Test]
        public void getCompleteTasks()
        {
            TodoList core = new TodoList();
            
            core.getSomeTasks();
            Assert.Fail();
        }

        public void getInCompleteTasks()
        {
            TodoList core = new TodoList();

            core.getInCompleteTasks();
            Assert.Fail();
        }

        public void getIndividualTask()
        {
            TodoList core = new TodoList();

            core.getIndividualTasks();
            Assert.Fail();
        }


        public void removeTask()
        {
            TodoList core = new TodoList();

            core.removeTask();
            Assert.Fail();
        }

        public void orderedTasksAlphabeticaly()
        {
            TodoList core = new TodoList();

            core.getOrderedTasks();
            Assert.Fail();
        }

        public void orderedTasksReversedAlphabeticaly()
        {
            TodoList core = new TodoList();

            core.getOrderedTasksReversed();
            Assert.Fail();
        }




    }
}