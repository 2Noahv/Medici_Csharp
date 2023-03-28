using System;

namespace Csharp2023
{
	class Parent
	{
		public void Foo()
		{
			Console.WriteLine("부모 메소드");
		}
	}

	class Child : Parent
	{
		public void Bar()
		{
			Console.WriteLine("자식 메소드");
		}
	}

	// 상속 테스트 2
	// Animal => Tiger
	class Animal
	{
		public int Leg = 4;

		public void Eattt()
		{
			Console.WriteLine("======== 먹다 =======");
		}
	}

	class Tiger : Animal
	{
		public string Gender;
		public string Name;

		public void Run()
		{
			Console.WriteLine("======== 달리다 =======");
		}

	}


	// 상속 테스트 3
	// Car => Sedan, Truck
	public class Car
	{
		public string color;
		public int speed;

		public void UpSpeed(int value)
		{
			speed = speed + value;
		}

		public void DownSpeed(int value)
		{
			speed = speed - value;
		}
	}

	public class Sedan : Car
	{
		public int seatNum;

		public int GetSeatNum()
		{
			return seatNum;
		}
	}

	public class Truck : Car
	{
		public int capacity;

		public int GetCapacity()
		{
			return capacity;
		}
	}

	class Dinosaur
	{
		public string Kind;

		public string Sleep(string sleep)
		{
           return $"\t{sleep}에서 잔다!!!";
        }

		public string Eat(string eat)
		{
			return $"\t{eat}를/을 먹는다!!!";
		}

	

	}

	class Tyrano : Dinosaur
	{
		public string Name;

		public string Hunt(string name, string hunt)
		{
			this.Kind = name;
			this.Name = hunt;
			return $"\t{this.Kind}가 {this.Name}를/을 사냥한다!!!";
		}
	}


	class Dooly : Dinosaur
	{
		public string Name;

		public string Dance(string name)
		{
			this.Name = name;
			return $"\t{this.Name}가 춤춘다!!!";
		}

		public string Sing(string name)
		{
			this.Name = name;
			return $"\t{this.Name}가 노래한다!!!";
		}

	}

	

	internal class day8_1
	{
		static void Main()
		{

			Console.WriteLine("==================");
			Console.WriteLine("상속 테스트1");
			Child child = new Child();
			child.Foo();
			child.Bar();

			Console.WriteLine("\n\n ==================");
			Console.WriteLine("상속 테스트2");

			// 부모 클래스 인스턴스 
			Animal animal = new Animal();
			Console.WriteLine(animal.Leg);
			animal.Eattt();

			// 자식 클래스 인스턴스 
			Tiger tiger = new Tiger();
			Console.WriteLine(tiger.Leg);
			tiger.Name = "호순이";
			tiger.Gender = "여";
			Console.WriteLine(tiger.Name);
			Console.WriteLine(tiger.Gender);
			tiger.Eattt();
			tiger.Run();


			Console.WriteLine("\n\n ==================");
			Console.WriteLine("상속 테스트3");

			Sedan sedan = new Sedan();
			Truck truck = new Truck();

			sedan.UpSpeed(150);
			truck.UpSpeed(100);

			sedan.seatNum = 5;
			truck.capacity = 50;

			Console.WriteLine("승용차 속도는 {0}km, 좌석수는 {1}개 ",
				sedan.speed, sedan.GetSeatNum());
			Console.WriteLine("트럭 속도는 {0}km, 적재량은 {1}톤 ",
				truck.speed, truck.GetCapacity());
			Console.WriteLine("\n\n ==================");


			Tyrano tyrano = new Tyrano();
			tyrano.Kind = "공룡 티라노사우루스";
			Console.WriteLine($"{tyrano.Kind}");
			Console.WriteLine(tyrano.Sleep("동굴"));
			Console.WriteLine(tyrano.Hunt("티라노사우루스", "물고기"));
			Console.WriteLine(tyrano.Eat("물고기"));
			Console.WriteLine();

			Dooly dooly = new Dooly();
			dooly.Kind = "공룡 둘리";
			Console.WriteLine($"{dooly.Kind}");
			Console.WriteLine(dooly.Sleep("공원"));
			Console.WriteLine(dooly.Eat("치킨"));
			Console.WriteLine(dooly.Dance("둘리"));
			Console.WriteLine(dooly.Sing("둘리"));
			Console.WriteLine("\n\n ==================");





		}
	}
}
