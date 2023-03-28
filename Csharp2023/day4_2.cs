using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1_2023
{
	class day4_2
	{
		static void Main(string[] args)
		{
			// foreach + 문자열 
			string message = "abcdefg";
			foreach (char c in message)
			{
				Console.Write($"{c} => ");
			}
			Console.WriteLine();
			Console.WriteLine();

			// var 키워드 이용 
			string message2 = "궁상각치우";
			foreach (var c in message2)
			{
				Console.Write($"{c} => ");
			}
			Console.WriteLine();
			Console.WriteLine();


			// 다음 문자열에서 a, l을 *로 출력하라
			//string word = "apple apart ant apply aribaba";

			//foreach( char c in word)
			//{
			//	if(c == 'a' || c == 'l') Console.Write($"*");
			//	else Console.Write($"{c}");	
			//}
			//Console.WriteLine("\n");

			// break : 제어문 탈출 
			// 1~100까지의 누적합 
			int result = 0;
			for (int i = 1; i <= 100; i++)
			{
				result += i;
				Console.WriteLine($"{i} {result}");
			}
			Console.WriteLine(result);

			result = 0;
			for (int i = 1; i <= 100; i++)
			{
				if (result >= 30)
				{
					break;
				}
				else
				{
					result += i;
					Console.Write($"{i} ");
				}
			}
			Console.WriteLine();
			Console.WriteLine(result); // 36
			Console.WriteLine("\n\n");


			//Console.WriteLine("1,2 중 하나를 입력하세요 ");
			//int choice = Convert.ToInt32(Console.ReadLine());
			//if (choice == 1)
			//{ goto first; }
			//else if (choice == 2)
			//{ goto second;  }
			//else
			//{ goto etc;  }

			//first:
			//	Console.WriteLine(" First ");
			//second:
			//	Console.WriteLine(" Second ");
			//etc:
			//	Console.WriteLine(" ETC ");


			//switch + goto
			Console.WriteLine("수강과목을 선택하세요...");
			Console.WriteLine("1.C#		2.Unity		3.Database");
			Console.WriteLine("입력 >> ");
			int lecture = Convert.ToInt32(Console.ReadLine());
			switch (lecture)
			{
				case 1:
					goto A;
				case 2:
					goto B;
				case 3:
					goto C;
				case 4:
					goto D;
			}

		A:
			Console.WriteLine("C# 수업이 마감되었습니다.");
			goto E;
		B:
			Console.WriteLine("Unity 수업 신청이 완료 되었습니다.");
			goto E;
		C:
			Console.WriteLine("Database 수업은 폐강되었습니다.");
			goto E;
		D:
			Console.WriteLine("잘못된 입력입니다...");
			goto E;
		E:
			Console.WriteLine("===================");

		}










	}
}
