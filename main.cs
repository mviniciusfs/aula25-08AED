using System;

class MainClass {
  public static char CalculaConceito(double n1, double n2)
  {
    
    double media = (n1 + n2)/2;

    if (media >= 9 && media <= 10)
    {
      return 'A';
    }

    if (media >= 7.5 && media <= 9)
    {
      return 'B';
    }

    if (media >= 6 && media <= 7.5)
    {
      return 'C';
    }

    if (media >= 4 && media <= 6)
    {
      return 'D';
    }

    if (media >= 0 && media <= 4)
    {
      return 'E';
    }

    Console.WriteLine(CalculaConceito);    
  }
}