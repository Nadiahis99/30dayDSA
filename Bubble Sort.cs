/* خوارزمية Bubble Sort

بتشتغل بطريقه بسيطه جدا بتعدي عل كل الاري و بتفارن كل رقمين جمب بعض ببعض لحد ما الاري تترتب



المتطلبات ايه عشان تتنفذ ؟

بيها الرقمين دول فينكشن اكيد هتاخد الاري و محتاجين حاجه  عشان نعرف ان الاري تمام هي سورتنيج
*/




using System;

class BubbleSortExample
{
    static void Main()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Original Array: " + string.Join(", ", arr));

        BubbleSort(arr);

        Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // لو مفيش أي تبديلات، يبقى المصفوفة مترتبة بالفعل ونخرج
            if (!swapped)
                break;
        }
    }
}
