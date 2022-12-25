using System;
namespace AdventOfCode.ChallengeOne
{
    public class ChallengeOne
    {
        public static void FindMostCalories(string calories)
        {
            /* Separate the string into an iterable list and count the number
               of reindeer */
            var separatedCalories = calories.Split('\n');
            var reindeer = separatedCalories.Count(x => x == string.Empty) + 1;

            /* Initialise list of reindeer & their calories, starting at
               the first reindeer */
            var reindeerCalories = new int[reindeer];
            var count = 0;

            // Iterate through list and total calories for each reindeer
            foreach (var calorie in separatedCalories)
            {
                if (calorie == string.Empty)
                    count++;
                else
                    reindeerCalories[count] += int.Parse(calorie);
            }

            Console.WriteLine($"Reindeer " +
                $"{Array.IndexOf(reindeerCalories, reindeerCalories.Max()) + 1} " +
                $"had the most calories: {reindeerCalories.Max()}");
        }
    }
}

