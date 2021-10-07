using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtraBlogApi.Models;
using XtraBlogApi.Repository.IRepository;

namespace XtraBlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {

        private readonly IPostRepository Post;
        private readonly ICommentRepository Comment;
        private readonly ICategoryRepository Category;
        private readonly IUserRepository User;

        public BlogController(IPostRepository post, IUserRepository user, ICategoryRepository category, ICommentRepository comment)
        {
            Post = post;
            Comment = comment;
            Category = category;
            User = user;

        }

        #region GET

        [HttpGet("Posts")]
        public async Task<List<PostCategories>> Posts()
        {
            return await Post.Posts();
        }

        [HttpGet("Categories")]
        public async Task<List<Category>> Categories()
        {
            return await Category.Categories();
        }

        [HttpGet("Comments")]
        public async Task<List<Comment>> Comments()
        {
            return await Comment.Comments();
        }

        [HttpGet("Users")]
        public async Task<List<User>> Users()
        {
            return await User.Users();
        }

        [HttpGet("User")]
        public async Task<bool> Users([FromQuery] string email, [FromQuery] string password)
        {
            return await User.User(email, password);
        }


        #endregion

        #region POST

        [HttpPost("DeletePost")]
        public async Task<bool> DeletePost([FromBody] int id)
        {
            return await Post.DeletePost(id);
        }

        [HttpPost("DeleteCategory")]
        public async Task<bool> DeleteCategory([FromBody] int id)
        {
            return await Category.DeleteCategory(id);
        }

        [HttpPost("DeleteComment")]
        public async Task<bool> DeleteComment([FromBody] int id)
        {
            return await Comment.DeleteComment(id);
        }

        [HttpPost("DeleteUser")]
        public async Task<bool> DeleteUser([FromBody] int id)
        {
            return await User.DeleteUser(id);
        }

        [HttpPost("UpdatePost")]
        public async Task<bool> UpdatePost([FromBody] Post post)
        {
            return await Post.UpdatePost(post);
        }

        [HttpPost("UpdateCategory")]
        public async Task<bool> UpdateCategory([FromBody] Category category)
        {
            return await Category.UpdateCategory(category);
        }

        [HttpPost("UpdateComment")]
        public async Task<bool> UpdateComment([FromBody] Comment comment)
        {
            return await Comment.UpdateComment(comment);
        }

        [HttpPost("UpdateUser")]
        public async Task<bool> UpdateUser([FromBody] User user)
        {
            return await User.UpdateUser(user);
        }

        [HttpPost("NewPost")]
        public async Task<bool> NewPost([FromBody] Post post)
        {
            return await Post.NewPost(post);
        }

        [HttpPost("NewCategory")]
        public async Task<bool> NewCategory([FromBody] Category category)
        {
            return await Category.NewCategory(category);
        }

        [HttpPost("NewComment")]
        public async Task<bool> NewComment([FromBody] Comment comment)
        {
            return await Comment.NewComment(comment);
        }

        [HttpPost("NewUser")]
        public async Task<bool> NewUser([FromBody] User user)
        {
            return await User.NewUser(user);
        }

        #endregion
    }
}

