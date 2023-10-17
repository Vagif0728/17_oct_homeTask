//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeTask13
//{
//    internal class ListInt
//    {
//        private int[] array = new int[10];
//        public int this[int i]
//        {
//            get
//            {
//                return array[i];
//            }
//            set
//            {
//                array[i] = value;
//            }
//        }

//        public void Add(int[]arr,int num)
//        {
           
//            Array.Resize(ref arr, arr.Length + 1);

//            arr[arr.Length - 1] = num;

//            for (int i = 0; i <arr.Length; i++)
//            {
//                Console.WriteLine(arr[i]);
//            }
           

//        }
//        public void AddRange(params int[] nums) 
//        { 
            
//        }
//        public bool Contains(int [] arr ,int num) 
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i]==num)
//                {
//                    return true;
//                }
                
//            }
//            return false;
//        }

//        public void Sum(int[]arr)
//        {
//            int sum = 0;
//            for (int i = 0; i <arr.Length; i++)
//            {
//              sum+= arr[i];
//            }
//            Console.WriteLine(sum);
//        }


//        public void Remove(ref int [] arr, int num)
//        {

            

//            for (int i =0; i < arr.Length; i++)
//            {
//                if (arr[i] == num)
//                {
//                    arr[arr.Length - 1]=0;

//                    // print the modified array
//                    Console.WriteLine("The modified array is:");
//                    for (int j = 0; j < arr.Length; j++)
//                    {
//                        Console.WriteLine(arr[j] + " ");
//                    }
//                }
                 
//            }

            
            
//        }

//        public int[] Removee(int[] inputArray, int elementToRemove)
//        {
             
            
//                int indexToRemove = Array.IndexOf(inputArray, elementToRemove);
//                //if (indexToRemove < 0)
//                //{
//                //    return inputArray;
//                //}
//                int[] tempArray;
//                 tempArray = new int[inputArray.Length - 1];
//            for (int i = 0; i < inputArray.Length; i++)
//            {
//                if (i == indexToRemove)
//                {
//                    continue;
//                }

//                for (int j = 0; j < inputArray.Length; j++)
//                {
//                    tempArray[j] = inputArray[i];
//                }

                
//            }
//            return tempArray;
//        }

//        public void RemoveRange()
//        {

//        }

//        //public override string ToString(int[]arr)
//        //{
//        //    for (int i = 0; i < arr.Length; i++)
//        //    {
//        //        Console.WriteLine(arr[i]);
//        //    }
//        //    return arr ;
//        //}
//    }
//}
