int Max(int x1, int x2 ,int x3){
    int result = x1;
    if(x2>result)result=x2;
    if(x3>result)result=x3;
    return result;
}
int max;
int [] array = {11,21,31,15,41,61,17,18,19};
array[0]=12;
Console.WriteLine(array[0]);

max = Max(Max(array[0],array[1],array[2]),
          Max(array[3],array[4],array[5]),
          Max(array[6],array[7],array[8]));
Console.Write(max);

