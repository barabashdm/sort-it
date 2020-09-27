using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace sort_it
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                if (args[0] == "-i in1.txt in2.txt")
                {
                    int[] A = File.ReadAllText(Environment.CurrentDirectory + "\\in1.txt", Encoding.Default).Split('\n').Select(x => int.Parse(x)).ToArray();
                    int[] B = File.ReadAllText(Environment.CurrentDirectory + "\\in2.txt", Encoding.Default).Split('\n').Select(x => int.Parse(x)).ToArray();
                    int[] C = new int[0];
                    Console.WriteLine("in1.txt");
                    for (int i = 0; i < A.Length; i++)
                    {
                        Console.WriteLine(A[i]);
                    }
                    Console.WriteLine("in2.txt");
                    for (int i = 0; i < B.Length; i++)
                    {
                        Console.WriteLine(B[i]);
                    }
                    mergeInt(A, B, C);
                }
                if (args[0] == "-i in2.txt in3.txt")
                {
                    int[] A = new int[0];
                    int[] B = File.ReadAllText(Environment.CurrentDirectory + "\\in3.txt", Encoding.Default).Split('\n').Select(x => int.Parse(x)).ToArray();
                    int[] C = File.ReadAllText(Environment.CurrentDirectory + "\\in3.txt", Encoding.Default).Split('\n').Select(x => int.Parse(x)).ToArray();
                    Console.WriteLine("in2.txt");
                    for (int i = 0; i < B.Length; i++)
                    {
                        Console.WriteLine(B[i]);
                    }
                    Console.WriteLine("in3.txt");
                    for (int i = 0; i < C.Length; i++)
                    {
                        Console.WriteLine(C[i]);
                    }
                    mergeInt(A, B, C);
                }
                if (args[0] == "-i in1.txt in3.txt")
                {
                    int[] A = File.ReadAllText(Environment.CurrentDirectory + "\\in1.txt", Encoding.Default).Split('\n').Select(x => int.Parse(x)).ToArray();
                    int[] B = new int[0];
                    int[] C = File.ReadAllText(Environment.CurrentDirectory + "\\in3.txt", Encoding.Default).Split('\n').Select(x => int.Parse(x)).ToArray();
                    Console.WriteLine("in1.txt");
                    for (int i = 0; i < A.Length; i++)
                    {
                        Console.WriteLine(A[i]);
                    }
                    Console.WriteLine("in3.txt");
                    for (int i = 0; i < C.Length; i++)
                    {
                        Console.WriteLine(C[i]);
                    }
                    mergeInt(A, B, C);
                }
                if (args[0] == "-i in1.txt in2.txt in3.txt")
                {
                    int[] A = File.ReadAllText(Environment.CurrentDirectory + "\\in1.txt", Encoding.Default).Split('\n').Select(x => int.Parse(x)).ToArray();
                    int[] B = File.ReadAllText(Environment.CurrentDirectory + "\\in2.txt", Encoding.Default).Split('\n').Select(x => int.Parse(x)).ToArray();
                    int[] C = File.ReadAllText(Environment.CurrentDirectory + "\\in3.txt", Encoding.Default).Split('\n').Select(x => int.Parse(x)).ToArray();
                    Console.WriteLine("in1.txt");
                    for (int i = 0; i < A.Length; i++)
                    {
                        Console.WriteLine(A[i]);
                    }
                    Console.WriteLine("in2.txt");
                    for (int i = 0; i < B.Length; i++)
                    {
                        Console.WriteLine(B[i]);
                    }
                    Console.WriteLine("in3.txt");
                    for (int i = 0; i < C.Length; i++)
                    {
                        Console.WriteLine(C[i]);
                    }
                    mergeInt(A, B, C);
                }
                if (args[0] == "-s in1.txt in2.txt in3.txt")
                {
                    string[] A = File.ReadAllLines(Environment.CurrentDirectory + "\\in1.txt");
                    string[] B = File.ReadAllLines(Environment.CurrentDirectory + "\\in2.txt");
                    string[] C = File.ReadAllLines(Environment.CurrentDirectory + "\\in3.txt");
                    Console.WriteLine("in1.txt");
                    for (int i = 0; i < A.Length; i++)
                    {
                        Console.WriteLine(A[i]);
                    }
                    Console.WriteLine("in2.txt");
                    for (int i = 0; i < B.Length; i++)
                    {
                        Console.WriteLine(B[i]);
                    }
                    Console.WriteLine("in3.txt");
                    for (int i = 0; i < C.Length; i++)
                    {
                        Console.WriteLine(C[i]);
                    }
                    mergeString(A, B, C);
                }
                if (args[0] == "-s in1.txt in2.txt")
                {
                    string[] A = File.ReadAllLines(Environment.CurrentDirectory + "\\in1.txt");
                    string[] B = File.ReadAllLines(Environment.CurrentDirectory + "\\in2.txt");
                    string[] C = new string[0];
                    Console.WriteLine("in1.txt");
                    for (int i = 0; i < A.Length; i++)
                    {
                        Console.WriteLine(A[i]);
                    }
                    Console.WriteLine("in2.txt");
                    for (int i = 0; i < B.Length; i++)
                    {
                        Console.WriteLine(B[i]);
                    }
                    mergeString(A, B, C);
                }
                if (args[0] == "-s in1.txt in3.txt")
                {
                    string[] A = File.ReadAllLines(Environment.CurrentDirectory + "\\in1.txt");
                    string[] B = new string[0];
                    string[] C = File.ReadAllLines(Environment.CurrentDirectory + "\\in3.txt");
                    Console.WriteLine("in1.txt");
                    for (int i = 0; i < A.Length; i++)
                    {
                        Console.WriteLine(A[i]);
                    }
                    Console.WriteLine("in3.txt");
                    for (int i = 0; i < C.Length; i++)
                    {
                        Console.WriteLine(C[i]);
                    }
                    mergeString(A, B, C);
                }
                if (args[0] == "-s in2.txt in3.txt")
                {
                    string[] A = new string[0];
                    string[] B = File.ReadAllLines(Environment.CurrentDirectory + "\\in2.txt");
                    string[] C = File.ReadAllLines(Environment.CurrentDirectory + "\\in3.txt");
                    Console.WriteLine("in2.txt");
                    for (int i = 0; i < B.Length; i++)
                    {
                        Console.WriteLine(B[i]);
                    }
                    Console.WriteLine("in3.txt");
                    for (int i = 0; i < C.Length; i++)
                    {
                        Console.WriteLine(C[i]);
                    }
                    mergeString(A, B, C);
                }
            }
            Console.ReadKey(true);
        }
        static void mergeInt(int[] A, int[] B, int[] C)
        {
            List<int> list = new List<int>();
            int i = 0, j = 0, k = 0;
            while (i < A.Length && j < B.Length && k < C.Length)
            {
                int a = A[i];
                int b = B[j];
                int c = C[k];
                if (a <= b && a <= c)
                {
                    list.Add(a);
                    i++;
                }
                else if (b <= a && b <= c)
                {
                    list.Add(b);
                    j++;
                }
                else
                {
                    list.Add(c);
                    k++;
                }
            }
            while (i < A.Length && j < B.Length)
            {
                if (A[i] < B[j])
                {
                    list.Add(A[i]);
                    i++;
                }
                else
                {
                    list.Add(B[j]);
                    j++;
                }
            }
            while (j < B.Length && k < C.Length)
            {
                if (B[j] < C[k])
                {
                    list.Add(B[j]);
                    j++;
                }
                else
                {
                    list.Add(C[k]);
                    k++;
                }
            }
            while (i < A.Length && k < C.Length)
            {
                if (A[i] < C[k])
                {
                    list.Add(A[i]);
                    i++;
                }
                else
                {
                    list.Add(C[k]);
                    k++;
                }
            }
            while (i < A.Length)
            {
                list.Add(A[i]);
                i++;
            }
            while (j < B.Length)
            {
                list.Add(B[j]);
                j++;
            }
            while (k < C.Length)
            {
                list.Add(C[k]);
                k++;
            }
            Console.WriteLine("out.txt");
            List<string> result = new List<string>();
            foreach (int x in list)
            {
                Console.WriteLine(x);
                result.Add(Convert.ToString(x));
            }
            File.WriteAllLines(Environment.CurrentDirectory + "\\out.txt", result);
            Console.ReadLine();
        }
        static void mergeString(string[] A, string[] B, string[] C)
        {
            List<string> list = new List<string>();
            int i = 0, j = 0, k = 0;
            while (i < A.Length && j < B.Length && k < C.Length)
            {
                byte[] a = Encoding.ASCII.GetBytes(A[i]);
                byte[] b = Encoding.ASCII.GetBytes(B[j]);
                byte[] c = Encoding.ASCII.GetBytes(C[k]);
                if (a[0] <= b[0] && a[0] <= c[0])
                {
                    list.Add(A[i]);
                    i++;
                }
                else if (b[0] <= a[0] && b[0] <= c[0])
                {
                    list.Add(B[j]);
                    j++;
                }
                else
                {
                    list.Add(C[k]);
                    k++;
                }
            }
            while (i < A.Length && j < B.Length)
            {
                if (Encoding.ASCII.GetBytes(A[i])[0] < Encoding.ASCII.GetBytes(B[j])[0])
                {
                    list.Add(A[i]);
                    i++;
                }
                else
                {
                    list.Add(B[j]);
                    j++;
                }
            }
            while (j < B.Length && k < C.Length)
            {
                if (Encoding.ASCII.GetBytes(B[j])[0] < Encoding.ASCII.GetBytes(C[k])[0])
                {
                    list.Add(B[j]);
                    j++;
                }
                else
                {
                    list.Add(C[k]);
                    k++;
                }
            }
            while (i < A.Length && k < C.Length)
            {
                if (Encoding.ASCII.GetBytes(A[i])[0] < Encoding.ASCII.GetBytes(C[k])[0])
                {
                    list.Add(A[i]);
                    i++;
                }
                else
                {
                    list.Add(C[k]);
                    k++;
                }
            }
            while (i < A.Length)
            {
                list.Add(A[i]);
                i++;
            }
            while (j < B.Length)
            {
                list.Add(B[j]);
                j++;
            }
            while (k < C.Length)
            {
                list.Add(C[k]);
                k++;
            }
            Console.WriteLine("out.txt");
            foreach (string x in list)
            {
                Console.WriteLine(x);
            }
            File.WriteAllLines(Environment.CurrentDirectory + "\\out.txt", list);
            Console.ReadLine();
        }
    }
}
