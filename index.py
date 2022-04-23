# Python3 code to find time
# taken by animals to meet
 
# function to calculate
# time to meet
def timeToMeet(s, v):
    V = 3 * v / 2;
     
    time = s / V;
     
    print(time);
 
# Driver Code
s = 25;
v = 56;
     
timeToMeet(s, v);