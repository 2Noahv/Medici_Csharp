using System;

namespace Csharp2023
{
	class MyClassA
	{
		public int X = 100;
		// int Y = 200; // private 생략가능 
		private int Y = 200; // 같은 클래스안에서 수정 + 읽기
		protected int Z = 300; // 상속관계와 같은 클래스안에서 수정 + 읽기

		// public 메서드로 지정 : Y 값 읽기 용도 
		public int GetY()
		{
			return this.Y;
		}

		// public 메서드로 지정 : Z 값 읽기 용도 
		public int GetZ()
		{
			return this.Z;
		}

		// public 메서드로 지정 : Y 값 수정용도 
		public void SetY(int y)
		{
			this.Y = y;
		}

		// public 메서드로 지정 : Z 값 수정용도 
		public void SetZ(int z)
		{
			this.Z = z;
		}
	}

	class MyClassB : MyClassA
	{
		// public 메서드로 지정 : Z 값 읽기 용도 
		public void Get_info()
		{
			Console.WriteLine($"X = {this.X}");
			// Console.WriteLine($"Y = {this.Y}"); 
			Console.WriteLine($"Z = {this.Z}");
		}

		// public 메서드로 지정 : Z 값 수정용도 
		public void Set_X_Z(int x, int z)
		{
			this.X = x;
			this.Z = z;
		}
	}

	internal class day8_3
	{
		static void Main()
		{
			MyClassA class_a = new MyClassA();
            Console.WriteLine($"X = {class_a.X}");
			class_a.X = 500;
            Console.WriteLine($"X = {class_a.X}");
			Console.WriteLine();

			//class_a.Y = 900;
            //Console.WriteLine($"Y = {class_a.Y}");
			Console.WriteLine($"X = {class_a.GetY()}");
			class_a.SetY(900);
			Console.WriteLine($"Y = {class_a.GetY()}");
			Console.WriteLine();

			MyClassB class_b = new MyClassB();
			class_b.Get_info();

			//class_b.Z = 77;
			class_b.Set_X_Z(55, 77);
			class_b.Get_info();
			Console.WriteLine();

			//추상클래스




		}
	}
}
