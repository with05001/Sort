using System.Diagnostics;
using Sortering_Selection;
Stopwatch tid = new Stopwatch();
Random rnd = new Random();
var lista = new List<int>();
Console.WriteLine("Hur lång ska listan vara?");
int q = Convert.ToInt32(Console.ReadLine());
for(int i=0;i<q;i++)
{
    lista.Add(rnd.Next(1000000));
}
tid.Start();
Metoder.SelectionSort(new List<int>(lista));
tid.Stop();
Console.WriteLine("SelectionSort = " + tid.ElapsedMilliseconds + "ms");
tid.Reset();
tid.Start();
Metoder.BubbleSort(new List<int>(lista));
tid.Stop();
Console.WriteLine("BubbleSort = " + tid.ElapsedMilliseconds + "ms");
tid.Reset();
tid.Start();
Metoder.InsertionSort(new List<int>(lista));
tid.Stop();
Console.WriteLine("InsertionSort = " + tid.ElapsedMilliseconds + "ms");
tid.Reset();
tid.Start();
Metoder.MergeSort(new List<int>(lista),0,lista.Count-1);
tid.Stop();
Console.WriteLine("MergeSort = " + tid.ElapsedMilliseconds + "ms");
tid.Reset();
tid.Start();
Metoder.QuickSort(new List<int>(lista),0,lista.Count-1);
tid.Stop();
Console.WriteLine("QuickSort = " + tid.ElapsedMilliseconds + "ms");