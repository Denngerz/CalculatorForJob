using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public TMP_InputField firstNumber;
    public TMP_InputField secondNumber;
    public TextMeshProUGUI sign;

    public void PressSign(string x)
    {
        sign.text = x;
        secondNumber.text = firstNumber.text;
        firstNumber.text = "";
    }
    public void Equal()
    {
        //FirstFraction======================================================================================
        if (firstNumber.text.Contains("/") && !secondNumber.text.Contains("/"))
        {
            if (sign.text == "+")
            {
                string[] n = firstNumber.text.Split('/');
                int b = int.Parse(secondNumber.text);
                int n1 = int.Parse(n[0]);
                int d1 = int.Parse(n[1]);
                int numerator = b*d1 + n1 ;
                int denuminator = d1;
                print(numerator + "/" + denuminator);
                int[] res = Reduce(numerator, denuminator);
                firstNumber.text = res[0] + "/" + res[1];
                secondNumber.text = "";
                sign.text = "";
            }
            if (sign.text == "-")
            {
                string[] n = firstNumber.text.Split('/');
                int b = int.Parse(secondNumber.text);
                int n1 = int.Parse(n[0]);
                int d1 = int.Parse(n[1]);
                int numerator = b * d1 - n1;
                int denuminator = d1;
                print(numerator + "/" + denuminator);
                int[] res = Reduce(numerator, denuminator);
                firstNumber.text = res[0] + "/" + res[1];
                secondNumber.text = "";
                sign.text = "";
            }
            if (sign.text == "*")
            {
                string[] n = firstNumber.text.Split('/');
                int b = int.Parse(secondNumber.text);
                int n1 = int.Parse(n[0]);
                int d1 = int.Parse(n[1]);
                int numerator = b*n1;
                int denuminator = d1;
                print(numerator + "/" + denuminator);
                int[] res = Reduce(numerator, denuminator);
                firstNumber.text = res[0] + "/" + res[1];
                secondNumber.text = "";
                sign.text = "";
            }
            if (sign.text == "/")
            {
                string[] n = firstNumber.text.Split('/');
                int b = int.Parse(secondNumber.text);
                int n1 = int.Parse(n[0]);
                int d1 = int.Parse(n[1]);
                int numerator = b * d1;
                int denuminator = n1;
                print(numerator + "/" + denuminator);
                int[] res = Reduce(numerator, denuminator);
                firstNumber.text = res[0] + "/" + res[1];
                secondNumber.text = "";
                sign.text = "";
            }
        }
        //SecondFraction=====================================================================================
        if (!firstNumber.text.Contains("/") && secondNumber.text.Contains("/"))
        {
            if (sign.text == "+")
            {
                string[] n = secondNumber.text.Split('/');
                
                int n1 = int.Parse(n[0]);
                int d1 = int.Parse(n[1]);
                int b = int.Parse(firstNumber.text);
                int numerator = n1 + d1 * b;
                int denuminator = d1;
                print(numerator + "/" + denuminator);
                int[] res = Reduce(numerator, denuminator);
                firstNumber.text = res[0] + "/" + res[1];
                secondNumber.text = "";
                sign.text = "";
            }
            if (sign.text == "-")
            {
                string[] n = secondNumber.text.Split('/');
               
                int n1 = int.Parse(n[0]);
                int d1 = int.Parse(n[1]);
                int b = int.Parse(firstNumber.text);
                int numerator = n1 - d1 * b;
                int denuminator = d1;
                print(numerator + "/" + denuminator);
                int[] res = Reduce(numerator, denuminator);
                firstNumber.text = res[0] + "/" + res[1];
                secondNumber.text = "";
                sign.text = "";
            }
            if (sign.text == "*")
            {
                string[] n = secondNumber.text.Split('/');
                int b = int.Parse(firstNumber.text);
                int n1 = int.Parse(n[0]);
                int d1 = int.Parse(n[1]);
                int numerator = n1 * b;
                int denuminator = d1;
                print(numerator + "/" + denuminator);
                int[] res = Reduce(numerator, denuminator);
                firstNumber.text = res[0] + "/" + res[1];
                secondNumber.text = "";
                sign.text = "";
            }
            if (sign.text == "/")
            {
                string[] n = secondNumber.text.Split('/');
                int b = int.Parse(firstNumber.text);
                int n1 = int.Parse(n[0]);
                int d1 = int.Parse(n[1]);
                int numerator = n1;
                int denuminator = d1 * b;
                print(numerator + "/" + denuminator);
                int[] res = Reduce(numerator, denuminator);
                firstNumber.text = res[0] + "/" + res[1];
                secondNumber.text = "";
                sign.text = "";
            }
        }
        //BouthFraction======================================================================================
        if (firstNumber.text.Contains("/") && secondNumber.text.Contains("/"))
        {
            if (sign.text == "+")
            {
                string[] n = secondNumber.text.Split('/');
                string[] d = firstNumber.text.Split('/');
                int n1 = int.Parse(n[0]);
                int d1 = int.Parse(n[1]);
                int n2 = int.Parse(d[0]);
                int d2 = int.Parse(d[1]);
                int numerator = (n1 * d2) + (d1 * n2);
                int denuminator = d1 * d2;
                print(numerator + "/" + denuminator);
                int[] res = Reduce(numerator, denuminator);
                firstNumber.text = res[0] + "/" + res[1];
                secondNumber.text = "";
                sign.text = "";
            }
            if (sign.text == "-")
            {
                string[] n = secondNumber.text.Split('/');
                string[] d = firstNumber.text.Split('/');
                int n1 = int.Parse(n[0]);
                int d1 = int.Parse(n[1]);
                int n2 = int.Parse(d[0]);
                int d2 = int.Parse(d[1]);
                int numerator = (n1 * d2) - (d1 * n2);
                int denuminator = d1 * d2;
                print(numerator + "/" + denuminator);
                int[] res = Reduce(numerator, denuminator);
                firstNumber.text = res[0] + "/" + res[1];
                secondNumber.text = "";
                sign.text = "";
            }
            if (sign.text == "*")
            {
                string[] n = secondNumber.text.Split('/');
                string[] d = firstNumber.text.Split('/');
                int n1 = int.Parse(n[0]);
                int d1 = int.Parse(n[1]);
                int n2 = int.Parse(d[0]);
                int d2 = int.Parse(d[1]);
                int numerator = n1 * n2;
                int denuminator = d1 * d2;
                print(numerator + "/" + denuminator);
                int[] res = Reduce(numerator, denuminator);
                firstNumber.text = res[0] + "/" + res[1];
                secondNumber.text = "";
                sign.text = "";
            }
            if (sign.text == "/")
            {
                string[] n = secondNumber.text.Split('/');
                string[] d = firstNumber.text.Split('/');
                int n1 = int.Parse(n[0]);
                int d1 = int.Parse(n[1]);
                int n2 = int.Parse(d[0]);
                int d2 = int.Parse(d[1]);
                int numerator = n1 * d2;
                int denuminator = d1 * n2;
                print(numerator + "/" + denuminator);
                int[] res = Reduce(numerator, denuminator);
                firstNumber.text = res[0] + "/" + res[1];
                secondNumber.text = "";
                sign.text = "";
            }

        }
        //Normal=============================================================================================
        if (sign.text == "+")
        {
            float a = float.Parse(firstNumber.text);
            float b = float.Parse(secondNumber.text);
            firstNumber.text = (b+a).ToString();
            secondNumber.text = "";
            sign.text = "";          
        }        
        else if (sign.text == "-")
        {
            float a = float.Parse(firstNumber.text);
            float b = float.Parse(secondNumber.text);
            firstNumber.text = (b - a).ToString();
            secondNumber.text = "";
            sign.text = "";
        }
        else if (sign.text == "*")
        {
            float a = float.Parse(firstNumber.text);
            float b = float.Parse(secondNumber.text);
            firstNumber.text = (b * a).ToString();
            secondNumber.text = "";
            sign.text = "";
        }
        else if (sign.text == "/")
        {
            float a = float.Parse(firstNumber.text);
            float b = float.Parse(secondNumber.text);
            firstNumber.text = (b / a).ToString();
            secondNumber.text = "";
            sign.text = "";
        }
      

    }
    public void Clear()
    {
        firstNumber.text = "";
        secondNumber.text = "";
        sign.text = "";
    }
    public void RemoveLastNumber()
    {
        if (firstNumber.text.Length > 0)
        {
            firstNumber.text = firstNumber.text.Remove(firstNumber.text.Length - 1);
        }
 
    }
    public void PressNumber(int x)
    {
        firstNumber.text += x;
    }
    public void Dot()
    {
        if (!firstNumber.text.Contains(".") || !firstNumber.text.Contains("/"))
        {
            firstNumber.text += ".";
        }
    }
    public void PlusMinus()
    {
        if (firstNumber.text.Length == 0)
        {
            return;
        }
        if (firstNumber.text[0] == '-')
        {
            firstNumber.text = firstNumber.text.Substring(1);
        }
        else
        {
            firstNumber.text = "-" + firstNumber.text;
        }
    }
    public void Fraction()
    {
        if (firstNumber.text.Length == 0 || firstNumber.text == "-" || firstNumber.text.Contains("."))
        {
            return;
        }

        if (!firstNumber.text.Contains("/"))
        {
            firstNumber.text += "/";
        }       
    }
    public static int nsp(int numerator, int denominator)
    {
        int a = Mathf.Abs(numerator);
        int b = Mathf.Abs(denominator);
        int min;
        if (a > b)
        {
            min = b;
        }
        else
        {
            min = a;
        }
        for (int i = min; i >= 1; i--)
        {
            if (a % i == 0 && b % i == 0)
            {
                return i;
            }
        }
        return 1;
    }

    public static int[] Reduce(int numerator, int denominator)
    {
        try
        {
            int gcdNum = nsp(numerator, denominator);

            if (gcdNum != 0)
            {
                numerator = numerator / gcdNum;
                denominator = denominator / gcdNum;
            }

            if (denominator < 0)
            {
                denominator = denominator * -1;
                numerator = numerator * -1;
            }
        }
        catch (Exception exp)
        {
            throw new InvalidOperationException("Cannot reduce Fraction: " + exp.Message);
        }
        return new int[]{ numerator,denominator};
    }
}
