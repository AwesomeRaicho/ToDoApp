namespace Entities
{
    public class ToDo
    {
        public Guid ToDoID { get; set; }
        public DateTime? Created { get; set; }
        public string? ToDoMessage { get; set; }
        public Guid UserID { get; set; }
    }
}