namespace AdventOfCode
{
    public class Day2
    {
        //opponent a = rock
        //opponent b = paper
        //opponent c = scissor

        //you Y = paper
        //you X = Rock
        //you Z = Scissor

        public void partOne()
        {
            foreach (string line in File.ReadLines("C:/Users/larsb/Documents/GitHub/AdventOfCode2022/AdventOfCode/input/rockpaperscissortable.txt"))
            {
                var move = line.Split(new[] { ' ' }, 2);
            }
        }

        public List<string> fillList()
        {
            List<string> list = new List<string>();
            foreach (string line in File.ReadLines("C:/Users/larsb/Documents/GitHub/AdventOfCode2022/AdventOfCode/input/rockpaperscissortable.txt"))
            {
                list.Add(line);
            }
            return list;
        }
    }
}
