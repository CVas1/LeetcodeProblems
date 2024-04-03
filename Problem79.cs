using System;
using System.Collections.Generic;
using System.Linq;

public class Problem79
{
    public static void Main()
    {
        Problem79 pb = new Problem79();
        char[][] charArray = new char[][]
        {
            new char[] { 'b','b' },
            new char[] { 'a','b' },
            new char[] { 'b','a' }

        };
        pb.Exist(charArray, "ABCCED");
    }

    public char[] chars;
    public Stack<Vector2> usedVector2s = new Stack<Vector2>();

    public bool Exist(char[][] board, string word)
    {
        if (word.Length == 1)
        {
            foreach (char[] c in board)
            {
                foreach (char VARIABLE in c)
                {
                    if (VARIABLE == word[0]) return true;
                    

                }
            }return false;
        }
        chars = word.ToCharArray();
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (chars[0] != board[i][j]) continue;
                usedVector2s.Push(new Vector2(i,j));
                if (TestRight(board, chars[1], new Vector2(i, j)))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public bool TestUp(char[][] board, char c, Vector2 vector2)
    {
        
        if (vector2.x >= 1)
        {
            if (board[vector2.x - 1][vector2.y] == c &&
                !usedVector2s.Any(v2 => vector2.x - 1 == v2.x && vector2.y == v2.y))
            {
                usedVector2s.Push(new Vector2(vector2.x - 1, vector2.y));
                if (usedVector2s.Count == chars.Length) return true;
                if (TestRight(board, chars[usedVector2s.Count], new Vector2(vector2.x - 1, vector2.y))) return true;
            }
        }
        if (usedVector2s.Count == chars.Length) return true;
        if (usedVector2s.Count != 0)
            usedVector2s.Pop();
        return false;

        //return TestDown(board, c, vector2);
        
    }

    public bool TestDown(char[][] board, char c, Vector2 vector2)
    {
        if (vector2.x < board.Length - 1)
        {
            if (board[vector2.x + 1][vector2.y] == c &&
                !usedVector2s.Any(v2 => vector2.x + 1 == v2.x && vector2.y == v2.y))
            {
                usedVector2s.Push(new Vector2(vector2.x + 1, vector2.y));
                if (usedVector2s.Count == chars.Length) return true;
                if (TestRight(board, chars[usedVector2s.Count], new Vector2(vector2.x + 1, vector2.y))) return true;
            }
        }

        return TestLeft(board, c, vector2);
    }

    public bool TestRight(char[][] board, char c, Vector2 vector2)
    {
        if (vector2.y < board[0].Length - 1)
        {
            if (board[vector2.x][vector2.y + 1] == c &&
                !usedVector2s.Any(v2 => vector2.x == v2.x && vector2.y + 1 == v2.y))
            {
                usedVector2s.Push(new Vector2(vector2.x, vector2.y + 1));
                if (usedVector2s.Count == chars.Length) return true;
                if (TestRight(board, chars[usedVector2s.Count], new Vector2(vector2.x, vector2.y + 1))) return true;
            }
        }

        return TestDown(board, c, vector2);
    }

    public bool TestLeft(char[][] board, char c, Vector2 vector2)
    {
        if (vector2.y >= 1)
        {
            if (board[vector2.x][vector2.y - 1] == c &&
                !usedVector2s.Any(v2 => vector2.x == v2.x && vector2.y - 1 == v2.y))
            {
                usedVector2s.Push(new Vector2(vector2.x, vector2.y - 1));
                if (usedVector2s.Count == chars.Length) return true;
                if (TestRight(board, chars[usedVector2s.Count], new Vector2(vector2.x, vector2.y - 1))) return true;
            }
        }
        return TestUp(board, c, vector2);
        // if (usedVector2s.Count == chars.Length) return true;
        // if (usedVector2s.Count != 0)
        //     usedVector2s.Pop();
        // return false;
    }

    public struct Vector2
    {
        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x;
        public int y;
    }
}