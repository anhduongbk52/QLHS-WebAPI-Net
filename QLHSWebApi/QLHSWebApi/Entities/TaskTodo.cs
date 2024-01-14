using QLHSWebApi.Entities.Enum;

namespace QLHSWebApi.Entities
{
    public class TaskTodo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? Assignee { get; set; }
        public DateTime CreateDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
    }
}
