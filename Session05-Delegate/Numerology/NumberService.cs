using System;
namespace Numerology
{
	public class NumberService
	{
		static List<int> _arr = new List<int> { -5, -10, -1, 5, 10, 15, 20, 1, 3, 5, 7, 99, 101 };

		public static void PrintNumbers(Action<int> f)
		{
			foreach (var i in _arr)
			{
				f(i); //tao lần lượt gửi data cho mày, cho hàm f() hàm f() làm gì với data kệ
				//nếu f() check i > 0 mới in, PrintNumbers() chính là hàm in ra các số > 0
			}
		}
		//style cũ: thiết kế đủ các loại hàm cung cấp data! Đủ cỡ nào cũng k là dủ, do nhu cầu tính toán khác nhay trên bộ data:
		//có người tính chẵn, lẻ, âm, dương, nguyên tố, chia hết 5, chia 10..
	}
}

