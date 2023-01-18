void FillArray( int [] collection){
    int leinght = collection.Length;
    int i = 0;
    while(i<leinght){
        collection[i]= new Random().Next(1,10);
        i++;
    }
}
 void PrintArray(int [] col){
    int lein = col.Length;
    int j = 0;
    while(j<lein){
        Console.WriteLine(col[j]);
        j++;
    }
 }
 int IndexOf( int [] collection, int find ){
    int count=collection.Length;
    int i = 0;
    int x = -1;
    while(i<count){
        if(collection[i]==find){
            x = i;
            break;
        }
        i++;
    }
    return x;
 }
 int [] array = new int [10]; 
 FillArray(array);
 PrintArray(array);

 int y = IndexOf(array, 4);
 Console.WriteLine("fff "+y);
