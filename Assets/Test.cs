using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int num = 87;
    int result;
    public List<int> numbers = new List<int>();
    List<int> notInclude = new List<int>();

    System.Text.StringBuilder sb = new System.Text.StringBuilder();

    string n;

    void Start()
    {
        //string strBinary = Convert.ToString(num, 2);
        //Debug.Log("변환" + strBinary);
        for (int i = 1; i < num; i *= 2)
        {
            numbers.Add(i);
            numbers.Reverse();

        }

        if (numbers[0] < num)
        {
            numbers.Add(numbers[0] + numbers[0]);
            numbers.Sort();
            numbers.Reverse();
        }

        for (int y = 0; y < numbers.Count; y++)
        {
            if (numbers[y] <= num)
            {
                result += numbers[y];

                if (result > num)
                {
                    result -= numbers[y];
                    notInclude.Add(numbers[y]);
                }
            }
            else
            {
                notInclude.Add(numbers[y]);

            }

            if (notInclude.Contains(numbers[y]))
            {
                n = "0";
            }
            else
            {
                n = "1";
            }

            sb.Append(n);
            Debug.Log(sb);
        }
    }
}
