// C# Object Orientated Programming box area maths.
using System;
namespace BoxMaths
{
	class Box  //Object Box, with return area maths method. 
	{
		public double l,w,h; //set the variables.
		public double volume(double l,double w,double h) 		
		{
			return (l*w*h);
		}
	}	
	class Program //Build new Object Box1, asign values and write volume.
	{
		public static void Main(string []args)
		{
			//Copies the Box class/object and makes a new one Box1.
			//class, object, =new class method, builds the new object.
			Box Box1 = new Box();
			//new object Box1's length, asigning a new value to it.
			Box1.l = 10;
			//new object Box1's width, asigning a new value to it.
			Box1.w = 10;
			//new object Box1's height, asigning a new value to it.
			Box1.h = 10;
			
			Console.Write("The volume of Mike's C# Box1 is: {0}",Box1.volume(Box1.l, Box1.w, Box1.h));
			Console.ReadKey(true); 
		}
	}
}