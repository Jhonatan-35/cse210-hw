using System;

class Program
{
    static void Main(string[] args)
    {
        VideoList videoList = new VideoList();
        string viewList = videoList.DisplayList();
        Console.WriteLine(viewList);

    }
}