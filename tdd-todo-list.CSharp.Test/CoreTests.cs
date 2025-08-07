using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void Add1TaskTest()
        {
            TodoList todoList = new TodoList();

            var task1 = new TodoTask(0, "do the dishes");
            todoList.AddTask(task1);


            int expectedTasksNumber = 1;

            Assert.That(todoList.tasks.Count, Is.EqualTo(expectedTasksNumber));
        }

        [Test]
        public void Add2TasksTest()
        {
            TodoList todoList = new TodoList();

            var task1 = new TodoTask(0, "do the dishes");
            todoList.AddTask(task1);

            var task2 = new TodoTask(1, "do the dishes 2");
            todoList.AddTask(task2);

            int expectedTasksNumber = 2;

            Assert.That(todoList.tasks.Count, Is.EqualTo(expectedTasksNumber));
        }

        [Test]
        public void ChangeTaskStatusTest()
        {
            TodoList todoList = new TodoList();

            string taskContent = "do the dishes";
            var task1 = new TodoTask(0, taskContent);
            todoList.AddTask(task1);


            todoList.CompleteTaskByName(taskContent);
            bool expectedCompleteness = true;

            Assert.That(todoList.tasks.First().IsCompleted, Is.EqualTo(expectedCompleteness));
        }

        [Test]
        public void GetAllTasksTest()
        {
            TodoList todoList = new TodoList();

            var task1 = new TodoTask(0, "do the dishes");
            todoList.AddTask(task1);

            var task2 = new TodoTask(1, "do the dishes2");
            todoList.AddTask(task2);

            var task3 = new TodoTask(2, "do the dishes3");
            todoList.AddTask(task3);

            int expectedTasksNumber = 3;

            var allTasks = todoList.GetAllTasks();

            Assert.That(allTasks.Count, Is.EqualTo(expectedTasksNumber));
        }

        [Test]
        public void GetCompleteTasksTest()
        {
            TodoList todoList = new TodoList();

            string taskContent = "do the dishes";
            var task1 = new TodoTask(0, taskContent);
            todoList.AddTask(task1);

            var task2 = new TodoTask(1, "do the dishes2");
            todoList.AddTask(task2);

            int expectedTasksNumber = 1;

            todoList.CompleteTaskByName(taskContent);

            var completedTasks = todoList.GetCompletedTasks();

            Assert.That(completedTasks.Count, Is.EqualTo(expectedTasksNumber));
            Assert.That(completedTasks.FirstOrDefault().TaskContent, Is.EqualTo(taskContent));
        }

        [Test]
        public void GetIncompleteTasksTest()
        {
            TodoList todoList = new TodoList();

            string taskContent = "do the dishes";
            var task1 = new TodoTask(0, taskContent);
            todoList.AddTask(task1);

            var task2 = new TodoTask(1, "do the dishes2");
            todoList.AddTask(task2);

            var task3 = new TodoTask(2, "do the dishes3");
            todoList.AddTask(task3);

            int expectedTasksNumber = 2;

            todoList.CompleteTaskByName(taskContent);

            var incompletedTasks = todoList.GetIncompleteTasks();

            Assert.That(incompletedTasks.Count, Is.EqualTo(expectedTasksNumber));
        }

        [Test]
        public void GetTaskNotFoundExceptionTest()
        {
            TodoList todoList = new TodoList();

            var task1 = new TodoTask(0, "do the dishes");
            todoList.AddTask(task1);

            Assert.Throws<TaskNotFoundException>( () => todoList.GetTaskByName("name") );
        }

        [Test]
        public void RemoveTaskTest()
        {
            TodoList todoList = new TodoList();

            string taskContent = "do the dishes";
            var task1 = new TodoTask(0, taskContent);
            todoList.AddTask(task1);

            int expectedTasksNumber = 0;

            todoList.RemoveTaskByName(taskContent);

            var allTasks = todoList.GetAllTasks();

            Assert.That(allTasks.Count, Is.EqualTo(expectedTasksNumber));
        }

        [Test]
        public void GetAlphabethicallySortedTasksTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "aaa";
            var task1 = new TodoTask(0, taskContent);
            todoList.AddTask(task1);

            var task2 = new TodoTask(1, "bbb");
            todoList.AddTask(task2);

            var task3 = new TodoTask(2, "ccc");
            todoList.AddTask(task3);

            bool ascending = true;
            var sortedTasks = todoList.GetAlphabeticallySortedTasks(ascending);

            int expectedTasksNumber = 3;

            Assert.That(sortedTasks.Count, Is.EqualTo(expectedTasksNumber));

            Assert.That(sortedTasks.FirstOrDefault().TaskContent, Is.EqualTo(taskContent));
        }

        [Test]
        public void GetAlphabethicallyReverseSortedTasksTest()
        {
            TodoList todoList = new TodoList();
            var taskContent = "ddd";
            var task1 = new TodoTask(0, taskContent);
            todoList.AddTask(task1);

            var taskContent2 = "fff";
            var task2 = new TodoTask(1, taskContent2);
            todoList.AddTask(task2);

            var task3 = new TodoTask(2, "ccc");
            todoList.AddTask(task3);

            bool ascending = false;
            var sortedTasks = todoList.GetAlphabeticallySortedTasks(ascending);

            int expectedTasksNumber = 3;

            Assert.That(sortedTasks.Count, Is.EqualTo(expectedTasksNumber));
            Assert.That(sortedTasks.FirstOrDefault().TaskContent, Is.EqualTo(taskContent2));
        }

        [Test]
        public void ChangeTaskPriorityTest()
        {
            TodoList todoList = new TodoList();

            var taskContent = "ddd";
            var task1 = new TodoTask(0, taskContent);
            todoList.AddTask(task1);

            todoList.ChangeTaskPriorityByName(taskContent, TaskPriorityEnum.High);

            TaskPriorityEnum expectedTaskPriority = TaskPriorityEnum.High;

            var task = todoList.GetTaskByName(taskContent);

            Assert.That(task.Priority, Is.EqualTo(expectedTaskPriority));
        }

        [Test]
        public void GetHighPriorityTasksTest()
        {
            TodoList todoList = new TodoList();
            var taskContent = "aaa";
            var task1 = new TodoTask(0, taskContent);
            todoList.AddTask(task1);

            var taskContent2 = "bbb";
            var task2 = new TodoTask(1, taskContent2);
            todoList.AddTask(task2);

            var taskContent3 = "ccc";
            var task3 = new TodoTask(2, taskContent3);
            todoList.AddTask(task3);

            int totalTasks = 3;

            todoList.ChangeTaskPriorityByName(taskContent, TaskPriorityEnum.Low);
            todoList.ChangeTaskPriorityByName(taskContent3, TaskPriorityEnum.High);

            var prioritySortedTasks = todoList.GetAllTasksByPriority();
            Assert.That(prioritySortedTasks.Count, Is.EqualTo(totalTasks));
            Assert.That(prioritySortedTasks.FirstOrDefault().TaskContent, Is.EqualTo(taskContent3));
        }
    }
}