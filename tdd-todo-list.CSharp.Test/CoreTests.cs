using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void FirstTest()
        {
            TodoList core = new TodoList();
            Assert.Pass("An instance of TodoList was successfully created.");
        }

        [Test]
        public void Add()
        {
            TodoList core = new TodoList();
            string task = "Take out the thrash";

            core.Add(task);

            Assert.IsTrue(core.Tasks.ContainsKey(task), "The task should be added to the dictionary.");
        }

        [Test]
        public void Display()
        {
            // Arrange
            TodoList core = new TodoList();
            core.Add("Task 1");
            core.Add("Task 2");

            string expectedOutput = "Task 1 (Uncompleted)" + Environment.NewLine +
                                    "Task 2 (Uncompleted)" + Environment.NewLine;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                core.Display();

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput, actualOutput, "The displayed tasks should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void DisplayFalse()
        {
            // Arrange
            TodoList core = new TodoList();
            core.Add("Task 1");
            core.Add("Task 2");

            string expectedOutput1 = "Task 1" + Environment.NewLine +
                                     "Task 2" + Environment.NewLine;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                core.Display(false);

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput1, actualOutput, "The displayed tasks should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void DisplayTrue()
        {
            // Arrange
            TodoList core = new TodoList();
            core.Add("Task 1");
            core.Add("Task 2");

            string expectedOutput1 = "";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                core.Display(true);

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput1, actualOutput, "The displayed tasks should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void DisplayAscending()
        {
            // Arrange
            TodoList core = new TodoList();
            core.Add("Task B");
            core.Add("Task A");
            core.Add("Task C");

            string expectedOutput1 = "Task A (Uncompleted)" + Environment.NewLine +
                                     "Task B (Uncompleted)" + Environment.NewLine +
                                     "Task C (Uncompleted)" + Environment.NewLine;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                core.DisplayAscending();

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput1, actualOutput, "The displayed tasks should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void DisplayAscendingFalse()
        {
            // Arrange
            TodoList core = new TodoList();
            core.Add("Task B");
            core.Add("Task A");
            core.Add("Task C");

            string expectedOutput1 = "Task A" + Environment.NewLine +
                                     "Task B" + Environment.NewLine +
                                     "Task C" + Environment.NewLine;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                core.DisplayAscending(false);

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput1, actualOutput, "The displayed tasks should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void DisplayAscendingTrue()
        {
            // Arrange
            TodoList core = new TodoList();
            core.Add("Task B");
            core.Add("Task A");
            core.Add("Task C");

            string expectedOutput1 = "";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                core.DisplayAscending(true);

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput1, actualOutput, "The displayed tasks should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void DisplayDescending()
        {
            // Arrange
            TodoList core = new TodoList();
            core.Add("Task B");
            core.Add("Task A");
            core.Add("Task C");

            string expectedOutput1 = "Task C (Uncompleted)" + Environment.NewLine +
                                     "Task B (Uncompleted)" + Environment.NewLine +
                                     "Task A (Uncompleted)" + Environment.NewLine;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                core.DisplayDescending();

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput1, actualOutput, "The displayed tasks should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void DisplayDescendingFalse()
        {
            // Arrange
            TodoList core = new TodoList();
            core.Add("Task B");
            core.Add("Task A");
            core.Add("Task C");

            string expectedOutput1 = "Task C" + Environment.NewLine +
                                     "Task B" + Environment.NewLine +
                                     "Task A" + Environment.NewLine;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                core.DisplayDescending(false);

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput1, actualOutput, "The displayed tasks should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void DisplayDescendingTrue()
        {
            // Arrange
            TodoList core = new TodoList();
            core.Add("Task B");
            core.Add("Task A");
            core.Add("Task C");

            string expectedOutput1 = "";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                core.DisplayDescending(true);

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput1, actualOutput, "The displayed tasks should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void CompleteExists()
        {
            TodoList core = new TodoList();
            string task = "Take out the thrash";

            core.Add(task);
            core.Complete(task);

            Assert.IsTrue(core.Tasks.ContainsKey(task) && core.Tasks[task] == true, "The task should be have value true.");
        }

        [Test]
        public void CompleteDoesNotExists()
        {
            TodoList core = new TodoList();
            string task = "Take out the thrash";

            string expectedOutput = "Not found\r\n";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                core.Complete(task);

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput, actualOutput, "The displayed task should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void SearchExists()
        {
            TodoList core = new TodoList();
            string task = "Take out the thrash";

            core.Add(task);

            string expectedOutput = "Take out the thrash (Uncompleted)\r\n";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                core.Search(task);

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput, actualOutput, "The displayed task should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void SearchDoesNotExists()
        {
            TodoList core = new TodoList();
            string task = "Take out the thrash";

            string expectedOutput = "Not found\r\n";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                core.Search(task);

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput, actualOutput, "The displayed task should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }

        [Test]
        public void RemoveExists()
        {
            TodoList core = new TodoList();
            string task = "Take out the thrash";

            core.Add(task);
            core.Remove(task);

            Assert.IsFalse(core.Tasks.ContainsKey(task), "The task should be added to the dictionary.");
        }

        [Test]
        public void RemoveDoesNotExists()
        {
            TodoList core = new TodoList();
            string task = "Take out the thrash";

            string expectedOutput = "Not found\r\n";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                core.Remove(task);

                // Assert
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput, actualOutput, "The displayed task should match the expected output.");

                // Reset the standard output stream
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }
        }
    }
}