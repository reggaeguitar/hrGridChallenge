using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace hrGridChallenge
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine(Solve(Console.In));
        }

        public static string Solve(TextReader textReader)
        {
            var sb = new StringBuilder();
            var numCases = Int32.Parse(textReader.ReadLine());
            while (numCases-- > 0)
            {
                var dimension = Int32.Parse(textReader.ReadLine());
                var grid = new List<string>();
                for (int i = 0; i < dimension; ++i)
                {
                    var c = textReader.ReadLine().OrderBy(x => x);
                    var d = String.Concat(c);
                    grid.Add(d);
                }
                string answer = "YES";
                bool done = false;
                for (int row = 0; row < dimension; ++row)
                {
                    if (!done)
                    {
                        for (int col = 0; col < dimension; ++col)
                        {
                            // check in row -> char to right
                            if (col != dimension - 1)
                            {
                                if (grid[row][col] > grid[row][col + 1])
                                {
                                    answer = "NO";
                                    done = true;
                                    break;
                                }
                            }
                            // check in col -> char below
                            if (row != dimension - 1)
                            {
                                if (grid[row][col] > grid[row + 1][col])
                                {
                                    answer = "NO";
                                    done = true;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                sb.AppendLine(answer);
            }
            return sb.ToString();
        }
    }
}
