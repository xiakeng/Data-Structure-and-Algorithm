using System;
using TestApp.Entities;
using TestLib;
namespace TestApp;

public class Program
{
    public static void Main(string[] args)
    {
        var obj = new TestObj()
        {
            Id = 1,
            Name = "aaa",
            Modified = DateTime.Now
        };

        var json = JsonUtils.ToJson(obj);

        Console.WriteLine(json);

        var fromJson = JsonUtils.FromJson<TestObj>(json);

        Console.ReadKey();
    }
}