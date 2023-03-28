using System;

namespace Csharp2023
{
	//ICar 인터페이스 정의
	//interface ICar 처럼 앞에 I가 붙는 룰이 있다.
	//한정자를 붙이지 않으면 항상 public이고, virtual 및 static 사용 불가
	interface ICAr
	{
		//abstract 키워드 없이 모두 추상클래스로 판단한다.
		void Go();
	}

	//ICar 인터페이스를 상속하는 Car클래스 선언
	class Car : ICAr
	{
		public void Go() 
		{
			//상속 이후에도 override 키워드 사용 X
			Console.WriteLine("Go");
        }
	}

	interface ICar2
	{
		void Work();
	}

	class Sedan : ICar2
	{
		public void Work()
		{
            Console.WriteLine("Seadn 출력");
            Console.WriteLine("승용차가 사람을 태우고 있습니다.");
        }
	}

	class Truck : ICar2
	{
		public void Work()
		{
			Console.WriteLine("Truck 출력");
			Console.WriteLine("트럭이 짐을 싣고 있습니다.");
        }
	}

	interface IDino
	{
		void Eat(string what);
		void Sleep(string where);
		void Play(int num);
		void Today(string what, int num, string where);
	}

	class Tyrano : IDino
	{
		public void Eat(string what)
		{
            Console.WriteLine($"{what} 을/를 먹는다.");
        }
		public void Sleep(string where)
		{
			Console.WriteLine($"{where} 에서 잔다");

		}
		public void Play(int num)
		{
			Console.WriteLine($"친구 {num} 명과 놀고 있다.");
		}
		public void Today(string what, int num, string where)
		{
            Console.WriteLine("====== 티라노 티티의 하루 일상 ======");
			Console.WriteLine($"{what} 을/를 먹는다.");
			Console.WriteLine($"친구 {num} 명과 놀고 있다.");
			Console.WriteLine($"{where} 에서 잔다");
		}
	}


	internal class day8_5
	{
		static void Main()
		{
			//파생 클래스를 이용한 인스턴스화
			Car car = new Car();
			car.Go();
			Console.WriteLine("==========");

			Sedan sedan = new Sedan();
			sedan.Work();
            Console.WriteLine();

            Truck truck = new Truck();
			truck.Work();
			Console.WriteLine("==========\n");


			Tyrano tyrano = new Tyrano();
			tyrano.Eat("고기");
			tyrano.Eat("생선");
			tyrano.Sleep("동굴");
			tyrano.Play(3);
			tyrano.Today("사과", 2, "숲속");
			Console.WriteLine("==========\n");

		}
	}
}
