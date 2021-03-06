﻿using System;
using System.Collections.Generic;

public class CropRatio
{
    private int totalWeight;
    private Dictionary<string, int> crops = new Dictionary<string, int>();

    public void Add(string name, int cropWeight)
    {
        if (crops.ContainsKey(name))
        {
            int currentCropWeight;
            crops.TryGetValue(name, out currentCropWeight);
            crops[name] = currentCropWeight + cropWeight;
        }
        else
        {
            crops.Add(name, cropWeight);
        }
        totalWeight += cropWeight;
    }

    public double Proportion(string name)
    {
        if (totalWeight == 0) return 0.0;
        return (double)crops[name] / (double)totalWeight;
    }

    public static void Main(string[] args)
    {
        CropRatio cropRatio = new CropRatio();

        cropRatio.Add("Wheat", 4);
        cropRatio.Add("Wheat", 5);
        cropRatio.Add("Rice", 1);

        Console.WriteLine("Ratio of wheat: {0}", cropRatio.Proportion("Wheat"));
    }
}