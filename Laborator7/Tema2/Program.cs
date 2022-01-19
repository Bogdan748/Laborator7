using System;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrieti un array de numere intregi separate prin virgula:");
            int[] arr=Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
            Console.WriteLine($"Directia de sortare ({(Direction)0},{(Direction)1}) :");
            string direction = Console.ReadLine();
            
            Direction enumerator;

            if (!(Enum.TryParse(direction, out enumerator) && (Enum.IsDefined(typeof(Direction), direction)|| Enum.IsDefined(typeof(Direction), Int32.Parse(direction)))))
            {
                Console.Write("Directia este incorecta!");
                return;
            }

            QuickSort(arr, 0, arr.Length - 1, enumerator);

            Console.WriteLine("Array-ul sortat:");
            Console.WriteLine(String.Join(',', arr));
        }

        static void QuickSort(int[] arr, int left, int right, Direction direction)
        {
            if (left < right)
            {
                int pivot = partition(arr, left, right, direction);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1, direction);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right, direction);
                }
            }
        }

        static int partition(int[] arr, int left, int right, Direction direction)
        {
            int pivot = arr[left];

            if (direction == Direction.ascendent)
            {
                while (true)
                {
                    while (arr[left] < pivot)
                    {
                        left++;

                    }

                    while (arr[right] > pivot)
                    {
                        right--;
                    }

                    if (left < right)
                    {
                        if (arr[left] == arr[right])
                        {
                            return right;
                        }
                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;
                    }
                    else
                    {

                        return right;
                    }
                }
            }
            else if (direction == Direction.descendent)
            {
                while (true)
                {
                    while (arr[left] > pivot)
                    {
                        left++;

                    }

                    while (arr[right] < pivot)
                    {
                        right--;
                    }

                    if (left < right)
                    {
                        if (arr[left] == arr[right])
                        {
                            return right;
                        }
                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;
                    }
                    else
                    {

                        return right;
                    }
                }
            }

            return right;
            
        }
    }
}
