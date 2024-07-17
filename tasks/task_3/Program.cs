// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//      Использовать рекурсию, не использовать циклы.
 

        int[] myArray = { 10, 12, 6, 2, 9, 11, 16 }; 
 
        Console.WriteLine("Элементы массива, начиная с конца:"); 
        PrintArrayReverse(myArray, myArray.Length - 1); 


     void PrintArrayReverse(int[] arr, int index) 
    { 
        if (index >= 0) 
        { 
            Console.Write(arr[index] + " "); 
            PrintArrayReverse(arr, index - 1); 
        } 
    } 