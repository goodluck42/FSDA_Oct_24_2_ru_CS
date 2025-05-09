// bool - Boolean
// byte - Byte 
// sbyte - SByte
// char - Char
// short - Int16
// int - Int32
// long - Int64
// float - Single
// double - Double
// decimal - Decimal 

// string str = "Ravan";
//
// str = str.Insert(0, "Nail, "); // Nail, Ravan
//
// str = str.Remove(6, 5);
//
// str = str.Replace("Nail", "Tural_chik");
//
// str += "Ravan";
//
// Console.WriteLine(str[0]);
// Console.WriteLine(str.Length);
// Console.WriteLine(str);
//
//
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
//
// // string result = string.Format("{0} + {1} = {2}", a, b, a + b);
// string result = $"{a} + {b} = {a + b}";
//
// Console.WriteLine(result);

////////////////// Arrays

//// Create array
// int[] arr = new int[3] {10, 20, 30};
// int[] arr2 = new int[] {10, 20, 30};
// int[] arr3 = {10, 20, 30};
// int[] arr4 = [10, 20, 30];

// int[] arrN = new int[3];
// int currentIndex = 0;
//
// arrN[currentIndex++] = 9;
// arrN[currentIndex++] = 20;
// arrN[currentIndex++] = 16;
//
// Console.WriteLine(arrN.Length);
//
// for (int i = 0; i < arrN.Length; i++)
// {
// 	Console.WriteLine(arrN[i]);
// }

// int[,] mdArray = new int[2, 3]
// {
// 	{10, 20, 30},
// 	{42, 9, 16}
// };
//
// mdArray[0, 1] = 7;

// Console.WriteLine(mdArray.GetLength(0));
// Console.WriteLine(mdArray.GetLength(1));
//
// for (int i = 0; i < mdArray.GetLength(0); i++)
// {
// 	for (int j = 0; j < mdArray.GetLength(1); j++)
// 	{
// 		Console.WriteLine(mdArray[i, j]);
// 	}
// }

int[][] jagged = new int[3][];

jagged[0] = new int[3];
jagged[1] = new int[4];
jagged[2] = new int[5];

Console.WriteLine(jagged.Length);

for (int i = 0; i < jagged.Length; ++i)
{
	for (int j = 0; j < jagged[i].Length; ++j)
	{
		jagged[i][j] = Random.Shared.Next(10, 99);
	}
}

for (int i = 0; i < jagged.Length; ++i)
{
	for (int j = 0; j < jagged[i].Length; ++j)
	{
		Console.Write(jagged[i][j]);

		if (j != jagged[i].Length - 1)
		{
			Console.Write(", ");
		}
	}

	Console.WriteLine();
}

