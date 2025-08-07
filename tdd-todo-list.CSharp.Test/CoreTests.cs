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
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);


            int expectedTasksNumber = 1;

            Assert.That(todoList.tasks.Count, Is.EqualTo(expectedTasksNumber));
        }

        [Test]
        public void Add2TasksTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            string taskContent2 = "do the dishes2";
            todoList.AddTask(taskContent2);

            int expectedTasksNumber = 2;

            Assert.That(todoList.tasks.Count, Is.EqualTo(expectedTasksNumber));
        }

        [Test]
        public void ChangeTaskStatusTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);


            todoList.ChangeTaskStatus(taskContent);
            bool expectedCompleteness = true;

            Assert.That(todoList.tasks.First().IsCompleted, Is.EqualTo(expectedCompleteness));
        }

        [Test]
        public void GetAllTasksTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            string taskContent2 = "do the dishes2";
            todoList.AddTask(taskContent2);

            string taskContent3 = "do the dishes3";
            todoList.AddTask(taskContent3);

            int expectedTasksNumber = 3;

            todoList.ChangeTaskStatus(taskContent);

            var allTasks = todoList.GetAllTasks();

            Assert.That(allTasks.Count, Is.EqualTo(expectedTasksNumber));
        }

        [Test]
        public void GetCompleteTasksTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            string taskContent2 = "do the dishes2";
            todoList.AddTask(taskContent2);

            int expectedTasksNumber = 1;

            todoList.ChangeTaskStatus(taskContent);

            var completedTasks = todoList.GetCompletedTasks();

            Assert.That(completedTasks.Count, Is.EqualTo(expectedTasksNumber));
        }

        [Test]
        public void GetIncompleteTasksTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            string taskContent2 = "do the dishes2";
            todoList.AddTask(taskContent2);

            string taskContent3 = "do the dishes3";
            todoList.AddTask(taskContent3);

            int expectedTasksNumber = 2;

            todoList.ChangeTaskStatus(taskContent);

            var incompletedTasks = todoList.GetIncompleteTasks();

            Assert.That(incompletedTasks.Count, Is.EqualTo(expectedTasksNumber));
        }

        [Test]
        public void GetTaskNotFoundExceptionTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            Assert.Throws<TaskNotFoundException>( () => todoList.GetTaskByName("name") );
        }

        [Test]
        public void RemoveTaskTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

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
            todoList.AddTask(taskContent);

            string taskContent2 = "bbb";
            todoList.AddTask(taskContent2);

            string taskContent3 = "ccc";
            todoList.AddTask(taskContent3);

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
            string taskContent = "ddd";
            todoList.AddTask(taskContent);

            string taskContent2 = "bbb";
            todoList.AddTask(taskContent2);

            string taskContent3 = "ccc";
            todoList.AddTask(taskContent3);

            bool ascending = true;
            var sortedTasks = todoList.GetAlphabeticallySortedTasks(ascending);

            int expectedTasksNumber = 3;

            Assert.That(sortedTasks.Count, Is.EqualTo(expectedTasksNumber));

            Assert.That(sortedTasks.FirstOrDefault().TaskContent, Is.EqualTo(taskContent));
        }

        [Test]
        public void ChangeTaskPriorityTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "aaa";
            todoList.AddTask(taskContent);

            todoList.ChangeTaskPriorityByName(taskContent, TaskPriorityEnum.High);

            TaskPriorityEnum expectedTaskPriority = TaskPriorityEnum.High;

            var task = todoList.GetTaskByName(taskContent);

            Assert.That(task.Priority, Is.EqualTo(expectedTaskPriority));
        }

        [Test]
        public void GetHighPriorityTasksTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            string taskContent2 = "do the dishes2";
            todoList.AddTask(taskContent2);

            string taskContent3 = "do the dishes3";
            todoList.AddTask(taskContent3);

            int expectedTasksNumber = 2;

            todoList.ChangeTaskPriorityByName(taskContent, TaskPriorityEnum.High);
            todoList.ChangeTaskPriorityByName(taskContent2, TaskPriorityEnum.High);

            var incompletedTasks = todoList.GetAllTasksByPriority(TaskPriorityEnum.High);

            Assert.That(incompletedTasks.Count, Is.EqualTo(expectedTasksNumber));
        }
    }
}