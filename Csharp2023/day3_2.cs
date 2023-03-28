using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1_2023
{
	class day3_2
	{
		static void Main(string[] args)
		{
			// switch ~ case ~ break
			int x = 100;
			switch (x)
			{
				case 1:
					Console.WriteLine("x는 1"); break;
				case 50:
					Console.WriteLine("x는 50"); break;
				case 100:
					Console.WriteLine("x는 100"); break;
				default:
					Console.WriteLine("x는 1도 50도 100도 아니다"); break;
			}

			switch (x)
			{
				//	//*** 이렇게도 쓸수 있다.
				case 1:
				case 50:
				case 100:
					Console.WriteLine("x는 1 또는 50 또는 100"); break;
				default:
					Console.WriteLine("x는 1도 50도 100도 아니다"); break;
			}
			Console.WriteLine("======================\n");

			// if ~ else if ~ else 스타일로 변경 
			if (x == 1) { Console.WriteLine("x는 1"); }
			else if (x == 50) { Console.WriteLine("x는 50"); }
			else if (x == 100) { Console.WriteLine("x는 100"); }
			else { Console.WriteLine("x는 1도 50도 100도 아니다"); }

			// case 실행명령문이 공통인 경우 
			switch (x)
			{
				case 1:
				case 50:
				case 100:
					Console.WriteLine("x는 1 또는 50 또는 100"); break;
				default:
					Console.WriteLine("x는 1도 50도 100도 아니다"); break;
			}
			Console.WriteLine("======================\n");

			//가장 좋아하는 프로그래밍 언어를 물어보는 프로그램
			//Console.WriteLine("가장 좋아하는 프로그래밍 언어를 입력하시오.");
			//Console.WriteLine("1.C   2.C++   3.C#   4.JAVA");
			//         Console.Write("입력 => ");
			//         int select = Convert.ToInt32(Console.ReadLine());

			//switch(select)
			//{
			//	case 1:
			//                 Console.WriteLine("C 선택");
			//		break;
			//	case 2:
			//		Console.WriteLine("C++ 선택");
			//		break;
			//	case 3:
			//		Console.WriteLine("C# 선택");
			//		break;
			//	case 4:
			//		Console.WriteLine("JAVA 선택");
			//		break;
			//	default: 
			//		Console.WriteLine("잘못된 선택");
			//		break;
			//}


			//퀴즈2
			Console.Write("점수를 입력하세요: ");
			//int s = Convert.ToInt32(Console.ReadLine());
			//s /= 10;
			//string grade = "";

			//switch (s)
			//{
			//	case 10:
			//		grade = "A";
			//		break;
			//	case 9:
			//		grade = "A";
			//		break;
			//	case 8:
			//		grade = "B";
			//		break;

			//	case 7:
			//		grade = "C";
			//		break;

			//	case 6:
			//		grade = "D";
			//		break;
			//	default:
			//		grade = "F";
			//		break;
			//}
			//Console.WriteLine($"학점은 {grade}");


			//출생년도를 입력해 띠를 출력하는 프로그램
			//Console.Write("출생연도 입력>>");
			//int myage = Convert.ToInt32(Console.ReadLine());
			//int originMyage = myage;
			//myage %= 12;
			//string anyName = "";

			//switch (myage)
			//{
			//	case 0:
			//		anyName = "원숭이"; break;
			//	case 1:
			//		anyName = "닭"; break;
			//	case 2:
			//		anyName = "개"; break;
			//	case 3:
			//		anyName = "돼지"; break;
			//	case 4:
			//		anyName = "쥐"; break;
			//	case 5:
			//		anyName = "소"; break;
			//	case 6:
			//		anyName = "호랑이"; break;
			//	case 7:
			//		anyName = "토끼"; break;
			//	case 8:
			//		anyName = "용"; break;
			//	case 9:			
			//		anyName = "뱀"; break;
			//	case 10:		
			//		anyName = "말"; break;
			//	default:		
			//		anyName = "양"; break;
			//}
			//Console.WriteLine($"{originMyage}년생은 {anyName}띠입니다.\n\n");

			// ===============================
			// 반복문 while 
			// Hello world n번 출력하기 
			int count = 1;
			while (count <= 10)
			{
				Console.WriteLine($"{count} Hello World");
				count++;
			}
			Console.WriteLine("======================\n");

			// 5~1까지
			int cnt1 = 5;
			while (cnt1 > 0)
			{
				Console.WriteLine(cnt1);
				cnt1--;
			}
			Console.WriteLine("======================\n");

			// 1~100까지 누적합 
			int cnt2 = 1;
			int sum = 0;
			while (cnt2 <= 100)
			{
				sum += cnt2;
				cnt2++;
			}
			Console.WriteLine($"1~100까지의 합은? {sum}");
			Console.WriteLine("======================\n");


			//구구단을 출력하는 프로그램
			//Console.Write("입력 숫자=>");
			//int rGugudan = Convert.ToInt32(Console.ReadLine());
			//int i = 1;
			//while (i < 10)
			//{				
			//	Console.WriteLine($"{rGugudan} X {i} = {(rGugudan * i)}");
			//	i++;
			//}


			// ================================
			// while + if 문 테스트 
			// 1~50 짝수만 출력 


			//int n = 1;
			//while (n <= 50)
			//{
			//	//n을 2로 나누었을때 나머지가 0이면 출력 
			//	if (n % 2 == 0)
			//	{
			//		Console.Write($"\t{n}");
			//	}
			//	n++;
			//}
			//Console.WriteLine();
			//Console.WriteLine("======================\n");


			//// 1~100까지에서 3의 배수의 합은?
			//// 3+6+...+99 = ?
			//int cnt4 = 1;
			//int sum3 = 0; // 누적합 변수 
			//while (cnt4 <= 100)
			//{
			//	if (cnt4 % 3 == 0)
			//	{
			//		Console.Write(" " + cnt4);
			//		sum3 += cnt4;
			//	}
			//	cnt4++;
			//}
			//Console.WriteLine($"1~100까지에서 3의 배수의 합은? {sum3}");

			//// ================================
			//// 중첩 while 
			//int a = 1, b;
			//while (a <= 5)
			//{
			//	b = 1;
			//	Console.WriteLine($"\n\n\ta = {a}");
			//	Console.Write($"\n\t\tb = ");
			//	while (b <= 5)
			//	{
			//		Console.Write($"{b} ");
			//		b++;
			//	}
			//	a++;
			//}
			//Console.WriteLine();
			//Console.WriteLine("======================\n");

			//2~9단 구구단 출력하기
			//int sNumber = 2, i = 1;
			//while (sNumber < 10)
			//{
			//	Console.WriteLine($"\n\n{sNumber,4}단");
			//	i = 1;
			//	while (i < 10)
			//	{
			//		int numMul = (sNumber * i);
			//		Console.WriteLine($"{sNumber} X {i} = {numMul}");
			//		i++;
			//	}
			//	sNumber++;
			//}


			// 무한루프 
			int my_count = 1;
			while (true)
			{
				Console.Write("{0,5}", my_count);
				if (my_count == 5)
				{
					Console.WriteLine();
					break;
				}
				my_count++;
			}
			Console.WriteLine("======================\n");


			// 문자열 누적 테스트 
			string word = "강아지";
			Console.WriteLine(word);
			word = word + "고양이";
			Console.WriteLine(word);
			word = word + "나비";
			Console.WriteLine(word);
			Console.WriteLine("======================\n");


			//*** 생각보다 헷갈렸음 주의할 것
			//Q나 q를 입력하면 빠져 나오는 프로그램
			//string strRand;
			//string curStr = "";
			//while (true)
			//{
			//	Console.WriteLine("Q나 q를 입력하면 입력이 종료됩니다.");				
			//	Console.Write("종목 >> ");
			//	strRand = Console.ReadLine();
			//	Console.WriteLine($"{strRand}\n");			

			//	if (strRand == "Q" || strRand == "q" )
			//	{
			//		break;
			//  }
			//	curStr += strRand + " ";				
			//}
			//Console.WriteLine("입력이 종료되었습니다.");
			//Console.WriteLine($"보유 주식 종목 : {curStr}");

			// 1 ~ 100  7의 배수, 11의 배수 숫자를 환줄에 5줄 나타내기
			int i = 1;
			int lineCount = 1;
			int totalCount = default;

			do
			{
				if (i % 7 == 0 || i % 11 == 0)
				{
					Console.Write($"{i,5}");

					if (lineCount == 5)
					{
						Console.WriteLine();
						lineCount = 0;
					}
					lineCount++;
					totalCount++;

					//강사님이 하신 로직
					//Console.Write($"{digit,5}");
					//total++;
					//if (total % 5 == 0) Console.WriteLine();

				}
				i++;
			} while (i <= 100);
			Console.WriteLine($"\n총 갯수는? {totalCount}");




		}
	}
}
