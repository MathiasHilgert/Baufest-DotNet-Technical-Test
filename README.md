# 🚀 Baufest technical test for .NET developers

## 📖 Table of Contents

- [🚀 Baufest technical test for .NET developers](#-baufest-technical-test-for-net-developers)
  - [📖 Table of Contents](#-table-of-contents)
  - [⚠️ Disclaimer](#️-disclaimer)
  - [🗒️ About this solution](#️-about-this-solution)
  - [☠️ About the challenge exercises](#️-about-the-challenge-exercises)
    - [✨ The answers](#-the-answers)
    - [Exercise #1: Sorting](#exercise-1-sorting)
    - [Exercise #2: Repeated characters](#exercise-2-repeated-characters)
    - [Exercise #3: Alphabet Soup](#exercise-3-alphabet-soup)

## ⚠️ Disclaimer

**Okay, let's go... 🚀✨💥**

This technical evaluation has been done **just for fun** (Yep, as simple as that).
If you want to know more about Baufest, this is [their website](https://baufest.com/en)... They have interesting projects! 

The documentation of the exercises is in spanish, since it was the language requested for the evaluation (perhaps you should translate it into English).

## 🗒️ About this solution

In this repository, you will find my proposed solution for the Baufest entry challenge for the role of .NET Framework developer. I have seen this technical evaluation during a weekend and I have found it interesting to solve it, **just for fun** and so you can serve as a reference for other developers.

**If you find a better implementation, feel free to generate a pull-request 😉.**

## ☠️ About the challenge exercises

The technical evaluation includes three basic exercises, each one with its respective complexity and originally described in the [instructions file](consignas.md) provided by Baufest.

### ✨ The answers

The solutions proposed for these exercises can be found in the files described in each of the sections. This way you can also check its operation in the test files that Baufest has generated for this occasion.

### Exercise #1: Sorting

To carry out this exercise, the file **sorting.cs** in the **ingreso/sorting** folder must be modified.

- Implement the method **"OrdenarPorPuntuacionYNombre"**, to sort the players in a list. Sort by score descending first, then name ascending.

- Implement the **"OrdenarPorPuntuacionPerdidasYNombre"** method, similar to the first point but that takes into account the losses of a player. When two players have the same amount of points, the one with the least losses will be considered the highest. Then at equal points and losses, the name will continue to be used in an ascending way.

### Exercise #2: Repeated characters

To carry out this exercise, the file **repeatedCharacters.cs** in the folder **ingreso/strings** s must be modified.

The method must return a Boolean indicating whether the "cadena" parameter meets any of the following properties:

1- **All characters appear the same number of times.**

> Examples: "aabbcc", "abcdef", "aaaaaa"

2- **All the characters appear the same amount of times, except for 1, which appears one more time or one less time.**

> Examples: "aabbccc", "aabbc", "aaaaccccc"

### Exercise #3: Alphabet Soup

To carry out this exercise, the **wordSearcher.cs** file in the **ingreso/alphabetSoup** folder must be modified.

The objective of this exercise is to implement a function that determines if a word is in an alphabet soup, using the following rules:

- Words can be arranged horizontally or vertically, not diagonally.
- Words can be oriented in any direction, that is, from right to left or vice versa, and from top to bottom or vice versa.
- The change of direction can be in the middle of a word, so that, for example, part of the word is horizontal and from left to right, part is vertical and from top to bottom, and another part is horizontal from right to left.