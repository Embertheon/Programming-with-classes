using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;

class Program
{
    static List<int> Sort(List<int> value){
        List<int> SortedList = new List<int>();
        int temp = value[0];
        int tempIndex = 0;
        while (value.Count != 0){
            for (int i = 0; i < value.Count; i++){
                if (value[i] < temp){
                    temp = value[i];
                    tempIndex = i;
                }
            }
        SortedList.Add(temp);
        value.RemoveAt(tempIndex); 
        temp = 999999999; 
        tempIndex = 0;   
        }
        return SortedList;
    }

    static void Main(string[] args)
    {
        int sum = 0;
        int lowest = 9999999;
        int highest = 0;
        int Positive_lowest = 99999999;
        List<int> values = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        values = [];
        while(!values.Contains(0)){
            values.Add(int.Parse(Console.ReadLine()));
        }
        for (int i = 0; i < values.Count; i++){
            sum += values[i];
            if (values[i] > 0 & values[i] < Positive_lowest){
              Positive_lowest = values[i];  
            }
            if (values[i] < lowest){
                lowest = values[i];
            }
            if (values[i] > highest){
                highest = values[i];
            }
        }
        float average = sum/values.Count;
        Console.WriteLine($"The sum is: {sum}\nThe average is: {average}\nThe largest number is: {highest}\nThe smallest number is {lowest}\n The smallest positive number is {Positive_lowest} \n The sorted list is:");
        List<int> sorted = Sort(values);
         for (int i = 0; i < sorted.Count; i++){
            Console.WriteLine(sorted[i]);
        }
    }


}