﻿
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
//List<List<int>> ds = new List<List<int>>();
//ds = Array3.getNextPermutation(array,0,ds);
//Array3.printArray(ds);

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
//LinkedList l5 = new LinkedList(5,null);
//LinkedList l4 = new LinkedList(4, l5);
//LinkedList l3 = new LinkedList(3, l4);
//LinkedList l2 = new LinkedList(2, l3);
//LinkedList l1 = new LinkedList(1, l2);
//int[] arr = { 2, 4 };
//LinkedList head = Weekly406.removeNodes(l1, arr);
//Console.WriteLine(head.value);

//Console.WriteLine($"Lexicographic string is {Weekly406.getSmallestString("20")}");

//int cost = Weekly406.CakeCutting1(3, 2, [1,3] , [5]);
//Console.WriteLine(cost);


//Array4_1
//int[] array = {2,6,5,8,11};
//Array4_1.Sum2Array2(array, 15);


//Array4_2
//int[] array = { 1, 0, -1, 0, -2, 2 };
//Array4_2.GetQuadNumbers(array, 0);

//Array4_3
//int[] array = [100, 200, 1, 3, 2, 4, 5];
//int maxcount = Array4_3.getLongestConsecutiveSequence(array);
//Console.WriteLine($"The maximum count is : {maxcount}");

//LinkedList1 2
//LinkedList l1 = new LinkedList(1, null);
//LinkedList l2 = new LinkedList(2, l1);
//LinkedList l3 = new LinkedList(3, l2);
//LinkedList l4 = new LinkedList(4, l3);
//LinkedList l5 = new LinkedList(5, l4);

//int middleElement = LinkedList1_2.getMiddleElement(l5);
//Console.WriteLine($"The middle element is {middleElement}");


//LinkedList1 3
//LinkedList l1 = new LinkedList(10, null);
//LinkedList l2 = new LinkedList(8, l1);
//LinkedList l3 = new LinkedList(4, l2);
//LinkedList l4 = new LinkedList(2, l3);

//LinkedList l5 = new LinkedList(14, null);
//LinkedList l6 = new LinkedList(11, l5);
//LinkedList l7 = new LinkedList(6, l6);
//LinkedList l8 = new LinkedList(3, l7);
//LinkedList l9 = new LinkedList(3, l8);
//LinkedList l10 = new LinkedList(1, l9);


//LinkedList head = LinkedList1_3.mergeSortedList(l4,l10);
//Console.WriteLine(head.value);

//LinkedList l1 = new LinkedList(10, null);
//LinkedList l2 = new LinkedList(8, l1);
//LinkedList l3 = new LinkedList(4, l2);
//LinkedList l4 = new LinkedList(2, l3);

//LinkedList head = LinkedList1_4.removeNode(l4, 7);

//LinkedList1_5
//LinkedList l1 = new LinkedList(9, null);
//LinkedList l2 = new LinkedList(9, l1);
//LinkedList l3 = new LinkedList(9, l2);
//LinkedList l4 = new LinkedList(9, l3);


//LinkedList l6 = new LinkedList(9, null);
//LinkedList l7 = new LinkedList(9, l6);
//LinkedList l8 = new LinkedList(9, l7);
//LinkedList l9 = new LinkedList(9, l8);
//LinkedList l10 = new LinkedList(9, l9);
//LinkedList l11 = new LinkedList(9, l10);
//LinkedList l12 = new LinkedList(9, l11);

//long sum = LinkedList1_5.addTwoNumbers(l4, l12);

//LinkedList l6 = new LinkedList(9, null);
//LinkedList l7 = new LinkedList(9, l6);
//LinkedList l8 = new LinkedList(9, l7);
//LinkedList l9 = new LinkedList(9, l8);
//LinkedList l10 = new LinkedList(9, l9);
//LinkedList l11 = new LinkedList(9, l10);
//LinkedList l12 = new LinkedList(9, l11);


//LinkedList1_6
//LinkedList l6 = new LinkedList(7, null);
//LinkedList l7 = new LinkedList(6, l6);
//LinkedList l8 = new LinkedList(5, l7);
//LinkedList l9 = new LinkedList(4, l8);
//LinkedList l10 = new LinkedList(3, l9);
//LinkedList l11 = new LinkedList(2, l10);
//LinkedList l12 = new LinkedList(1, l11);
//LinkedList1_6.deleteNode(l9, l12);

//Console.WriteLine($"The sum is {sum}");


//LinkedList2_1
//LinkedList l5 = new LinkedList(4, null);
//LinkedList l4 = new LinkedList(2, l5);
//LinkedList l3 = new LinkedList(1, l4);
//LinkedList l2 = new LinkedList(3, l3);
//LinkedList l1 = new LinkedList(1, l2);



//LinkedList l6 = new LinkedList(3, l4);

//LinkedList node = LinkedList2_1.getCommonNode(l1, l6);
//LinkedList node = LinkedList2_1.getCommonNode2(l1, l6);
//Console.WriteLine("The common Node is " +  node.value);


//LinkedList2_1
//LinkedList l5 = new LinkedList(4, null);
//LinkedList l4 = new LinkedList(2, l5);
//LinkedList l3 = new LinkedList(1, l4);
//LinkedList l2 = new LinkedList(3, l3);
//LinkedList l1 = new LinkedList(1, l2);
//l5.next = l3;


//bool isCyclic = LinkedList2_2.isCyclic(l1);
//Console.WriteLine($"The Linked is Cyclic : {isCyclic}");

//LinkedList2_4

//LinkedList l5 = new LinkedList(1, null);
//LinkedList l4 = new LinkedList(2, l5);
//LinkedList l3 = new LinkedList(3, l4);
//LinkedList l2 = new LinkedList(2, l3);
//LinkedList l1 = new LinkedList(1, l2);
//bool isPalindrome = LinkedList2_4.isPalindrome(l1);
//Console.WriteLine($"Is Palindrome : {isPalindrome}");


//LinkedList2_5
LinkedList l5 = new LinkedList(5, null);
LinkedList l4 = new LinkedList(4, l5);
LinkedList l3 = new LinkedList(3, l4);
LinkedList l2 = new LinkedList(2, l3);
LinkedList l1 = new LinkedList(1, l2);
//l5.next = l3;


LinkedList startingPoint = LinkedList2_5.getStartPoint(l1);
Console.WriteLine($"The starting point of Linked List is {(startingPoint != null ? startingPoint.value:0)}");







