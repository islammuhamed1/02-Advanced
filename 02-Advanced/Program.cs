namespace _02_Advanced
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            #region q1
            //int[] arr = { 5, 10, 15 };
            //Console.WriteLine(ReturnGreaterNumber(arr, 4)); 
            //Console.WriteLine(ReturnGreaterNumber(arr, 8));
            //Console.WriteLine(ReturnGreaterNumber(arr, 20)); 
            #endregion
            #region q2
            //Console.WriteLine("Enter Number Of Elements:");
            // int.TryParse(Console.ReadLine() , out int x);

            //Console.WriteLine("Enter Array Elements:");
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //if (IsPalindrome(arr))
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            #endregion
            #region q3
            //Queue<int> queue = new Queue<int>([ 1, 2, 3, 4, 5 ]);
            //Queue<int> reversedQueue = ReverseQueue(queue);
            //Console.WriteLine(string.Join(", ", reversedQueue));
            #endregion
            #region q4
            //Console.WriteLine(IsBalanced("[()]{}{)")); 
            //Console.WriteLine(IsBalanced("[()]{}")); 
            #endregion
            #region q5
            //Console.WriteLine(string.Join(", ", RemoveDuplicates([ 1 ,1, 2, 2, 3, 4, 4, 5 ]))); 
            #endregion
            #region q6
            //List<int> list = new List<int> { 1,2,3,4,5,6,7,8 };
            //Console.WriteLine(string.Join(", ", RemoveOddNumbers(list))); 
            #endregion
            #region q7
            //Queue<int> intQueue = new Queue<int>();
            //QueueDifferentTypes(intQueue, 5);
            //Queue<string> stringQueue = new Queue<string>();
            //QueueDifferentTypes(stringQueue, "Samsung");
            //Queue<double> doubleQueue = new Queue<double>();
            //QueueDifferentTypes(doubleQueue, 12.8);
            //Console.WriteLine(intQueue.Dequeue());
            //Console.WriteLine(stringQueue.Dequeue());
            //Console.WriteLine(doubleQueue.Dequeue());

            #region q8
            //// 8. Test SearchStack
            //Stack<int> stack = new Stack<int>(new int[] { 1, 2, 3, 4, 5 });
            //SearchStack(stack, 3); // Expected: Found message
            //SearchStack(stack, 6); // Expected: Not found message
            #endregion

            //#region q9
            //// 9. Test FindIntersection
            //Console.WriteLine(string.Join(", ", FindIntersection(new int[] { 1, 2, 3, 4, 4 }, new int[] { 10, 4, 4 }))); // Expected: 4, 4
            #endregion
            #region q8
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Push(6);
            //Console.Write("target: ");
            //int target = int.Parse(Console.ReadLine());
            //GetTargetCount(stack, target);
            #endregion
            #region q9
            //List<int> list1 = new List<int> {1,2,3,4,5};
            //List<int> list2 = new List<int> {8,7,6,5 };
            //List<int> intersection = list1.Intersect(list2).ToList();
            //Console.WriteLine(string.Join(",", intersection));
            #endregion
            #region q10
            //404NotFound
            #endregion
            #region q11
            //Queue<int> queue = new Queue<int>([1, 2, 3, 4, 5, 6]);
            //Queue<int> reversed = ReverseTargetElements(queue, 3);
            //Console.WriteLine(string.Join(", ", reversed));
            #endregion

        }

        #region q1
        //static int ReturnGreaterNumber(int[] arr, int x)
        //{
        //    int count = 0;
        //    foreach (var num in arr)
        //    {
        //        if (num > x) count++;
        //    }
        //    return count;
        //}
        #endregion
        #region q2
        //static bool IsPalindrome(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length / 2; i++)
        //    {
        //        if (arr[i] != arr[arr.Length - 1 - i])
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        #endregion
        #region q3
        //static Queue<int> ReverseQueue(Queue<int> queue)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    while (queue.Count > 0) stack.Push(queue.Dequeue());
        //    while (stack.Count > 0) queue.Enqueue(stack.Pop());
        //    return queue;
        //}
        #endregion
        #region q4
        //static string IsBalanced(string input)
        //{
        //    Dictionary<char, int> parentheses= new Dictionary<char, int>
        //{
        //    { '(', 0 },
        //    { ')', 0 },
        //    { '{', 0 },
        //    { '}', 0 },
        //    { '[', 0 },
        //    { ']', 0 }
        //};
        //    foreach (char ch in input)
        //    {
        //        if (ch == '(' || ch == '{' || ch == '[')
        //        {
        //            parentheses[ch]++;
        //        }
        //        else if (ch == ')' || ch == '}' || ch == ']')
        //        {
        //            if (ch == ')' && parentheses['('] == 0)
        //                return "Unbalanced";
        //            if (ch == '}' && parentheses['{'] == 0)
        //                return "Unbalanced";
        //            if (ch == ']' && parentheses['['] == 0)
        //                return "Unbalanced";

        //            parentheses[ch]++;
        //        }
        //    }
        //    if (parentheses['('] == parentheses[')'] &&
        //        parentheses['{'] == parentheses['}'] &&
        //        parentheses['['] == parentheses[']'])
        //    {
        //        return "Balanced";
        //    }

        //    return "Unbalanced";
        //}
        #endregion
        #region q5
        //static int[] RemoveDuplicates(int[] arr)
        //{
        //    HashSet<int> set = new HashSet<int>(arr);
        //    return new List<int>(set).ToArray();
        //}

        #endregion
        #region q6
        //static List<int> RemoveOddNumbers(List<int> list)
        //{
        //    list.RemoveAll(num => num % 2 != 0);
        //    return list;
        //}

        #endregion
        #region q7
        //static void QueueDifferentTypes<T>(Queue<T> queue, T data)
        //{
        //    queue.Enqueue(data);
        //}
        #endregion
        #region q8
        //static void GetTargetCount(Stack<int> stack, int target)
        //{
        //    int count = 0;

        //    Stack<int> targetCount = new Stack<int>(stack);

        //    while (targetCount.Count > 0)
        //    {
        //        count++;
        //        int num = targetCount.Pop();

        //        if (num == target)
        //        {
        //            Console.WriteLine($"founded, count is = {count}");
        //            return;
        //        }
        //    }
        //             Console.WriteLine("Target not founded");
        //}
        #endregion
        #region q10
        //404NotFound
        #endregion
        #region q11
        //static Queue<int> ReverseTargetElements(Queue<int> queue, int k)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    List<int> list = new List<int>();
        //    for (int i = 0; i < k; i++)
        //        stack.Push(queue.Dequeue());
        //    while (stack.Count > 0) list.Add(stack.Pop());
        //    while (queue.Count > 0) list.Add(queue.Dequeue());
        //    return new Queue<int>(list);
        //}
        #endregion
    }

}
