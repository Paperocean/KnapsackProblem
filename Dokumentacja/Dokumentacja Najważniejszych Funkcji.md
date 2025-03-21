# Dokumentacja funkcji

## KnapsackProblem

### 1. CompareTo  
**Opis:** Implementacja interfejsu `IComparable<Item>`. Porównuje dwa przedmioty na podstawie ich stosunku wartości do wagi (`Ratio`).  

### 2. Item.ToString  
**Opis:** Zwraca reprezentację tekstową obiektu `Item`.  

### 3. Result.ToString  
**Opis:** Zwraca reprezentację tekstową obiektu `Result`, w tym:  
   - wybrane przedmioty,  
   - całkowitą wartość,  
   - całkowitą wagę.  

### 4. Knapsack.Solver  
**Opis:** Implementacja algorytmu plecakowego (*Knapsack Problem*) z użyciem programowania dynamicznego.  
**Zwraca:** obiekt `Result`, który zawiera:  
   - wybrane przedmioty,  
   - całkowitą wartość,  
   - całkowitą wagę.  

### 5. Knapsack.Problem  
**Opis:** Funkcja konsolowa, która:  
   - pobiera dane wejściowe od użytkownika,  
   - generuje losowe przedmioty,  
   - sortuje przedmioty,  
   - rozwiązuje problem plecakowy,  
   - wyświetla wynik.  

---

## KnapsackProblem.Tests

### 1. TestAtLeastOneItemSelected  
**Opis:** Sprawdza, czy jeśli istnieje co najmniej jeden przedmiot spełniający ograniczenia wagowe, to zwrócone rozwiązanie zawiera przynajmniej jeden wybrany przedmiot.  

### 2. TestNoItemSelected  
**Opis:** Sprawdza, czy gdy żaden przedmiot nie spełnia ograniczenia wagowego, rozwiązanie jest puste (`total value` i `total weight` równe 0).  

### 3. TestSpecificInstance  
**Opis:** Sprawdza poprawność rozwiązania dla konkretnej instancji.  
**Oczekiwany wynik:**  
   - `total value = 90`  
   - `total weight = 9`  

### 4. TestExactWeightMatch  
**Opis:** Sprawdza sytuację, gdy jeden z przedmiotów dokładnie odpowiada limitowi wagowemu.  

### 5. TestEmptyItemList  
**Opis:** Sprawdza działanie algorytmu dla pustej listy przedmiotów.  

---

## KnapsackProblem.Gui

### 1. buttonSolve_Click  
**Opis:** Obsługuje kliknięcie przycisku **"Solve"**.  

**Działanie:**  
   1. Waliduje i parsuje dane wejściowe z pól tekstowych (`textBoxSize`, `textBoxSeed`, `textBoxMaxWeight`).  
   2. Generuje listę przedmiotów o losowych wagach i wartościach.  
   3. Sortuje listę przedmiotów.  
   4. Wywołuje metodę `Knapsack.Solver` w celu rozwiązania problemu plecakowego.  
   5. Wyświetla wynik w polu tekstowym `textBoxResult`.  
