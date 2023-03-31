using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharp2023
{
	internal class day10_2
	{
		static void Main()
		{
			StreamReader inFp; //입력 파일 통로
			string inStr; //읽어올 문자 열 한행

			//입력 파일 설정
			inFp = new StreamReader("C:\\mediciStudy\\C# Data\\Testfile\\data_eng.txt");

			//한행씩 읽어서 변수에 저장 후 출력
			inStr = inFp.ReadLine();
			Console.WriteLine(inStr);
			
			inStr = inFp.ReadLine();
			Console.WriteLine(inStr);

			inStr = inFp.ReadLine();
			Console.WriteLine(inStr);


			while (true)
			{
				inStr = inFp.ReadLine();
				if (inStr == null)
					break;
                Console.WriteLine(inStr);
            }

			inFp.Close();
			Console.WriteLine("===========================\n");


			// ===========================
			// 파일 한행씩 배열에 저장 
			// File.ReadAllLines(URL) : 배열로 저장
			string[] inStrAry;  // 문자열 배열 <= 저장소                                        
			string file_url = "C:\\mediciStudy\\C# Data\\Testfile\\Yesterday.txt";
			inStrAry = File.ReadAllLines(file_url);
			Console.WriteLine(inStrAry.Length);  // 행수 30
												 // 배열 전체 출력
			foreach (string ins in inStrAry)
			{
				Console.WriteLine(ins);
			}
            Console.WriteLine("===========================\n");


            string[] inStrAry2;
			string file_url2 = "C:\\mediciStudy\\C# Data\\Testfile\\national_anthem.txt";

			//파일의 내용을 통째로 읽어서 배열로 반환한다.
			inStrAry2 = File.ReadAllLines(file_url2);

			foreach (string instry2 in inStrAry2)
			{
				Console.WriteLine(instry2);
			}


			// 슬라이드 31
			Console.WriteLine();
			string[] inStrAry3;
			string file_url3 = "C:\\mediciStudy\\C# Data\\Testfile\\data_kor.txt";
			inStrAry3 = File.ReadAllLines(file_url3);
			int sum = 0;
			foreach (string data in inStrAry3)
			{
				sum += Convert.ToInt32(data);
			}

			Console.WriteLine($"\n\n \t 총점 : {sum}   평균: {sum / inStrAry.Length}");


		}
	}
}
