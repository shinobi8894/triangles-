// CPP code to find time
// taken by animals to meet
#include <bits/stdc++.h>
using namespace std;
 
// function to calculate time to meet
void timeToMeet(double s, double v){
 
     double V = 3 * v / 2;
           
     double time = s / V;
      
     cout << time;
}
 
// Driver Code
int main(void) {
     
    double s = 25, v = 56;
     
    timeToMeet(s, v);
     
    return 0;
}