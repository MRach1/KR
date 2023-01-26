string[] array = {"word", "333", ":-)", "Moskov", "red", "homework", "21"};
string[] Three(string[] arr)
{
    string[] result = new string[arr.Length];
    int j = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            result[j] = arr[i];
            j ++;
        }
    }
    return result;
}
void PrintArray(string[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write($"{ar[i]} ");
    }
}
PrintArray(Three(array));