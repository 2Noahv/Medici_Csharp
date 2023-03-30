using System;

namespace Csharp2023
{
	class MyClass
	{
		//캡슐화
		private string Name3;
		public string name3 //property 방식

		{
			get	{ return this.Name3; }
			set { this.Name3 = value; }
		}
		//property 방식을 이용한 필드 방식
		public string Name4 { get; set; }
		//public string Name4 { get; } // 읽기전용

	}

	class Namecard
	{
		private string Name; //2글자 이상
		private int Age;

		public string name
		{
			get { return this.Name; }
			set {
				if (value.Length >= 2) this.Name = value;
				else this.Name = "Unknown";
				}
		}

		public int age
		{
			get { return this.Age; }
			set {
				if (value >= 0) this.Age = value;
				else this.Age = 0;
				}
		}
	}

	class Student
	{
		private int No;
		private int Grade;
		private char Gender;

		public int no
		{
			get { return this.No; }
			set {
				if (value >= 3000 && value < 4000) this.No = value;
				else this.No = 0;
			}
		}

		public int grade
		{
			get { return this.Grade; }
			set {
				if (0 < value && 4 >= value) this.Grade = value;
				else this.Grade = 0;
				}
		}

		public char gender
		{
			get { return this.Gender; }
			set {
				if (value == 'F' || value == 'f' || value == 'M' || value == 'm') this.Gender = value;
				else this.Gender = 'U';
				}
		}
	}


	internal class day9_2
	{
		static void Main()
		{
			MyClass myclass = new MyClass();
			myclass.name3 = "최지훈";
            Console.WriteLine(myclass.name3);
			myclass.Name4 = "이지훈";
			Console.WriteLine(myclass.Name4);
			Console.WriteLine("\n=================");


			Namecard myCard = new Namecard();
			//myCard.Name // 접근 제한으로 인한 오류 발생
			myCard.name = "오";
			myCard.age = -99;
            Console.WriteLine($"이름 : {myCard.name}");
			Console.WriteLine($"나이 : {myCard.age}");

			myCard.name = "공유";
			myCard.age = 37;
			Console.WriteLine($"이름 : {myCard.name}");
			Console.WriteLine($"나이 : {myCard.age}");
			Console.WriteLine("\n=================");

			Student student = new Student();
			student.no = 2;
			Console.WriteLine($"3000 ~ 3999 오류시 0 결과값 :{student.no}");
			student.no = 3000;
			Console.WriteLine($"3000 ~ 3999 오류시 0 결과값 :{student.no}");
			student.no = 3999;
			Console.WriteLine($"3000 ~ 3999 오류시 0 결과값 :{student.no}");
			student.no = 4000;
			Console.WriteLine($"3000 ~ 3999 오류시 0 결과값 :{student.no}");


			student.grade = 1;
			Console.WriteLine($"1 ~ 4 오류시 0 결과값 :{student.grade}");
			student.grade = 2;
			Console.WriteLine($"1 ~ 4 오류시 0 결과값 :{student.grade}");
			student.grade = 3;
			Console.WriteLine($"1 ~ 4 오류시 0 결과값 :{student.grade}");
			student.grade = 4;
			Console.WriteLine($"1 ~ 4 오류시 0 결과값 :{student.grade}");
			student.grade = 5;
			Console.WriteLine($"1 ~ 4 오류시 0 결과값 :{student.grade}");

			student.gender = 'F';
			Console.WriteLine($"F나 M 오류시 U 결과값 :{student.gender}");
			student.gender = 'M';
			Console.WriteLine($"F나 M 오류시 U 결과값 :{student.gender}");
			student.gender = 'A';
			Console.WriteLine($"F나 M 오류시 U 결과값 :{student.gender}");



		}
	}
}
