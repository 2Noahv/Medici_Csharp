using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Csharp2023
{
	class Figure
	{
		public double X, Y, Z;

		public Figure()
		{
		}

		public Figure(double x)
		{
			this.X = x;
		}

		public Figure(double x, double y)
		{
			this.X = x;
			this.Y = y;
		}

		public Figure(double x, double y, double z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public void PrintInfo()
		{
			if (this.X != 0 && this.Y == 0 && this.Z == 0)
			{
				Console.WriteLine("타원 도형 정보");
				Console.WriteLine($"반지름 : {this.X} cm");
				Console.WriteLine($"넓이 : {this.X * this.X * 3.14} cm");

			}
			else if (this.X != 0 && this.Y != 0 && this.Z == 0)
			{
				Console.WriteLine("================");
				Console.WriteLine("사각형 도형 정보");
				Console.WriteLine($"가로 : {this.X} cm");
				Console.WriteLine($"높이 : {this.Y} cm");
				Console.WriteLine($"넓이 : {this.X * this.Y} cm");

			}
			else if (this.X != 0 && this.Y != 0 && this.Z != 0)
			{
				Console.WriteLine("================");
				Console.WriteLine("사다리꼴 도형 정보");
				Console.WriteLine($"윗변 : {this.X} cm");
				Console.WriteLine($"아랫변 : {this.Y} cm");
				Console.WriteLine($"높이 : {this.Z} cm");
				Console.WriteLine($"넓이 : {(this.X + this.Y) * this.Z / 2} cm");

			}
			else
			{
				Console.Write("입력 및 출력 오류");
				Console.WriteLine("================");
			}



		}
	}

	class day7_2
	{
		static void Main()
		{
			Figure figure = new Figure();
			Figure circle = new Figure(2.5);
			Figure square = new Figure(4.5, 3.0);
			Figure trapezoid = new Figure(1.5, 3.0, 2.5);
			figure.PrintInfo();
			circle.PrintInfo();
			square.PrintInfo();
			trapezoid.PrintInfo();

		}
	}
}