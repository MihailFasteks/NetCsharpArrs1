// See https://aka.ms/new-console-template for more information
//task1
//int[] arr = new int[10];
//Random random = new Random();
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = random.Next(1,10);
//    Console.Write("{0,4}", arr[i]);
//}
//Console.WriteLine();
//Console.WriteLine("Even elems: ");
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        Console.Write("{0,4}", arr[i]);
//    }

//}
//Console.WriteLine();
//Console.WriteLine("Odd elems: ");
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 != 0)
//    {
//        Console.Write("{0,4}", arr[i]);
//    }

//}
//Console.WriteLine();
//Console.WriteLine("Unique elems: ");

//for (int i=0;i<arr.Length; i++)
//{
//  bool  isUnique = true;
//    for (int j=0; j<arr.Length; j++)
//    {

//        if (i!=j && arr[i] == arr[j])
//        {
//            isUnique = false;
//            break;
//        }
//    }
//    if (isUnique == true)
//    {
//        Console.Write("{0,4}", arr[i]);
//    }
//}
//Console.WriteLine();


//task2

//Console.WriteLine("Input value ");
//int v=int.Parse(Console.ReadLine());

//if (v <= 0)
//{
//    Console.WriteLine("Wrong value! ");
//}
//else
//{
//    int[] arr = new int[20];
//    Random random = new Random();
//    for (int i = 0; i < arr.Length; i++)
//    {
//        arr[i] = random.Next(1, 10);

//    }
//    for (int i = 0; i < v-1; i++)
//    {
//        arr[i] = random.Next(1, 10);
//        Console.Write("{0,4}", arr[i]);
//    }


//}

//task3
//Console.WriteLine("Input value 1 ");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Input value 2 ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Input value 3 ");
//int num3 = int.Parse(Console.ReadLine());

//int[] arr = new int[20];
//Random random = new Random();
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = random.Next(1, 10);

//}
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write("{0,4}", arr[i]);

//}
//Console.WriteLine();
//int count = 0;
//for (int i = 2; i < arr.Length; i++)
//{
//    if (arr[i] == num3 && arr[i - 1] == num2 && arr[i - 2] == num1)
//    {
//        count++;
//    }

//}
//Console.WriteLine($"Count: {count}");


//task4
Random random = new Random();
int[] arr = new int[5];
int[] arr1 = new int[6];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(1, 10);

}
for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = random.Next(1, 10);

}
for (int i = 0; i < arr.Length; i++)
{
    Console.Write("{0,4}", arr[i]);

}
Console.WriteLine();
for (int i = 0; i < arr1.Length; i++)
{
    Console.Write("{0,4}", arr1[i]);

}
Console.WriteLine();
int size=arr.Length<arr1.Length? arr.Length: arr1.Length;
int[] res=new int[size];
int count = 0;

for (int i = 0; i < size; i++)
{
    bool isUnique = true;
    for (int j = 0; j < size; j++)
    {

        if (i != j && arr[i] == arr[j])
        {
            isUnique = false;
            break;
        }
    }
    if (isUnique == true && arr[i] == arr1[i])
    {
        res[count] = arr[i];
        count++;
        
    }
}
for (int i = 0; i < res.Length; i++)
{
    Console.Write("{0,4}", res[i]);

}
Console.WriteLine();