namespace MVC_Burger_Project.Models.Entities
{
    public class Feedback
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime CommentTime { get; set; } = DateTime.Now;
    }
}
