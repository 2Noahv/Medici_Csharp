using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Csharp2023
{
	// 클래스 선언 위치는 namespace 아래 
	class Cat
	{
		public string Name;
		public string Gender;
		public int Age;
		public string Color;

		public void Eat()
		{
			Console.WriteLine($"{this.Name} 이(가) 먹는다");
		}

		public void Run()
		{
			Console.WriteLine($"{this.Name} 이(가) 달린다.");
		}
	}

	class CircleQuiz
	{
		public string Name;
		public double Radius;

		//타원 정보 출력 메서드 
		public void PrintInfo()
		{
            Console.WriteLine($"Name : {this.Name}");
            Console.WriteLine($"Radius : {this.Radius}");
			Console.WriteLine($"원의 넓이 = {GetArea1()}");
			Console.WriteLine($"{GetArea2()}");
        }

		//타원의 넓이 구하기 메서드
		public double GetArea1()
		{
			double area = this.Radius * this.Radius * 3.14;
			return area;

		}

		//타원의 넓이 구하기
		public string GetArea2()
		{
			return $"원의 넓이 : {this.Radius} X {this.Radius} X 3.14 = {GetArea1()}";
		}
	}

	// Dog 클래스 선언 
	class Dog
	{
		public string Kind;
		public string Name;

		public Dog(string kind, string name)
		{
			this.Kind = kind;
			this.Name = name;
		}

		public void Bark()
		{
			Console.WriteLine($"{this.Name} : 멍멍");
		}
	}



	class Car
	{
		public string Name;
		public string Color;
		public double Speed;

		public Car(string name, string color, double speed)
		{
			this.Name = name;
			this.Color = color;
			this.Speed = speed;
		}

		public double SpeedUp(double speed)
		{
			this.Speed += speed;
			return this.Speed;
		}

		public double SpeedDown(double speed)
		{
			this.Speed -= speed;
			return this.Speed;
		}

	}


	class Book
	{
		long Isbn;
		string Title;
		string Writer;
		double Price;

		public Book(long isbn, string title, string writer, double price)
		{
			this.Isbn = isbn;
			this.Title = title;
			this.Writer = writer;
			this.Price = price;
		}

		public void Print_book(double Rate)
		{
			Console.WriteLine($"ISBN : {this.Isbn}");
			Console.WriteLine($"제 목 : {this.Title}");
			Console.WriteLine($"저 자 : {this.Writer}");
			Console.WriteLine($"정 가 : {this.Price:N0} 원");
			Console.WriteLine($"할인가({Rate * 100}%) : {this.Price - this.Price * Rate:N0} 원");
		}

	}


	class day7_1
	{
		static void Main()
		{

			Cat catCss = new Cat();
			catCss.Name = "네로";
			catCss.Gender = "수컷";
			catCss.Age = 1;
			catCss.Color = "흰색";
			catCss.Eat();
			catCss.Run();
			Console.WriteLine("=========================\n");

			CircleQuiz circleQuiz = new CircleQuiz();
			circleQuiz.Name = "Green";
			circleQuiz.Radius = 1.5;
			circleQuiz.PrintInfo();
            Console.WriteLine("=========================\n");

			// Dog dog1 = new Dog(); 
			Dog dog1 = new Dog("시츄", "토토");
			Dog dog2 = new Dog("진돗개", "진돌");
			Console.WriteLine($"dog1 이름: {dog1.Name}");
			Console.WriteLine($"dog1 종류: {dog1.Kind}");
			Console.WriteLine($"dog2 이름: {dog2.Name}");
			Console.WriteLine($"dog2 종류: {dog2.Kind}");
			dog1.Bark();
			dog2.Bark();

			//==========================================
			// 
			Console.WriteLine("====================");
			Car car = new Car("제네시스", "블랙", 0);
			Console.WriteLine("\t 차종 : {0}, 색상 : {1}, 현재 속도 : {2}",
										car.Name, car.Color, car.Speed);
			car.SpeedUp(10);
			Console.WriteLine($"\t 속도를 올립니다. 현재 속도 : {car.Speed}");
			car.SpeedUp(12.5);
			Console.WriteLine($"\t 속도를 올립니다. 현재 속도 : {car.Speed}");
			car.SpeedDown(5.7);
			Console.WriteLine($"\t 속도를 줄입니다. 현재 속도 : {car.Speed}");


			//==========================================
			// 퀴즈 - 슬라이드 34
			Console.WriteLine("====================");

			// 책 인스턴스 생성
			Book book1 = new Book(9788932917245, "어린왕자", "생텍쥐페리", 15000);
			Book book2 = new Book(9791162243770, "이것이 C#이다", "박상현", 35000);

			// 출력 
			Console.WriteLine("\n======================");
			var rate = 0.25;
			Console.WriteLine($"첫번째 책 정보 : 할인율 {rate} ");
			book1.Print_book(rate);

			Console.WriteLine();

			rate = 0.3;
			Console.WriteLine($"두번째 책 정보 : 할인율 {rate} ");
			book2.Print_book(rate);








		}

	}
}