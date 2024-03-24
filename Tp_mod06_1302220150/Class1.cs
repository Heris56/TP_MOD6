using System;

public class SayaTube
{
	Random random = new Random();
     public int id;
	private String title;
	private int playCount;
    public SayaTube(String Judul)
	{
		this.title = Judul;
		this.id = random.Next(10000, 99999);
		this.playCount = 0;
	}

	public void increasePlaycount(int playCount)
	{
		this.playCount = playCount;
	}

	public void printvideoDetails()
	{
		Console.WriteLine("id\t\t: " +  this.id);
		Console.WriteLine("title\t\t: " + this.title);
		Console.WriteLine("play count\t: " + this.playCount);
	}
}
