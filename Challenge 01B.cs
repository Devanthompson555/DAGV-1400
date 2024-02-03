using System;
					
public class Program
{
	public static void Main()
	{
int num01;
float num02;
float num03;
float num04;
Console.WriteLine("What is the weather today in Celcius");

 num01 = Convert.ToInt32( Console.ReadLine() );

 if (num01 >= 30) {

Console.WriteLine("Weather is rough today, make sure you stay hydrated and stay out of the sun today");
// Code for letting them know weather is warm based off given num01
 }
 else {
Console.WriteLine("Weather is nice today, Enjoy the pleasant weather");
 }
// code for letting them know weather is nice based on num01
 Console.WriteLine("What grade did you get on your homework?");
 
 num02 = Convert.ToInt32 (Console.ReadLine() );

 Console.WriteLine("What was it out of?");

 num03 = Convert.ToInt32 (Console.ReadLine());
 num04 = Convert.ToInt32 (num02 / num03 * 100); //takes both given numbers and turns it into a percentage
 Console.WriteLine(num02 + " Out of " + num03 + " Is " + num04 + " Percent."); 

if (num04 > 94 ) { //following code is a long if else statement to check grade and give a letter grade based on the percentage.
    Console.WriteLine("You got an A for being above 94% goodjob");
}
else if (num04 < 94 && num04 > 90){
    Console.WriteLine(" You got an A- by being above 90% but not quite above 94%, keep at it!");
}

else if (num04 <90 && num04 > 86) {
    Console.WriteLine("You got a B+ Keep at it, you need to be at 90% to have an A-");

}

else if (num04 <86 && num04 > 83) {
    Console.WriteLine("You got a B Keep at it, you need to be at 83% to have an B+");
}
else if (num04 <83 && num04 > 80) {
    Console.WriteLine("You got a B- Keep at it, you need to be at 80% to have an B");
}
else if (num04 <80 && num04 > 76) {
    Console.WriteLine("You got a C+ Keep at it, you need to be at 76% to have an B-");

}
else if (num04 <76 && num04 > 73) {
    Console.WriteLine("You got a C Keep at it, you need to be at 73% to have a C+");
}

else if (num04 <73 && num04 > 70) {
    Console.WriteLine("You got a C- Keep at it, you need to be at 70% to have a C");
}
else if (num04 <70 && num04 > 66) {
    Console.WriteLine("You got a D+ Keep at it, you need to be at 66% to have an C-");
}
else if (num04 <66 && num04 > 63) {
    Console.WriteLine("You got a D Keep at it, you need to be at 63% to have an D+");
}

else if (num04 <63 && num04 > 60) {
    Console.WriteLine("You got a D- Keep at it, you need to be at 60% to have an D");
}
else if (num04 < 59) {
    Console.WriteLine("You got an F Keep at it, you need to be at 59% to have an D-");
}
//end of letter grading else if statement


Console.WriteLine("What day of the week is it?");
//Switch to ask the day of the week
string day = Console.ReadLine();
switch (day)
{
case "Monday":
    Console.WriteLine("Happy monday!");
    break;
case "Tuesday":
    Console.WriteLine("Happy Tueday!");
    break;
case "Wednesday":
    Console.WriteLine("Happy Wednesday!");
    break;
case "Thursday":
    Console.WriteLine("Happy Thursday!");
    break;
case "Friday":
    Console.WriteLine("Happy Friday!");
    break;
case "Saturday":
    Console.WriteLine("Happy Saturday!");
    break;
case "Sunday":
    Console.WriteLine("Happy Sunday!");
    break;
default: //If not given a date.
    Console.WriteLine(day + " is not a day of the week.");
	break;




}

    }
}
