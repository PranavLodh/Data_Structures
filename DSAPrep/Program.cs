
using DSAPrep;

//Console.WriteLine("Hello, World!");
//Array 1
//int[,] matrix = new int[3, 3]
//{
//    {1,2,3},
//    {4,5,6},
//    {4,0,6},
//};

//Console.WriteLine("-----------Before-----------");
//Array1.PrintMatrix(matrix);

//matrix = Array1.SetMatrixZero1(matrix);

//Console.WriteLine("-----------After-----------");
//Array1.PrintMatrix(matrix);

////Array2
//int[][] Triangle=Array2.PascalTriangle(10);
//Array2.PrintTriangle(Triangle);


//Array 3
//int[] array = { 1, 2, 3 };
//Console.WriteLine("------------------Array 3-----------------------");
//array = Array3.getNextPermutation(array);
//Array3.printArray(array);

//int[] array1 = { 1, 2, 3 };
//List<List<int>> list = new List<List<int>>();
//Array3.recursegetPermutations(0,array1,list);

//int max = Array4.getHighestSum([-2, 1, -3, 4, -1, 2, 1, -5, 4]);
//Console.WriteLine($"Maximum Number is {max}");



//Array5
//int[] a = [2,2,1,1,0,0,0,0,0,0];
//a=Array5.SortArray(a);
//for(int i = 0; i < a.Length; i++)
//{
//    Console.WriteLine(a[i]);
//}

//Array6
//int[] a = [7,1,5,3,6,4];
//int maxprofit = Array6.getMaxProfit(a);
//Console.WriteLine(maxprofit);

//Array7
//int[,] matrix = new int[,]
//{
//    {1, 2, 3, 6},
//    {4, 5, 6, 6},
//    {7, 8, 9, 6}
//};
//int[,] matrix2 = Array7.RotateMatrix(matrix);
//Array7.PrintMatrix(matrix2);

//Array8
//List<Interval> intervals = new List<Interval>()
//{
//    new Interval(1,3),
//    new Interval(2,6),
//    new Interval(8,10),
//    new Interval(11,15),
//};
//List<Interval> newIntervals = Array8.NonOverlappingArray(intervals);

//foreach(Interval interval in newIntervals)
//{
//    Console.WriteLine(interval.startIndex + "\t" + interval.endIndex);
//}

//Array9
//int[] a = [1, 4, 8, 10];
//int[] b = [2, 3, 9];

//Array9.mergeArray(a, b);


//Array10
//int[] a = [1, 3, 4, 2, 2];
//int number = Array10.getDuplicateNumber(a);   
//Console.WriteLine($"The duplicate number is {number}");


//[1,2,3] AP - 6 GP - 6
//[2,2,3] AP - 7 GP - 12
//[3,3,1] AP - 7 GP - 9

//[1,2,3,4] AP - 10 GP - 24
//[1,1,3,4] AP - 9 GP - 12
//[2,2,3,4] AP - 11 GP - 48
//[3,3,1,4] AP - 11 GP - 36
//[3,3,2,1] AP - 9
//[1,1,]
////Array11
//int[] a = [1,1,3,4,5];
//Array11.getDuplicateAndMissingNumber(a);

//LinkedList1
//LinkedList l1 = new LinkedList(1,null);
//LinkedList l2 = new LinkedList(2, l1);
//LinkedList l3 = new LinkedList(3, l2);
//LinkedList l4 = new LinkedList(4, l3);
//LinkedList l5 = new LinkedList(5, l4);

//LinkedList1.reverseLinkedList(l5);

//Array12
//int[] a = [5, 4, 3, 2, 1];
//Array12.countInversionArray(a);

//Array3_1
//int[,] mat = {{1, 2, 3, 4}, { 5, 6, 7, 8}, { 9, 10, 11, 12} };
//Console.WriteLine(Array3_1.isPresent2(mat, 10));

//Array3_2
//float result = Array3_2.CalculatePower(2, 1);
//Console.WriteLine("The result is " + result);

//Array3_3
//int[] a = { 3, 2, 3 };
//int repeater = Array3_3.CalculateMostOccurring(a);
//Console.WriteLine("The repeated element is " + repeater);

//Array3_4
//int[] a = { 11, 33, 33, 11, 33, 11 };
//List<int> frequentNumbers = Array3_4.getFrequentNumbers(a);
//foreach(int n in frequentNumbers)
//{
//    Console.Write(n + "\t");
//}

//Array3_5
//Array3_5.countPaths(2,3);

//Array3_6
//int count = Array3_6.countReversePairs([3 ,2 ,1 ,4]);
//Console.WriteLine($"The count is {count}");


//Weekly406
LinkedList l5 = new LinkedList(5,null);
LinkedList l4 = new LinkedList(4, l5);
LinkedList l3 = new LinkedList(3, l4);
LinkedList l2 = new LinkedList(2, l3);
LinkedList l1 = new LinkedList(1, l2);
int[] arr = { 2, 4 };
LinkedList head = Weekly406.removeNodes(l1, arr);
Console.WriteLine(head.value);

Console.WriteLine($"Lexicographic string is {Weekly406.getSmallestString("20")}");
