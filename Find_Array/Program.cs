int[] array = {1, 2, 23, 34, 75, 53, 14, 17, 39, 75};

int n = array.Length;
int find = 75;

int index = 0;

while(index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}