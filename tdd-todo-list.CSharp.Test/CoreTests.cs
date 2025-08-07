using NUnit.Framework;
using NUnit.Framework.Interfaces;
using tdd_todo_list.CSharp.Main;
using TaskItem = tdd_todo_list.CSharp.Main.TaskItem;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        List<TaskItem> tempTaskItemList = new List<TaskItem>();

        TodoList todoList;
        TaskItem t1;
        TaskItem newTask1 = new TaskItem(4, "danse", "danse litt", 1, "hobby");
        TaskItem newTask2 = new TaskItem(4, "synge", "synge litt", 2, "hobby");
        [SetUp]
        public void Init()
        {
            todoList = new TodoList();
            t1 = new TaskItem(1, "vaske", "vaske trapp og kjeller", 3, "husarbeid");
            TaskItem t2 = new TaskItem(2, "rydde", "rydde kjøkken", 1, "husarbeid");
            TaskItem t3 = new TaskItem(3, "lade", "lade mobilen", 1, "annet", "complete");
            todoList.AddTask(t1);
            todoList.AddTask(t2);
            todoList.AddTask(t3);
        }





        [Test]
        public void AddingOneTaskShouldBe4()
        {
            todoList.AddTask(newTask1);
            Assert.That(todoList.GetAllTasksInOrder().Count, Is.EqualTo(4));
        }

        [Test]
        public void RemovingOneTaskShouldBe2()
        {
            todoList.RemoveTask(todoList.GetTaskById(1));
            Assert.That(todoList.GetAllTasksInOrder().Count, Is.EqualTo(2));
        }

        [Test]
        public void ChangingStatusToComplete()
        {
            todoList.ChangeStatus(t1);
            Assert.That(t1.Status, Is.EqualTo("complete"));
        }

        [Test]
        public void GetAllTasksShouldBe3()
        {
            List<TaskItem> taskItems = todoList.GetAllTasks();
            Assert.That(taskItems.Count, Is.EqualTo(3));
        }

        [Test]
        public void GetAllCompleteTasks()
        {
            tempTaskItemList = todoList.GetCompletedTasks();

            Assert.That(tempTaskItemList.All(t => t.Status == "complete"), Is.True);
        }

        [Test]
        public void GetAllIncompleteTasks()
        {
            tempTaskItemList = todoList.GetIncompleteTasks();

            Assert.That(tempTaskItemList.All(t => t.Status == "incomplete"), Is.True);
        }

        [Test]
        public void GetTasksInOrderShouldBeInOrder()
        {
            tempTaskItemList = todoList.GetAllTasksInOrder();
            Assert.That(tempTaskItemList[0].Name.CompareTo(tempTaskItemList[1].Name) <= 0, Is.True);
        }

        [Test]
        public void GetTasksInReverseOrderShouldBeInReverseOrder()
        {
            tempTaskItemList = todoList.GetAllTasksInReverseOrder();
            Assert.That(tempTaskItemList[0].Name.CompareTo(tempTaskItemList[1].Name) >= 0, Is.True);
        }
    }
}