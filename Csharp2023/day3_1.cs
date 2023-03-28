using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1_2023
{
	class day3_1
	{
		static void Main(string[] args)
		{
			//제어문
			//단순 if
			//if ~ else ~
			//if ~ else if ~ else

			// 단순 if 문 예시 
			string s1 = "Hello";
			string s2 = "hello";

			// 복문 스타일 {}
			if (s1 == s2)
			{
				Console.WriteLine("s1과 s2는 같다");
			}
			if (s1 != s2)
			{
				Console.WriteLine("s1과 s2는 같지않다");
			}

			Console.WriteLine("=============================\n");
			// 단문 스타일 
			if (s1 == s2) Console.WriteLine("s1과 s2는 같다");
			if (s1 != s2) Console.WriteLine("s1과 s2는 같지않다");

			Console.WriteLine("=============================\n");

			// 조건식에 변수나 리터럴값이 오는 경우 
			bool status = true;
			if (status)
			{
				Console.WriteLine("Hello World1");
				Console.WriteLine("Hello C#1");
			}

			Console.WriteLine("=============================\n");


			// 중첩 if문 : if문 안에 if문이 있는 구조 
			string userName = "Maria";
			int userAge = 20;

			if (userName == "Maria")
			{
				if (userAge >= 20)
				{
					Console.WriteLine($"Welcome {userName}!!!");
				}
			}
			Console.WriteLine("=============================\n");

			// 조건연산자 스타일로 변경 
			string msg =
				((userName == "Maria") && (userAge >= 20)) ?
				("Welcome " + userName + "!!!") : "";
			Console.WriteLine(msg);

			Console.WriteLine("=============================\n");


			//// 아이디, 패스워드 입력에 따른 메세지 출력 
			//string userId = "doremi";
			//string userPwd = "abcd";
			//Console.WriteLine("===========");
			//Console.Write("아이디 입력 => ");
			//string input1 = Console.ReadLine();
			//Console.Write("패스워드 입력 => ");
			//string input2 = Console.ReadLine();

			//if (input1 == userId)
			//{
			//	if (input2 == userPwd)
			//	{
			//		Console.WriteLine("\n로그인 되었습니다.\n" +
			//			"{0} 님 환영합니다", userId);
			//	}
			//}

			//Console.WriteLine("=============================");
			//// 조건연산자 스타일로 변경 
			//string msg2 =
			//	((input1 == userId) && (input2 == userPwd)) ?
			//	("\n로그인 되었습니다.\n" + userId + "님 환영합니다") : "";
			//Console.WriteLine(msg2);

			// if ~ else문

			// 점수가 70점 이상이면 합격 그렇지 않으면 불합격을 출력한다.
			int score = 90;
			if (score >= 70)
			{
				Console.WriteLine("합격");
			}
			else
			{
				Console.WriteLine("불합격");
			}

			// 단문 스타일 
			if (score >= 70) Console.WriteLine("합격");
			else Console.WriteLine("불합격");


			// 조건 연산자 스타일 
			string msg3 = (score >= 70) ? "합격" : "불합격";
			Console.WriteLine(msg3);

			Console.WriteLine("=========================\n");
			// 입력 숫자 중 큰 숫자만 출력 

			//Console.Write(" 첫번째 수 입력 => ");
			//int n1 = Convert.ToInt32(Console.ReadLine());
			//Console.Write(" 두번째 수 입력 => ");
			//int n2 = Convert.ToInt32(Console.ReadLine());
			//if (n1 >= n2)
			//{
			//	Console.WriteLine($"큰수는? {n1}");
			//}
			//else
			//{
			//	Console.WriteLine($"큰수는? {n2}");
			//}

			//Console.WriteLine("========================");
			//// 조건연산자 스타일로 변경 
			//int max_number = (n1 >= n2) ? n1 : n2;
			//Console.WriteLine($"큰수는 ? {max_number}");

			//========================================
			// 중첩 if .. else구문 => 다중 분기 
			// s값이 y=>Yes , n=>No, 그외에는 Cancel
			string s = "c";
			if (s == "y")
			{
				Console.WriteLine("Result => Yes");
			}
			else
			{
				if (s == "n")
				{
					Console.WriteLine("Result => No");
				}
				else
				{
					Console.WriteLine("Result => Cancel");
				}
			}
			Console.WriteLine("=========================\n");

			//2개의 숫자를 입력한 후 비교하기
			//Console.Write("첫번째 수 입력 => ");
			//int fNum = Convert.ToInt32(Console.ReadLine());
			//Console.Write("두번째 수 입력 => ");
			//int sNum = Convert.ToInt32(Console.ReadLine());

			//if (fNum == sNum) Console.WriteLine("입력 숫자는 같다.");	
			//else if (fNum > sNum) Console.WriteLine($"첫번째 수 {fNum}이 크다.");			
			//else Console.WriteLine($"두번째 수 {sNum}이 크다.");


			// if ~ else if ~ else 
			char letter = 'y';
			if (letter == 'b')
			{
				Console.WriteLine($"{letter} : banana");
			}
			else if (letter == 'c')
			{
				Console.WriteLine($"{letter} : car");
			}
			else if (letter == 'a')
			{
				Console.WriteLine($"{letter} : apple");
			}
			else
			{
				Console.WriteLine($"{letter} : ...");
			}

			Console.WriteLine("=========================\n");
			// 0, 짝수, 홀수 테스트 
			//Console.WriteLine("숫자를 입력하세요...");
			//int inData = Convert.ToInt32(Console.ReadLine());
			int inData = 0;
			if (inData == 0)
			{
				Console.WriteLine("0");
			}
			else if (inData % 2 == 0)
			{
				Console.WriteLine("짝수");
			}
			else
			{
				Console.WriteLine("홀수");
			}
			Console.WriteLine("=========================\n");


			// 퀴즈 - 슬라이드 55
			// 90이상이면 금메달, 80이상이면 은메달, 70이상이면 동메달 
			//  70점 미만인 경우 점수만

			//Console.Write("점수 =>  ");
			//int score2 = Convert.ToInt32(Console.ReadLine());

			//if (score2 >= 90)
			//{
			//	Console.WriteLine("축하합니다. 금메달을 수상하셨습니다.");
			//}
			//else if (score2 >= 80)
			//{
			//	Console.WriteLine("축하합니다. 은메달을 수상하셨습니다.");
			//}
			//else if (score2 >= 70)
			//{
			//	Console.WriteLine("축하합니다. 동메달을 수상하셨습니다.");
			//}
			//else
			//{
			//	Console.WriteLine($"{score2} 점. 수고하셨습니다.");
			//}
			//Console.WriteLine("=========================\n");


			////BMI 프로그램 
			//double mycm, mykg, bmiresult;
			//int div = 100;
			//Console.Write("키를 입력하세요(cm) : ");
			//mycm = Convert.ToDouble(Console.ReadLine());
			//Console.Write("체중을 입력하세요(kg) : ");
			//mykg = Convert.ToDouble(Console.ReadLine());

			////BMI 지수 = 몸무게(kg) ÷ (키(m) × 키(m))
			//mycm /= div; //m 단위
			//bmiresult = mykg / (mycm * mycm);

			//if (20 > bmiresult) Console.WriteLine($"bmi={bmiresult:f1}, 저체중");
			//else if ((20 <= bmiresult) && (bmiresult < 25)) Console.WriteLine($"bmi={bmiresult:f1}, 정상체중");
			//else if ((25 <= bmiresult) && (bmiresult < 30)) Console.WriteLine($"bmi={bmiresult:f1}, 경도비만");
			//else if ((30 <= bmiresult) && (bmiresult < 40)) Console.WriteLine($"bmi={bmiresult:f1}, 비만");
			//else Console.WriteLine($"bmi={bmiresult:f1}, 고도비만");
			//Console.WriteLine("=========================\n");

		}
	}
}
