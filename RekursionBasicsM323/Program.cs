﻿using System.Collections;

namespace RekursionBasicsM323 {
  public static class Program {
    static void EinMalEinsFor() {
      for (int i = 1; i <= 10; i++) {
        for (int y = 1; y <= 10; y++) {
          Console.Write($"{i * y} ");
        }

        Console.Write('\n');
      }
    }

    static string EinMalEinsInnerRecursive(int maxw, int mul, string outstr) {
      if (maxw == 0) return outstr;
      return EinMalEinsInnerRecursive(maxw - 1, mul, $"{maxw * mul} {outstr}");
    }

    static string EinMalEinsOuterRecursive(int maxw, int maxh) {
      if (maxh == 0) return "";
      return $"{EinMalEinsOuterRecursive(maxw, maxh - 1)}\n{EinMalEinsInnerRecursive(maxw, maxh, "")}";
    }

    static void EinMalEinsRecursive(int maxw, int maxh, int w, int h) {
      if (h == maxh + 1) return;
      if (w == maxw + 1) {
        Console.WriteLine();
        EinMalEinsRecursive(maxw, maxh, 1, h + 1);
        return;
      }

      Console.Write($"{w * h} ");
      EinMalEinsRecursive(maxw, maxh, w + 1, h);
    }


    // TODO: Calculate prime numbers from 1 to n (excluding 1)
    // For-loop solution: Time complexity: O(n * sqrt(n))
    static List<int> PrimesToNForLoopSmart(int n) {
      List<int> primes = new List<int>();
      primes.Add(2);
      for (int i = 3; i < n; i++) {
        bool isPrime = true;
        foreach (int prime in primes) {
          if (i % prime == 0) {
            isPrime = false;
            break;
          }
        }

        if (isPrime) primes.Add(i);
      }

      return primes;
    }

    static void PrintIntList(List<int> ls) {
      Console.Write("[");
      foreach (int i in ls) {
        Console.Write($"{i}, ");
      }

      Console.WriteLine("\b\b]");
    }


    // Double recursion Ackermann function
    static int Ackermann(int m, int n) {
      if (m == 0) return n + 1;
      if (n == 0) return Ackermann(m - 1, 1);
      return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static void DrawPatternFor(int h) {
      for (int i = 1; i <= h; i++) {
        for (int y = 0; y < i; y++) {
          Console.Write("*");
        }

        Console.WriteLine();
      }
    }

    static void DrawPatternSingleRecursive(int h, int i) {
      if (i == h + 1) return;
      for (int y = 0; y < i; y++) {
        Console.Write("*");
      }

      Console.WriteLine();
      DrawPatternSingleRecursive(h, i + 1);
    }

    static void DrawPatternFullRecursive(int h, int w, int maxh) {
      if (h == maxh + 1) return;
      if (w == h + 1) {
        Console.WriteLine();
        DrawPatternFullRecursive(h + 1, 1, maxh);
        return;
      }

      Console.Write("*");
      DrawPatternFullRecursive(h, w + 1, maxh);
    }

    // TODO: Calculate prime numbers upto N (inclusive) using a double For loop
    static void CalculatePrimesToNFor(int n) {
      for (int i = n; i >= 2; i--) {
        bool isPrime = true;
        for (int y = i - 1; y >= 2; y--) {
          if (i % y == 0) {
            isPrime = false;
            break;
          }
        }

        if (isPrime) Console.Write($"{i} ");
      }
    }

    // TODO: Calculate prime numbers upto N (inclusive) using a double recursion
    static void CalculatePrimesToNRecursive(int n, int y, bool isPrime) {
      if (n == 1) return;
      if (y == 1 || !isPrime) {
        if (isPrime) Console.Write($"{n} ");
        CalculatePrimesToNRecursive(n - 1, n - 2, true);
        return;
      }

      if (n % y == 0) {
        isPrime = false;
        y = 2;
      }

      CalculatePrimesToNRecursive(n, y - 1, isPrime);
    }

    // Pascal triangle double for loop
    static List<List<int>> PascalFor(int h) {
      List<List<int>> pascal = new List<List<int>>();
      for (int i = 0; i < h; i++) {
        List<int> row = new List<int>();
        for (int y = 0; y <= i; y++) {
          if (y == 0 || y == i) row.Add(1);
          else row.Add(pascal[i - 1][y - 1] + pascal[i - 1][y]);
        }

        pascal.Add(row);
      }

      return pascal;
    }

    // Pascal triangle double recursion
    static List<List<int>> PascalRecursive(int h, int i, int y, List<List<int>> pascal) {
      if (i == h) return pascal;
      if (y == i + 1) {
        List<int> row = new List<int>();
        for (int x = 0; x <= i; x++) {
          if (x == 0 || x == i) row.Add(1);
          else row.Add(pascal[i - 1][x - 1] + pascal[i - 1][x]);
        }

        pascal.Add(row);
        return PascalRecursive(h, i + 1, 0, pascal);
      }

      return PascalRecursive(h, i, y + 1, pascal);
    }

    static void Print2dIntList(List<List<int>> ls) {
      Console.Write("[");
      foreach (List<int> i in ls) {
        Console.Write("[");
        foreach (int y in i) {
          Console.Write($"{y}, ");
        }

        Console.WriteLine("\b\b], ");
      }

      Console.WriteLine("\b\b]");
    }

    static void SimpleDoubleForLoop(int n, int m) {
      for (int i = 0; i < n; i++) {
        for (int y = 0; y < m; y++) {
          Console.WriteLine($"{i} - {y}");
        }
      }
    }

    static void SimpleDoubleRecursion(int n, int m, int nmax, int mmax) {
      if (n == nmax) return;
      if (m == mmax) {
        SimpleDoubleRecursion(n + 1, 0, nmax, mmax);
        return;
      }

      Console.WriteLine($"{n} + {m}");
      SimpleDoubleRecursion(n, m + 1, nmax, mmax);
    }


    static void Main(String[] args) {
      // Console.WriteLine(Ackermann(3, 4));
      // EinMalEinsRecursive(10, 10, 1, 1);
      // DrawPatternFor(10);
      // DrawPatternFullRecursive(1, 1, 10);
      // int n = 150;
      // CalculatePrimesToNFor(n);
      // Console.WriteLine();
      // CalculatePrimesToNRecursive(n, n - 1, true);
      // Print2dIntList(PascalFor(10));
      // Print2dIntList(PascalRecursive(25, 0, 0, new List<List<int>>()));

      // SimpleDoubleForLoop(5, 5);
      SimpleDoubleRecursion(0, 0, 5, 5);
    }
  }
}