forchan
=======
Simple .net api for 4chan, uses throttled WebRequest.
`foreach (var thread in new forchan.ForChan().getBoard("s4s").Threads)
{
    Console.WriteLine(thread);
    foreach (var post in thread.Posts)
    {
        Console.WriteLine(post);
    }
}`
