public static class Sorting
{

  /// <summary>
  /// Сортировка методом выбора
  /// </summary>
  /// <param name="collection">Исходный массив</param>
  /// <returns>Отсортированный массив массив</returns>
  public static int[] SortSelection(this int[] collection)
  {
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
      int pos = i;
      for (int j = i + 1; j < size; j++)
      {
        if (collection[j] < collection[pos]) pos = j;
      }
      int temp = collection[i];
      collection[i] = collection[pos];
      collection[pos] = temp;
    }
    return collection;
  }
}