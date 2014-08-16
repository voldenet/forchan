using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forchan
{
    public class Post
    {

        internal Model.Post Model { get; set; }
        public Thread Thread { get; internal set; }
        internal ForChan Context { get; set; }
        public int Id { get { return Model.Id; } }
        public string CreationDate { get { return Model.CreationDate; } }
        public string Author { get { return Model.Author; } }
        public string HtmlBody { get { return Model.Body; } }
        public string Body
        {
            get
            {
                return Helpers.HtmlHelper.HtmlToPlain(HtmlBody);
            }
        }
        public int ResponseTo
        {
            get
            {
                return Model.ResponseTo;
            }
        }
        public File File
        {
            get
            {
                if (!string.IsNullOrEmpty(Model.Filename))
                {
                    return new File { Model = Model };
                }
                return null;
            }
        }
        public string TripCode { get { return TripCode; } }
        public string Url
        {
            get
            {
                return String.Format("http://boards.4chan.org/{0}/thread/{1}#p{2}", Thread.Board.Name, Thread.Id, Id);
            }
        }

        public override string ToString()
        {
            return "4chan post: " + Id + ", "+ Author +", " + CreationDate + " " + Url ;
        }
    }
}
