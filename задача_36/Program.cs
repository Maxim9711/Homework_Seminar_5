int[] randomArray (int length){

    int [] array = new int [length];

    for (int i=0; i < array.Length; i++){
        array[i] = new Random().Next(-99, 100);
    }

    return array;
}

int sumOddPosition(int[] array) {
    int sum = 0;

    for (int i=1; i < array.Length; i+=2)
        sum += array[i];

    return sum;
}

void showArray (int[] array){
    for(int i=0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.Write("\n");
}

// Формируем массив и выводим сумму чисел стоящих на нечетных позициях  
int [] array = randomArray(5);
showArray(array);
Console.WriteLine(sumOddPosition(array));