using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace forchan
{
    public class ForChan
    {
        internal Fetch.WebRequester requester;
        internal const string ThreadsList = "http://a.4cdn.org/{0}/threads.json";
        internal const string PostsList = "http://a.4cdn.org/{0}/thread/{1}.json";
        public ForChan()
        {
            requester = new Fetch.WebRequester
            {
                Throttle = new Fetch.TimedThrottler(2000)
            };
        }

        internal IEnumerable<Model.ThreadHeader> getThreads(string board){
            var str = requester.GetString(String.Format(ThreadsList, board));
            var pages =  JsonConvert.DeserializeObject<List<Model.Page>>(str);
            return pages.SelectMany(p => p.Threads);
        }

        internal IEnumerable<Model.Post> getPosts(string board, int id){
            var str = requester.GetString(String.Format(PostsList, board, id));
            var thread = JsonConvert.DeserializeObject<Model.ThreadBody>(str);
            return thread.Posts;
        }

        public Board getBoard(string name)
        {
            return new Board(name, this);
        }
    }
}
