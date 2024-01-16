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
        [Test]
        public void FirstTest()
        {
            TodoListExtension todoList = new TodoListExtension();
            Assert.Pass("An instance of TodoList was successfully created.");
        }

        [Test]
        public void Add()
        {
            TodoListExtension todoList = new TodoListExtension();
            string description = "Take out the thrash";

            int id = todoList.Add(description);

            Assert.IsTrue(todoList.Tasks[id].Description == description, "The task should be added to the dictionary.");
        }

        [Test]
        public void SearchMatch()
        {
            TodoListExtension todoList = new TodoListExtension();
            string description = "Take out the thrash";

            int id = todoList.Add(description);

            string expectedOutput = "Take out the thrash (Uncompleted)\r\n";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                todoList.Search(id);

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput, actualOutput, "The displayed task should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]

        public void SearchNoMatch()
        {
            TodoListExtension todoList = new TodoListExtension();
            string description = "Take out the thrash";

            int id = todoList.Add(description);

            string expectedOutput = "Not found\r\n";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                todoList.Search(1331);

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput, actualOutput, "The displayed task should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void RenameMatch()
        {
            TodoListExtension todoList = new TodoListExtension();
            string description = "Take out the thrash";
            string newDescription = "Take out the wife";

            int id = todoList.Add(description);
            todoList.Rename(id, newDescription);

            Assert.IsTrue(todoList.Tasks[id].Description != description, "The tasks description should not be equal to the old description.");
            Assert.IsTrue(todoList.Tasks[id].Description == newDescription, "The tasks description should be equal to the new description.");
        }

        [Test]
        public void RenameNoMatch()
        {
            TodoListExtension todoList = new TodoListExtension();
            string description = "Take out the thrash";
            string newDescription = "Take out the wife";

            int id = todoList.Add(description);
            todoList.Rename(id, newDescription);

            string expectedOutput = "Not found\r\n";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                todoList.Rename(1331, newDescription);

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput, actualOutput, "The displayed task should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void CompleteMatch()
        {
            TodoListExtension todoList = new TodoListExtension();
            string description = "Take out the thrash";

            int id = todoList.Add(description);
            todoList.Complete(id);

            Assert.IsTrue(todoList.Tasks[id].IsComplete, "The task should be completed.");
        }

        [Test]
        public void CompleteNoMatch()
        {
            TodoListExtension todoList = new TodoListExtension();
            string description = "Take out the thrash";

            int id = todoList.Add(description);
            todoList.Complete(id);

            string expectedOutput = "Not found\r\n";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                todoList.Complete(1331);

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput, actualOutput, "The display should show \"Not found\"");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void Display()
        {
            // Arrange
            TodoListExtension todoList = new TodoListExtension();
            int id1 = todoList.Add("Task 1");
            int id2 = todoList.Add("Task 2");

            DateTime creation1 = todoList.Tasks[id1].Creation;
            DateTime creation2 = todoList.Tasks[id1].Creation;

            string expectedOutput = $"Task 1 (Uncompleted) ({creation1})" + Environment.NewLine +
                                    $"Task 2 (Uncompleted) ({creation2})" + Environment.NewLine;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                todoList.Display();

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput, actualOutput, "The displayed tasks should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }
    }
}
