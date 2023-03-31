using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2023
{
	internal class day10_3
	{
		static void Main()
		{
			//통로 변수 설정
			StreamWriter outFp;
			//파일 쓰기 경로 설정
			outFp = new StreamWriter("C:\\mediciStudy\\C# Data\\Outputfile\\hello.txt");

			//for문 + WriteLine() 내용 쓰기
			for (int i = 0; i <= 10; i++)
			{
				outFp.WriteLine($"{i} 행 Hello world");
			}
			outFp.Close();
            Console.WriteLine("========= 파일 쓰기 완료 =========\n");


			StreamWriter outFp2;
			outFp2 = new StreamWriter("C:\\mediciStudy\\C# Data\\Outputfile\\gugu.txt");

			for (int i = 2; i <10; i++)
			{
				for (int j = 1; j <= 9; j++)
				{
					outFp2.WriteLine($"{i} X {j} = {i*j}");
				}
				outFp2.WriteLine($"{i}단 완료\n");
            }
			outFp2.Close();
			Console.WriteLine("========= 구구단 쓰기 완료 =========\n");


			StreamWriter outFp3;                                                 // 출력 파일
			outFp3 = new StreamWriter("C:\\mediciStudy\\C# Data\\Outputfile\\sample.txt");
			int line = 0;
			for (int i = 1; i <= 100; i++)
			{
				if (i % 5 == 0 || i % 11 == 0)
				{
					outFp3.Write($" {i}");
					line++;
					if (line % 5 == 0)
					{
						outFp3.Write("\n");
					}
				}
			}
			outFp3.Close();
			Console.WriteLine("--- 파일 쓰기 완료 ---\n");
		}
	}
}
