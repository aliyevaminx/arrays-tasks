//////////////////////////TASK1 Arraydaki ededleri print etmek

//int[] numberList = { 23, 42, 62, 73, 34, 73, 84 };
//for (int i = 0; i < numberList.Length; i++)
//{
//    Console.WriteLine(numberList[i]);
//}




//////////////////////////TASK2 Arraydaki ededlerin cemini tapmaq

//int[] numberList = { 536, 62, 837, 623, 75, 923, 526 };
//int result = 0;

//for (int i = 0; i < numberList.Length; i++)
//{
//    result += numberList[i];
//}
//Console.WriteLine(result);


//////////////////////////TASK3 Arrayi tersine print etmek

//int[] numberList = { 215, 627, 825, 8413, 4373, 274, 853 };

//for (int i = numberList.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(numberList[i]);
//}

//////////////////////////TASK4 Arrayi tersine cevirmek

//int[] numberList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
//int k = 1;

//for (int i = 0; i < numberList.Length; i++)
//{
//    int temp = numberList[i];
//    numberList[i] = numberList[numberList.Length - k];
//    numberList[numberList.Length - k] = temp;
//    k++;

//    if (i == (numberList.Length - 1) / 2)
//    {
//        for (int j = 0; j < numberList.Length; j++)
//        {
//            Console.WriteLine(numberList[j]);
//        }
            break;
//    }
//}


//////////////////////////TASK5 Arraydaki en boyuk elementi tapmaq

//int[] numberList = { 34, 62, 728, 948, 325, 362, 36, 26 };
//int maxNumber = numberList[0];

//for (int i = 1; i < numberList.Length; i++)
//{
//    if ( numberList[i] > maxNumber)
//    {
//        maxNumber = numberList[i];
//    }
//}
//Console.WriteLine(maxNumber);


//////////////////////////TASK6 Arraydeki ededlerin sayini tapmaq

//int[] numberList = { 34, 62, 728, 948, 325, 362, 36, 26 };
//int count = 0;

//for (int i = 0; i < numberList.Length; i++)
//{
//    count++;
//}
//Console.WriteLine(count);


//////////////////////////TASK7 Arrayi sort etmek (danisdiqlarimizdan biri ile arasdirmaq)

//int[] arr = { 34, 62, 728, 948, 325, 362, 36, 26 };
//int n = arr.Length;

//// One by one move boundary of unsorted subarray
//for (int i = 0; i < n - 1; i++)
//{
//    // Find the minimum element in unsorted array
//    int min_idx = i;
//    for (int j = i + 1; j < n; j++)
//        if (arr[j] < arr[min_idx])
//            min_idx = j;

//    // Swap the found minimum element with the first
//    // element
//    int temp = arr[min_idx];
//    arr[min_idx] = arr[i];
//    arr[i] = temp;
//}

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//////////////////////////TASK8 Arrayde 0 ededinden nece defe islendiyini tapmaq

//int[] numberList = { 34, 62, 0, 948, 0, 362, 36, 0 };
//int count = 0;

//for (int i = 0; i < numberList.Length; i++)
//{
//    if (numberList[i] == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//////////////////////////TASK9 Arraydeki menfi ededlerin sayini tapmaq

//int[] numberList = { -4, 62, 0, 948, 0, -9, 36, 0 };
//int count = 0;

//for (int i = 0; i < numberList.Length; i++)
//{
//    if (numberList[i] < 0)
//        count++;
//}
//Console.WriteLine(count);

//////////////////////////TASK10 Arraydeki musbet ededlerin cemini tapmaq

//int[] numberList = { 623, 62, 0, 948, 0, -9, 36, 84 };
//int result = 0;

//for (int i = 0; i < numberList.Length; i++)
//{
//    if (numberList[i] > 0)
//    {
//        result += numberList[i];
//    }
//}
//Console.WriteLine(result);


//////////////////////////TASK11 Arraydeki ededleri ozlerinin kvadratina cevirmek

int[] numberList = { 63, 62, 0, 94, 0, -9, 36, 84 };

for  (int i = 0; i < numberList.Length; i++)
{
    numberList[i] = numberList[i] * numberList[i];
    Console.WriteLine(numberList[i]);
}

