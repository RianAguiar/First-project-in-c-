using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			  int[,] matriz = new int [8,8]{
		    {1,2,3,4,5,6,7,8},
		    {0,0,0,0,0,0,0,0},
		    {0,0,0,0,0,0,0,0},
		    {0,0,0,0,0,0,0,0},
		    {0,0,0,0,0,0,0,0},
		    {0,0,0,0,0,0,0,0},
		    {0,0,0,0,0,0,0,0},
		    {0,0,0,0,0,0,0,0}
		  };
      string mensagem = $"A celula da matriz escolhida é : 😀👉 {matriz[0, 1]} 👈😀";
        Console.WriteLine (mensagem);
		}
	}
}