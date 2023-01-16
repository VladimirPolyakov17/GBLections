void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while (index < length)
  {
      collection[index] = new Random().Next(1, 10);
      //index = index + 1 (см.строку нижу);
      index++;
  }
}

void PrintArray(int[] col)
{
  int count = col.Length;
  int position = 0;
  while (position < count)
  {
      Console.WriteLine(col[position]);
      position++;
  }

}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //Можно 0 или лучше -1 чтобы понять что такого элемента в массиве нет

    while (index < count)
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

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
