using System.Collections;

namespace RekursionBasicsM323 {
  class Program {
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

    // TODO: Calculate prime numbers from 1 to n (excluding 1)
    // For-loop solution: Time complexity: O(n * sqrt(n))
    static List<int> PrimesToNForLoop(int n) {
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


    static void Main(String[] args) {
      // EinMalEinsFor();
      // Console.WriteLine(EinMalEinsOuterRecursive(15, 15));
      PrintIntList(PrimesToNForLoop(100));
      Console.WriteLine(PrimesToNForLoop(100).Count);
    }
  }
}