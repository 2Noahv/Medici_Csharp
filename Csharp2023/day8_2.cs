using System;

namespace Csharp2023
{
	// 오버라이딩 테스트
	//class Animal
	//{
	//	public string Name = "Animal";
	//	public virtual void Eat()
	//	{
	//		Console.WriteLine("Animal : Eat");
	//	}
	//}

	//class Cat : Animal
	//{
	//	public string Name = "Cat";
	//	public override void Eat()
	//	{
	//		Console.WriteLine("Cat : Eat");
	//	}
	//}

	// 오버라이딩 테스트2

	// 부모 클래스 
	public class Car
	{
		public int Speed;

		public virtual void UpSpeed(int speed)
		{
			this.Speed += speed;
			Console.WriteLine("\t현재속도(기본 클래스) : {0}km", this.Speed);
		}
	}
	// 자식 클래스 
	public class Sedan : Car
	{
		public override void UpSpeed(int speed)
		{
			this.Speed += speed;
			// 최고 속도를 150으로 제한 
			if (this.Speed > 150) this.Speed = 150;
			Console.WriteLine("\t현재속도(Sedan 클래스) : {0}km", this.Speed);
		}
	}
	// 자식 클래스 
	public class Truck : Car
	{
	}

	// 부모 클래스 
	class Animal
	{
		public string Name = "Animal";
		// virtual 키워드 오버라이드 메서드 
		public virtual void Eat()
		{
			Console.WriteLine("Animal : Eat");
		}
	}

	// 자식 클래스 
	class Cat : Animal
	{
		public string Name = "Cat";
		// override 키워드 오버라이드 메서드 
		public override void Eat()
		{
			Console.WriteLine("Cat : Eat");
		}

		public void Who_parent()
		{
			Console.WriteLine(base.Name);
			base.Eat();
		}

	}


	internal class day8_2
	{
		static void Main()
		{
			//부모 클래스 인스턴스 생성
			Animal animal = new Animal();
			animal.Eat();
			Console.WriteLine(animal.Name);
			Console.WriteLine("============\n");

			//자식 클래스 인스턴스 생성
			Cat cat = new Cat();
			cat.Eat();
			Console.WriteLine(cat.Name);

			// ===========================
			// 오버라이드 테스트 2
			Sedan sedan = new Sedan();
			Truck truck = new Truck();

			Console.Write("승용차 ---> ");
			sedan.UpSpeed(200);

			Console.Write("트럭 ---> ");
			truck.UpSpeed(200);
			Console.WriteLine("============\n");

			// ===========================
			// 오버라이드 테스트 3
			Console.WriteLine("\n\n ============================");
			Cat cat2 = new Cat();
			Console.WriteLine(cat2.Name);
			cat2.Eat();
			cat2.Who_parent();
		}




	}
}
