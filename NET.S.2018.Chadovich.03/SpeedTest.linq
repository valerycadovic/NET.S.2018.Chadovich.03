<Query Kind="Program" />

int[] FilterDigit(int[] array, int digit)
{
	List<int> result = new List<int>();

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i].ToString().Contains(digit.ToString()))
		{
			result.Add(array[i]);
		}
	}

	return result.ToArray();
}

int[] FilterDigitViaDivision(int digit, params int[] array)
{
	List<int> result = new List<int>();

	int item = 0;
	for (int i = 0; i < array.Length; i++)
	{
		item = array[i];

		while (item != 0)
		{
			if (digit == Math.Abs(item % 10))
			{
				result.Add(array[i]);
				break;
			}

			item /= 10;
		}
	}

	return result.ToArray();
}

void Main()
{
	Random rand = new Random();
	int[] testArray = new int[int.MaxValue >> 3];
	for (int i = 0; i < testArray.Length; i++)
	{
		testArray[i] = rand.Next(-1000, 1001);
	}

	Stopwatch timer = Stopwatch.StartNew();
	FilterDigit(testArray, 7);
	long resultString = timer.ElapsedMilliseconds;
	
	timer.Reset();

	timer.Start();
	FilterDigitViaDivision(7, testArray);
	long resultArithmetic = timer.ElapsedMilliseconds;
	
	resultArithmetic.Dump();
	resultString.Dump();
	
	
	// В итоге метод с арифметическими операциями работал в среднем 19 секунд
	// метод со строками - в среднем 156 секунд
}