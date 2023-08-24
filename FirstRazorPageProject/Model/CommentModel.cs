namespace FirstRazorPageProject.Model;

public class CommentModel
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Message { get; set; }
    public DateTime AddedDate { get; set; } = DateTime.Now;
}
