
<?php
// PHP code to find time
// taken by animals to meet
 
// function to calculate
// time to meet
function timeToMeet($s, $v)
{
 
    $V = 3 * $v / 2;
    $time = $s / $V;
    echo $time;
}
 
    // Driver Code
    $s = 25; $v = 56;
    timeToMeet($s, $v);
     
?>