using System;
using System.Collections.Generic;
using System.Linq;

public class Problem1700
{
    // public static void Main()
    // {
    //     Problem1700 pb = new Problem1700();
    //     Console.WriteLine(pb.CountStudents(new []{1,1,0,0},new []{0,1,0,1}));
    // }
    public int CountStudents(int[] students, int[] sandwiches)
    {
        List<int> listStudent = students.ToList();
        List<int> listSandwiches = sandwiches.ToList();
        
        int i = 0;
        int turn = 0;
        while (turn < listStudent.Count && listStudent.Count>=0)
        {
            
            if (listStudent[i%listStudent.Count] == listSandwiches[0])
            {
                listStudent.RemoveAt(i%listStudent.Count);
                listSandwiches.RemoveAt(0);
                turn = 0;
                continue;
            }
            i++;
            turn++;

        }

        return listStudent.Count;
    }
}