using System;

namespace Csharp2023
{
	
	interface ParentInterface
	{
		//인터페이스의 상속
		//오버로딩과 오버라이딩 사용가능
		void myMethod(string str);	//추상 메서드
	}

	interface SubInterface : ParentInterface
	{
		//ParentInterface 상속받아 추상 메서드 + 오버로딩 됨
		void myMethod(string str, int i);

	}

	class Myclass : SubInterface
	{
		//상속받은 추상메서드를 오버라이딩 가능하다.
		public void myMethod(string str)
		{
            Console.WriteLine($"{str} ParentInterface.myMethod() call!");
        }

		public void myMethod(string str, int count)
		{
			for (int i = 0; i < count; i++)
			{
                Console.WriteLine($"{str} SubInterface.myMethod() {i} call!");
            }
		}
	}

	//인터페이스 다중 상속
	interface IRunnable
	{
		void Run();
	}

	interface IFlyable
	{
		void Fly();
	}

	class FlyingCar : IRunnable, IFlyable
	{
		public void Run()
		{
            Console.WriteLine("Run! Run!");
        }

		public void Fly()
		{
            Console.WriteLine("Fly! Fly!");
        }
	}

	interface ICar3
	{
		void Run();
	}

	interface ICannon3
	{
		void Fire();
	}

	class Tank : ICar3, ICannon3
	{
		public void Run()
		{
            Console.WriteLine("탱크가 앞으로 굴러갑니다.");
        }

		public void Fire()
		{
            Console.WriteLine("탱크에서 대포를 발사합니다.");
        }
	}

	interface ITgier
	{
		//추상 메서드
		void Jump();
		void Cry_tiger();
	}

	interface ILion
	{
		void Bite();
		void Cry_lion();
	}

	interface ILiger : ITgier, ILion
	{
		void Play(string play);
	}

	class Liger : ILiger
	{
		public string Name;
		public string Tiger = "호랑이";
		public string Lion = "사자";

		public Liger(string liger)
		{
			this.Name = liger;
			Console.WriteLine(this.Name);
		}

		public void Cry_tiger()
		{
			Console.WriteLine($"{this.Tiger}처럼 어흥 ~~~");

		}

		public void Play(string play)
		{
			Console.WriteLine($"{play}와 놀기");

		}

		public void Bite()
		{
			Console.WriteLine($"{this.Lion}처럼 한입에 꿀꺽하기");

		}

		public void Cry_lion()
		{
			Console.WriteLine($"{this.Lion}처럼 으르렁 ~~~");
		}

		public void Jump()
		{
			Console.WriteLine($"{this.Tiger}처럼 점프하기");
		}
	}








	internal class day9_1
	{
		static void Main()
		{
            Console.WriteLine("인터페이스 상속 테스트");

			Myclass myclass = new Myclass();

			myclass.myMethod("Interface");
			myclass.myMethod("interface", 4);
			Console.WriteLine("\n=================");

			FlyingCar flyingcar = new FlyingCar();
			flyingcar.Run();
			flyingcar.Fly();
			Console.WriteLine("\n=================");

			Tank tank = new Tank();
			tank.Run();
			tank.Fire();
			Console.WriteLine("\n=================");


			Liger liger = new Liger("꿈돌이");
			Console.WriteLine($"라이거 {liger.Name} 의 하루 ");
			liger.Cry_tiger();
			liger.Play("사육사");
			liger.Bite();
			liger.Cry_tiger();
			liger.Cry_lion();
			liger.Jump();
			Console.WriteLine("\n=================");
		}
	}
}
