// day 5 -- Sorting & Searching------->  Quick Sort

/* --- الشرح---

هي خوارزمية ترتيب تعتمد على فكرة "التقسيم والفَرِز" (Divide and Conquer).
الفكرة الأساسية:

نختار عنصر من المصفوفة ليكون Pivot (المحور).
نقسم المصفوفة إلى جزئين:
الأرقام الأصغر من الـ Pivot توضع على اليسار.
الأرقام الأكبر من الـ Pivot توضع على اليمين.
نكرر نفس العملية على الجزئين حتى تصبح المصفوفة مرتبة بالكامل.



*/

using System;

class QuickSortExample
{
   
    static void Main()
    {
       


        int[] arr = { 8, 3, 7, 4, 6, 2, 5 };

        Console.WriteLine("قبل الترتيب: " + string.Join(", ", arr));

        QuickSort(arr, 0, arr.Length - 1);

        Console.WriteLine("بعد الترتيب: " + string.Join(", ", arr));
    
    }


    static void QuickSort (int arr[] , int right , int left ){


if (left < right ){




            int pivotIndex = Partition(int arr[] , int left , int right) ;
            QuickSort(arr, left, pivotIndex - 1); 
            QuickSort(arr, pivotIndex + 1, right);


    }
    }
static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right]; 
        int i = left - 1; 

        for (int j = left; j < right; j++)
        {
            if (arr[j] < pivot) 
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, right);
        return i + 1;
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

}

