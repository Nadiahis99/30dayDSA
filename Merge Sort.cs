 /* searcing algorithms ------> Merge sort  
                     --------> Divide and Conquer

    ازاي بتشتغل ؟

1️نقسم المصفوفة لنصفين (يسار ويمين).
نكرر عملية التقسيم على كل نصف حتى نصل إلى عناصر فردية
2️نبدأ ندمج العناصر في مجموعات مرتبة
3 نكرر الدمج لحد ما نحصل على مصفوفة مرتبة بالكامل


لو معانا مثلا arr [5 , 9 , 6 , 8 , 4 , 3 ,7] 

هنقسم الاري لمجموعتين يمين و شمال 
الاولي 
[5 , 9 , 6 , 8]
التانيه  [4 , 3 , 7 ]
بعدين الاولي نفسمها لحد ما توصل لل , 6 ,8 , 9 5 
نقارن كل رقيمين جمب بعض لحد ما تترتب و هكذا مع الجزء التاني و بعدين ندمجهم 
احنا محتاجين ايه عشان نكتب الحاجات دي  ؟
خلينا نفكير 
function ------> arr , lift , right 
*/

using System;

class QuickSortExample
{
    static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6, 7 };
        merge_sort(arr, 0, arr.Length - 1);

        Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
    }

    static void merge_sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2; // حساب منتصف المصفوفة

            merge_sort(arr, left, mid); // تقسيم الجزء الأيسر
            merge_sort(arr, mid + 1, right); // تقسيم الجزء الأيمن

            Merge(arr, left, mid, right); // دمج الجزئين بعد الترتيب
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int lef1 = mid - left + 1; // حجم الجزء الأيسر
        int rig1 = right - mid; // حجم الجزء الأيمن

        int[] arr1 = new int[lef1];
        int[] arr2 = new int[rig1];

        // نسخ البيانات إلى المصفوفات المؤقتة
        Array.Copy(arr, left, arr1, 0, lef1);
        Array.Copy(arr, mid + 1, arr2, 0, rig1);

        int i = 0, j = 0, k = left;

        // دمج المصفوفات
        while (i < lef1 && j < rig1)
        {
            if (arr1[i] <= arr2[j])
                arr[k++] = arr1[i++];
            else
                arr[k++] = arr2[j++];
        }

        // نسخ العناصر المتبقية من اليسار
        while (i < lef1)
            arr[k++] = arr1[i++];

        // نسخ العناصر المتبقية من اليمين
        while (j < rig1)
            arr[k++] = arr2[j++];
    }
}





