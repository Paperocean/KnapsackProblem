using NUnit.Framework;
using KnapsackProblem;
using System.Collections.Generic;

namespace KnapsackProblem.Tests
{
    [TestFixture]
    public class KnapsackTests
    {
        // Test 1: Sprawdzenie, czy przy istnieniu co najmniej jednego przedmiotu spe�niaj�cego ograniczenia,
        // zwr�cone rozwi�zanie zawiera przynajmniej jeden wybrany przedmiot.
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

        // Test 2: Sprawdzenie, czy gdy �aden przedmiot nie spe�nia ograniczenia wagowego,
        // rozwi�zanie jest puste (total value i total weight r�wne 0).
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
            Assert.IsTrue(result.TotalValue == 0, "Przy braku przedmiot�w spe�niaj�cych ograniczenia, warto�� powinna wynosi� 0.");
            Assert.IsTrue(result.TotalWeight == 0, "Przy braku przedmiot�w spe�niaj�cych ograniczenia, waga powinna wynosi� 0.");
        }

        // Test 3: Sprawdzenie poprawno�ci rozwi�zania dla konkretnej instancji.
        // Dla danego zestawu przedmiot�w oczekujemy, �e optymalne rozwi�zanie ma total value 90 i total weight 9.
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

            Assert.IsTrue(result.TotalValue == 90, "Oczekiwano, �e ca�kowita warto�� wyniesie 90.");
            Assert.IsTrue(result.TotalWeight == 9, "Oczekiwano, �e ca�kowita waga wyniesie 9.");
        }

        // Dodatkowy Test 1: Test sprawdzaj�cy sytuacj�, gdy jeden z przedmiot�w dok�adnie odpowiada limitowi wagowemu.
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

            Assert.IsTrue(result.TotalValue == 100, "Oczekiwano warto�ci 25 przy dok�adnym dopasowaniu wagi.");
            Assert.IsTrue(result.TotalWeight == 10, "Oczekiwano wagi r�wnej limitowi (10).");
        }

        // Dodatkowy Test 2: Test dla pustej listy przedmiot�w.
        [Test]
        public void TestEmptyItemList()
        {
            var items = new List<Knapsack.Item>(){};
            int maxWeight = 10;
            var knapsack = new Knapsack();

            var result = Knapsack.Solver(maxWeight, items);

            Assert.IsTrue(result.TotalValue == 0, "Dla pustej listy przedmiot�w warto�� powinna wynosi� 0.");
            Assert.IsTrue(result.TotalWeight == 0, "Dla pustej listy przedmiot�w waga powinna wynosi� 0.");
        }
    }
}
