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
        TaskItem newTask1 = new TaskItem("danse", "danse litt", 1, "hobby");
        TaskItem newTask2 = new TaskItem("synge", "synge litt", 2, "hobby");
        [SetUp]
        public void Init()
        {
            todoList = new TodoList();
            t1 = new TaskItem("vaske", "vaske trapp og kjeller", 3, "husarbeid");
            TaskItem t2 = new TaskItem("rydde", "rydde kjøkken", 1, "husarbeid");
            TaskItem t3 = new TaskItem("lade", "lade mobilen", 1, "annet", true);
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
            TodoList todoList1 = new TodoList();
            TaskItem newTask1 = new TaskItem("danse", "danse litt", 1, "hobby");
            TaskItem newTask2 = new TaskItem("synge", "synge litt", 2, "hobby");

            todoList1.AddTask(newTask1);
            todoList1.AddTask(newTask2);

            todoList1.RemoveTask(newTask1);


            //todoList.RemoveTask(todoList.GetTaskById(2));
            //Assert.That(todoList.GetAllTasksInOrder().Count, Is.EqualTo(2));
            Assert.That(todoList1.GetAllTasks().Count, Is.EqualTo(1));
        }

        [Test]
        public void ChangingStatusToComplete()
        {
            TaskItem task1 = new TaskItem("test1", "dette er en test", 1, "vasking");
            todoList.AddTask(task1);

            task1.ChangeStatus();
            Assert.That(task1.StatusComplete, Is.True);
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

            Assert.That(tempTaskItemList.All(t => t.StatusComplete == true), Is.True);
        }

        [Test]
        public void GetAllIncompleteTasks()
        {
            tempTaskItemList = todoList.GetIncompleteTasks();

            Assert.That(tempTaskItemList.All(t => t.StatusComplete == false), Is.True);
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

        [Test]
        public void GetTasksSortedByPriorityShouldBeOrderedByPriority()
        {
            tempTaskItemList = todoList.GetAllTasksSortedByPriority();
            Assert.That(tempTaskItemList[0].Priority.CompareTo(tempTaskItemList[1].Priority) <= 0, Is.True);
        }

        [Test]
        public void TaskDoesExistShouldReturnTrue()
        {
            TaskItem tempTaskItem = new TaskItem("test", "test", 1, "test");
            todoList.AddTask(tempTaskItem);

            Assert.That(todoList.DoesTaskExist(tempTaskItem), Is.True);
        }


        [Test]
        public void UpdatingNameShouldGiveNewName()
        {
            todoList.UpdateNameById(t1.Id, "johan");
            Assert.That(t1.Name, Is.EqualTo("johan"));
        }

        
    }
}