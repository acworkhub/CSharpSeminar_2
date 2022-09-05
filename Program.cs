// int[] arr = new int[3];
// int length = arr.Length;
// int i = 0;


// while (i<length)
// {
//     arr[i] = new Random().Next(10,99);
//     System.Console.WriteLine(arr[i]);
//     i++;
// }


int[] ar = {3,5,7};
int count = 0;
int length = ar.Length;
int max = 0;
// System.Console.WriteLine(max);

 while (count<length)
 {
    if (ar[count]>ar[max]) 
   {
        ar[count] = max;
        System.Console.WriteLine(ar[max]);
   } 
    count++;
 }
   System.Console.WriteLine(ar[max]);
   


