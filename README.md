# 🐝 C# Exam Exercises 🚀

This repository provides C# solutions for a set of programming exercises designed to evaluate your understanding of fundamental C# concepts, including **class design**, **data structures**, and **algorithm implementation**.

---

## 🎯 Exercise Breakdown

This repository contains solutions for the following exercises:

1.  **[Wild Survival](#wild-survival)**: Simulate a battle between bees and bee-eaters based on their group sizes.
2.  **[Collecting Stars Game](#collecting-stars-game)**: Implement a console game where a player collects stars on a field while avoiding obstacles, following a sequence of moves.
3.  **[Cocktail Bar](#cocktail-bar)**: Develop a system to manage a cocktail menu, including adding, removing, and retrieving cocktail information.

---

## ⚔️ <a name="wild-survival"></a> 1. Wild Survival

> This exercise involves simulating a conflict between groups of bees and bee-eaters. You will process sequences of their sizes to determine the outcome of their battles.

### ⚙️ Input Details:

* **Bee Groups:** A sequence of integers, where each integer represents the size of a bee group.
* **Bee-eater Groups:** A sequence of integers, where each integer represents the size of a bee-eater group.

### 📤 Expected Output:

* The final result of the simulation, indicating the remaining bee groups, bee-eater groups, or a message if neither survives.

### 💡 Core Concepts:

* **Data Structures:** `Queue<T>`, `Stack<T>`, `List<T>`
* **Logic:** Implementing game rules, processing sequential data

---

## ✨ <a name="collecting-stars-game"></a> 2. Collecting Stars Game

> In this console-based game, the player navigates a square field to collect a specific number of stars while avoiding obstacles, based on a given set of movement commands.

### ⚙️ Input Details:

* **Field Size (N):** An integer defining the dimensions of the $N \times N$ game field.
* **Field Layout:** $N$ lines of characters (separated by spaces), representing the game board. Symbols include:
    * `P`: Player's starting position
    * `*`: Star to collect (target: 10 stars)
    * `#`: Obstacle to avoid
* **Movement Commands:** A sequence of strings (e.g., "up", "down", "left", "right") indicating the player's moves.

### 📤 Expected Output:

* **Game Outcome:** A message indicating whether the player won (collected 10 stars) or lost (encountered an obstacle).
* **Final Position:** The player's coordinates after all movements, in the format `[row, column]`.
* **Final Field State:** The game board after the movements, with the player's path potentially marked (e.g., with '.').

### 💡 Core Concepts:

* **Data Structures:** 2D arrays (`char[,]`)
* **Logic:** Implementing a game loop, handling player input, updating game state, collision detection

---

## 🍹 <a name="cocktail-bar"></a> 3. Cocktail Bar

> This exercise focuses on creating a system to manage a cocktail bar menu. You will define classes to represent cocktails and the menu itself, allowing for operations like adding, removing, and retrieving cocktail information.

### ⚙️ Class Definitions:

* **`Cocktail` Class:**
    ```csharp
    public class Cocktail
    {
        public string Name { get; }
        public decimal Price { get; }
        public double Volume { get; }
        public List<string> Ingredients { get; }

        public Cocktail(string name, decimal price, double volume, List<string> ingredients) { /* ... */ }

        public override string ToString() { /* ... */ }
    }
    ```
    * **Properties:** `Name` (string), `Price` (decimal), `Volume` (double), `Ingredients` (`List<string>`).
    * **Constructor:** Initializes a new `Cocktail` object.
    * **`ToString()` Method:** Returns a formatted string representation of the cocktail.

* **`Menu` Class:**
    ```csharp
    public class Menu
    {
        public List<Cocktail> Cocktails { get; }
        // ... other methods and properties
    }
    ```
    * **Property:** `Cocktails` (`List<Cocktail>`) - stores the list of `Cocktail` objects.
    * **Methods (based on problem description):**
        * `AddCocktail(Cocktail cocktail)`: Adds a `Cocktail` to the menu.
        * `RemoveCocktail(string name)`: Removes a `Cocktail` from the menu by its name.
        * `GetMostDiverse()`: Returns the `Cocktail` with the most ingredients.
        * `Details(string name)`: Returns the details of a specific `Cocktail`.
        * `GetAll()`: Returns a string listing all cocktails in the menu.

### 💡 Core Concepts:

* **Object-Oriented Programming (OOP):** Classes, Objects, Properties, Methods
* **Data Structures:** `List<T>`
* **Class Design**
* **Method Implementation**

---

## 📦 Submission Instructions

* For each exercise, please compress your complete project folder into a `.zip` file.
* **Important:** Ensure that you **exclude** the `bin` and `obj` folders from your zipped submission.

**Note:** Please adhere to the specific naming conventions and project structure outlined in the original problem descriptions for each exercise.
