using System;

public class SayaTube
{
	Random random = new Random();
    private int id;
	private String title;
	private int playCount;
    public SayaTube(String Judul)
	{
		if (String.IsNullOrEmpty(Judul) || Judul.Length >100) {
			Console.WriteLine("inputan tidak valid");
		}
		else
		{
            this.title = Judul;
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }
		
	}

	public void increasePlaycount(int playCount)
	{
		if(playCount > 10000000)
		{
			Console.WriteLine("input Playcount invalid");
		}
		else
		{
            try
			{
				checked
				{
                    this.playCount = this.playCount + playCount;
                }
			}
			catch (OverflowException)
			{
				Console.WriteLine("Overflow");
			}
        }
		
	}

	public void printvideoDetails()
	{
		Console.WriteLine("id\t\t: " +  this.id);
		Console.WriteLine("title\t\t: " + this.title);
		Console.WriteLine("play count\t: " + this.playCount);
	}
}
