using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    //Problem Statement: Given an array of intervals,
    //merge all the overlapping intervals and return an array of non-overlapping intervals.
    internal class Array8
    {
        public static List<Interval> NonOverlappingArray(List<Interval> intervals)
        {
            List<Interval> mergedInterval = new List<Interval>();
            Interval currentInterval = intervals[0];

            foreach(var interval in intervals) 
            {
                if(interval.startIndex <= currentInterval.endIndex)
                {
                    currentInterval.endIndex = Math.Max(currentInterval.startIndex, interval.endIndex);
                }
                else
                {
                    mergedInterval.Add(currentInterval);
                    currentInterval = interval;
                }
            }
            mergedInterval.Add(currentInterval);
            return mergedInterval;
        }
    }

    public class Interval
    {
        public int startIndex;
        public int endIndex;

        public Interval(int startIndex, int endIndex) 
        {
        this.startIndex = startIndex;
        this.endIndex = endIndex;
        }
    }
}
