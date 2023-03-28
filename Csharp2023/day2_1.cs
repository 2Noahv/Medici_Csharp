using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1_2023
{
	class day2_1
	{
		static void Main(string[] args)
		{
			//Var 키워드를 이용한 변수 설정
			//변수 선언시 var 키워드를 사용하면 데이터값에 따라 자동으로 데이터 형식이 저장된다.
			//var 변수명 = 데이터값;
			//암시적 변수 지정이라고 한다.

			//var 키워드를 이용한 변수 설정
			var q1 = "닷넷프레임워크";
			var q2 = 10;
			var q3 = 123.567;
			var q4 = '옹';
			var q5 = false;
			Console.WriteLine($"\t q1의 값은 {q1}, 데이타형은 {q1.GetType()}");
			Console.WriteLine($"\t q2의 값은 {q2}, 데이타형은 {q2.GetType()}");
			Console.WriteLine($"\t q3의 값은 {q3}, 데이타형은 {q3.GetType()}");
			Console.WriteLine($"\t q4의 값은 {q4}, 데이타형은 {q4.GetType()}");
			Console.WriteLine($"\t q5의 값은 {q5}, 데이타형은 {q5.GetType()}");


			//default 키워드
			//숫자 데이터 형식은 0, char는 \0로 기본값이 저장된다.
			//데이타형 변수명 = default;
			//데이타형 변수명 = default(데이타형);
			//String 변수의 경우 default 키워드를 사용 할 수 없어서 ""을 사용한다.
			// defalut 키워드를 이용한 변수 초기값 지정 
			int p1 = default;
			long p2 = default;
			float p3 = default;
			bool p4 = default;
			char p5 = default;
			//string p6 = default;   // 오류 발생 
			string p6 = "";

			Console.WriteLine($"\t p1의 값은 {p1} 데이타형은 {p1.GetType()}");
			Console.WriteLine($"\t p2의 값은 {p2} 데이타형은 {p2.GetType()}");
			Console.WriteLine($"\t p3의 값은 {p3} 데이타형은 {p3.GetType()}");
			Console.WriteLine($"\t p4의 값은 {p4} 데이타형은 {p4.GetType()}");
			Console.WriteLine($"\t p5의 값은 {p5} 데이타형은 {p5.GetType()}");
			Console.WriteLine($"\t p6의 값은 {p6} 데이타형은 {p6.GetType()}");
			Console.WriteLine("\n");

			//탐색 메서드
			//indexOf()		: 현재 문자열에서 찾고자 하는 문자나 문자열의 위치를 숫자 형태로 반환한다.
			//LastIndexOf()	: 현재 문자열에서 찾고자 하는 문자나 문자열의 위치를 뒤에서부터 찾아 숫자 형태로 반환하다.
			//StartWith()	: 현재 문자열이  특정 문자열이나 문자로 시작하는지를 True, False로 반환한다.
			//EndsWith()	: 현재 문자열이 특정 문자열이나 문자로 끝나는지를 True, False로 반환한다.
			//Replace(w1, w2): 현재 문자열에서 특정 문자열을 다른 문자열로 변경한 후 반환한다. (원본 변경 X 출력만 바꿔준다, 미리보기라고 생각하자)

			//문자열 탐색 메소드
			//문자열변수.메소드(옵션)
			string sampleTxt1 = "Good Morning";
			//Console.WriteLine(sampleTxt1.Length);
			//Console.WriteLine(sampleTxt1[11]);
			string sampleTxt2 = "가나다라마바사아자차카타파하";
			Console.WriteLine($"\t sampleTxt1 = {sampleTxt1}");
			Console.WriteLine($"\t sampleTxt2 = {sampleTxt2}");
			Console.WriteLine($"\t 마지막 o의 인덱스 위치 = {sampleTxt1.LastIndexOf("o")}");
			Console.WriteLine($"\t 첫번째 o의 인덱스 위치 = {sampleTxt1.StartsWith("o")}");
			Console.WriteLine($"\t a로 시작하는가? {sampleTxt1.StartsWith("a")}");
			Console.WriteLine($"\t G로 시작하는가? {sampleTxt1.StartsWith("G")}");
			Console.WriteLine($"\t G로 끝나는가? {sampleTxt1.EndsWith("G")}");
			Console.WriteLine($"\t ing로 끝나는가? {sampleTxt1.EndsWith("ing")}");
			Console.WriteLine($"\t 차가 포함되었는가? {sampleTxt2.Contains("차")}");
			Console.WriteLine($"\t Morning 글자 교체 {sampleTxt1.Replace("Morning", "Night")}");
			Console.WriteLine($"\t sampleTxt1 = {sampleTxt1}");
			//새로운 값으로 교체하려면?
			sampleTxt1 = sampleTxt1.Replace("Morning", "Night");
			Console.WriteLine($"\t sampleTxt1 = {sampleTxt1}");
			//문자열 인덱싱
			//문자열변수[인덱스값]
			Console.WriteLine(sampleTxt1[0]);
			Console.WriteLine(sampleTxt1.Length - 1); // 마지막 위치의 문자는?
			Console.WriteLine("\n");

			//변형 메소드
			//ToLower()	: 알파벳 소문자로 반환한다.
			//ToUpper()	: 알파벳 대문자로 반환한다.
			//Insert(index, string)	: 현재 문자열의 index 위치에 string을 삽입한다.
			//Remove(indexm n)	: 현재 문자열에서 index 위치에서 n개의 문자열을 삭제한다.
			//Trim() : 현재 문자열에서 앞과 뒤에 삽입된 공백을 삭제한다.
			//TrimStart()	: 현재 문자열에서 앞에 삽입된 공백을 삭제한다.
			//TrimEnd()		: 현재 문자열에서 뒤에 삽입된 공백을 삭제한다.	

			string sampleTxt3 = "hello C#";
			string sampleTxt4 = "abcdefghijklmnopqrstu";
			Console.WriteLine($"\t sampleTxt3 = {sampleTxt3}");
			Console.WriteLine($"\t sampleTxt4 = {sampleTxt4}");
			Console.WriteLine($"\t ToLower = {sampleTxt3.ToLower()}");
			Console.WriteLine($"\t ToUpper = {sampleTxt4.ToUpper()}");
			Console.WriteLine("\t Insert = {0}", sampleTxt3.Insert(0, "***"));
			Console.WriteLine("\t Remove = {0}", sampleTxt4.Remove(3, 5));
			Console.WriteLine();
			//좌우 여백만 삭제 
			Console.Write("####");
			Console.Write("Trim={0}", "     홍 길 동    ".Trim());
			Console.Write("####");
			//중간 여백도 모두 삭제하려면?
			Console.WriteLine();
			Console.Write("####");
			Console.Write("Trim={0}", "     홍 길 동    ".Replace(" ", ""));
			Console.Write("####");

			//==================================
			//문자열 분할 메소드 
			//Substring(인덱스) : 인덱스 기준으로 자르기
			//Split() : 공백기준으로 나누기 => 배열구조 
			//배열은 여러개의 데이타값이 저장되는 구조 
			//string[] 배열명 = 문자열.Split()
			//배열구조의 인덱싱 
			//배열명[인덱스]
			string sampleTxt5 = "C# JAVA PYTHON";
			Console.WriteLine($"\t sampleTxt5 = {sampleTxt5}");
			Console.WriteLine($"\t Substring(2) = {sampleTxt5.Substring(2)}");
			Console.WriteLine($"\t Substring(8) = {sampleTxt5.Substring(8)}");

			string[] arr = sampleTxt5.Split();
			Console.WriteLine($"\t arr = {arr}");
			Console.WriteLine($"\t arr = {arr[0]}, {arr[1]}, {arr[2]}");
			//foreach 문법을 이용하여 배열구조의 데이타를
			//순차적으로 접근한 후 세로로 출력
			foreach (var item in arr)
			{
				Console.WriteLine($"\t {item}");
			}

			int x = 10, y = 20, z = 30;
			// 10 + 20 + 30 = ?
			Console.Write(x);
			Console.Write(" + ");
			Console.Write(y);
			Console.Write(" + ");
			Console.Write(z);
			Console.Write(" = ");
			Console.Write(x + y + z);
			Console.WriteLine();
			Console.WriteLine("{0} + {1} + {2}", x, y, z);
			Console.WriteLine();
			Console.WriteLine($"{x} + {y} + {z}");

			//=====================
			// {인덱스, 왼쪽여백수치값}, {인덱스, -오른쪽여백수치값}
			string sample1 = "가나다라마바사";
			Console.WriteLine("\t*{0}*", sample1);
			Console.WriteLine("\t*{0, 20}*", sample1);
			Console.WriteLine("\t*{0, -20}*", sample1);

			//=====================
			// 숫자 포맷팅 
			// {인덱스:포맷문자}
			// {인덱스:D전체자릿수} 공백인경우 0으로 지정
			// 형식 지정자 "N", "F"만 사용하였을 때는 소수점 이하 2번째 자리까지 표현한다.
			Console.WriteLine("\t 10진수 => {0:D10}", 12345);
			// {인덱스:X}
			// {인덱스:X전체자릿수} 공백인경우 0으로 지정
			Console.WriteLine("\t 16진수 => {0}", 0X32A); // 10진수로 형태로 출력 810 
			Console.WriteLine("\t 16진수 => {0:X}", 0X32A);
			Console.WriteLine("\t 16진수 => {0:X10}", 0X32A);
			// {인덱스:N} 3자리수마다 쉼표 출력 
			// {인덱스:N소숫점아래표시숫자}
			Console.WriteLine("\t N => {0}", 10000000000);
			Console.WriteLine("\t N => {0:N}", 10000000000);
			Console.WriteLine("\t N => {0:N0}", 10000000000);
			// {인덱스:F소숫점아래표시숫자} 
			Console.WriteLine("\t F => {0:F}", 1234.5678); // 1234.57
			Console.WriteLine("\t F => {0:F3}", 1234); // 1234.000
			Console.WriteLine("\t F => {0:F0}", 1234.5678); // 1235
			Console.WriteLine("\t F => {0:F7}", 1234.5678);// 1234.5678000
														   // {인덱스:E소숫점아래표시숫자} 
			Console.WriteLine("\t E => {0:E}", 1234.5678);// 1.234568E+003
			Console.WriteLine("\t E => {0:E2}", 1234.5678);// 1.23E+003
			Console.WriteLine("\t E => {0:E5}", 1234.5678);// 1.23457E+003

		}
	}
}
