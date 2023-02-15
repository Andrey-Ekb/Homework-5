// Написать программу масштабирования фигуры
// Масштабирование равностороннего четырехугольника. (Левый нижний угол (точка А) остается на месте)


int[,] GetNewCords(int[] a, int[] b, int[] c, int[] d, int k)       
{
        int[,] coor = new int[4, 2];       

    for (int i = 0; i < 2; i++)                                 
    {
        for (int j = 0; j < 2; j++) 
        {                               
            if (i == j)  
            {                                          
                coor[0, j] = a[i];      
                coor[1, j] = (b[i] - a[i]) * k + a[i];                          
                coor[2, j] = (c[i] - a[i]) * k + a[i];
                coor[3, j] = (d[i] - a[i]) * k + a[i];
            }
        }
    }
    return coor;
}

void PrintCords(int[,] arr, char[] point)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{point[i]} ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"({arr[i, j]}, ");
            else Console.WriteLine($"{arr[i, j]})");
        }
    }
}

int k = 2;
int[] pointA = { 0, 0 };
int[] pointB = { 2, 0 };
int[] pointC = { 2, 2 };
int[] pointD = { 0, 2 };
char[] pointName = { 'A', 'B', 'C', 'D' };

Console.WriteLine();
int[,] newCords = GetNewCords(pointA, pointB, pointC, pointD, k);
PrintCords(newCords, pointName);
