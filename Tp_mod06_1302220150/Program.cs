// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;


class program()
{
    Random random = new Random();
    static void Main(string[] args)
    {
        SayaTube s = new SayaTube("Tutorial Design By Contract - [Haikal Risnandar]");
        s.increasePlaycount(102030);
        s.printvideoDetails();
    }
}