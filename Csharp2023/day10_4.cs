using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2023
{
	internal class day10_4
	{
		public static void SaveFile(int numA, int numB, string inStr2)
		{
			StreamReader inFp2;
			StreamWriter outFp2;
	
			inFp2 = new StreamReader("C:\\mediciStudy\\C# Data\\Testfile\\national_anthem.txt");
			outFp2 = new StreamWriter("C:\\mediciStudy\\C# Data\\Outputfile\\national_anthem_copy.txt");

			for (int i = numA; i <= numB; i++)
			{
				inStr2 = inFp2.ReadLine();
				outFp2.WriteLine(inStr2);
			}
			inFp2.Close();
			outFp2.Close();
			Console.WriteLine("--- 메소드 호출 ---");
		}


		//강사님이 하신거
		//static void SaveFile(int first, int last, string fileName)
		//{
		//	string[] instrary;
		//	string file_url1 = "c:\\workspace2023\\data\\national_anthem.txt";
		//	StreamWriter outFp;                                                 // 출력 파일
		//	string file_url2 = $"C:\\workspace2023\\output\\{fileName}.txt";
		//	outFp = new StreamWriter(file_url2);

		//	instrary = File.ReadAllLines(file_url1);

		//	for (int i = first - 1; i < last; i++)
		//	{
		//		outFp.WriteLine(instrary[i]);
		//		Console.WriteLine(instrary[i]);
		//	}

		//	Console.WriteLine($"{fileName}.txt 쓰기완료");
		//	outFp.Close();
		//}



		static void Main()
		{
			StreamReader inFp;
			StreamWriter outFp;
			string inStr;

			inFp = new StreamReader("C:\\mediciStudy\\C# Data\\Testfile\\Yesterday.txt");
			outFp = new StreamWriter("C:\\mediciStudy\\C# Data\\Outputfile\\Yesterday_copy.txt");

			while (true)
			{
				inStr = inFp.ReadLine();
				if (inStr == null) break;
				outFp.WriteLine(inStr);
			}

			inFp.Close();
			outFp.Close();
            Console.WriteLine("--- 파일복사 완료 ---");

			SaveFile(1, 5, "1절");


			//강사님이 하신거
			//===================
			// 퀴즈 - 슬라이드 39 
			// 1~5행을 1절.txt 파일에 저장하는 메소드 호출 
			// SaveFile(1, 5,"1절");

			//===================
			// 퀴즈 - 슬라이드 38
			//StreamWriter outFp;
			//outFp = new StreamWriter("C:\\workspace2023\\output\\score.txt");

			//string file_url1 = "C:\\workspace2023\\data\\data_kor.txt";
			//string file_url2 = "C:\\workspace2023\\data\\data_eng.txt";

			//string[] inStrAry = File.ReadAllLines(file_url1);
			//int sum = 0;
			//foreach (string data in inStrAry)
			//{
			//	sum += Convert.ToInt32(data);
			//}

			//Console.WriteLine($"\t 국어 총점 : {sum}   평균: {sum / inStrAry.Length}");
			//outFp.WriteLine($"\t 국어 총점 : {sum}   평균: {sum / inStrAry.Length}");

			//inStrAry = File.ReadAllLines(file_url2);
			//sum = 0;
			//foreach (string data in inStrAry)
			//{
			//	sum += Convert.ToInt32(data);
			//}
			//Console.WriteLine($"\t 영어 총점 : {sum}   평균: {sum / inStrAry.Length}");
			//outFp.WriteLine($"\n\t 영어 총점 : {sum}   평균: {sum / inStrAry.Length}");

			//outFp.Close();



		}
	}
}
