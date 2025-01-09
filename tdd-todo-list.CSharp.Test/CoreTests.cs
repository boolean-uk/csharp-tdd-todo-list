using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test;

[TestFixture]
public class CoreTests
{

    [Test]
    public void CreateListTest()
    {
        TodoList todoList = TodoList.CreateList("A", "A");
        Assert.IsNotNull(todoList);
        Assert.IsNotEmpty(todoList.UUID);
        Assert.IsNotEmpty(todoList.Title);
        Assert.IsNotEmpty(todoList.CreationDateTime);
        Assert.IsNotNull(todoList.Tasks);
        Assert.IsNotEmpty(todoList.Description);
    }

    [Test]
    public void TaskCreationTest()
    {
        TodoList todoList = TodoList.CreateList("A", "A");
        Assert.That(todoList.Tasks, Is.Empty);
        todoList.AddTask("B", "BS");
        Assert.That(todoList.Tasks, Is.Not.Empty);
    }

    [Test]
    public void UpdateTaskStatusTest()
    {
        TodoList todoList = TodoList.CreateList("A", "A");
        todoList.AddTask("B", "B");
        Assert.That(todoList.Tasks[0].Completed, Is.False);
        todoList.UpdateTaskStatus(todoList.Tasks[0].UUID, true);
        Assert.That(todoList.Tasks[0].Completed, Is.True);
    }

    [Test]
    public void GetTasksWithStatusTest()
    {
        TodoList todoList = TodoList.CreateList("A", "A");
        todoList.AddTask("B", "B");
        todoList.AddTask("C", "C");
        todoList.UpdateTaskStatus(todoList.Tasks[0].UUID, true);
        Assert.That(todoList.Tasks[0].Completed, Is.True);
        Assert.That(todoList.Tasks[1].Completed, Is.Not.True);

    }

    [Test]
    public void GetTaskTest()
    {
        TodoList todoList = TodoList.CreateList("A", "A");
        todoList.AddTask("B", "B");
        TodoTask? task = todoList.GetTask(todoList.Tasks[0].UUID);
        Assert.That(task, Is.Not.Null);
    }

    [Test]
    public void DeleteTaskTest()
    {
        TodoList todoList = TodoList.CreateList("A", "A");
        Assert.That(todoList.Tasks, Is.Empty);
        todoList.AddTask("B", "B");
        Assert.That(todoList.Tasks, Is.Not.Empty);
        todoList.DeleteTask(todoList.Tasks[0].UUID);
        Assert.That(todoList.Tasks, Is.Empty);
    }

    [Test]
    public void ReadSortedAlfasc()
    {
        TodoList todoList = TodoList.CreateList("A", "A");
        todoList.AddTask("Z", "Z");
        todoList.AddTask("A", "A");
        List<TodoTask> alfasc = todoList.GetSortedTasks("alfasc");
        Assert.That(alfasc[0].Title, Is.EqualTo("A"));
        Assert.That(alfasc[1].Title, Is.EqualTo("Z"));
    }

    [Test]
    public void ReadSortedAlfdec()
    {
        TodoList todoList = TodoList.CreateList("A", "A");
        todoList.AddTask("A", "A");
        todoList.AddTask("Z", "Z");
        List<TodoTask> alfasc = todoList.GetSortedTasks("alfdec");
        Assert.That(alfasc[0].Title, Is.EqualTo("Z"));
        Assert.That(alfasc[1].Title, Is.EqualTo("A"));
    }
}