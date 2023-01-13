using static Sorting;

int size = 10;
var arr = size.CreateArray()
            .Show()
            .SortQuick(0, size - 1)
            .Show();