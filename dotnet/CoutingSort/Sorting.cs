public static class Sorting
{
  public static int[] SortCounting(this int[] collection)
  {
    int size = collection.Length;

    int max = collection[0];
    for (int i = 1; i < size; i++)
      if (collection[i] > max) max = collection[i];

    int[] counter = new int[max + 1];

    for (int i = 0; i < size; i++)
      counter[collection[i]]++;
    Console.WriteLine($"counter = [{String.Join(' ', counter)}]");
    int index = 0;
    for (int i = 0; i < max + 1; i++)
      for (int j = 0; j < counter[i]; j++)
        collection[index++] = i;

    return collection;
  }
}