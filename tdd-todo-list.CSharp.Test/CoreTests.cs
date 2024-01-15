using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test;

[TestFixture]
public class CoreTests
{
    private StringWriter consoleOutput;

    [SetUp]
    public void RedirectConsoleOutput()
    {
        consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);
    }

    [TearDown]
    public void RestoreConsoleOutput()
    {
        // Clean up and restore the original standard output
        consoleOutput.Dispose();
        var standardOutput = new StreamWriter(Console.OpenStandardOutput());
        standardOutput.AutoFlush = true;
        Console.SetOut(standardOutput);
    }

    [TestCase("Write a test", true)]
    [TestCase("", false)]
    [TestCase("   ", false)]
    [TestCase("Hello", false)]
    [TestCase(" Hello ", false)]
    public void addTest(string task, bool isValid)
    {
        TodoList todoList = new TodoList();

        todoList.add("Hello");
        bool result = todoList.add(task);

        Assert.AreEqual(isValid, result);
    }

    [Test]
    public void printTest()
    {
        TodoList todoList = new TodoList();

        todoList.add("Hello");
        todoList.add("New test");
        todoList.add("Last test");
        todoList.print();
        var outputFromConsole = consoleOutput.ToString().Trim();

        Assert.AreEqual("Hello Incomplete\nNew test Incomplete\nLast test Incomplete", outputFromConsole);
    }

    [TestCase("New test", true)]
    [TestCase("Last test", false)]
    public void setStatusTest(string task, bool isFound)
    {
        TodoList todoList = new TodoList();

        todoList.add("New test");
        bool result = todoList.setStatus(task, true);

        Assert.AreEqual(isFound, result);
    }

    [TestCase("Hello", true, "Hello Complete")]
    [TestCase("New test", true, "New test Incomplete")]
    [TestCase("Last test", false, "Task not found!")]
    public void findTest(string task, bool isFound, string expectedConsoleLog)
    {
        TodoList todoList = new TodoList();

        todoList.add("Hello");
        todoList.add("New test");
        todoList.setStatus("Hello", true);
        bool result = todoList.find(task);
        var outputFromConsole = consoleOutput.ToString().Trim();

        Assert.AreEqual(isFound, result);
        Assert.AreEqual(expectedConsoleLog, outputFromConsole);
    }

    [Test]
    public void toggleShowCompletedTest()
    {
        var todoList = new TodoList();

        bool result = todoList.toggleShowCompleted();
        bool result1 = todoList.toggleShowCompleted();

        Assert.AreEqual(result, false);
        Assert.AreEqual(result1, true);
    }

    [Test]
    public void toggleShowIncompletedTest()
    {
        var todoList = new TodoList();

        bool result = todoList.toggleShowIncompleted();
        bool result1 = todoList.toggleShowIncompleted();

        Assert.AreEqual(result, false);
        Assert.AreEqual(result1, true);
    }

    [TestCase("Hello", true)]
    [TestCase("Nope", false)]
    public void removeTest(string test, bool isFound)
    {
        var todoList = new TodoList();

        todoList.add("Hello");
        bool result = todoList.remove(test);

        Assert.AreEqual(isFound, result);
    }

    [Test]
    public void printAscendingTest()
    {
        TodoList todoList = new TodoList();

        todoList.add("Hello");
        todoList.add("New test");
        todoList.add("Last test");
        todoList.printAscending();
        var outputFromConsole = consoleOutput.ToString().Trim();

        Assert.AreEqual("Hello Incomplete\nLast test Incomplete\nNew test Incomplete", outputFromConsole);
    }

    [Test]
    public void printDescendingTest()
    {
        TodoList todoList = new TodoList();

        todoList.add("Hello");
        todoList.add("New test");
        todoList.add("Last test");
        todoList.printDescending();
        var outputFromConsole = consoleOutput.ToString().Trim();

        Assert.AreEqual("New test Incomplete\nLast test Incomplete\nHello Incomplete", outputFromConsole);
    }

    [Test]
    public void printOnlyComplete()
    {
        TodoList todoList = new TodoList();

        todoList.add("Hello");
        todoList.add("New test");
        todoList.add("Last test");
        todoList.setStatus("Hello", true);
        todoList.toggleShowIncompleted();
        todoList.print();
        var outputFromConsole = consoleOutput.ToString().Trim();

        Assert.AreEqual("Incompleted tasks now hidden.\r\nHello Complete", outputFromConsole);
    }

    [Test]
    public void printOnlyIncomplete()
    {
        TodoList todoList = new TodoList();

        todoList.add("Hello");
        todoList.add("New test");
        todoList.add("Last test");
        todoList.setStatus("Hello", true);
        todoList.toggleShowCompleted();
        todoList.print();
        var outputFromConsole = consoleOutput.ToString().Trim();

        Assert.AreEqual("Completed tasks now hidden.\r\nNew test Incomplete\nLast test Incomplete", outputFromConsole);
    }
}