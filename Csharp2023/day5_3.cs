using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1_2023
{
	class day5_3
	{
		// 매개변수 X, 반환값 X
		static void show()
		{
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("Hellow world");
			}
			Console.WriteLine("=========================\n");
		}

		// 매개변수 O, 반환값 X
		static void showMessage(string message)
		{
			Console.WriteLine("message = {0}", message);
			Console.WriteLine("=========================\n");
		}


		// 매개변수가 여러개인 경우 O, 반환값 X
		static void showMessage2(string user, int clock, string message)
		{
			Console.WriteLine($"{user}님, {clock}시 입니다. {message}");
			Console.WriteLine("=========================\n");
		}

		// 구구단 전체 출력 메서드 정의 
		// 매개변수 X, 반환값 X
		static void Gugushow()
		{
			for (int i = 2; i <= 9; i++)
			{
				for (int j = 1; j <= 9; j++)
				{
					Console.WriteLine($"{i} X {j} = {i * j}");
				}
			}
			Console.WriteLine("\n\n");
		}


		//내가 만들어본 1 ~ 100안에서 5의 배수 출력 (3개 출력시 줄바꿈)
		//static void PrintNuber(int a)
		//{
		//	int cnt = 0;
		//	for (int i = 1; i < 101; i++)
		//	{
		//		if (i % a == 0)
		//		{
		//			Console.Write($"{i,5}");
		//			cnt++;
		//		}

		//		if(cnt == 3)
		//		{
		//			Console.WriteLine();
		//			cnt = 0;
		//		}

		//	}
		//      }

		//내가 만들어본 구구단
		//static void gugudanNum(int x)
		//{
		//	//int cntG = x;
		//	for (int i = 1; i < 9; i++)
		//	{
		//		for (int j = 1; j < 9; j++)
		//		{
		//			Console.WriteLine($"{x} X {j} = {(x * j)}");
		//		}
		//		Console.WriteLine();
		//		x++;
		//	}
		//}


		// 1~100 사이에서 특정 숫자의 배수만 출력 메서드 정의 
		// 매개변수 O, 반환값 X
		static void PrintNumber2(int number, int n)
		{
			int total = 0;
			for (int i = number; i < 100; i += number)
			{
				Console.Write($"{i,5}");
				++total;
				if (total % n == 0) Console.WriteLine();
			}
			Console.WriteLine("\n");
		}


		// 매개변수 X, 반환값 O : 반환값이 문자열인 경우 
		static string GetMessage()
		{
			return "message = Hellow Wordl";
		}


		// 매개변수 O, 반환값 O : 반환값이 정수형인 경우 
		static int GetSquare(int x, int y)
		{
			return x * y;
		}


		// 매개변수 O, 반환값 O : 반환값이 논리형 bool인 경우 
		static bool checkNumber(int number)
		{
			if (number % 2 != 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// 슬라이드 22 퀴즈 
		// 3수의 곱의 결과를 반환하는 메소드 정의 
		static int ThreeMultiplied(int x, int y, int z)
		{
			int threeMult = x * y * z;

			return threeMult;
		}


		// 기본 매개변수 + 일반 매개변수와 함께 사용 
		// 매개변수 O, 반환값 X
		static void getNumber2(int x, int y = 0, int z = 0)
		// static void getNumber2(int y = 0, int z = 0, int x) // 오류 발생

		{
			Console.WriteLine("\t x = {0}, y = {1}, z = {2} \n", x, y, z);
		}


		// 기본 매개변수 
		// 매개변수 O, 반환값 O
		static string getNumberSum(int x = 0, int y = 0, int z = 0)
		{
			return $"\t {x} + {y} + {z} = {x + y + z}\n";
		}


		//원의 넓이를 출력하는 메소드
		static void CircleArea(int a)
		{
			float pi = 3.14f;
			Console.WriteLine($"원의 넓이는? {a} X {a} X {pi} = {(a * a * pi):F3}");
		}


		//성적표를 출력하는 메서드
		static void gradePrint(float a, float b = 0, float c = 0)
		{
			float sum = a + b + c;
			float avg = (sum / 3);
			string ok = "합격", no = "불합격";

			Console.WriteLine($"국어 : {a}  영어 :  {b} 수학 : {c} ");
			if (70 <= avg) Console.WriteLine($"총점 : {sum}  평균 :  {avg:F2} => {ok} ");
			else Console.WriteLine($"총점 : {sum}  평균 :  {avg:F2} => {no} ");
			Console.WriteLine();
		}



		// 슬라이드 29
		// 원의 면적을 구하는 메소드 
		static void CircleArea(double r = 0)
		{
			Console.WriteLine($"원의 넓이는? {r} X {r} X 3.14 = {(r * r * 3.14):F3}");
		}
		// 슬라이드 29 
		// 메서드 호출 
		CircleArea();
		CircleArea(5);
		CircleArea(3.56);

		static void gradePrint(double kor = 0, double eng = 0, double math = 0)
		{
			Console.Write($" 국어 : {kor}");
			Console.Write($" 영어 : {eng}");
			Console.Write($" 수학 : {math}");
			Console.WriteLine();
			Console.Write($" 총점 : {kor + eng + math}");
			double avg = (kor + eng + math) / 3;
			Console.Write(" 평균 : {0:F2}", avg);
			if (avg > 70) { Console.Write("=> 합격"); }
			else { Console.Write(" => 불합격"); }
			Console.WriteLine("\n==================================");
		}



		static void Main(string[] args)
		{
			//int n = 2;

			show();
			showMessage("Good moring");
			showMessage2("박은우", 12, "운동할 시간입니다...");
			showMessage2("마동호", 9, "택배가 도착했습니다...");
			// 구구단 출력 메서드 호출 
			Gugushow();

			// 7 배수를 한 줄에 7개씩  
			PrintNumber2(7, 7);

			// 11 배수를 한 줄에 2개씩 배치 
			PrintNumber2(11, 2);


			//PrintNuber(5);
			//gugudanNum(n);

			// 반환값이 있는 메서드 호출
			string message = GetMessage();
			Console.WriteLine($" return value : {message} ");
			Console.WriteLine("======================");


			// 매개변수와 반환값이 있는 메서드 호출 
			// 사각형 넓이 구하기 
			int x = 20, y = 10;
			int r = GetSquare(x, y);
			Console.WriteLine($" 가로 : {x}, 세로 : {y}, 넓이 : {r} ");
			Console.WriteLine("======================");

			// 매개변수와 반환값이 있는 메서드 호출 
			// 홀수와 짝수
			int n = 100;
			Console.WriteLine($"{n}은 홀수인가? {checkNumber(n)}");
			n = 23;
			Console.WriteLine($"{n}은 홀수인가? {checkNumber(n)}");
			Console.WriteLine();
			Console.WriteLine();


			int xx = 78, yy = 5, zz = 11;
			Console.WriteLine($"{xx} X {yy} X {zz}의 결과값은? ");
			Console.WriteLine($"{ThreeMultiplied(xx, yy, zz)}\n");

			// 기본 매개변수가 있는 함수 호출 
			// 매개변수 O, 반환값 X
			//getNumber2();
			getNumber2(10);
			getNumber2(10, 20);
			getNumber2(10, 20, 30);
			Console.WriteLine("===============");

			// =================================
			// 기본 매개변수가 있는 함수 호출 
			// 매개변수 O, 반환값 O
			Console.WriteLine(getNumberSum());
			Console.WriteLine(getNumberSum(10));
			Console.WriteLine(getNumberSum(10, 20));
			Console.WriteLine(getNumberSum(10, 20, 30));
			Console.WriteLine("===============\n");


			CircleArea(0);
			CircleArea(5);
			CircleArea(12);

			gradePrint(0);
			gradePrint(80);
			gradePrint(80, 95);
			gradePrint(80, 95, 70);
			gradePrint(77, 35, 70);


			// 슬라이드 31 
			gradePrint();
			gradePrint(55, 67);
			gradePrint(90, 77, 88);

		}
	}
}
