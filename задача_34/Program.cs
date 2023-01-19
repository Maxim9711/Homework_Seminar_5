int[] randomArray (int length){

    int [] array = new int [length];

    for (int i=0; i < array.Length; i++){
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

int evenSymbol(int[] array) {
    int countSymbol = 0;

    for (int i=0; i < array.Length; i++)
        if (array[i]%2 == 0)
            countSymbol++;

    return countSymbol;
}

void showArray (int[] array){
    for(int i=0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.Write("\n");
}

// Формируем массив и выводим количество четных чисел в массиве  
int [] array = randomArray(5);
showArray(array);
Console.WriteLine(evenSymbol(array));