using System;

namespace Csharp2023
{
	public abstract class Car
	{
		//추상화 클래스
		int Speed = 0; // 한정자 생략시 private

		void UpSpeed(int speed)
		{
			this.Speed += speed;
		}
	}

	public class Sedan : Car
	{
	}

	public class Truck : Car
	{
	}
	
	
	//추상 메소드
	public abstract class Shape
	{
		//상속할 때 virtual 키워드 안 씀 
		public abstract double GetArea();
	}

	public class Square : Shape
	{
		private int Size;
		public Square(int size)
		{
			this.Size = size;
		}

		//오버라이딩을 안하면 추상화 메소드 때문에 오류가 난다.
		public override double GetArea()
		{
			return this.Size * this.Size;
		}
	}

	public class Circle : Shape
	{
		private double Radius;

		public Circle(double radius)
		{
			this.Radius = radius;
		}

		//오버라이딩을 안하면 추상화 메소드 때문에 오류가 난다.
		public override double GetArea()
		{
			return this.Radius * this.Radius * 3.14;
		}

	}

	//Animal 추상 클래스를 이용하여 객체화 해서 출력하라
	abstract class Animal
	{
		private int Time;
		private string Where;
		private string What;

		public int GetTime()
		{
			return this.Time;
		}

		public string GetWhere()
		{
			return this.Where;
		}

		public string GetWhat()
		{
			return this.What;
		}

		public void SetTime(int time)
		{
			this.Time = time;
		}

		public void SetWhere(string where)
		{
			this.Where = where;
		}

		public void SetWhat(string what)
		{
			this.What = what;
		}

		public void Run()
		{
            Console.WriteLine($"엄청 빨리 달린다");
        }

		public abstract void Sleep(int time, string where);
		public abstract void Hunt(string what, string where);
	}

	class Tiger : Animal
	{
		public override void Sleep(int time, string where)
		{
			SetTime(time);
			SetWhere(where);
			Console.WriteLine($"호랑이가 {GetTime()}시간을 {GetWhere()}에서 잤다.");
        }

		public override void Hunt(string where, string what)
		{
			SetWhere(where);
			SetWhat(what);
			Console.WriteLine($"호랑이가 {GetWhere()}에서 {GetWhat()}을/를 사냥한다.");
		}

	}

	class Cat : Animal
	{
		public override void Sleep(int time, string where)
		{
			SetTime(time);
			SetWhere(where);
			Console.WriteLine($"고양이가 {GetTime()}시간을 {GetWhere()}에서 잤다.");
		}

		public override void Hunt(string where, string what)
		{
			SetWhere(where);
			SetWhat(what);
			Console.WriteLine($"고양이가 {GetWhere()}에서 {GetWhat()}을/를 사냥한다.");
		}
	}


	internal class day8_4
	{
		static void Main()
		{
			// 객체화 
			Console.WriteLine("\n\n 추상 클래스 테스트1");
			// Car car1 = new Car(); // 오류 발생 
			Sedan sedan1 = new Sedan();
			Console.WriteLine("\n\t 승용차 인스턴스 생성~~~");
			sedan1.UpSpeed(10);
			Console.WriteLine("\t\t 현재 속도 : " + sedan1.Speed);
			Truck truck1 = new Truck();
			Console.WriteLine("\n\t 트럭 인스턴스 생성~~~");
			truck1.UpSpeed(30);
			Console.WriteLine("\t\t 현재 속도 : " + truck1.Speed);

			Square square = new Square(10);
            Console.WriteLine(square.GetArea());

			Circle circle = new Circle(5.5);
			Console.WriteLine(circle.GetArea());
            Console.WriteLine("====================\n");

            Tiger tiger = new Tiger();
			tiger.Run();
			tiger.Sleep(7, "동굴");
			tiger.Hunt("바다", "물고기");
			Console.WriteLine();

			Cat cat = new Cat();
			cat.Run();
			cat.Sleep(3, "침대");
			cat.Hunt("공원", "쥐");
			Console.WriteLine("====================\n");



		}
	}
}
