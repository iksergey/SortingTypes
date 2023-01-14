using static Sorting;

int size = 100;
var arr = size.CreateArray()
            .Show()
            .SortQuick(0, size - 1)
            .Show()
            ;