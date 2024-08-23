namespace weatherStationSim
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate: ");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine($"*** Simulating {days} days of weather ***");
            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 41);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
                Console.WriteLine(temperature[i] + " " + weatherConditions[i]);
            }

            temperature.Max();

            Console.WriteLine($"Average Temperature was {CalculateAverage(temperature)} degrees.");
            Console.WriteLine($"The max temp was {temperature.Max()} degrees.");
            Console.WriteLine($"The max temp was {MinTemperature(temperature)} degrees.");
            Console.WriteLine($"The most common condition was {MostCommonCondition(weatherConditions)}.");
            Console.ReadKey();
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i]) {
                        tempCount++;
                    }
                }
                if (tempCount > 0)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }
            return mostCommon;
        }
        static int CalculateAverage(int[] temperature)
        {
            int sum = 0;

            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }

            int average = sum / temperature.Length;

            return average;
        }

        static int MinTemperature(int[] temperature)
        {
            int min = temperature[0];

            foreach(int temp in temperature)
            {
                if (temp < min)
                {
                    min = temp;
                }
            }
            return min;
        }
    }
}
