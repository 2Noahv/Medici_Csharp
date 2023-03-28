using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1_2023
{
	class day4_1
	{
		static void Main(string[] args)
		{
			// for 반복문
			Console.WriteLine("for문으로 메세지 반복하기");

			for (int i = 1; i < 4; i++)
			{
				Console.WriteLine("Hello world");
			}
			Console.WriteLine("======================================\n");


			// 0~10까지 짝수만 출력
			for (int i = 0; i <= 10; i = i + 2)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("======================================\n");

			// 1~1000 까지 합구하기 
			int sum = 0;
			for (int i = 1; i <= 1000; i++)
			{
				sum += i;
			}
			Console.WriteLine("\t\t 결과 {0}", sum);
			Console.WriteLine("======================================\n");


			// 역순으로 출력하기 
			for (int i = 10; i > 0; --i)
			{
				Console.Write($"  {i}  ");
			}
			Console.WriteLine("\n======================================\n");


			//for문으로 구구단 출력
			//Console.Write("입력 숫자=> ");
			//int gugudan = Convert.ToInt32(Console.ReadLine());
			//for (int i = 1; i < 10; i++)
			//{
			//Console.WriteLine($"{gugudan} X {i} = {gugudan * i}");
			//}


			//for 문을 이용하여 1 ~ 100까지 3의 배수만 출력
			//한줄에 5개씩 출력해야 한다.
			//Console.WriteLine("for 문을 이용하여 1 ~ 100까지 3의 배수만 출력");
			//int total = default;
			//for (int i = 0; i <100; i+= 3)
			//{
			//	Console.Write($"{i,5}\t");
			//	total++;
			//	if (total % 5 == 0)
			//	{
			//		Console.WriteLine();
			//		total = 0;
			//	}
			//}

			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 7; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine("\n======================================\n");


			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5 - i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine("\n======================================\n");


			//트리처럼 별찍기
			//int num = 5;
			//for(int i = 0; i < num; i++) {
			//	for (int j = num - 1; j > i; j--) {
			//		Console.Write(" ");
			//	}
			//	//*** 만들면서 어려웠던 점
			//	//1,3,5,7,9(홀수 일 때 별 출력)
			//	for(int k = 0; k < 2*i + 1; k++) {
			//		Console.Write("* ");
			//	}               
			//  Console.WriteLine();
			//}

			// 문자열 인덱싱
			string txt = "abcdefg";
			Console.WriteLine(txt.GetType());
			Console.WriteLine(txt[0]);
			Console.WriteLine(txt[0].GetType());
			Console.WriteLine(txt.Length);
			Console.WriteLine(txt.Length.GetType());
			Console.WriteLine(txt[txt.Length - 1]);
			Console.WriteLine("================");
			Console.WriteLine("================");

			// for + 문자열   
			string sample = "도레미파솔라시";
			for (int i = 0; i < sample.Length; i++)
			{
				Console.WriteLine($"\t{i} ... {sample[i]}");
			}
			Console.WriteLine("================");
			Console.WriteLine("================");

			// for + 문자열 
			sample = "도레미파솔라시";
			for (int i = sample.Length - 1; i >= 0; i--)
			{
				Console.WriteLine($"\t{i} ... {sample[i]}");
			}

			Console.WriteLine("================");


			//문자열 인덱싱을 활용한 회원 정보 출력하기
			//string id, name = default;
			//Console.Write("이름...");
			//name = Console.ReadLine();
			//Console.Write("아이디...");
			//id = Console.ReadLine();

			//for (int i = 0; i < name.Length; i++) {

			//	if (name[0] == name[i]) Console.Write($"이름: {name[0]}");
			//	else Console.Write("*");
			//}
			//	Console.WriteLine();

			//for (int j = 0; j < id.Length; j++)
			//{

			//	if (id[0] == id[j] ) Console.Write($"아이디: {id[j]}");
			//	else if (id[1] == id[j]) Console.Write($"{id[j]}");
			//	else if (j == id.Length-1) Console.WriteLine($"{id[j]}");
			//	else Console.Write("*");
			//}
			//Console.WriteLine();


			// 강사님이 하신 프로그램
			//string user_name, user_id;

			//Console.Write("이름...");
			//user_name = Console.ReadLine();
			//Console.Write("아이디...");
			//user_id = Console.ReadLine();

			//user_name = "홍길동";
			//user_id = "hong12345678";
			//Console.WriteLine($"이름: {user_name[0]}**");
			//Console.Write($"아이디: {user_id[0]}{user_id[1]}");
			//for (int i = 0; i < user_id.Length - 2; i++)
			//{
			//	Console.Write("*");
			//}
			//Console.Write(user_id[user_id.Length - 1]);

		}
	}
}
