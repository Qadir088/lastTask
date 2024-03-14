
//1. Task
//Console.WriteLine("add number");
//int n = int.Parse(Console.ReadLine());

//for(int i = 0; i <= n; i++)
//{
//    int result = n * i;
//    Console.WriteLine($"{n} * {i} = {result}");
//}

//2.Task

//int[] arr = { 1, 2, 3, 4, 5, 6 };
//int[] arr1 = new int[2];
//int[] arr2 = new int[2];
//int[] arr3 = new int[2];
//int count = 0;
//for(int i = 0; i < arr.Length; i+=3)
//{
//    arr1[count] = arr[i];
//    arr2[count] = arr[i+1];
//    arr3[count] = arr[i+2];
//    count++;
//}
//foreach(int i in arr1)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("------------");
//foreach (int i in arr2)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("------------");
//foreach (int i in arr3)
//{
//    Console.WriteLine(i);
//}

//3.Task 
string[] names = {  "Guler", "Gozel", "Ulduz" };
string[] existance = new string[names.Length];
bool prime = false;
int count = 0;
foreach(string name in names)
{
    prime = false;
    foreach(char letter in name)
    {
        if(letter == 'u')
        {
            prime = true;
        }
        if (prime)
        {
            existance[count] = name;
            count++;
        }
        prime = false;
    }
};
for(int i =0; i < existance.Length; i++)
{
    if (existance[i] != null)
    {
        char[] word = existance[i].ToCharArray();
        for(int j =0;j< word.Length; j++)
        {
            if (word[j] == 'u')
            {
                word[j] = 'e';
            Console.WriteLine(word);
            }
        }
    }
}
Console.WriteLine("------------");
foreach(string name in existance)
{
    Console.WriteLine(name);
};
