// tack 1
// int EvenCount(int n)
// {
//     if (n == 0)
//     {
//         return 0;
//     }
//     int b = n % 10;
//     if (b % 2 == 0)
//     {
//         return 1 + EvenCount(n / 10);
//     }
//     return EvenCount(n / 10);
// }
// System.Console.WriteLine(EvenCount(126587));





// tack 2
// int OddCount(int n)
// {
//     if (n == 0)
//     {
//         return 0;
//     }
//     int b = n % 10;
//     if (b % 2 != 0)
//     {
//         return 1 + OddCount(n / 10);
//     }
//     return OddCount(n / 10);
// }
// System.Console.WriteLine(OddCount(1357));




// tack 3
// int ZeroCount(int n)
// {
//     if (n == 0)
//     {
//         return 1;
//     }
//     if (n < 10)
//     {
//         return 0;
//     }
//     if (n % 10 == 0)
//     {
//         return 1 + ZeroCount(n / 10);
//     }
//     return ZeroCount(n / 10);
// }
// System.Console.WriteLine(ZeroCount(12043));




// tack 4
// int DigitCount(int n)
// {
//     if (n >= 0 && n < 10)
//     {
//         return 1;
//     }
//     return 1 + DigitCount(n / 10);
// }
// System.Console.WriteLine(DigitCount(12043));


// tack 5
// int MinDigit(int n)
// {
//     int min = int.MaxValue;
//     for (int i = n; i > 0; i /= 10)
//     {
//         if ((i % 10) < min) min = i % 10;
//     }
//     return min;
// }
// System.Console.WriteLine(MinDigit(12043));


// tack 6
// int MaxDigit(int n)
// {
//     int max = int.MinValue;
//     for (int i = n; i > 0; i /= 10)
//     {
//         if ((i % 10 > max)) max = i % 10;
//     }
//     return max;
// }
// System.Console.WriteLine(MaxDigit(12043));



// tack 7
// int SumDigit(int n)
// {
//     int sum = 0;
//     for (int i = n; i > 0; i /= 10)
//     {
//         sum += i % 10;
//     }
//     return sum;
// }
// System.Console.WriteLine(SumDigit(12043));



// tack 8
// char CheckGrade(int grade)
// {
//     if (grade >= 90)
//     {
//         return 'A';
//     }
//      if (grade >= 80)
//     {
//         return 'B';
//     }
//      if (grade >= 70)
//     {
//         return 'C';
//     }
//      if (grade >= 60)
//     {
//         return 'D';
//     }
//     return 'F';
// }
// System.Console.WriteLine(CheckGrade(59));


// int Checked(int a)
// {
//     int b = 0;
//     for (int i = a; i > 0; i/=10)
//     {
//         if()
//     }
// }


// double Sqrt(int a)
// {
//     double p = 0;
//     for (double i = 0; i * i <= a; i += 0.01)
//     {
//         p = i;
//     }
//     return p;
// }
// System.Console.WriteLine(Sqrt(2));