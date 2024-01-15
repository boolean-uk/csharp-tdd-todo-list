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
        
        
        

        [Test]
        public void TestGetTaskById() { //* - I want to be able to get a task by a unique ID.
            TodoListExtension.Task foundTask = _extension.GetTask(2);

            Assert.IsNotNull(foundTask);
            Assert.AreEqual(2, foundTask._id);
        }

        [Test]
        public void TestUpdateData() { //*- I want to update the name of a task by providing its ID and a new name.
            _extension.UpdateData(2, "Feed Bob my cat");

            TodoListExtension.Task updatedTask = _extension.tasks.FirstOrDefault(t => t._id == 2);

            Assert.NotNull(updatedTask);
            Assert.AreEqual("Feed Bob my cat", updatedTask.task);
        }

        [Test]
        public void TestChangeState() { //*- I want to be able to change the status of a task by providing its ID.
            _extension.ChangeStatus(2, false);

    
            TodoListExtension.Task updatedTask = _extension.tasks.FirstOrDefault(t => t._id == 2);

            Assert.NotNull(updatedTask, "Task with the specified ID should exist");
            Assert.AreEqual(false, updatedTask.state, "Task state should be updated");
        }
        

        [Test]
        public void TestTimeStamp() { //*- I want to be able to see the date and time that I created each task.
            List<string> tasks = _extension.DisplayList();

    
            foreach (string task in tasks) {
                string[] taskParts = task.Split(new[] { "created at: " }, StringSplitOptions.RemoveEmptyEntries);

                Assert.IsTrue(taskParts.Length >= 2);

                string timestampPart = taskParts[1].Trim();

                Assert.IsTrue(DateTime.TryParseExact(timestampPart, "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out _));
            }
        }
        
        
    }
}
