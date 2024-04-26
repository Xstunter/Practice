using System;

public class AI
{
    
    public static int Recommend(int[][] nodes)
    {
        List<int> lastRowSums = new List<int> { nodes[0][0] };

        for (int i = 1; i < nodes.Length; i++)
        {
            List<int> currentRowSums = new List<int>();

            for (int j = 0; j < nodes[i].Length; j++)
            {
                int current = nodes[i][j];

                if (j == 0)
                {
                    currentRowSums.Add(current + lastRowSums[0]);
                }
                else if (j == nodes[i].Length - 1)
                {
                    currentRowSums.Add(current + lastRowSums[j - 1]);
                }
                else
                {
                    int firstPathSum = lastRowSums[j - 1] + current;
                    int secondPathSum = lastRowSums[j] + current;
                    if(firstPathSum >= secondPathSum)
                    {
                        currentRowSums.Add(firstPathSum);
                    }
                    else
                    {
                        currentRowSums.Add(secondPathSum);
                    }
                }
            }

            lastRowSums = currentRowSums;
        }

        return lastRowSums.Max();
    }

    public static void Main(string[] args)
    {
        int[][] nodes = new int[][] { new int[] { 5 }, new int[] { 7, 3 }, new int[] { 6, 8, 10 }, new int[] { 12, 9, 13, 16 }, new int[] { 1, 8, 10, 3, 5 } }; //, new int[] { 1, 8, 10, 3, 5 }
        int maxSum = Recommend(nodes);
        Console.WriteLine($"Результат: {maxSum}" );
    }
}

/*public static int Recommend(int[][] nodes) //MaxValue
    {
        int sum = nodes[0][0];
        int index = 0;

        for (int i = 1; i < nodes.Length; i++)
        {
            for(int j = index; j < index + 1; j++)
            {
                if (nodes[i][j] > nodes[i][j + 1]) 
                { 
                    sum+= nodes[i][j];
                    index = j;
                    break;
                }
                else
                {
                    sum += nodes[i][j + 1];
                    index = j + 1;
                    break;
                }
            }
        }
        return sum;
    }*/

/*public static int Recommend(int[][] nodes)
{
    List<List<int>> pathSums = new List<List<int>>() { new List<int>() { 0 } };

    foreach (int[] row in nodes)
    {
        List<int> rowSums = new List<int>();

        for (int j = 0; j < row.Length; j++)
        {
            if (j == 0)
            {
                rowSums.Add(row[0] + pathSums.Last()[0]);
            }
            else if (j == row.Length - 1)
            {
                rowSums.Add(row[j] + pathSums.Last()[j - 1]);
            }
            else
            {
                List<int> possibleSums = new List<int>();
                possibleSums.Add(row[j] + pathSums.Last()[j - 1]);
                possibleSums.Add(row[j] + pathSums.Last()[j]);

                rowSums.Add(possibleSums.Max());
            }
        }

        pathSums.Add(rowSums);
    }

    return pathSums.Last().Max();
}*/
