namespace Extension
{
    public class TaskItemExtension
{
        public string Name { get; set; }
        public int Id { get; set; }
        public String DateTime { get; set; }
        public bool IsComplete { get; set; } = false;

        public TaskItemExtension(string name, int id, String dateTime)
        {
            Name = name;
            Id = id;
            DateTime = dateTime;
        }

    }
}
