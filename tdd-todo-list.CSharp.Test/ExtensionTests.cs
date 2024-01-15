using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace tdd_todo_list.CSharp.Test;

[TestFixture]
public class ExtensionTests
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

    private TodoListExtension _extension;
    public ExtensionTests()
    {
        _extension = new TodoListExtension();
    }

    [TestCase(0, "Hello", 0)]
    [TestCase(1, "Another test", 1)]
    [TestCase(2, "", -1)]
    public void getByIdTest(int id, string returnName, int returnId)
    {
        TodoListExtension todo = new TodoListExtension();

        todo.add(0, "Hello");
        todo.add(1, "Another test");
        var task = todo.getById(id);

        Assert.IsNotNull(task);
        Assert.AreEqual(returnId, task.Id);
        Assert.AreEqual(returnName, task.Name);
    }

    [TestCase(0, true)]
    [TestCase(4, false)]
    public void updateNameOfIdTest(int id, bool isFound)
    {
        TodoListExtension todo = new TodoListExtension();

        todo.add(0, "Hello");
        todo.add(1, "Another test");
        bool found  = todo.updateNameOfId(id, "New name");
        var task = todo.getById(id);

        Assert.AreEqual(isFound, found);
        if (isFound )
            Assert.AreEqual("New name", task.Name);
    }

    [TestCase(0, true)]
    [TestCase(3, false)]
    public void changeStatusOfIdTest(int id, bool isFound)
    {
        TodoListExtension todo = new TodoListExtension();

        todo.add(0, "Hello");
        todo.add(1, "Another test");
        bool found = todo.setStatusOfId(id, true);
        var task = todo.getById(id);

        Assert.AreEqual(isFound, found);
        if (isFound)
            Assert.AreEqual(true, task.Completed);
    }

    [Test]
    public void printDetailedTest()
    {
        TodoListExtension todo = new TodoListExtension();

        todo.add(0, "Hello");
        todo.printDetailed();
        var outputFromConsole = consoleOutput.ToString().Trim();
        var time = DateTime.Now;

        Assert.AreEqual($"Id: 0 Task: Hello Completed: False DateTime: {time}", outputFromConsole);
    }
}
