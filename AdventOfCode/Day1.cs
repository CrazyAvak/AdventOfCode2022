namespace AdventOfCode
{
    public class Day1
    {

        /// <summary>
        /// stupid first version 
        /// </summary>

        /*
        int topCalories = 0;
        int currentCalories = 0;
        int index = 0;
        public void Part1()
        {
            foreach (string line in File.ReadLines("C:/Users/larsb/Documents/GitHub/AdventOfCode2022/AdventOfCode/input/calories.txt"))
            {
                index++;
                if (line != "")
                {
                    currentCalories = currentCalories + int.Parse(line);
                }

                if (line == "" && currentCalories > topCalories)
                {
                    Console.WriteLine("nieuwe top calorie : " + currentCalories);
                    topCalories = currentCalories;
                    currentCalories = 0;
                }
                else if (line == "" && topCalories == 0)
                {
                    topCalories = currentCalories;
                    currentCalories = 0;
                }
                else if (line == "")
                {
                    currentCalories = 0;
                }
            }
            Console.WriteLine(currentCalories);
            Console.WriteLine("top calorie:" + topCalories);
        }

        */



        List<int> caloriesSum = new List<int>();


        public void fillList()
        {
            int calorieSum = 0;
            foreach (string line in File.ReadLines("C:/Users/larsb/Documents/GitHub/AdventOfCode2022/AdventOfCode/input/calories.txt"))
            {
                if (line == "")
                {
                    caloriesSum.Add(calorieSum);
                    calorieSum = 0;
                }
                else
                {
                    calorieSum = calorieSum + int.Parse(line);
                }
            }
        }

        public void partOne()
        {
            fillList();
            var caloriesDesc = caloriesSum.OrderByDescending(calorieSum => calorieSum);
            Console.WriteLine(caloriesDesc.Take(1).Sum());
        }
        public void partTwo()
        {

            var caloriesDesc3 = caloriesSum.OrderByDescending(calorieSum => calorieSum);
            Console.WriteLine(caloriesDesc3.Take(3).Sum());
        }

    }
}
