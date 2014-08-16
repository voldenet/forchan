using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forchan
{
    public class Board
    {
        internal Board(string name, ForChan context)
        {
            Name = name;
            Context = context;
        }
        internal ForChan Context { get; set; }
        public string Name { get; internal set; }
        public string Url
        {
            get
            {
                return String.Format("http://boards.4chan.org/{0}/", Name);
            }
        }
        public IEnumerable<Thread> Threads
        {
            get
            {
                foreach (var thread in Context.getThreads(Name))
                {
                    yield return new Thread { Model = thread, Context = Context, Board = this };
                }
            }
        }
    }
}
