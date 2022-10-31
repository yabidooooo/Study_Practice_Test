using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StringFormatScript
{
    public static string MyApplyDecimalComma(int value)
    {
        string firstValue = new string("");
        List<string> secondValue = new List<string>();
        StringBuilder stringBuilder = new StringBuilder();
        string finalValue = new string("");

        int quotient = value.ToString().Length / 3;
        int remainder = value.ToString().Length % 3;

        if (value.ToString().Length <= 3)
        {
            return value.ToString();
        }
        else if (value.ToString().Length > 3)
        {
            for (int i = 0; i < quotient; i++)
            {
                if (remainder == 1)
                {
                    firstValue = value.ToString().Substring(0, 1);
                    secondValue.Add(value.ToString().Substring(1 + (3 * i), 3));
                }
                else if (remainder == 2)
                {
                    firstValue = value.ToString().Substring(0, 2);
                    secondValue.Add(value.ToString().Substring(2 + (3 * i), 3));
                }
                else if (remainder == 0)
                {
                    secondValue.Add(value.ToString().Substring(3 + (3 * (i - 1)), 3));
                }
            }
        }

        for (int i = 0; i < quotient; i++)
        {
            if (remainder == 0)
            {
                if (i == 0)
                {
                    stringBuilder.Append(secondValue[i]);
                }
                else if (i > 0)
                {
                    stringBuilder.Append("," + secondValue[i]);
                }
                finalValue = stringBuilder.ToString();
            }
            else
            {
                stringBuilder.Append("," + secondValue[i]);
                finalValue = firstValue + stringBuilder;
            }
        }

        return finalValue;
    }
}
