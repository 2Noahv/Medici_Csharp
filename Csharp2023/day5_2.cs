using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1_2023
{
	class day5_2
	{
		// 열거형 선언 
		enum Gender
		{
			Male,
			Female
		}


		enum Season
		{
			Spring,
			Summer,
			Autumn,
			Winter
		}

		enum Enum
		{
			C_language = 10,
			C_Plues = 20,
			C_Sharp = 30,
			Python = 40,
			JAVA = 50
		}

		// 열거형 상수와 고유 값 지정 
		enum DialogResult
		{
			YES = 10,
			NO,
			CANCEL,
			CONFIRM = 50,
			OK
		}


		static void Main(string[] args)
		{
			//열거형 변수 정의
			// 열거형 데이타 사용 1
			Console.WriteLine(Gender.Male);
			Console.WriteLine(Gender.Female);

			// 열거형 데이타 사용 2 - 열거형 변수 선언 방식 
			// 열거형이름 열거형변수 =  열거형이름.열거형상수; 
			Gender m = Gender.Male;
			Gender f = Gender.Female;

			Console.WriteLine(m);
			Console.WriteLine(f);
			Console.WriteLine($"==========================\n");

			Console.WriteLine($"01. {Season.Spring}");
			Console.WriteLine($"02. {Season.Summer}");
			Console.WriteLine($"03. {Season.Autumn}");
			Console.WriteLine($"04. {Season.Winter}");
			Console.WriteLine($"==========================\n");


			Console.WriteLine($"{(int)Enum.C_language}  {Enum.C_language}");
			Console.WriteLine($"{(int)Enum.C_Plues}  {Enum.C_Plues}");
			Console.WriteLine($"{(int)Enum.C_Sharp}  {Enum.C_Sharp}");
			Console.WriteLine($"{(int)Enum.Python}  {Enum.Python}");
			Console.WriteLine($"{(int)Enum.JAVA}  {Enum.JAVA}");
			Console.WriteLine($"==========================\n");

			// 열거형 값 확인 테스트 
			Console.WriteLine("===========================");
			Console.WriteLine($"\tDialogResult.YES => {(int)DialogResult.YES}");
			Console.WriteLine($"\tDialogResult.NO => {(int)DialogResult.NO}");
			Console.WriteLine($"\tDialogResult.CANCEL => {(int)DialogResult.CANCEL}");
			Console.WriteLine($"\tDialogResult.CONFIRM => {(int)DialogResult.CONFIRM}");
			Console.WriteLine($"\tDialogResult.OK => {(int)DialogResult.OK}");



		}
	}
}
