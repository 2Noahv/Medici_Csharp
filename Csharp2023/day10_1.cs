using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2023
{
	internal class day10_1
	{
		static void Main()
		{
			//예외처리
			//int[] arry = { 100, 200, 300 };
			//try
			//{
			//	//형변환 에러 - FormatException
			//	Console.Write("데이타 입력 => ");
			//	int num = Convert.ToInt32(Console.ReadLine());

			//	//인덱스 에러 - IndexOutOfRangeException
			//	for (int i = 0; i < num; i++)
			//	{
			//		Console.WriteLine(arry[i]);
			//	}
			//}

			//catch (IndexOutOfRangeException e)
			//{
			//	Console.WriteLine($"예외발생1 : {e.Message}");
			//}

			//catch (FormatException e)
			//{
			//	Console.WriteLine($"예외발생2 : {e.Message}");
			//}
			//Console.WriteLine("종료");


			// Exception을 이용한 구문 수정 (대표, 종합적)
			//try
			//{
			//	Console.Write("데이타 입력 => ");
			//	int num = Convert.ToInt32(Console.ReadLine());

			//	for (int i = 0; i < num; i++)
			//	{
			//		Console.WriteLine(arry[i]);
			//	}
			//}

			//catch (Exception e)
			//{
			//	Console.WriteLine($"예외발생!!! : {e.Message}");
			//}
			//Console.WriteLine("종료");
			//Console.WriteLine("===============\n");

			//try
			//{
			//	for (int i = 0; i < 3; i++)
			//	{
			//		//예외가 발생할 만한 코드 작성
			//		Console.WriteLine(arry[i]);
			//	}
			//}

			//catch (Exception e)
			//{
			//	//예외가 발생할 때 처리해야 할 코드 블록
			//	Console.WriteLine($"예외발생!!! : {e.Message}");
			//}

			//finally
			//{
			//	//예외가 발생하거나 정상일 때 모두 처리해야 할 코드 목록
			//             Console.WriteLine("예외처리 테스트 종료");
			//         }
			//Console.WriteLine("종료");
			//Console.WriteLine("===============\n");

			// 슬라이드 13
			string[] strings_arr = { "하나", "둘", "셋" };
			Queue que = new Queue(strings_arr);
			try
			{
				for (int i = 0; i < 5; i++)
				{
					Console.WriteLine(que.Dequeue());
				}
			}
			catch (Exception e)
			{
				Console.WriteLine($"오류 발생");
			}
			finally
			{
				Console.WriteLine("예외처리 종료");
			}
			Console.WriteLine("===============\n");

			int randnum = 0;
			ArrayList tarrylist = new ArrayList();
			for (int i = 0; i < 5; i++)
			{
				try
				{
					Console.Write("데이터를 입력하세요...");
					randnum = Convert.ToInt32(Console.ReadLine());
					tarrylist.Add(randnum);
				}

				catch (Exception e)
				{
					Console.WriteLine($"오류 발생");
				}
			}

	        Console.Write("\n\n mum_list = ");
			foreach (int i in tarrylist)
			{
				Console.Write($" {i}");
			}
			Console.WriteLine("===============\n");


			//throw 구문
			int arg = 12;
			try
			{
				if (arg < 10)
				{
					Console.WriteLine($" arg = {arg}");
				}
				else
				{
					throw new Exception("arg > 10");
				}
			}

			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				Console.WriteLine("throw 테스트 종료");
			}
;


		}

	}
}
