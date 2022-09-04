int size = 8;
int minValue = -100;
int maxValue = 100;
int[] array = new int[size];

for (int i = 0; i < array.Length; ++i) {
    array[i] = new Random().Next(minValue, maxValue +1);
}

Console.WriteLine("[ " + string.Join(", ", array) + " ]");