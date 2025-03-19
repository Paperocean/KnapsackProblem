using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    public class Knapsack
    {
        public class Item : IComparable<Item>
        {
            public int Id { get; set; }
            public int Value { get; set; }
            public int Weight { get; set; }
            public double Ratio { get; private set; }

            public Item(int id, int value, int weight)
            {
                Id = id;
                Value = value;
                Weight = weight;
                Ratio = (weight == 0) ? double.MaxValue : (double)value / weight;
            }
            public int CompareTo(Item other) => other.Ratio.CompareTo(this.Ratio);
            public override string ToString() => $"Id: {Id}, V: {Value}, W: {Weight}, R: {Ratio:F2}{System.Environment.NewLine}";
        }
        public class Result
        {
            public required List<Item> SelectedItems { get; set; }
            public int TotalValue { get; set; }
            public int TotalWeight { get; set; }

            public override string ToString()
            {
                var result = $"Selected items:{System.Environment.NewLine}";
                foreach (var item in SelectedItems)
                {
                    result += $"{item}";
                }
                result += $"Total value: {TotalValue}{System.Environment.NewLine}";
                result += $"Total weight: {TotalWeight}{System.Environment.NewLine}\n";
                return result;
            }
        }

        public static Result Solver(int maxWeight, List<Item> items)
        {
            int n = items.Count;
            int[,] dp = new int[n + 1, maxWeight + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int w = 0; w <= maxWeight; w++)
                {
                    if (i == 0 || w == 0)
                    {
                        dp[i, w] = 0;
                    }
                    else if (items[i - 1].Weight <= w)
                    {
                        dp[i, w] = Math.Max(
                            dp[i - 1, w - items[i - 1].Weight] + items[i - 1].Value,
                            dp[i - 1, w]);
                    }
                    else
                    {
                        dp[i, w] = dp[i - 1, w];
                    }
                }
            }

            List<Item> selectedItems = new();
            for (int i = n, w = maxWeight; i > 0 && w > 0; i--)
            {
                if (dp[i, w] != dp[i - 1, w])
                {
                    selectedItems.Insert(0, items[i - 1]);
                    w -= items[i - 1].Weight;
                }
            }

            return new Result
            {
                SelectedItems = selectedItems,
                TotalValue = dp[n, maxWeight],
                TotalWeight = selectedItems.Sum(item => item.Weight)
            };
        }

        public static void Problem()
        {
            Console.WriteLine("Enter number of items: ");
            if(!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                Console.WriteLine("Invalid SIZE input. Exiting.");
                return;
            }

            Console.WriteLine("Enter the seed: ");
            if (!int.TryParse(Console.ReadLine(), out int seed))
            {
                Console.WriteLine("Invalid SEED input. Exiting.");
                return;
            }

            Console.WriteLine("Max weight: ");
            if (!int.TryParse(Console.ReadLine(), out int maxWeight) || maxWeight <= 0)
            {
                Console.WriteLine("Invalid MAX WEIGHT input. Exiting.");
                return;
            }

            Random rand = new(seed);
            List<Item> items = new();
            for (int i = 0; i < size; i++)
            {
                items.Add(new Item(i + 1, rand.Next(1, 11), rand.Next(1, 11)));
            }

            items.Sort(); // For greedy algorithm

            Result result = Solver(maxWeight, items);
            Console.WriteLine(result);
        }
    }
}
