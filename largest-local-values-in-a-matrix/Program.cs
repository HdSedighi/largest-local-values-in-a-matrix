using System;

class Solution {
    public int[][] MaxSlidingWindow(int[][] grid) {
        int n = grid.Length;
        int[][] maxLocal = new int[n - 2][];

        for (int i = 0; i < n - 2; i++) {
            maxLocal[i] = new int[n - 2];
            for (int j = 0; j < n - 2; j++) {
                int max = int.MinValue;
                for (int k = i; k < i + 3; k++) {
                    for (int l = j; l < j + 3; l++) {
                        max = Math.Max(max, grid[k][l]);
                    }
                }
                maxLocal[i][j] = max;
            }
        }
        return maxLocal;
    }

    static void Main(string[] args) {
        Solution solution = new Solution();
        int[][] grid1 = new int[][] {
            new int[] {9, 9, 8, 1},
            new int[] {5, 6, 2, 6},
            new int[] {8, 2, 6, 4},
            new int[] {6, 2, 2, 2}
        };

        int[][] maxLocal1 = solution.MaxSlidingWindow(grid1);
        Console.WriteLine("Output 1:");
        foreach (int[] row in maxLocal1) {
            Console.WriteLine($"[{string.Join(", ", row)}]");
        }

        int[][] grid2 = new int[][] {
            new int[] {1, 1, 1, 1, 1},
            new int[] {1, 1, 1, 1, 1},
            new int[] {1, 1, 2, 1, 1},
            new int[] {1, 1, 1, 1, 1},
            new int[] {1, 1, 1, 1, 1}
        };

        int[][] maxLocal2 = solution.MaxSlidingWindow(grid2);
        Console.WriteLine("\nOutput 2:");
        foreach (int[] row in maxLocal2) {
            Console.WriteLine($"[{string.Join(", ", row)}]");
        }
    }
}
