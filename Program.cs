String[] ert =  {"kot", "shmot","1", "bl", "hosting"};

String[] newArray = getNewArray(ert);
printArray(newArray);

String[] getNewArray(String[] array){
    String[] newArray = new String[array.Length];
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if (array[i].Length <= 3 ){
            newArray[count] = array[i];
            count++;
        }
    }
    Array.Resize<String>(ref newArray, count);
    return newArray;
}

void printArray(String[] array){
   Console.WriteLine(array.Length + " Size ");
    foreach(String i in array){
        
        Console.Write(i + "; ");
    }
}