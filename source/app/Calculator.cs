﻿using System;

namespace app
{
  public class Calculator
  {
    public int add(int first, int second)
    {
        if (first < 0 || second < 0)
            throw new ArgumentException("I can't add negative numbers :(");

        return first + second;
    }
  }
}