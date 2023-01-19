int[] randomArray (int length){

    int [] array = new int [length];

    for (int i=0; i < array.Length; i++){
        array[i] = new Random().Next(0, 100);
    }

    return array;
}

void showArray (int[] array){
    for(int i=0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.Write("\n");
}

// Нахождение разницы между максимальным и минимальным значением
int [] array = randomArray(5);
showArray(array);
Console.WriteLine($"Разница между максимальным и минимальным значением массива равна {array.Max() - array.Min()}");