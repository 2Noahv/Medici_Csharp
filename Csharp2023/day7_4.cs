using System;

namespace Csharp2023
{
	// 클래스 선언 
	class MyClass
	{
		public int MyField1;
		public int MyField2;
	}

	// 구조체 선언 
	struct MyStruct
	{
		public int a;
		public int b;
	}

	internal class day7_4
	{
		static void Main()
		{
			//일반 변수 사본 테스트
			//깊은 복사 , 깊은 복사(Deep Copy)
			//값형식, 구조체
			int a = 100;
			int b = a; // b는 a의 사본
            Console.WriteLine($"a = {a}  b {b} "); // 100	100
			b = 300;
			Console.WriteLine($"a = {a}  b {b} "); // 100	300

			//배열 사본 테스트
			Console.WriteLine();
			int[] arr1 = { 1, 2, 3 };
			int[] arr2 = arr1; // arr2는 arr1의 사본 
			Console.WriteLine("arr1");
			foreach (int item in arr1)
			{
				Console.Write($"\t {item} ");
			}
			Console.WriteLine("arr2");
			foreach (int item in arr2)
			{
				Console.Write($"\t {item} ");
			}
			// arr2의 특정 데이타 수정 
			// 메모리 참조 복사 방식, 얕은 복사(shallow copy)
			// 클래스, 배열

			arr2[0] = 100;
			Console.WriteLine("\n 값 수정후 ....");
			Console.WriteLine("\n arr1");
			foreach (int item in arr1)
			{
				Console.Write($"\t {item} ");
			}
			Console.WriteLine("\n arr2");
			foreach (int item in arr2)
			{
				Console.Write($"\t {item} ");
			}

			// 클래스 객체의 사본 테스트 
			MyClass source = new MyClass();
			source.MyField1 = 10;
			source.MyField2 = 20;

			// 객체의 사본 생성 
			MyClass target = source;

			Console.WriteLine($"source.MyField1 => {source.MyField1}");
			Console.WriteLine($"source.MyField2 => {source.MyField2}");
			Console.WriteLine($"target.MyField1 => {target.MyField1}");
			Console.WriteLine($"target.MyField2 => {target.MyField2}");

			Console.WriteLine("\n 값 수정후 ....");
			target.MyField2 = 30;
			Console.WriteLine($"source.MyField1 => {source.MyField1}");
			Console.WriteLine($"source.MyField2 => {source.MyField2}");
			Console.WriteLine($"target.MyField1 => {target.MyField1}");
			Console.WriteLine($"target.MyField2 => {target.MyField2}");

			// 구조체 멤버 변수의 사본 테스트 
			Console.WriteLine();

			MyStruct mystruct1 = new MyStruct();
			mystruct1.a = 100;
			mystruct1.b = 200;

			MyStruct mystruct2 = mystruct1;
			Console.WriteLine($"mystruct1.a => {mystruct1.a}");
			Console.WriteLine($"mystruct1.b => {mystruct1.b}");
			Console.WriteLine($"mystruct2.a => {mystruct2.a}");
			Console.WriteLine($"mystruct2.b => {mystruct2.b}");

			Console.WriteLine("\n 값 수정후 ....");
			mystruct2.a = 500;
			Console.WriteLine($"mystruct1.a => {mystruct1.a}");
			Console.WriteLine($"mystruct1.b => {mystruct1.b}");
			Console.WriteLine($"mystruct2.a => {mystruct2.a}");
			Console.WriteLine($"mystruct2.b => {mystruct2.b}");



		}
	}
}
