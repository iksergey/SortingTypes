public static class Sorting
{
  /// <summary>
  /// Сортировка методом пузырька (Базовая)
  /// </summary>
  /// <param name="collection">Исходный массив</param>
  /// <returns>Отсортированный массив массив</returns>
  public static int[] SortBubble(this int[] collection)
  {
    int size = collection.Length;

    for (int current = 0; current < size - 1; current++)
    {
      for (int i = 0; i < size - 1; i++)
      {
        if (collection[i] > collection[i + 1])
        {
          int temp = collection[i];
          collection[i] = collection[i + 1];
          collection[i + 1] = temp;
        }
      }
    }

    return collection;
  }

  /// <summary>
  /// Сортировка методом пузырька (Оптимизированная)
  /// </summary>
  /// <param name="collection">Исходный массив</param>
  /// <returns>Отсортированный массив массив</returns>
  public static int[] SortBubbleOptimized(this int[] collection)
  {
    int size = collection.Length;

    for (int current = 0; current < size - 1; current++)
    {
      for (int i = 0; i < size - 1 - current; i++)
      {
        if (collection[i] > collection[i + 1])
        {
          int temp = collection[i];
          collection[i] = collection[i + 1];
          collection[i + 1] = temp;
        }
      }
    }
    return collection;
  }
}