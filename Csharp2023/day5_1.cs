using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1_2023
{
	class day5_1
	{
		static void Main(string[] args)
		{
			// 2차원 배열 생성 
			//int[,] arrInt = { { 10, 20, 30 }, { 400, 500, 100 } };
			// 2차원 배열 각각 접근 : 배열명[행,열]
			//Console.WriteLine("1행 1열 배열값은? {0}", arrInt[0, 0]);
			//Console.WriteLine("1행 3열 배열값은? {0}", arrInt[0, 2]);
			//Console.WriteLine("2행 2열 배열값은? {0}", arrInt[1, 1]);
			//Console.WriteLine("2행 3열 배열값은? {0}", arrInt[1, 2]);
			// 2차원 배열 전체 출력 - 이중 for문 이용 
			//for (int i = 0; i < 2; i++)
			//{
			//	for (int j = 0; j < 3; j++)
			//	{
			//		Console.WriteLine($" {i} , {j} => {arrInt[i, j]} ");
			//	}
			//}

			//string[,] foodArr = {
			//						{"라면", "짜장면", "순대", "짬뽕" }
			//					,	{ "우동",  "초밥",  "샐러드", "볶음밥"}
			//					,	{ "돈까스", "샤브샤브", "삼겹살", "만두"}
			//					};

			//         Console.WriteLine("\n\n\n===============================");
			//int cnt = 1;
			//foreach (var item in foodArr)
			//{
			//             Console.WriteLine($"{cnt} : {item}");
			//	// 4개마다 줄 삽입
			//	if (cnt %4 == 0)
			//	{
			//                 Console.WriteLine("===============================");
			//             }
			//	cnt++;
			//         }
			//Console.WriteLine("===============================");


			// 배열 생성후 데이타 입력하기  
			//string[,] city2d = new string[3, 2];

			//Console.WriteLine("============");
			//Console.WriteLine("\t입력화면");
			//Console.WriteLine("============");

			//int number = 1;
			//for (int i = 0; i < 3; i++)
			//{
			//    for (int j = 0; j < 2; j++)
			//    {
			//        // Console.Write($"입력값{j+1} => ");
			//        Console.Write($"입력값{number} => ");
			//        number++;
			//        city2d[i, j] = Console.ReadLine();
			//        Console.WriteLine();
			//    }
			//}
			//Console.WriteLine("\n\n============");

			//for (int i = 0; i < 3; i++)
			//{
			//    for (int j = 0; j < 2; j++)
			//    {
			//        Console.Write($"{city2d[i, j]}\t");
			//    }
			//    Console.WriteLine();
			//}
			//Console.WriteLine("\n\n============");

			//int n = 1;
			//foreach (var item in city2d)
			//{
			//    Console.Write($"{item}\t");
			//    if (n % 2 == 0)
			//    {
			//        Console.WriteLine();
			//    }
			//    n++;
			//}


			// ==================================
			// ==================================
			// 퀴즈 - 슬라이드 35
			//int[,] num2DArr = new int[5, 5];
			//int count3 = 1;
			//for (int i = 0; i < 5; i++)
			//{
			//	for (int j = 0; j < 5; j++)
			//	{
			//		num2DArr[i, j] = count3 * 5;
			//		count3++;
			//	}
			//}

			//Console.WriteLine("\n\n\t출력1");
			//for (int i = 0; i < 5; i++)
			//{
			//	for (int j = 0; j < 5; j++)
			//	{
			//		Console.Write($"{num2DArr[i, j],5}");
			//	}
			//	Console.WriteLine("\n");
			//}

			//Console.WriteLine("\n\n");
			//int[,] num77DArr = new int[5, 5];
			//int count77 = 5;
			//for (int i = 0; i < 5; i++)
			//{
			//	for (int j = 0; j < 5; j++)
			//	{
			//		num77DArr[i, j] = count77;
			//		count77 += 5;
			//	}
			//}

			//Console.WriteLine("\n\n\t출력2");
			//for (int i = 0; i < 5; i++)
			//{
			//	for (int j = 0; j < 5; j++)
			//	{
			//		Console.Write($"{num77DArr[i, j],5}");
			//	}
			//	Console.WriteLine("\n");
			//}



			//5의 배수로 구성된 5행 5열 2차원 배열을 생성하고 출력하라
			//int[,] num2DArr = new int[5, 5] { 
			//									{ 5, 10, 15, 20, 25}
			//								,	{30, 35, 40, 45, 50}
			//								,	{55, 60, 65, 70, 75}
			//								,	{ 80, 85, 90, 95, 100}
			//								,	{ 105, 110, 115, 120, 125}
			//								};

			//int cntNum2D = default;

			//for(int i = 0; i < num2DArr.Length; i++)
			//{
			//	for(int j = 0; j < num2DArr.Length; j++)
			//	{
			//		Console.Write($"{num2DArr[i,j]}\t");
			//		cntNum2D++;
			//		if (cntNum2D % 5 == 0)
			//		{
			//                     Console.WriteLine();
			//                 }
			//	}

			//}
			//Console.WriteLine("===============================");


			//3행 3열의 2차원 배열을 생성하고 행과 열이 같으면 1로 바꿀 것
			//int[,] chageNum = new int[3, 3];

			//for (int i = 0; i <3; i++)
			//{
			//	for (int j = 0; j < 3; j++)
			//	{
			//		if (i == j)	Console.Write("1\t");					
			//		else Console.Write("0\t");

			//             }
			//	Console.WriteLine();

			//}







		}
	}
}
