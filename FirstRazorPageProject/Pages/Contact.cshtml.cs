using FirstRazorPageProject.Data;
using FirstRazorPageProject.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstRazorPageProject.Pages
{
    [BindProperties(SupportsGet = true)]
    public class ContactModel : PageModel
    {
        public List<CommentModel> Comments { get; set; } = default!;

        public string Username { get; set; }
        public string Message { get; set; }

        private AppDbContext dbContext { get; }

        public ContactModel(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void OnGet()
        {
            Comments = dbContext.Comments.OrderByDescending(com => com.AddedDate).ToList();
        }

        public void OnPost()
        {
            CommentModel comment = new CommentModel()
            {
                Username = Username,
                Message = Message
            };

            dbContext.Comments.Add(comment);
            dbContext.SaveChanges();

            OnGet();
		}
    }
}
