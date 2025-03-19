using NUnit.Framework;
using KnapsackProblem;
using System.Collections.Generic;

namespace KnapsackProblem.Tests
{
    [TestFixture]
    public class KnapsackTests
    {
        // Test 1: Sprawdzenie, czy przy istnieniu co najmniej jednego przedmiotu spe³niaj¹cego ograniczenia,
        // zwrócone rozwi¹zanie zawiera przynajmniej jeden wybrany przedmiot.
        [Test]
        public void TestAtLeastOneItemSelected()
        {
            var items = new List<Knapsack.Item>()
            {
                new Knapsack.Item(1, 10, 5),
                new Knapsack.Item(2, 11, 6),
                new Knapsack.Item(3, 5, 3)
            };

            int maxWeight = 10;
            var knapsack = new Knapsack();

            var result = Knapsack.Solver(maxWeight, items);

            Assert.IsTrue(result.SelectedItems.Count > 0, "Oczekiwano wybrania przynajmniej jednego przedmiotu.");
        }

        // Test 2: Sprawdzenie, czy gdy ¿aden przedmiot nie spe³nia ograniczenia wagowego,
        // rozwi¹zanie jest puste (total value i total weight równe 0).
        [Test]
        public void TestNoItemSelected()
        {
            var items = new List<Knapsack.Item>();
            new Knapsack.Item(1, 10, 15);
            new Knapsack.Item(2, 6, 20);
            new Knapsack.Item(3, 20, 25);

            int maxWeight = 10;
            var knapsack = new Knapsack();

            var result = Knapsack.Solver(maxWeight, items);

            // Assert
            Assert.IsTrue(result.TotalValue == 0, "Przy braku przedmiotów spe³niaj¹cych ograniczenia, wartoœæ powinna wynosiæ 0.");
            Assert.IsTrue(result.TotalWeight == 0, "Przy braku przedmiotów spe³niaj¹cych ograniczenia, waga powinna wynosiæ 0.");
        }

        // Test 3: Sprawdzenie poprawnoœci rozwi¹zania dla konkretnej instancji.
        // Dla danego zestawu przedmiotów oczekujemy, ¿e optymalne rozwi¹zanie ma total value 90 i total weight 9.
        [Test]
        public void TestSpecificInstance()
        {
            var items = new List<Knapsack.Item>()
            {
                new Knapsack.Item(1, 35, 3),
                new Knapsack.Item(2, 40, 4),
                new Knapsack.Item(3, 10, 10),
                new Knapsack.Item(4, 15, 2)
            };

            int maxWeight = 10;
            var knapsack = new Knapsack();

            var result = Knapsack.Solver(maxWeight, items);

            Assert.IsTrue(result.TotalValue == 90, "Oczekiwano, ¿e ca³kowita wartoœæ wyniesie 90.");
            Assert.IsTrue(result.TotalWeight == 9, "Oczekiwano, ¿e ca³kowita waga wyniesie 9.");
        }

        // Dodatkowy Test 1: Test sprawdzaj¹cy sytuacjê, gdy jeden z przedmiotów dok³adnie odpowiada limitowi wagowemu.
        [Test]
        public void TestExactWeightMatch()
        {
            var items = new List<Knapsack.Item>()
            {
                new Knapsack.Item(1, 35, 3),
                new Knapsack.Item(2, 40, 4),
                new Knapsack.Item(3, 100, 10),
                new Knapsack.Item(4, 15, 2)
            };

            int maxWeight = 10;
            var knapsack = new Knapsack();

            var result = Knapsack.Solver(maxWeight, items);

            Assert.IsTrue(result.TotalValue == 100, "Oczekiwano wartoœci 25 przy dok³adnym dopasowaniu wagi.");
            Assert.IsTrue(result.TotalWeight == 10, "Oczekiwano wagi równej limitowi (10).");
        }

        // Dodatkowy Test 2: Test dla pustej listy przedmiotów.
        [Test]
        public void TestEmptyItemList()
        {
            var items = new List<Knapsack.Item>(){};
            int maxWeight = 10;
            var knapsack = new Knapsack();

            var result = Knapsack.Solver(maxWeight, items);

            Assert.IsTrue(result.TotalValue == 0, "Dla pustej listy przedmiotów wartoœæ powinna wynosiæ 0.");
            Assert.IsTrue(result.TotalWeight == 0, "Dla pustej listy przedmiotów waga powinna wynosiæ 0.");
        }
    }
}
