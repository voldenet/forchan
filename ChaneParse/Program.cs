using System;
using System.Collections.Generic;
using System.Linq;

namespace ChaneParse
{
    public static class Expr
    {
        public static Func<forchan.Post, bool> Contains(string str)
        {
            str = str.ToUpper();
            return new Func<forchan.Post, bool>(post=>{
                if (post.Body != null)
                    return post.Body.ToUpper().Contains(str);
                return false;
            });
        }
    }
    public class Test
    {
        public static void Main()
        {
            forchan.ForChan f = new forchan.ForChan();
            var board = f.getBoard("a");
            foreach (var thr in board.Threads)
            {
                Console.WriteLine(thr.Id + " " + thr.LastModified);
                foreach (var post in thr.Posts.Where(Expr.Contains("yuri")))
                {
                    Console.WriteLine(post);
                }
            }
        }
    }
}