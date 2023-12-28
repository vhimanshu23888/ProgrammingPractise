using System;
using System.Collections.Generic;
using ProblemSolving.common;
using ProgrammingPractise;
using ProblemSolving.LeetCode_Top150;
namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TwoSum

            //TwoSum twoSum = new TwoSum();
            //int[] input = { 3, 2, 4 };target = 6
            //int[] input = { 3, 3 }; target = 9
            //int[] input = { 2, 7, 11, 15 };
            //int[] result = twoSum.TwoSums(input, 9);

            //if (result != null)
            //{
            //    Console.WriteLine($"[{result[0]},{result[1]}]");
            //    Console.ReadKey();
            //}
            #endregion

            #region RomanToInt
            //RomanToIntegers romanToIntegers = new RomanToIntegers();
            //Console.WriteLine(romanToIntegers.RomanToInt("III"));
            //Console.WriteLine(romanToIntegers.RomanToInt("LVIII"));
            //Console.WriteLine(romanToIntegers.RomanToIntBetter("MCMXCIV"));
            //Console.ReadKey();
            #endregion

            #region LongestCommonPrefix
            //LongestCommonPrefix LCF = new LongestCommonPrefix();
            //string[] input = new string[] { "flower", "flow", "flight" }; Output: "fl"
            //string[] input = new string[] { "dog", "racecar", "car" }; //Output: ""
            //string[] input = new string[] { "cir", "car" }; Output: "c"
            //string[] input = new string[] { "flower", "flower", "flower", "flower" }; //Output: "flower"
            //string result = LCF.GetLongestCommonPrefix(input); 
            //Console.WriteLine(string.IsNullOrEmpty(result) ? "Empty" : result);
            //Console.ReadKey();
            #endregion

            #region Valid Parentheses
            //Valid_Parentheses Valid_Parentheses = new Valid_Parentheses();
            //Console.WriteLine(Valid_Parentheses.IsValid("()"));
            //Console.WriteLine(Valid_Parentheses.IsValid("()[]{}"));
            //Console.WriteLine(Valid_Parentheses.IsValid("(]"));
            //Console.WriteLine(Valid_Parentheses.IsValid("["));
            //Console.WriteLine(Valid_Parentheses.IsValid("]"));
            //Console.ReadKey();
            #endregion

            #region Palindrome
            //Palindrome palindrome = new Palindrome();
            //Console.WriteLine(palindrome.IsPalindrome(121));
            //Console.WriteLine(palindrome.IsPalindrome(-121));
            //Console.WriteLine(palindrome.IsPalindrome(10));
            //Console.WriteLine(palindrome.IsPalindrome(1000030001));
            //Console.WriteLine(palindrome.IsPalindromeWithoutString(-1));
            //Console.WriteLine("**********************************************************");
            //Console.WriteLine(palindrome.IsPalindromeWithoutString(121));
            //Console.WriteLine(palindrome.IsPalindromeWithoutString(-121));
            //Console.WriteLine(palindrome.IsPalindromeWithoutString(10));
            //Console.WriteLine(palindrome.IsPalindromeWithoutString(1000030001));
            //Console.WriteLine(palindrome.IsPalindromeWithoutString(-1));
            //Console.ReadKey();
            #endregion

            #region RemoveDuplitateFromSortedArray

            //RemoveDuplicatesFromSortedArray RemoveDuplicatesFromSortedArray = new RemoveDuplicatesFromSortedArray();
            //Console.WriteLine(RemoveDuplicatesFromSortedArray.RemoveDuplicates(new int[] { 1, 1 }));
            //Console.WriteLine(RemoveDuplicatesFromSortedArray.RemoveDuplicates(new int[] { 1, 1, 2 }));
            //Console.WriteLine(RemoveDuplicatesFromSortedArray.RemoveDuplicates(new int[] { 1, 2, 2 }));
            //Console.WriteLine(RemoveDuplicatesFromSortedArray.RemoveDuplicates(new int[] { 1, 2, 2, 2 }));
            //Console.WriteLine(RemoveDuplicatesFromSortedArray.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
            #endregion

            #region Plus Minus

            //PlusMinus objPlusMinus = new PlusMinus();
            //objPlusMinus.plusMinusOperation(new List<int>{ -4, 3, -9, 0, 4, 1 });
            #endregion
            #region Max Min Sum
            //MinMaxSum sum = new MinMaxSum();
            //sum.MinAndMaxSum(new List<int> {1,2,3,4,5 });
            //sum.MinAndMaxSum(new List<int> { 1, 3, 5, 7, 9 });
            //sum.MinAndMaxSum(new List<long> { 256741038, 623958417, 467905213, 714532089, 938071625 });
            #endregion
            #region Time Conversion
            //TimeConversion t = new TimeConversion();
            //Console.WriteLine(t.timeConversion("07:05:45PM"));
            //Console.WriteLine(t.timeConversion("12:01:00PM"));
            //Console.WriteLine(t.timeConversion("12:01:00AM"));
            #endregion
            #region Breaking the Records
            //BreakingTheRecords objBreakingTheRecords = new BreakingTheRecords();
            //Console.WriteLine(string.Join(" ",objBreakingTheRecords.breakingRecords(new List<int> { 12, 24, 10, 24 })));

            #endregion
            #region camel Casing
            //CamelCasing objCamelCasing = new CamelCasing();
            //Console.WriteLine(objCamelCasing.camelCasingMethod("S;M;plasticCup()"));
            //Console.WriteLine(objCamelCasing.camelCasingMethod("C;V;mobile phone"));
            //Console.WriteLine(objCamelCasing.camelCasingMethod("C;C;coffee machine"));
            //Console.WriteLine(objCamelCasing.camelCasingMethod("S;C;LargeSoftwareBook"));
            //Console.WriteLine(objCamelCasing.camelCasingMethod("C;M;white sheet of paper"));
            //Console.WriteLine(objCamelCasing.camelCasingMethod("S;V;pictureFrame"));

            #endregion
            #region DivisibleSumPairs
            //DivisibleSumPairs divisibleSumPairs = new DivisibleSumPairs();
            //Console.WriteLine(divisibleSumPairs.GetDivisiblePairsCount(6, 5, new List<int> { 1,2,3,4,5,6 }));
            //Console.WriteLine(divisibleSumPairs.GetDivisiblePairsCount(6, 3, new List<int> { 1, 3, 2, 6, 1, 2 }));
            #endregion

            #region Sparse Array
            //SparseArray sparseArray = new SparseArray();
            //foreach (int i in sparseArray.matchingStrings(new List<string> { "aba", "baba", "aba", "xzxb" }, new List<string> { "aba", "xzxb", "ab" }))
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region FindMedianTest
            //FindMedianTest findMedianTest = new FindMedianTest();
            //Console.WriteLine(findMedianTest.findMedian(new List<int> { 5, 3, 1, 2, 4 }));
            //Console.WriteLine(findMedianTest.findMedian(new List<int> { 0, 1, 2, 4, 6, 5, 3 }));
            #endregion

            #region MED_AddTwoNumbersFromLinkedLists

            //MED_AddTwoNumbersFromLinkedLists mED_AddTwoNumbersFromLinkedLists = new MED_AddTwoNumbersFromLinkedLists();
            //ListNode node = mED_AddTwoNumbersFromLinkedLists.AddTwoNumbers(
            //    new common.ListNode { val = 2, next = new common.ListNode { val = 4, next = new common.ListNode { val = 3 } } },
            //    new common.ListNode { val = 5, next = new common.ListNode { val = 6, next = new common.ListNode { val = 4 } } });

            ////node.next = mED_AddTwoNumbersFromLinkedLists.AddTwoNumbers(
            //    //new common.ListNode { val = 0},
            //    //new common.ListNode { val = 1});

            //while (true)
            //{
            //    if (node != null)
            //    {
            //        Console.WriteLine(node.val);
            //        node = node.next;
            //    }
            //    else
            //        break;
            //}

            #endregion

            #region Easy_MergeSortedArray
            Easy_MergeSortedArray mergeSortedArray = new Easy_MergeSortedArray();
            //int[] num1 = new int[] { 1, 2, 3, 0, 0, 0 };
            //mergeSortedArray.Merge(ref num1, 3, new int[] { 2, 5, 6 }, 3);
            //foreach (int i in num1)
            //    Console.WriteLine(i);
            //int[] num2 = new int[] { 0 };
            //mergeSortedArray.Merge(ref num2, 0, new int[] { 1 }, 1);
            //foreach (int i in num2)
            //    Console.WriteLine(i);

            //int[] num3 = new int[] { 1 };
            //mergeSortedArray.Merge(ref num3, 1, new int[] {  }, 0);
            //foreach (int i in num3)
            //    Console.WriteLine(i);

            //Easy_MergeSortedArray3PointersApproach mergeSortedArray3PointersApproach = new Easy_MergeSortedArray3PointersApproach();
            //int[] num1 = new int[] { 1, 2, 3, 0, 0, 0 };
            //mergeSortedArray3PointersApproach.Merge(num1, 3, new int[] { 2, 5, 6 }, 3);

            //Console.WriteLine();
            //int[] num2 = new int[] { 0 };
            //mergeSortedArray3PointersApproach.Merge(num2, 0, new int[] { 1 }, 1);

            //Console.WriteLine();

            //int[] num3 = new int[] { 1 };
            //mergeSortedArray3PointersApproach.Merge(num3, 1, new int[] { }, 0);
            #endregion

            #region Easy_RemoveElementArray
            Easy_RemoveElementArray removeElementArray = new Easy_RemoveElementArray();
            Console.WriteLine("K: " + removeElementArray.RemoveElement(new int[] { 3, 2, 2, 3 }, 3));
            Console.WriteLine();
            Console.WriteLine("K: " + removeElementArray.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));
            Console.WriteLine();
            Console.WriteLine("K: " + removeElementArray.RemoveElement(new int[] { 2 }, 3));
            Console.WriteLine();
            Console.WriteLine("K: " + removeElementArray.RemoveElement(new int[] { 3, 3 }, 3));
            Console.WriteLine();
            Console.WriteLine("K: " + removeElementArray.RemoveElement(new int[] { 4, 5 }, 5));
            #endregion
            Console.ReadKey();

        }
    }
}
