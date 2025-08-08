using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;
using static tdd_todo_list.CSharp.Main.TodoList;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        private TodoListExtension _extension;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();
        }

        [Test]
        public void GetTaskByIdTest()
        {
            TodoList todoList = new TodoList();

            int id = todoList.Add("oppvask");

            TodoList.Task task = todoList.GetTask(id);

            Assert.That(task.Id, Is.EqualTo(id));
        }

        [Test]
        public void SetTaskNameTest()
        {
            TodoList todoList = new TodoList();
            int id = todoList.Add("oppvask");

            bool result = todoList.SetTaskName(id, "oppdatert");

            Assert.That(todoList.Tasks.First().Value.Name == "oppdatert");
        }

        [Test]
        public void SeeDateTime()
        {
            TodoList todoList = new TodoList();
            int id = todoList.Add("oppvask");

            Assert.That(todoList.Tasks.First().Value.CreatedAt.DayOfWeek, Is.EqualTo(DateTime.Now.DayOfWeek));
        }

        [Test]
        public void SeeCompleteTime()
        {
            TodoList todoList = new TodoList();
            int id = todoList.Add("oppvask");
            todoList.Tasks.First().Value.CompletedAt = DateTime.Now;

            Assert.That(todoList.Tasks.First().Value.CompletedAt.DayOfWeek, Is.EqualTo(DateTime.Now.DayOfWeek));
        }

        // Longest amount of time
        [Test]
        public void LongestTimeTaskTest()
        {
            TodoList todoList = new TodoList();
            int id = todoList.Add("oppvask", category: "study");
            int id2 = todoList.Add("kode", category: "work");

            TodoList.Task task = todoList.Tasks.First().Value;
            task.CreatedAt = DateTime.Now.AddDays(-6);

            // Complete task
            todoList.CompleteTask(id);
            todoList.CompleteTask(id2);

            Assert.That(todoList.LongestTask.Id, Is.EqualTo(id));
        }

        // Shortest amount of time
        [Test]
        public void ShortestTimeTaskTest()
        {
            TodoList todoList = new TodoList();
            int id = todoList.Add("oppvask", category: "study");
            int id2 = todoList.Add("kode", category: "work");

            TodoList.Task task = todoList.Tasks.First().Value;
            task.CreatedAt = DateTime.Now.AddDays(-6);

            // Complete task
            todoList.CompleteTask(id);
            todoList.CompleteTask(id2);

            Assert.That(todoList.ShortestTask.Id, Is.EqualTo(id2));
        }

        // Tasks longer than 5 days
        [Test]
        public void GetLongerThanFiveTest()
        {
            TodoList todoList = new TodoList();
            int id = todoList.Add("oppvask", category: "study");
            int id2 = todoList.Add("kode", category: "work");

            // Set creation time to 6 days ago
            TodoList.Task task = todoList.Tasks.First().Value;
            task.CreatedAt = DateTime.Now.AddDays(-6);

            // Complete task
            todoList.CompleteTask(id);

            Assert.That(task.CompletionTime.TotalDays, Is.GreaterThan(5));
        }

        [Test]
        public void CategorizeTaskTest()
        {
            TodoList todoList = new TodoList();
            int id = todoList.Add("oppvask", category: "study");
            int id2 = todoList.Add("kode", category: "work");
            int id3 = todoList.Add("gaming", category: "admin");

            List<TodoList.Task> tasks = todoList.Tasks.Values.ToList();


            Assert.That(tasks[0].Category == "study");
        }

        [Test]
        public void GetTasksByCategoryTest()
        {
            TodoList todoList = new TodoList();
            int id = todoList.Add("oppvask", category: "study");
            int id2 = todoList.Add("kode", category: "work");
            int id3 = todoList.Add("gaming", category: "admin");

            List<TodoList.Task> task = todoList.GetTasksByCategory("study");

            Assert.That(task[0].Category == "study");
        }
    }
}
