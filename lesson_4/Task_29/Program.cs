int size = 8;

int[] Array(int size){
    int[] array = new int[size];
    int index = 0;
    Random rdn = new Random();

    while(index < array.Length){
        array[index] = rdn.Next(0,100);
        index++;
    }
    return array;
}

void printArray(int[] arr){
    for(int i = 0; i < arr.Length; i++){
        if(i == 0) Console.Write("[");
        if(i < arr.Length - 1) Console.Write(arr[i]+",");
        else Console.Write(arr[i]+ "]");
    }
}

int[] resArray = Array(size);
printArray(resArray);