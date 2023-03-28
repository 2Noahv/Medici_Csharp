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
	class day4_3
	{
		static void Main(string[] args)
		{
			//배열 길이 선언 
			int[] numArr1 = new int[6];
			Console.WriteLine(numArr1);
			Console.WriteLine(numArr1.GetType());
			//배열 값 지정
			numArr1[0] = 100;
			numArr1[1] = 200;
			numArr1[2] = 50;
			numArr1[3] = 67;
			numArr1[4] = 34;
			numArr1[5] = 67;
			//배열 전체 출력
			for (int i = 0; i < numArr1.Length; i++)
			{
				Console.Write($"{i + 1} 번째 =>  {numArr1[i]}   ");
			}

			Console.WriteLine("\n\n ===================");
			Console.WriteLine();

			// 배열 선언2 - 배열 길이와 중괄호를 이용해서 초기값 설정
			int[] moneyArr = new int[4] { 10000, 1000, 500, 5000 };
			for (int i = 0; i < moneyArr.Length; i++)
			{
				Console.WriteLine(moneyArr[i]);
			}

			Console.WriteLine("\n\n ===================");
			Console.WriteLine();

			// 배열 선언3 - 배열 길이 생략. 중괄호를 이용해서 초기값 설정
			string[] fruitArr = new string[] { "바나나", "포도", "오렌지" };
			for (int i = 0; i < fruitArr.Length; i++)
			{
				Console.WriteLine(fruitArr[i]);
			}

			Console.WriteLine("\n\n ===================");
			Console.WriteLine();

			// 배열 선언4 - 배열 길이 및 new 키워드 생략
			// 중괄호를 이용해서 초기값 설정
			string[] nameArr = { "최", "선우", "박", "신", "이" };
			for (int i = 0; i < nameArr.Length; i++)
			{
				Console.WriteLine(nameArr[i]);
			}
			Console.WriteLine("===================\n\n");


			//int[] scoreArr = new int[] { 65, 77, 55 };
			//int[] scoreArr = new int[3] { 65, 77, 55 };
			//int[] scoreArr = { 65, 77, 55 };

			//double tot = 0;
			//double avg;

			//for (int i = 0; i < scoreArr.Length; i++)
			//{
			//	tot += scoreArr[i];
			//}

			//avg = tot / scoreArr.Length;
			//Console.WriteLine($"총점 = {tot}");
			//Console.WriteLine($"평균 = {avg:F3}");
			//Console.WriteLine("=========================");



			//국가이름으로 나열된 배열 출력하기
			//string[] countryArr = new string[7]  {	"프랑스", "브라질", "싱가폴"
			//									 ,	"대한민국", "영국", "중국"
			//									 , "미국"							  
			//									 };

			//for(int i = 0;i < countryArr.Length; i++) {
			//	Console.WriteLine($"=> {countryArr[i]}");
			//}

			//강사님이 하신 로직
			//string[] countryArr = new string[7];

			//for (int i = 0; i < countryArr.Length; i++)
			//{
			//    Console.Write($"{i}번째 배열값 = > ");
			//    countryArr[i] = Console.ReadLine();
			//}

			//for (int i = 0; i < countryArr.Length; i++)
			//{
			//    Console.WriteLine("=> " + countryArr[i]);
			//}


			//foreach문으로 출력하기
			//string[] newnameArr = { "민호", "수진", "석진", "남준", "태형" };

			//foreach (var nameA  in newnameArr)
			//{
			//	if (nameA == newnameArr[0]) Console.WriteLine($"첫번째 배열값 출력: {nameA}");
			//	else if (nameA == newnameArr[2]) Console.WriteLine($"세번째 배열값 출력: {nameA}");
			//}

			//Console.WriteLine($"배열 모두 출력하기");
			//foreach (var nameB in newnameArr)
			//{
			//	Console.WriteLine($"=> {nameB}");
			//}
			//Console.WriteLine("=========================");


			//배열의 길이를 입력 받고 출력해보자
			Console.Write("배열 길이 입력 => ");
			//int ranSelect = Convert.ToInt32(Console.ReadLine());
			//string[] arrySelect = new string[ranSelect];

			//for (int i = 0; i < arrySelect.Length; i++)
			//{
			//	Console.Write($"{i} 배열값 => ");
			//	arrySelect[i] = Console.ReadLine();
			//}

			//Console.WriteLine("\n입력하신 과일목록 입니다.");
			//foreach (var fruit in arrySelect)
			//{
			//	Console.WriteLine(fruit);
			//}



			// 1) 배열 선언 
			//int[] scoreArr2 = new int[5]; // 점수 배열
			//string[] subTitle = { "국어", "영어", "수학", "과학", "한문" }; // 과목 배열 
			//													  // 2) 점수 배열에 데이타 입력 
			//													  // for (int i = 0; i < 5; i++)
			//for (int i = 0; i < scoreArr2.Length; i++)
			//{
			//	Console.Write($" {subTitle[i]} 점수 = > ");
			//	scoreArr2[i] = Convert.ToInt32(Console.ReadLine());
			//}
			//// 3) 총점(배열의합) 구하면서 배열값 출력 
			//double sum2 = 0;
			//double avg2;
			//for (int i = 0; i < scoreArr2.Length; i++)
			//{
			//	sum2 += scoreArr2[i];
			//	Console.Write($" {subTitle[i]} 점수 = > ");
			//	Console.Write(scoreArr2[i]);
			//	Console.WriteLine();
			//}
			//// 4) 평균 및 학점 구하기 
			//avg2 = sum2 / scoreArr2.Length;
			//string grade;
			//if (avg2 >= 90)
			//	grade = "A";
			//else if (avg2 >= 80)
			//	grade = "B";
			//else if (avg2 >= 70)
			//	grade = "C";
			//else if (avg2 >= 60)
			//	grade = "D";
			//else
			//	grade = "F";
			//// 5) 합계, 평균, 학점 출력 
			//Console.WriteLine($" 합계 = > {sum2} ");
			//Console.WriteLine($" 평균 = > {avg2:F3} ");
			//Console.WriteLine($" 학점 = > {grade} ");

		}
	}
}
