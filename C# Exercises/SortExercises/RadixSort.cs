using LinkedListsExercises; 

namespace SortExercises
{
    class RadixSort
    {
        public RadixSort()
        { }

        public void Main()
        {
            int[] nums = [325, 224, 785, 564, 156, 462];

            var result = Sort(nums);
            Console.WriteLine($"Result: {String.Join(", ", result)}");
        }

        public int[] Sort(int[] nums)
        {
            //Iteration to sort the last digit
            var firstArray = new SingleLinkedList[10];
            for (int i = 0; i < nums.Length; i++)
            {
                var lastDigital = nums[i] % 10;
                //Console.WriteLine($"Last digital of {nums[i]}: {lastDigital}");

                if (firstArray[lastDigital] == null)
                {
                    firstArray[lastDigital] = new SingleLinkedList();
                    firstArray[lastDigital].InsertBegin(nums[i]);
                }
                else
                {
                    firstArray[lastDigital].InsertEnd(nums[i]);
                }
                //Console.WriteLine($"Linked List {firstArray[lastDigital]}");
                //firstArray[lastDigital].PrintList();
                //Console.WriteLine("------------");
            }

            //Iteration to sort the second digit
            var secondArray = new SingleLinkedList[10];
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == null)
                    continue;

                Node temp = firstArray[i].head;
                //Console.WriteLine($"Node {temp.data}");

                while (temp != null)
                {
                    var secondDigital = (temp.data / 10) % 10;
                    //Console.WriteLine($"Second digital of {temp.data}: {secondDigital}");

                    if (secondArray[secondDigital] == null)
                    {
                        secondArray[secondDigital] = new SingleLinkedList();
                        secondArray[secondDigital].InsertBegin(temp.data);
                    }
                    else
                    {
                        secondArray[secondDigital].InsertEnd(temp.data);
                    }
                    temp = temp.next;

                    //Console.WriteLine($"2° Linked List {secondArray[secondDigital]}");
                    //secondArray[secondDigital].PrintList();
                    //Console.WriteLine("------------");
                }
            }

            //Iteration to sort the third digit        
            var thirdArray = new SingleLinkedList[10];
            for (int i = 0; i < secondArray.Length; i++)
            {
                if (secondArray[i] == null)
                    continue;

                Node temp = secondArray[i].head;
                //Console.WriteLine($"Node {temp.data}");

                while (temp != null)
                {
                    var thirdDigital = (temp.data / 100) % 10;
                    //Console.WriteLine($"Third digital of {temp.data}: {thirdDigital}");

                    if (thirdArray[thirdDigital] == null)
                    {
                        thirdArray[thirdDigital] = new SingleLinkedList();
                        thirdArray[thirdDigital].InsertBegin(temp.data);
                    }
                    else
                    {
                        thirdArray[thirdDigital].InsertEnd(temp.data);
                    }
                    temp = temp.next;

                    //Console.WriteLine($"3° Linked List {thirdArray[thirdDigital]}");
                    //thirdArray[thirdDigital].PrintList();
                    //Console.WriteLine("------------");
                }
            }

            //Last iteration to get the final sorted array
            var result = new int[nums.Length];
            int j = 0;
            for (int i = 0; i < thirdArray.Length; i++)
            {
                if (thirdArray[i] == null)
                    continue;

                Node temp = thirdArray[i].head;
                while (temp != null)
                {
                    result[j++] = temp.data;
                    temp = temp.next;
                }
            }

            return result;
        }
    }
}
