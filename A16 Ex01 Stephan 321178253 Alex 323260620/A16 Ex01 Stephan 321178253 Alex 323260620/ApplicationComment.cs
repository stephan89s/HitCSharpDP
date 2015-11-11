using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    public class ApplicationComment
    {
        public string From { get; }
        public string Comment { get; }
        public DateTime? CreatedTime { get; }
       

        public ApplicationComment(Comment i_Comment)
        {
            From = i_Comment.From.Name != null ? i_Comment.From.Name : string.Empty;
            Comment = i_Comment.Message != null ? i_Comment.Message : string.Empty;
            CreatedTime = i_Comment.CreatedTime;
           
        }
    }
}
