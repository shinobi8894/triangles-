// C# code to find time
// taken by animals to meet
using System;
 
public class GFG {
     
    // function to calculate time to meet
    static void timeToMeet(double s, double v){
     
        double V = 3 * v / 2;
             
        double time = s / V;
         
        Console.WriteLine((float)time);
    }
     
    // Driver Code
    static public void Main ()
    {
         
        double s = 25, v = 56;
     
        timeToMeet(s, v);
     
    }
}