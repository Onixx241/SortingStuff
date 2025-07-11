using System.Diagnostics;

public class Sort 
{
    public int[] arr;

    public Sort(int[] Arr) 
    {
        this.arr = Arr;
    }

    public void InsertionSort() 
    {
        Stopwatch stopp = new Stopwatch();
        stopp.Start();
        for (int i = 1; i < arr.Length; i++) 
        {
            int val = arr[i];

            int position = i;

            while (position > 0 && arr[position - 1] > val) 
            {
                arr[position] = arr[position - 1];

                position = position - 1;
            }

            arr[position] = val;

        }
        stopp.Stop();
        Console.WriteLine($"Insertion Sort Time: {stopp.Elapsed}");
    }

    public void BubbleSort() 
    {
        Stopwatch stopp = new Stopwatch();
        stopp.Start();
        for (int i = 0;i < arr.Length - 1; i++) 
        {

            for (int j = 0; j < arr.Length - 1 - i; j++) 
            {

                if (arr[j] > arr[j+1])
                {
                    var temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }

            }

        }

        stopp.Stop();
        Console.WriteLine($"Bubble Sort Time: {stopp.Elapsed}");

        arr = arr.Distinct().ToArray();
    }

    public void PrintArr() 
    {
        Console.WriteLine(String.Join(",",arr));
    }

    public static void Main() 
    {
        int ArraySize = 75000;
        int[] GenArray = new int[ArraySize];

        Random ran = new Random();

        for (int i = 0; i < ArraySize; i++) 
        {
            GenArray[i] = ran.Next(1, ArraySize);
        }

        Sort newsorter = new Sort(GenArray);
        Sort newsorter2 = new Sort(GenArray);

        newsorter.InsertionSort();
        newsorter2.BubbleSort();
        


    }
}