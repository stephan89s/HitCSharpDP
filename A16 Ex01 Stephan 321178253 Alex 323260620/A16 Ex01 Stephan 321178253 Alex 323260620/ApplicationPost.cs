using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    public class ApplicationPost : IPublishable
    {
        public string From { get; }
        public string Message { get; }
        public string Title { get; }
        public Post.eType? Type { get; }
        public string Link { get; }
        public DateTime? CreatedTime { get; }
        public DateTime? UpdateTime { get; }
        private readonly string r_PostID;


        public ApplicationPost(Post i_Post)
        {
            Message = i_Post.Message != null ? i_Post.Message : string.Empty;
            From = i_Post.From.Name != null ? i_Post.From.Name : string.Empty;
            Title = i_Post.Name != null ? i_Post.Name : string.Empty;
            Link = i_Post.Link != null ? i_Post.Link : string.Empty;
            Type = i_Post.Type;
            CreatedTime = i_Post.CreatedTime;
            UpdateTime = i_Post.UpdateTime;
            r_PostID = i_Post.Id;
            
        }

        public string GetPublishedItemID()
        {
            return r_PostID;
        }
    }
}

