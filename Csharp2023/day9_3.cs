using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2023
{
	internal class day9_3
	{
		static void Main()
		{
			//컬렉션
			//List
			ArrayList list = new ArrayList();
			for (int i = 0; i < 5; i++) {
				list.Add(i);
			}

			foreach (var item in list)
			{
                Console.Write(item);
            }
            Console.WriteLine();

			list.RemoveAt(2);
			foreach (var item in list)
			{
                Console.Write(item);
            }
            Console.WriteLine();

			list.Insert(2, 2);
			foreach (var item in list)
			{ 
				Console.Write(item);
			}
            Console.WriteLine();

			list.Add("abc");
			list.Add("도레미");
			for (int i = 0; i < list.Count; i++)
			{
				Console.Write(list[i]);
            }
            Console.WriteLine();
			Console.WriteLine("===============\n");

			//입력 받은 데이터를 이용하여 ArrayList 생성하고 출력하기
			ArrayList myList = new ArrayList { };
			Console.Write("좋아하는 음식은? ");
			myList.Add("\'초밥\', ");
			Console.WriteLine(myList[0]);
            Console.Write("최근 본 영화는? ");
			myList.Add("\'알라딘\', ");
			Console.WriteLine(myList[1]);

			Console.Write("좋아하는 가수는? ");
			myList.Add("\'BTS\', ");
			Console.WriteLine(myList[2]);

			Console.Write("좋아하는 숫자는? ");
			myList.Add($"{10}, ");
			Console.WriteLine(myList[3]);

			Console.Write("최근 여행지? ");
			myList.Add("\'부산\'");
			Console.WriteLine(myList[4]);

			Console.Write($"당신에 관한 리스트 : [");
			foreach (var mylist in  myList) 
			{
                Console.Write($"{mylist}");
            }
            Console.WriteLine("]");
			Console.WriteLine("===============\n");

			//// 퀴즈 : 슬라이드 37
			//string data;
			//ArrayList yourlist = new ArrayList();
			//string[] question_arr = {"좋아하는 음식은? ",
			//						"최근본 영화는? ",
			//						"좋아하는 가수는? ",
			//						"좋아하는 숫자는? ",
			//						"최근 여행지는? "};
			//for (int i = 0; i < 5; i++)
			//{
			//	Console.Write(question_arr[i]);
			//	data = Console.ReadLine();
			//	yourlist.Add(data);
			//}
			//Console.Write("\n 당신에 관한 리스트 : [ ");
			//for (int i = 0; i < 5; i++)
			//{
			//	if (i == 4) { Console.Write($" \'{yourlist[i]}\' "); }
			//	else { Console.Write($" \'{yourlist[i]}\', "); }
			//}

			//Console.WriteLine(" ] ");


			//ArrayList 사용하기2
			ArrayList myFood = new ArrayList { "\'사과\', ", "\'망고\', ", "\'치즈케이크\', ", "\'주스\'" };
            Console.Write($"우리집 냉장고에는? [");
			foreach (var myfood in myFood)
			{
                Console.Write($"{myfood}");
            }
            Console.WriteLine($"]");
			Console.WriteLine("동생이 사과를 먹었다.\n");

			myFood.RemoveAt(0);
			Console.Write($"우리집 냉장고에는? [");
			foreach (var myfood in myFood)
			{
				Console.Write($"{myfood}");
			}
			Console.WriteLine($"]");
			Console.WriteLine($"이모가 수박을 사오셨다.\n");

			myFood.Insert(3," \'수박\'");
			Console.Write($"우리집 냉장고에는? [");
			foreach (var myfood in myFood)
			{
				Console.Write($"{myfood}");
			}
			Console.WriteLine($"]");
			Console.WriteLine($"동생 친구가 치즈케이크, 수박을 먹었다.\n");

			myFood.RemoveAt(1); //인덱스 0 삭제, 인덱스 3에서 2가됨
			myFood.RemoveAt(2); //인덱스 2삭제
			Console.Write($"우리집 냉장고에는? [");
			foreach (var myfood in myFood)
			{
				Console.Write($"{myfood}");
			}
			Console.WriteLine($"]");
			Console.WriteLine("===============\n");

			// 큐 : FIFO 선입선출
			// Enqueue() : 데이타 추가 
			// Dequeue() : 데이타 삭제 
			Queue queue = new Queue();
			queue.Enqueue(10);
			queue.Enqueue(20);
			queue.Enqueue(30);
			//queue.Dequeue();
			//queue.Dequeue();
			//queue.Dequeue();
			//queue.Dequeue(); // 데이터가 비어서 알람

			Queue que =	new Queue();
			que.Enqueue("홍길동.");
			que.Enqueue("장나라.");
			que.Enqueue("김석진.");

			while (que.Count > 0)
			{
				Console.WriteLine(que.Dequeue());
			}
			Console.WriteLine("===============\n");

			int[] arr = { 10, 22, 55, 77, 66 };
			Queue que2 = new Queue(arr);
			while (que2.Count > 0)
			{
				Console.WriteLine(que2.Dequeue());
			}
			Console.WriteLine("===============\n");

			// 스택 : LIFO 
			// push(데이타) 데이타 삽입
			// pop() 데이타 삭제 
			Stack stack = new Stack();
			stack.Push(100);
			stack.Push(true);
			stack.Push("Maria");
			while (stack.Count > 0)
			{
				Console.WriteLine(stack.Pop());
			}
			Console.WriteLine("===============\n");

			//Stack을 이용하여 문자열을 낱개 문자로 각각 저장하고 출력하기
			Console.WriteLine("Before : 도레미파솔라시");
			string[] stacK2 = { "도 =", "레 = ", "미 =", "파 =", "솔 =", "라 =", "시 = "};
			Stack stack2 = new Stack(stacK2);
			for(int i = 0; i < stacK2.Length; i++)
			{
				Console.Write(stack2.Pop());
			}
			Console.WriteLine();
			Console.WriteLine("===============\n");
			// 퀴즈 - 슬라이드 39, 강사님이 하신거
			//Stack c_stack = new Stack();
			//string myText = "도레미파솔라시";
			//foreach (var letter in myText)
			//{
			//	c_stack.Push(letter);

			//}
			//while (c_stack.Count > 0)
			//{
			//	Console.Write(c_stack.Pop() + " = ");
			//}
			//Console.WriteLine("\n\n======================");




			// 3의 배수로 구성된 길이 15의 배열을 Queue로 만들 것
			Queue qu = new Queue();
			int num = 3;
			for(int i = 1; i < 16; i++)
			{
				if (num % 3 == 0)
				{
					qu.Enqueue((3 * i));
					Console.Write($"^{qu.Dequeue()} ");
				}
			}
            Console.WriteLine();
			Console.WriteLine("===============\n");


			Console.WriteLine("\n\n======================");
			// 퀴즈 - 슬라이드 40, 강사님이 하신거
			//int[] num_arr = new int[15];
			//int num = 3;
			//for (int i = 0; i < num_arr.Length; i++)
			//{
			//	num_arr[i] = num;
			//	num += 3;
			//}
			//foreach (var item in num_arr)
			//{
			//	Console.Write(item + " ");

			//}
			//Console.WriteLine();
			//Console.WriteLine();

			//Queue numQueue = new Queue(num_arr);
			//foreach (var item in numQueue)
			//{
			//	Console.Write($"^{item} ");
			//}
			//Console.WriteLine();

		}
	}
}
