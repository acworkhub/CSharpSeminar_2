
Random rnd = new Random();
int n = new Random().Next(10,100);
int d1 = n/10;
int d2 = n % 10;

int max = d1;

if (max<d2)
{
    max=d2;
}

System.Console.WriteLine($"Максимальная цифра числа {n} => {max}");

// int[] arr = new int[3];
// int length = arr.Length;
// int i = 0;


// while (i<length)
// {
//     arr[i] = new Random().Next(10,100);
//     System.Console.WriteLine(arr[i]);
//     i++;
// }



