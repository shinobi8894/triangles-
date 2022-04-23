// JavaScript code to find time taken by animals
// to meet
 
    // function to calculate time to meet
    function timeToMeet(s , v) {
 
        var V = 3 * v / 2;
 
        var time = s / V;
 
        document.write( time.toFixed(6));
    }
 
    // Driver Code
 
        var s = 25, v = 56;
 
        timeToMeet(s, v);