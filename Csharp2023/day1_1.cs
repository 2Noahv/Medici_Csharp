using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1_2023
{
	class day1_1
	{
		static void Main(string[] args)
		{
			//2023.03.20
			//출력문 cw tap
			//주석 드래그 + Ctrl + K + C
			//해제 드래그 + Ctrl + K + U
			/*\
				여
				러
				줄
				주
				석
			 */

			//출력문
			//블록	: 한행에 한번씩 Console.WriteLine(리터널|변수|수식);
			//인라인	: 한행에 여러번 Console.Write(리터널|변수|수식);

			Console.WriteLine("Hello World1");
			Console.WriteLine("Hello C#1");
			Console.WriteLine();
			Console.Write("Hello World2");
			Console.Write("Hello C#2");
			Console.WriteLine();

			//이스케이프 문자 /n(개행), /t(들여쓰기)
			Console.WriteLine("***\n1\n\t\t2\n3***");
			Console.WriteLine();

			//자리표시자 {}
			Console.WriteLine("*{0}-{1}-{2}", "홍길동", "고길동", 1000);
			Console.WriteLine("*{2}-{0}-{0}-{1}", "홍길동", "고길동", 1000);

			//변수
			//데이타형 변수 = 리터널
			//변수.Gettype() : 변수의 데이터형 반환 (반환값은 닷넷형식의	데이타 형식으로 표시된다.)
			//float은 System.Single, Double은 System.Double, Bool형식은 첫글자가 대문자로 변환된다.
			// $"... {변수|계산식|메서드} ...."
			int v1 = 100;
			float v2 = 3.14f;
			string v3 = "2002년 10월 31일";
			bool v4 = true;
			Console.WriteLine("\n\n\n데이타형 확인하기");
			Console.WriteLine($"v1의 값은 {v1} 데이타형은 {v1.GetType()}");
			Console.WriteLine($"v2의 값은 {v2} 데이타형은 {v2.GetType()}");
			Console.WriteLine($"v3의 값은 {v3} 데이타형은 {v3.GetType()}");
			Console.WriteLine($"v4의 값은 {v4} 데이타형은 {v4.GetType()}");

			//숫자 구분자(digit separator)
			//언더바 _ 를 이용한 값 할당, 3자리마다 언더바 삽입
			//long d = 1000000;
			long d = 1_000_000;
			Console.WriteLine($" d= {d}, d의 데이타형 = {d.GetType()}");


			//데이타형에서 지원하는 최대값과 최소값 속성
			//데이타형.MinValue, 데이타형.MaxValue
			Console.WriteLine($" int의 최소값 : {int.MinValue}");
			Console.WriteLine($" int의 최대값 : {int.MaxValue}");
			Console.WriteLine($" int의 최소값 : {long.MinValue}");
			Console.WriteLine($" int의 최대값 : {long.MaxValue}");

			//정수형 범위를 넘어가서 값을 할당한다면 오버플로우 에러 발생
			int e1 = int.MaxValue;
			long e2 = e1 + 1;
			Console.WriteLine(e1);
			Console.WriteLine(e2);

			//실수형 데이타
			float n1 = 3.14f;
			double n2 = 3.143526272d;
			decimal n3 = 3.1435262726m;
			Console.WriteLine("실수형 데이타");
			Console.WriteLine($" n1 = {n1}, {n1.GetType()}");
			Console.WriteLine($" n1 = {n2}, {n2.GetType()}");
			Console.WriteLine($" n1 = {n3}, {n3.GetType()}");
			Console.WriteLine($" float 범위 : {float.MinValue} ~ {float.MaxValue}");
			Console.WriteLine($" float 범위 : {double.MinValue} ~ {double.MaxValue}");
			Console.WriteLine($" float 범위 : {decimal.MinValue} ~ {decimal.MaxValue}");

			//원 넓이 둘레 구하기
			int radius = 5;
			float pi = 3.14f;

			Console.WriteLine("-------------------");
			Console.WriteLine("      출력화면      ");
			Console.WriteLine("-------------------");

			Console.WriteLine($"원의 반지름 = {radius}");
			Console.WriteLine($"원의 넓이 = {pi * radius * radius}");
			Console.WriteLine($"원의 둘레 = {2 * pi * radius}");

			//문자와 문자열
			Console.WriteLine("\n\n문자와 문자열 데이타형");
			char c1 = 'A';
			string s1 = "Hello World";
			//@을 이용한 여러줄 문자열 변수 저장
			string s2 = @"l
						 오늘도
						 당신을
						 응원합니다.
						  ";

			Console.WriteLine($"c1 = {c1}, {c1.GetType()}");
			Console.WriteLine($"s1 = {s1}, {s1.GetType()}");
			Console.WriteLine($"s2 = {s2}");

			// String.Format()을 이용한 문자열 변수 생성 
			string user1 = "Maria", user2 = "John";
			string msg = "Good Night";
			string msg1 = String.Format("{0}, {1}", user1, msg);
			string msg2 = String.Format("{0}, {1}", user2, msg);
			// string msg3 = String.Format($"{user1} {msg},\n {user2} {msg}");
			string msg3 = $"{user1} {msg},\n {user2} {msg}";
			Console.WriteLine(msg1);
			Console.WriteLine(msg2);
			Console.WriteLine(msg3);

			//오늘의 운세
			Console.WriteLine("------------------------");
			Console.WriteLine("\t출력 화면");
			Console.WriteLine("------------------------");
			Console.WriteLine("2020년 10월 15일 쥐띠 운세 ");

			string luck = @"
							신중하게 보내고 싶을 때입니다.
							약속없어도 갑자기 친구나 지인이 찾아 오거나
							많은 사람과 떠들썩한 하루를 보낼 수 있을 것 같습니다.

							금전운 : 금전운은 오후부터 회복을 기대할 수 있는 날.
							사업운 : 쓸데 없는 수다는 평판을 떨어뜨릴 것 같다.
							";
			Console.WriteLine($"오늘의 운세\n{luck}");

			//상수
			//read only, immutable
			//const 데이타형 변수 = 값;
			const float PI = 3.14f;
			const string MYNAME = "홍길동";
			Console.WriteLine($"PI 값은? {PI}");
			Console.WriteLine($"작성자 이름은? : {MYNAME}");
			//에러 발생
			//MYNAME = "고길동";
			Console.WriteLine($"작성자 이름 : {MYNAME}");

			//float 값 상수화 시키기
			const float aMinvalue = float.MinValue;
			const float aMaxvalue = float.MaxValue;
			Console.WriteLine($"float 자료형의 최대값 = {aMaxvalue}");
			Console.WriteLine($"float 자료형의 최소값 = {aMinvalue}");

			//문자열 입력 관련 메소드
			//ReadLine()은 string tpye이고 Read()는 int type으로 유니코드를 받는다.
			//Console.Write("이름을 입력하세요 => ");
			//string userNmae = Console.ReadLine();
			//Console.WriteLine($"string type의 {userNmae}");

			//Console.Write("입력 키 유니코드 값 => ");
			//int user_key = Console.Read();
			//Console.WriteLine($"int type의 {user_key}");

			//Console.Write("입력 키 정보 => ");
			//ConsoleKeyInfo userkey;
			//userkey = Console.ReadKey();			
			//Console.WriteLine($"입력 키 정보 : {userkey.Key}");


			//===================================================
			//암시적 형(IsImplicit) 변환
			//변환 형식이 안전하게 유지되며 데이터가 손실되지 않아 특수한 구문이 필요 없다.
			//예) int 형 변수 => long 변수
			int vv1 = 100;
			long vv2 = vv1;
			Console.WriteLine("\n\n\n암시적 형변환 테스트");
			Console.WriteLine($"\t vv1의 값은 {vv1}, 데이터형은 {vv1.GetType()}");
			Console.WriteLine($"\t vv2 값은 {vv2}, 데이터형은 {vv2.GetType()}");

			//오류 발생. 오버플로우
			//long vv3 = long.MaxValue;
			//int vv4 = vv3;  값의 손실 -1

			//===================================================
			//명시적 형(explicit) 변환
			//캐스팅(casting)이라고도 한다.
			//별도의 문법이 필요하며 데이터가 손실될 수 있다.
			//예) long 형 변수 => int 형 변수
			//변수명앞에 (데이터형)을 이용하거나 Convert 클래스를 이용하요 변환해야 한다.
			long vv3 = long.MaxValue;
			int vv4 = (int)vv3;
			double vv5 = vv3;
			Console.WriteLine($"\t vv3의 값은 {vv3}, 데이터형은 {vv3.GetType()}");
			Console.WriteLine($"\t vv3의 값은 {vv4}, 데이터형은 {vv4.GetType()}");
			Console.WriteLine($"\t vv3의 값은 {vv5}, 데이터형은 {vv5.GetType()}");

			//Convert 클래스
			//Convert.ToString()	: 숫자 데이터 형식을 문자열로 변경합니다.
			//Convert.ToInt32()		: 숫자 데이터 형식을 정수 형식으로 변경합니다.
			//Convert.ToDouble()	: 숫자 데이터 형식을 실수 형식으로 변경합니다.
			//Convert.ToChar()		: 입력받은 숫자 또는 문자열 하나를 문자로 변경합니다.

			// ==============================
			// 명시적 형변환 : Convert.To자료형(변수);
			int x1 = int.MinValue;
			double x2 = Convert.ToDouble(x1);
			bool x3 = Convert.ToBoolean(x1); // 0을 제외한 나머지 숫자들은 True로 변환
			string x4 = Convert.ToString(x1);
			Console.WriteLine($"\t x1의 값은 {x1} 데이타형은 {x1.GetType()}");
			Console.WriteLine($"\t x2의 값은 {x2} 데이타형은 {x2.GetType()}");
			Console.WriteLine($"\t x3의 값은 {x3} 데이타형은 {x3.GetType()}");
			Console.WriteLine($"\t x4의 값은 {x4} 데이타형은 {x4.GetType()}");
			Console.WriteLine();

			//// ==============================
			//// 퀴즈 : 사각형 넓이 구하기 
			//int w, h;
			//Console.Write("사각형의 가로 길이를 숫자로 입력하여 주세요 ....  ");
			//w = Convert.ToInt32(Console.ReadLine());
			//Console.Write("사각형의 세로 길이를 숫자로 입력하여 주세요 ....  ");
			//h = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("------------------------");
			//Console.WriteLine($"사각형의 가로 길이 = {w}");
			//Console.WriteLine($"사각형의 세로 길이 = {h}");
			//Console.WriteLine($"사각형의 넓이 = {w * h}");

			//// ==============================
			//Convert.ToString()와 PadLeft()
			//-Convert.ToString(문자열숫자, 2)	: 2진수 문자열
			int y1 = 100;
			String y2 = Convert.ToString(y1, 2);
			//-Convert.ToString(문자열숫자, 8)	: 8진수 문자열
			String y3 = Convert.ToString(y1, 8);
			//-Convert.ToString(문자열숫자, 16)	: 16진수 문자열
			String y4 = Convert.ToString(y1, 16);
			//-PadLeft(전체자릿수, 채울문자0)		: 왼쪽에 여백을 0으로 채운다.
			Console.WriteLine($"8진수 = {y3.PadLeft(8, '0')}");
			Console.WriteLine();
			//이진수 리터널
			//0b나 0B 접두사를 붙여 이진수를 직접 코드로 표현하는 방법이다. 예)0b0010
			//출력문으로 이진수 리터럴값을 출력하면 10진수 형태로 자동변환되어 표시된다.
			// 변수의 초기값을 2진수, 16진수로 지정 
			// 접두사 0b, 0x
			byte z = 0b0010;
			Console.WriteLine($"\t z = {z} {z.GetType()}");
			Console.WriteLine($"\t z = {Convert.ToString(z, 2)}");
			Console.WriteLine($"\t z = {Convert.ToString(z, 2).PadLeft(4, '0')}");

			//입력받은 10진수를 2, 8, 16 진수로 출력
			Console.Write("입력 >>");
			//정수형태로 형변환
			int vNum = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"2진수 = {Convert.ToString(vNum, 2)}");
			Console.WriteLine($"8진수 = {Convert.ToString(vNum, 8)}");
			Console.WriteLine($"16진수 = {Convert.ToString(vNum, 16)}");

		}
	}
}
