using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forchan
{
    public class Thread
    {
        public Board Board { get; internal set; }
        internal Model.ThreadHeader Model { get; set; }
        public int Id { get { return Model.Id; } }
        public DateTime LastModified { get { return new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).AddSeconds(Model.LastModified).ToLocalTime(); } }
        internal ForChan Context { get; set; }
        public string Url
        {
            get
            {
                return String.Format("http://boards.4chan.org/{0}/thread/{1}", Board.Name, Id);
            }
        }
        public IEnumerable<Post> Posts
        {
            get
            {
                foreach (var post in Context.getPosts(Board.Name, Model.Id))
                {
                    yield return new Post { Model = post, Context = Context, Thread = this };
                }
            }
        }

        public override string ToString()
        {
            return "4chan thread: " + Id + " " + LastModified + " " + Url;
        }
    }
}
