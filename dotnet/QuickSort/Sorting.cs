public static class Sorting
{
  public static int[] SortQuick(this int[] collection, int left, int right)
  {
    int i = left;
    int j = right;

    int pivot = collection[Random.Shared.Next(left, right)];
    while (i <= j)
    {
      while (collection[i] < pivot) i++;
      while (collection[j] > pivot) j--;

      if (i <= j)
      {
        int t = collection[i];
        collection[i] = collection[j];
        collection[j] = t;
        i++;
        j--;
      }
    }
    if (i < right) SortQuick(collection, i, right);
    if (left < j) SortQuick(collection, left, j);
    return collection;
  }
}