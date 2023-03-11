/*
    // Task 34. 4: Define an array filled with random positive three-digit numbers. Write a program to show the number of even numbers in an array.
double [] FillArrayWhithRandomNumber(int size)
{
double[] arr = new double[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(100, 1000);
}
return arr;
}
    
System.Console.Write("Input the array length: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayWhithRandomNumber(size);

double sum = 0;
for(int i = 0; i < array.Length; i++)
{
  if(array[i] % 2 == 0)
  {
sum+= array[i];
  }
}

System.Console.Write("Your random array: ");
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"Sum of even numbers {sum}");
*/
    
    /*
// Task 36: Input a one-dimensional array filled with random numbers. Find the sum of elements in odd positions.
int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr;
}
    
System.Console.Write("Input the array length: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
    
int sum = 0;
for(int i = 1; i < array.Length; i=i+2)
{

sum+= array[i];

}
System.Console.Write("Your random array: ");
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"The sum of values ​​at odd positions is equal to {sum}");
*/

/*
    // Task 38: Specify an array of real numbers (double type). Find the difference between the maximum and minimum elements of an array.
    double [] FillArrayWhithRandomNumber(int size)
{
double[] arr = new double[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(1, 1000);
}
return arr;
}
    
System.Console.Write("Input the array length: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayWhithRandomNumber(size);

double minValue = array[0];
double maxValue = array[0];
for(int i = 0; i < array.Length; i++)
{
  if(array[i] > maxValue)
  {
    maxValue = array[i];
  }
  if(array[i] < minValue)
  {
    minValue = array[i];
  }
}

System.Console.Write("Your random array: ");
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"Difference between max value {maxValue} and min value {minValue} is {maxValue - minValue}");
    */
