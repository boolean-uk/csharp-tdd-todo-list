using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void ShouldReturnTaskById()
        {
            BetterTask task = new BetterTask("Clean the dog", false, 1, new DateTime());
            BetterTask task1 = new BetterTask("Put up shelf", false, 2, new DateTime());
            ToDo toDo = new ToDo();
            toDo.addTaskToList(task1);
            toDo.addTaskToList(task);
            Main.Task t = toDo.GetTaskById(1);

            Assert.AreEqual(task, t);
        }
        [Test]
        public void ShouldUpdateTaskNameAndCompletedById()
        {
            BetterTask task = new BetterTask("Clean the dog", false, 1, new DateTime());
            BetterTask task1 = new BetterTask("Put up shelf", false, 2, new DateTime());
            ToDo toDo = new ToDo();
            toDo.addTaskToList(task1);
            toDo.addTaskToList(task);
            toDo.UpdateTaskById(task.id, "Clean the cat");
            toDo.UpdateTaskById(task1.id);
            Assert.AreEqual(task.description, "Clean the cat");
            Assert.AreEqual(task1.completed, true);

        }
        [Test]
        public void shouldReturnADateAndTimeFromTask()
        {
            BetterTask task = new BetterTask("Do homework", false, 3, new DateTime());
            ToDo toDo = new ToDo();
            toDo.addTaskToList(task);
            DateTime dtFromTask = toDo.DisplayDateAndTime(task);
            DateTime dT = new DateTime();
          
            Assert.That(dtFromTask.Month == dT.Month);
        }

    }
}
