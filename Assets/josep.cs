using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class josep : MonoBehaviour
{
    public List<int> total = new List<int>();
    public List<int> die = new List<int>();

    void Start()
    {
        var totalNum = 7;
        var target = 3;

        for (int i = 0; i < totalNum; i++)
        {
            total.Add(i + 1);
        }

        while (true)
        {
            if (die.Count == totalNum)
                return;
            else
            {
                for (int j = 0; j < target - 1; j++)
                {
                    total.Add(total[0]);
                    total.Remove(total[0]);
                }

                die.Add(total[0]);
                total.Remove(total[0]);
            }
        }
    }
}
