﻿using System;
using System.IO;
using System.Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            int[] nums = File.ReadAllText("numsTask5.txt").Split(' ').Select(int.Parse).ToArray();
            
            int minIndex = Array.IndexOf(nums, nums.Min());
            int maxIndex = Array.IndexOf(nums, nums.Max());

            int sum = 0;
            int count = 0;
            if (minIndex < maxIndex)
            {
                for (int i = minIndex + 1; i < maxIndex; i++)
                {
                    sum += nums[i];
                    count++;
                }
            }
            else
            {
                for (int i = maxIndex + 1; i < minIndex; i++)
                {
                    sum += nums[i];
                    count++;
                }
            }
            
            Console.WriteLine($"Среднее арифметическое элементов расположенных между минимальным и максимальным: {sum / count}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
    }
}
