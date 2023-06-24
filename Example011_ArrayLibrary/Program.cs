void FillArray(int[] collection)
{
    int max = 10;
    int min = 1;
    Random random = new Random();
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = random.Next(min, max);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while(position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }

    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();
int pos = IndexOff(array, 4);
Console.WriteLine(pos);