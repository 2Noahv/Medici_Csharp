using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2023
{
	class MyClass
	{
		//정적 속성 = 정적 필드
		//클래스명.속성으로 사용가능 (객체화 X)
		public static int A;
		public static int B;

		//정적 메서드
		//클래스명.메서드명(매개변수값..)으로 사용가능 (객체화 X)
		public static void Print_number1()
		{
            Console.WriteLine($"정적 메소드 Print_number1, 정적필드 {A}  ,  {B} 호출");
        }

		public void Print_number2() 
		{
			Console.Write($"일반 메소드 Print_number2, 일반필드 {A}  ,  {B} 호출");
		}
	}

	class Bread
	{
		public static string Brand = "파리바게뜨";
		public string Kind;
		public decimal Price;
		public double Kcal;

		public static void Info()
		{
			//Console.WriteLine(this.Brand); 오류 발생 : 정적필드는 this 사용 불가능
			Console.WriteLine("\t\t" + Brand);
			Console.WriteLine("\t\t주소 : 부산시 금정구 장전동 ... ");
		}

		public Bread(string kind, decimal price, double kcal)
		{
			this.Kind = kind;
			this.Price = price;
			this.Kcal = kcal;
		}

		// 일반 메서드
		public void Bread_info()
		{
			Console.WriteLine();
			Console.WriteLine($"\t종류 : {this.Kind}");
			Console.WriteLine($"\t가격 : {this.Price} 원 ");
			Console.WriteLine($"\t칼로리 : {this.Kcal} kcal");
		}

	}

	class Global
	{
		// 정적 필드
		public static int Count = 0;

		// 정적 메소드 
		public static void method_static()
		{
			Console.WriteLine("정적 메소드 호출");
		}
	}

	class ClassA
	{
		public ClassA()
		{
			Global.Count++;
		}
	}

	class ClassB
	{
		public ClassB()
		{
			Global.Count++;
		}
	}


	//생각보다 헷갈렸다 다시한번 더 볼 것
	class MyZodiac
	{
		public static string GetZodiac(int BirthYear)
		{
			string[] zodiackList =
			{
			"원숭이", "닭", "개", "돼지", "쥐", "소", "호랑이", "토끼", "용", "뱀", "말", "양"
			};

			string zodiackRe = zodiackList[BirthYear % 12];
			return zodiackRe;


			//string Zodiac = "";
			//switch (BirthYear % 12)
			//{
			//    case 0: Zodiac = "원숭이"; break;
			//    case 1: Zodiac = "닭"; break;
			//    case 2: Zodiac = "개"; break;
			//    case 3: Zodiac = "돼지"; break;
			//    case 4: Zodiac = "쥐"; break;
			//    case 5: Zodiac = "소"; break;
			//    case 6: Zodiac = "호랑이"; break;
			//    case 7: Zodiac = "토끼"; break;
			//    case 8: Zodiac = "용"; break;
			//    case 9: Zodiac = "뱀"; break;
			//    case 10: Zodiac = "말"; break;
			//    case 11: Zodiac = "양"; break;
			//}

			//return Zodiac;
		}
	}



	internal class day7_3
	{
		static void Main()
		{
            Console.WriteLine("정적 필드와 정적 메서드 테스트");
			MyClass.A = 100;
			MyClass.B = 100;
			MyClass.Print_number1();

			//인스턴스 생성 후 인스턴스 메서드 호출
			MyClass myclass = new MyClass();
			myclass.Print_number2();

			// static 테스트 2
			Bread.Info();
			Console.WriteLine("\n\t\t Barand : " + Bread.Brand);

			// 객체 생성 및 객체 메서드 호출 
			Bread baguette = new Bread("바게뜨", 4_500, 250);
			baguette.Bread_info();

			// static 테스트 3
			Console.WriteLine($"\t 1) Global Count => {Global.Count}");
			Global.method_static();

			new ClassA();
			//ClassA a = new ClassA();
			Console.WriteLine($"\t 2) Global Count => {Global.Count}");
			new ClassA();
			Console.WriteLine($"\t 3) Global Count => {Global.Count}");
			new ClassB();
			Console.WriteLine($"\t 4) Global Count => {Global.Count}");
			new ClassB();
			Console.WriteLine($"\t 5) Global Count => {Global.Count}");
			Console.WriteLine("\n=========================================");

			Console.WriteLine($"2009년 생은 {MyZodiac.GetZodiac(2009)} 띠");
			Console.WriteLine($"2023년 생은 {MyZodiac.GetZodiac(2023)} 띠");
			Console.WriteLine($"1997년 생은 {MyZodiac.GetZodiac(1997)} 띠");


			
		}
	}
}
