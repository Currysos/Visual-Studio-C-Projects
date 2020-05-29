using System;
using System.Threading;

public class WriteAnim
{
    public void Write(string WhatToWrite, int delayMS)
    {
        for (int i = 0; i < WhatToWrite.Length; i++)
        {
            Console.Write(WhatToWrite[i]);
            Thread.Sleep(delayMS);
        }
        Console.WriteLine();
    }
}