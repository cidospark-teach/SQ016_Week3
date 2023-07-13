namespace Todo.Data.Entities
{
    public class MyTask
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Description { get; set; }
        public bool status { get; set; }

    }
}
