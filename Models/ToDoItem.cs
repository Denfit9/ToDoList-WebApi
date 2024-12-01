namespace ToDoList.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
