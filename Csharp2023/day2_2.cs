using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1_2023
{
	class day2_2
	{
		static void Main(string[] args)
		{
			// 산술 연산자 
			double n1 = 100;
			double n2 = 3;
			Console.WriteLine("\t {0} + {1} = {2}", n1, n2, (n1 + n2));
			Console.WriteLine("\t {0} - {1} = {2}", n1, n2, (n1 - n2));
			Console.WriteLine("\t {0} * {1} = {2}", n1, n2, (n1 * n2));

			Console.WriteLine("\t {0} / {1} = {2}", n1, n2, (n1 / n2));
			Console.WriteLine("\t {0} / {1} = {2:F2}", n1, n2, (n1 / n2));
			Console.WriteLine("\t {0} % {1} = {2}", n1, n2, (n1 % n2));

			////두수를 입력받은 후 사칙연산하기
			//double dNum, dNum2;
			//Console.Write("첫번째 숫자 입력: ");			
			//dNum = Convert.ToDouble(Console.ReadLine());
			//Console.Write("두번째 숫자 입력: ");
			//dNum2 = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine($"{dNum} + {dNum2} = {(dNum + dNum2):F2}");
			//Console.WriteLine($"{dNum} - {dNum2} = {(dNum - dNum2):F2}");
			//Console.WriteLine($"{dNum} * {dNum2} = {(dNum * dNum2):F2}");
			//Console.WriteLine($"{dNum} / {dNum2} = {(dNum / dNum2):F2}");
			//Console.WriteLine($"{dNum} % {dNum2} = {(dNum % dNum2):F2}");

			//문자열 연결 연산자
			//자동 형변환으로 String 타입으로 더해진다.
			string x1 = "12";
			int x2 = 100;
			double x3 = 3.14;
			bool x4 = true;

			string y;

			//y = x1 + x4;
			//Console.WriteLine($"{y.GetType()}");
			Console.WriteLine($"{x1} + {x2} = {x1 + x2}");
			Console.WriteLine($"{x1} + {x3} = {x1 + x3}");
			Console.WriteLine($"{x1} + {x4} = {x1 + x4}");
			Console.WriteLine("\n");

			// ===========================
			// 할당 연산자 = 대입연산자  
			// =, +=, -=, *=, /=, %=
			int xx = 0;
			Console.WriteLine($"1단계 xx = {xx}");        // 0
			xx += 10; // xx = xx+10 
			Console.WriteLine($"2단계 xx = {xx}");        // 10
			xx -= 5; // xx = xx-5 
			Console.WriteLine($"3단계 xx = {xx}");        // 5
			xx *= 3; // xx = xx*3 
			Console.WriteLine($"4단계 xx = {xx}");        // 15
			xx /= 5; // xx = xx/5 
			Console.WriteLine($"5단계 xx = {xx}");        // 3
			xx %= 2; // xx = xx%2
			Console.WriteLine($"6단계 xx = {xx}");        // 1 

			//동전 교환 프로그램
			//int coin = Convert.ToInt32(Console.ReadLine());
			int coin = 7777;
			int cAA, cBB, cCC, cDD;

			cAA = coin / 500;
			coin %= 500;
			cBB = coin / 100;
			coin %= 100;
			cCC = coin / 50;
			coin %= 50;
			cDD = coin / 10;
			coin %= 10;

			Console.WriteLine($"오백원 짜리 => {cAA}개");
			Console.WriteLine($"백원 짜리 => {cBB}개");
			Console.WriteLine($"오십원 짜리 => {cCC}개");
			Console.WriteLine($"십원 짜리 => {cDD}개");
			Console.WriteLine($"바꾸지 못한 잔돈 => {coin}원");


			// ===========================
			// 증감연산자 ++, --
			// ++n 
			// n = n + 1
			// n += 1
			int n = 10;
			Console.WriteLine($"\t 1단계 : n = {n}");     //10
			Console.WriteLine($"\t 2단계 : n = {n++}");   //10
			Console.WriteLine($"\t 3단계 : n = {n}");     //11
			Console.WriteLine($"\t 4단계 : n = {++n}");   //12
			Console.WriteLine($"\t 5단계 : n = {n--}");   //12
			Console.WriteLine($"\t 6단계 : n = {n}");     //11
			Console.WriteLine($"\t 7단계 : n = {--n}");   //10
			Console.WriteLine();
			Console.WriteLine();


			// ===========================
			// 관계 연산자 : ==, !=, <=, >=, >, <
			int z1 = 100;
			int z2 = 200;
			int z3 = 100;

			Console.WriteLine($" == 연산자 : {z1 == z2}");
			Console.WriteLine($" != 연산자 : {z1 != z3}");
			Console.WriteLine($" >= 연산자 : {z1 >= z2}");
			Console.WriteLine($" <= 연산자 : {z1 <= z3}");
			Console.WriteLine($" > 연산자 : {z1 > z2}");
			Console.WriteLine($" < 연산자 : {z1 < z2}");

			//문자열 데이타를 이용한 관계연산자 테스트
			string name1 = "홍길동";
			string name2 = "고길동";
			//bool result = flase
			var result = false;
			result = (name1 == name2);
			Console.WriteLine("name1과 name2의 값이 같은가요? {0}", result);
			result = (name1 != name2);
			Console.WriteLine("name1과 name2의 값이 틀린것이 맞지요? {0}", result);
			Console.WriteLine("\n");


			//입력받은 비밀번호가 맞는지 안맞는지
			//var result33 = false;
			//var result44 = false;
			//Console.Write("비밀번호 입력 => ");
			//int randomNum1 = Convert.ToInt32(Console.ReadLine());

			//result33 = (1234 == randomNum1);
			//Console.WriteLine($"출력 => {result33}");
			//Console.WriteLine();

			//Console.Write("비밀번호 입력 => ");
			//string randomNum2 = Console.ReadLine();
			//result44 = (Convert.ToString(1234) == randomNum2);
			//Console.WriteLine($"출력 => {result44}");


			// ===========================
			// 논리 연산자 => &&(논리곱, and), ||(논리합, or), !(부정, not)
			// && => 모든 값이 true여야 true 
			// || => 모든 값중 하나라도 true 이면 true 
			// ! => 반대 

			Console.WriteLine($" true && true : {true && true}");
			Console.WriteLine($" true && false : {true && false}");
			Console.WriteLine($" false && true : {false && true}");
			Console.WriteLine($" false && false : {false && false}");

			Console.WriteLine($" false || true : {false || true}");
			Console.WriteLine($" false || false : {false || false}");
			Console.WriteLine($" true || true : {true || true}");
			Console.WriteLine($" true || false : {true || false}");

			Console.WriteLine($" !false  : {!false}");
			Console.WriteLine($" !true  : {!true}");

			Console.WriteLine();
			Console.WriteLine();

			// 논리연산자 + 관계연산자
			string userId = "abcd";
			string userPwd = "1234";
			bool r;
			r = (userId == "abcd") && (userPwd == "1234");
			Console.WriteLine(r);
			r = (userId == "abcd") && (userPwd == "3456");
			Console.WriteLine(r);
			r = (userId == "abbc") || (userPwd == "1234");
			Console.WriteLine(r);
			r = (userId == "abbc") || (userPwd == "5678");
			Console.WriteLine(r);

			Console.WriteLine();
			Console.WriteLine();


			////놀이기구 탑승 조건 프로그래밍
			//int age = 10;
			//int tall = 150;
			//double csAge, csTall;

			//Console.Write("철수의 나이는? ... ");
			//csAge = Convert.ToDouble(Console.ReadLine());
			//Console.Write("철수의 키는? ... ");
			//csTall = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine($"철수는 놀이기구를 탈 수 있을까요? {csAge >= age && csTall >= tall}");


			////입력 받은 숫자가 짝수인지 홀수인지 출력하여라
			//Console.Write("정수 숫자 입력 => ");
			//int rNum = Convert.ToInt32(Console.ReadLine());
			//int result77 = rNum % 2;
			//Console.WriteLine($"{rNum}는 짝수인가요?{result77 == 0}");
			//Console.WriteLine("\n");


			//3개의 숫자를 변수로 정의하고 3숫자의 합이 500보다 크고 짝수일 때 True False 출력해보기
			//Console.WriteLine("3개의 숫자를 입력하세요!!");
			//int a = Convert.ToInt32(Console.ReadLine());
			//int b = Convert.ToInt32(Console.ReadLine());
			//int c = Convert.ToInt32(Console.ReadLine());
			//int sum = (a+b+c);

			//Console.WriteLine($"세수의 합은 500보다 큰가? {sum > 500}");
			//Console.WriteLine($"세수는 모두 짝수인가? {a % 2 ==0 && b % 2 == 0 && c % 2 == 0}");
			//Console.WriteLine($"세수의 합은 500보다 크고 세수는 모두 짝수인가? {sum > 500 && a % 2 == 0 && b % 2 == 0 && c % 2 == 0}");


			//철수와 영희의 치킨 쿠폰
			// 쿠폰의 합이 10장이면 치킨을 먹을 수 있다 
			//int coupone1, coupone2;
			//bool result2;

			//Console.Write("철수의 쿠폰 => ");
			//coupone1 = Convert.ToInt32(Console.ReadLine());
			//Console.Write("영희의 쿠폰 => ");
			//coupone2 = Convert.ToInt32(Console.ReadLine());

			//result2 = (coupone1 + coupone2) >= 10;
			//Console.WriteLine($"철수와 영희는 치킨을 먹을 수 있을까...?   {result2}");
			//Console.WriteLine("\n");

			// ===========================
			// 조건 연산자
			// (조건식)? 값1:값2;
			// 조건식이 만족(True) 이면 첫번째 값
			// 조건식이 불만족(False) 이면 두번째값 

			// 짝수인지 홀수인지?
			int number = 100;
			string result1 = ((number % 2) == 0) ? "짝수" : "홀수";
			Console.WriteLine($" {number} : {result1}");
			Console.WriteLine("\n");

			// 음수이면 양수로 변환하기 
			int number2 = -123;
			int result3 = (number2 < 0) ? -number2 : number2;
			Console.WriteLine($" {number2} : {result3}");
			number2 = 567;
			var result4 = (number2 < 0) ? -number2 : number2;
			Console.WriteLine($" {number2} : {result4}");
			Console.WriteLine("\n");


			////철수 놀이기구2
			//Console.Write("철수의 나이를 입력해주세요 : ");
			//int age2 = Convert.ToInt32(Console.ReadLine());
			//Console.Write("철수의 키를 입력해주세요 : ");
			//int tall2 = Convert.ToInt32(Console.ReadLine());
			//string msg = ( tall2 >= 150  && age2 >= 10 ) ? "탈수 있다" : "탈수 없다";
			//Console.WriteLine($"철수의 나이는? ... {age2}");
			//Console.WriteLine($"철수의 키는? ... {tall2}");
			//Console.WriteLine($"철수는 놀이기구를 탈 수 있을까요? {msg}");


			////짝수인지 홀수인지? 3과 7의 배수인지?			
			//Console.Write("숫자를 입력하여 주세요 ... ");
			//int my_number = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine();
			//string ans1 = (my_number % 2 == 0) ? "짝수" : "홀수";
			//Console.WriteLine("{0}은 {1}", my_number, ans1);
			//string ans2 = ((my_number % 3 == 0) && (my_number % 7 == 0)) ? "3과 7의 배수" : "";
			//Console.WriteLine(ans2);




		}
	}
}
