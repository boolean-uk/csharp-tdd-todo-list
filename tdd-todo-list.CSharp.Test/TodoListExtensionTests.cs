using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Xml.Linq;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class TodoListExtensionTests
    {
        [TestCase ("Wash", 1)]
        [TestCase ("Bath", 2)]
        [TestCase ("Clean", 3)]
        public void findTaskByIdTest(string name, int id)
        {
            List<TodoTaskExtension> tasks = new List<TodoTaskExtension>();
            TodoTaskExtension todo = new TodoTaskExtension(name, id);

            tasks.Add(todo);
            TodoListExtension todoList = new TodoListExtension(tasks);

            TodoTaskExtension actual = todoList.findTodoById(id);

            Assert.That(todoList.findTodoById(id).Name, Is.EqualTo(todo.Name));

        }

        [TestCase("Wash", 1, "WashBathroom")]
        [TestCase("Bath", 2, "Bathing")]
        [TestCase("Clean", 3, "CleanKitchen")]
        public void UpdateNameOfTaskTest(string name, int id, string newName)
        {
            List<TodoTaskExtension> tasks = new List<TodoTaskExtension>();
            TodoTaskExtension todo1 = new TodoTaskExtension(name, id);

            tasks.Add(todo1);
            TodoListExtension todoList = new TodoListExtension(tasks);

            TodoTaskExtension newTodo = todoList.ChangeName(id, newName);

            Assert.That(newTodo.Name, Is.EqualTo(newName));
        }

        [TestCase("Wash", 1, false, true)]
        [TestCase("Bath", 2, true, false)]
        [TestCase("Clean", 3, false, false)]
        public void UpdateStatusTest(string name, int id, bool status, bool newStatus)
        {
            List<TodoTaskExtension> tasks = new List<TodoTaskExtension>();
            TodoTaskExtension todo1 = new TodoTaskExtension(name, id);

            tasks.Add(todo1);
            TodoListExtension todoList = new TodoListExtension(tasks);
            TodoTaskExtension newTodo = todoList.UpdateStatus(id, newStatus);
            
            Assert.That(newTodo.Status, Is.EqualTo(newStatus));
        }
    }
}
