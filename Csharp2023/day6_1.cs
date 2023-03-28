using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1_2023
{
	class day6_1
	{

		// 명명된 매개변수 
		// 매개변수 O, 반환값 X
		static void printProfile(string name, string phone)
		{
			Console.WriteLine($" 이름 : {name}");
			Console.WriteLine($" 모바일 : {phone}");
			Console.WriteLine();
		}

		// 명명된 매개변수 
		// 매개변수 O, 반환값 O
		// 기호에 따른 계산 결과 출력
		static string calculator(char symbol, double n1, double n2)
		{
			if (symbol == '+') return $"{n1} + {n2} = {(n1 + n2):f2}";
			else if (symbol == '-') return $"{n1} - {n2} = {(n1 - n2):f2}";
			else if (symbol == '*') return $"{n1} x {n2} = {(n1 * n2):f2}";
			else if (symbol == '/') return $"{n1} / {n2} = {(n1 / n2):f2}";
			else if (symbol == '%') return $"{n1} % {n2} = {n1 % n2}";
			else return "계산 오류";
		}


		static string printBMI(double height, double weight)
		{
			height /= 100;
			double bmiMy = weight / (height * height);

			if (20 > bmiMy) return $"{bmiMy:F2}, 저체중";
			else if (25 > bmiMy) return $"{bmiMy:F2}, 정상체중";
			else if (30 > bmiMy) return $"{bmiMy:F2}, 경도비만";
			else if (40 > bmiMy) return $"{bmiMy:F2}, 비만";
			else return ($"{bmiMy:F2}, 고도비만");
		}


		//매개변수의 모두의 합 구하기
		//매개변수 0, 반환값 0
		//params 키워드를 사용하면 가변 개수의 인수를 사용하는 메서드 매개 변수를 지정할 수 있다.
		//매개 변수 배열은 1차원 배열이어야 합니다.
		static int getParameterSum(params int[] args)
		{
			int sum = 0;
			for (int i = 0; i < args.Length; i++)
			{
				sum += args[i];
			}
			return sum;
		}


		//가변길이 매개변수 방식으로 메소드를 호출하기
		static void printMessage(params string[] myStr)
		{
			string nameArr = default;
			for (int j = 0; j < myStr.Length; j++ )
			{
				Console.WriteLine($"{myStr[j]} 님. 안녕하세요 !!!!");
			}
            Console.WriteLine("\n");
        }

		/*
         * 퀴즈 - 가변길이 매개변수 메소드 
         * 매개변수중 가장 큰수를 출력하여라 
        */
		static string getMaxNumber(params double[] args)
		{
			double max_number; // 최댓값 변수 
							   // 매개변수 값이 1개이거나 없는 경우 
			if (args.Length <= 1) return "오류발생";
			// 최댓값을 매개변수의 첫번째 값으로 초기화 
			max_number = args[0];
			for (int i = 1; i < args.Length; i++)
			{
				// 현재 최댓값보다 인덱스에 해당하는 매개변수값이 크다면 
				// 최댓값 교체 
				if (max_number < args[i])
				{
					max_number = args[i];
				}
			}
			return $"큰수는? {max_number}";
		}
		
		static void Calculator(int numA, int numB)
		{
			int sum = numA + numB;
			int minus = numA - numB;
			int mul = numA * numB;
			int div = numA / numB;

            Console.WriteLine($"{numA} + {numB} = {sum}");
			Console.WriteLine($"{numA} - {numB} = {minus}");
			Console.WriteLine($"{numA} * {numB} = {mul}");
			Console.WriteLine($"{numA} / {numB} = {div}");
		}

		static void Calculator(double numA, double numB, double numC)
		{
			double sumABC = numA + numB + numC;
			double minusABC = numA - numB - numC;
			double mulABC = numA * numB * numC;
			double divABC = numA / numB / numC;

			Console.WriteLine($"{numA} + {numB} + {numC} = {sumABC:F2}");
			Console.WriteLine($"{numA} - {numB} - {numC} = {minusABC:F2}");
			Console.WriteLine($"{numA} * {numB} * {numC} = {mulABC:F2}");
			Console.WriteLine($"{numA} / {numB} / {numC} = {divABC:F2}");
		}

		static double GetArea (double numA)
		{
			double pi = 3.14;
			double ellips =  (numA * numA) * pi;
			return ellips;

		}

		static double GetArea(double numA, double numB)
		{
			double rectArea = numA * numB;
			return rectArea;
		}

		static double GetArea(double numA, double numB, double numC)
		{
			//사다리꼴 (윗변 + 아랫변) * 높이 / 2 
			double trapezoidArea = (numA + numB) * numC / 2;
			return trapezoidArea;
		}




		static void Main(string[] args)
		{
			Console.WriteLine("===============");
			// 명명된 매개변수 함수 호출 
			printProfile(name: "장원영", phone: "010-1234-7890");
			printProfile(phone: "010-6789-0000", name: "이승기");

			Console.WriteLine("===============");
			// 명명된 매개변수 함수 호출 
			Console.WriteLine("계산식1 : " + calculator(symbol: '*', n1: 34.5, n2: 4.569));
			Console.WriteLine("계산식2 : " + calculator(n1: 52, n2: 7, symbol: '%'));
			Console.WriteLine("계산식3 : " + calculator(n2: 25.89, n1: 33.5, symbol: '/'));
			Console.WriteLine("계산식4 : " + calculator(n2: 34, n1: 267.89, symbol: '^'));
			Console.WriteLine("===============\n");

			Console.WriteLine($"고객001 167.5cm , 55.7kg => BMI {printBMI(height:167.5, weight:55.7)}");
			Console.WriteLine($"고객002 188cm , 89kg => BMI {printBMI(weight: 89.1, height: 188)}");
			Console.WriteLine($"고객003 145cm , 50.35kg => BMI {printBMI(weight: 50.35, height:145)}");
			Console.WriteLine("===============\n");

            Console.WriteLine("{0}+{1}={2}", 10, 20, getParameterSum(10, 20));
			Console.WriteLine("{0}+{1}+{2}={3}", 10, 30, 50, getParameterSum(10, 30, 50));
			Console.WriteLine("{0}+{1}+{2}+{3}={4}", 10, 30, 50, 100, getParameterSum(10, 30, 50, 100));
			Console.WriteLine("===============\n");

			printMessage("철수");
			printMessage("강호", "영희");
			printMessage("영준", "명희", "지민", "수진");

            Console.WriteLine(getMaxNumber());
			Console.WriteLine(getMaxNumber(55.5));
			Console.WriteLine(getMaxNumber(12.678, 55.5));
			Console.WriteLine(getMaxNumber(123.5, -90, 678));
			Console.WriteLine(getMaxNumber(-90, 678, 999, 456, 123));
			Console.WriteLine("===============\n");

			Calculator(100, 4);
			Calculator(15.78, 3.456, 23.456);
			Console.WriteLine("===============\n");

			Console.WriteLine($"반지름 2.5cm인 타원의 면적 = " + $"{GetArea(2.5)}cm");
			Console.WriteLine($"가로 5.5cm, 세로 7.5cm인 사각형 면적 = " + $"{GetArea(5.5, 7.5)}cm");
			Console.WriteLine($"윗변 2.5cm, 아랫변 4.3cm, 높이 5.2cm인 사다리꼴의 면적 = " + $"{GetArea(2.5, 4.3, 5.2)}cm");
			Console.WriteLine("===============\n");

		}
	}
}
