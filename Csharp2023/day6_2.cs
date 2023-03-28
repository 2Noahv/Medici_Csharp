using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2023
{
	// 좌표 데이타 구조체 (X, Y)
	struct Point
	{
		// 멤버 선언 
		public int X;
		public int Y;

		// 생성자 메서드 정의 : return문 X, 구조체명과 동일
		public Point(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		// 출력 용도 메서드 정의 1
		// 매개변수 X, 반환값 X
		public void Print_point1()
		{
			Console.WriteLine($"X 좌표 : {this.X}");
			Console.WriteLine($"Y 좌표 : {this.Y}");
		}

		// 출력 용도 메서드 정의 1
		// 매개변수 O, 반환값 X
		public void Print_point2(int n)
		{
			Console.WriteLine($"{n}번째 Point");
			Console.WriteLine($"X 좌표 : {this.X} , Y 좌표 : {this.Y}");
		}
	} // End Point


	// 삼각형 구조체 선언 
	struct Triangle
	{
		public string Name;
		public double Width;
		public double Height;

	}


	struct Trapezoid
	{
		public string Name;
		public double Height;
		public double Topbase;
		public double Bottombase;
	}

	struct Book
	{
		public long Isbn;
		public string Bookname;
		public string Bookauthor;
		public int Price;

		public Book(long isbn, string bookname, string bookauthor, int price)
		{
			this.Isbn = isbn;
			this.Bookname = bookname;
			this.Bookauthor = bookauthor;
			this.Price = price;
		}

		public void Print_book1(int n)
		{
			Console.WriteLine($"{n}번째 책 정보");
			Console.WriteLine($"ISNB : {this.Isbn}");
			Console.WriteLine($"제목 : {this.Bookname}");
			Console.WriteLine($"저자 : {this.Bookauthor}");
			Console.WriteLine($"가격 : {this.Price:N0}");
            Console.WriteLine();
        }

		public void Print_book2(int n)
		{
			Console.WriteLine($"{n}번째 책 정보");
			Console.WriteLine($"ISNB : {this.Isbn}");
			Console.WriteLine($"제목 : {this.Bookname}");
			Console.WriteLine($"저자 : {this.Bookauthor}");
			Console.WriteLine($"가격 : {this.Price:N0}");
            Console.WriteLine();
        }

	}


	struct User
	{
		public string Name;
		public string Id;
		public int Age;
		public string Address;


		public User (string name, string id, int age, string address)
		{
			this.Name = name;
			this.Id = id;
			this.Age = age;
			this.Address = address;
		}


		//출력 메소드1
		public void Print_user1()
		{
			Console.WriteLine($"고객명 => {this.Name}");
			Console.WriteLine($"ID => {this.Id}");
			Console.WriteLine($"나이 => {this.Age}");
			Console.WriteLine($"거주지 => {this.Address}");

		}

		//출력 메소드2 : 고객명과 Id의 경우 * 이용
		public void Print_user2()
		{

			Console.WriteLine($"고객명 => {this.Name[0]}**");
			Console.Write("ID => ");
			for (int i = 0; i < this.Id.Length; i++)
			{
				if (i == 0 || i == this.Id.Length-1) Console.Write($"{this.Id[i]}");
				else Console.Write($"*");
			}
			Console.WriteLine();
			Console.WriteLine($"나이 => {this.Age}");
			Console.Write($"거주지 => {this.Address}");

		}
	}

	internal class day6_2
	{
		static void Main()
		{
			//구조체 변수 설정
			Point point77;
			point77.X = 20;
			point77.Y = 20;

			Console.WriteLine($"X 좌표 : {point77.X}");
			Console.WriteLine($"Y 좌표 : {point77.Y}");
			Console.WriteLine("==================");


			// 구조체 변수 설정 
			Point point88, point99;
			// 구조체변수.멤버변수 = 값
			point88.X = 20;
			point88.Y = 50;
			point99.X = -100;
			point99.Y = -200;

			Console.WriteLine($"X 좌표 : {point88.X}");
			Console.WriteLine($"Y 좌표 : {point88.Y}");
			Console.WriteLine();
			Console.WriteLine($"X 좌표 : {point99.X}");
			Console.WriteLine($"Y 좌표 : {point99.Y}");
			Console.WriteLine("==================");



			// 생성자 메서드를 이용해서 값전달 
			Point point3 = new Point(0, 0);
			Console.WriteLine();
			Console.WriteLine($"point3 X 좌표 : {point3.X}");
			Console.WriteLine($"point3 Y 좌표 : {point3.Y}");
			Console.WriteLine("==================");


			Triangle triangle;
			triangle.Name = "정삼각형";
			triangle.Width = 5.0;
			triangle.Height = 5.0;
			Console.WriteLine(triangle.Name);
			Console.WriteLine($"가로크기 = {triangle.Width}cm");
			Console.WriteLine($"세로크기 = {triangle.Height}cm");
			Console.WriteLine($"넓이 = {(triangle.Width * triangle.Height) / 2}cm");
			Console.WriteLine("==================");

			Trapezoid trZoid;
			trZoid.Name = "사다리꼴A";
			trZoid.Height = 50;
			trZoid.Topbase = 120;
			trZoid.Bottombase = 230;
			
            Console.WriteLine($"{trZoid.Name}");
			Console.WriteLine($"윗변 = {trZoid.Topbase}cm");
			Console.WriteLine($"아랫변 = {trZoid.Bottombase}cm");
			Console.WriteLine($"높이 = {trZoid.Height}cm");
            Console.WriteLine($"넓이 = {(trZoid.Topbase + trZoid.Bottombase) * trZoid.Height / 2}cm");
			Console.WriteLine("==========================\n");

			Book boo1, boo2;
			boo1 = new Book(9788932817245, "어린왕자", "생택쥐페리", 15_000);
			boo2 = new Book(9791162243770, "이것이 C#이다", "박상현", 35_000);
     
			boo1.Print_book1(1);
			boo2.Print_book2(2);
			Console.WriteLine("==========================\n");

			// 구조체 변수 선언 및 값 전달 
			// 구조체명 구조체변수 = new 구조체명(값1, ...);
			Point point = new Point(5, 5);

			// 구조체변수.메서드명(매개변수값) 호출 
			point.Print_point1();
			Console.WriteLine();
			point.Print_point2(1);
			Console.WriteLine("==========================\n");

			User user1, user2;
			user1 = new User("김철수", "kim1234", 33, "서울");
			user2 = new User("이민주", "lee123456789", 25, "전주");

			user1.Print_user1();
			Console.WriteLine("\n\n\n");
			user1.Print_user2();
			Console.WriteLine("\n\n\n");

			user2.Print_user1();
			Console.WriteLine("\n\n\n");
			user2.Print_user2();
			Console.WriteLine("\n\n\n");

		}

	}
}
