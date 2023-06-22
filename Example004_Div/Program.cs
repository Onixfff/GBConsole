int min = 1;
int max = 10;
Random random = new Random();
float numberFirst = random.Next(min, max);
float numberSecond = random.Next(min, max);
Console.WriteLine($"Первое число - {numberFirst}\nВторое число - {numberSecond}\nSun = {numberFirst/numberSecond}");
