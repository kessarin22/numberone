using System;

class Program
{
    static void Main()
    {
        int row_num;
        while (true)
        {
            Console.Write("กรุณากรอกชั้นของสามเหลี่ยมปาสคาล: ");
            if (int.TryParse(Console.ReadLine(), out row_num))
            {
                if (row_num < 0)
                {
                    Console.WriteLine("Invalid Pascal's triangle row number.");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("โปรดป้อนจำนวนเต็มที่ถูกต้อง");
            }
        }

        int[][] triangle = GeneratePascalsTriangle(row_num);
        if (triangle != null)
        {
            Console.WriteLine("ผลลัพธ์เป็นรูปสามเหลี่ยมปาสคาล:");
            foreach (int[] row in triangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }

    static int[][] GeneratePascalsTriangle(int row_num)
    {
        if (row_num < 0)
        {
            return null;
        }

        int[][] triangle = new int[row_num + 1][];
        for (int i = 0; i <= row_num; i++)
        {
            triangle[i] = new int[i + 1];
            triangle[i][0] = 1;

            for (int j = 1; j < i; j++)
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }

            triangle[i][i] = 1;
        }

        return triangle;
    }
}
