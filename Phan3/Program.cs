
var productIds = new List<int> { 1,2,3,4,5,6,7,8};

var result = from p in productIds
             where p < 5
             select p;

foreach(var p in result)
    Console.WriteLine(p);