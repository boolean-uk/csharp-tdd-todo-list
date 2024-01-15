using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {

        private TodoListExtension? _extension;

        [SetUp] 
        public void SetUp() {
            _extension = new TodoListExtension();
            _extension.tasks.Add(new TodoListExtension.Task(1, "task1", false));
            _extension.tasks.Add(new TodoListExtension.Task(2, "task2", true));
            _extension.tasks.Add(new TodoListExtension.Task(3, "task3", true));
            _extension.tasks.Add(new TodoListExtension.Task(4, "task4", false));
            _extension.tasks.Add(new TodoListExtension.Task(5, "task5", true));
        }
        //* - I want to be able to get a task by a unique ID.
        //*- I want to update the name of a task by providing its ID and a new name.
        //*- I want to be able to change the status of a task by providing its ID.
        //*- I want to be able to see the date and time that I created each task.

        [Test]
        public void UpdateData() { //*- I want to update the name of a task by providing its ID and a new name.
            _extension.UpdateData(2, "Feed Bob my cat");

            TodoListExtension.Task updatedTask = _extension.tasks.FirstOrDefault(t => t._id == 2);

            Assert.NotNull()
        }
        
    }
}
