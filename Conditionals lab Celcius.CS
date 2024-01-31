using System;
					
public class Program
{
	public static void Main()
	{
		int num01;
	Console.WriteLine("What is the weather today in Celcius");

 num01 = Convert.ToInt32( Console.ReadLine() );

 if (num01 >= 30) 
 {

Console.WriteLine("Weather is rough today, make sure you stay hydrated and stay out of the sun today");

 }
 else {
Console.WriteLine("Weather is nice today, Enjoy the pleasant weather");
 }
	}
}
