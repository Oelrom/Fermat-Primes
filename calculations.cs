double num;
	for (double i = 0; i <= 8; i++)
	{
		num = (float)(Math.Pow(2, Math.Pow(2, i)) + 1);
		bool result = true;
		for (float j = 2; j <= Math.Sqrt(num) && result == true; j++)
		{
			if (num % j == 0)
				result = false;
		}
		if (result == true)
			Console.WriteLine(num);
	}
