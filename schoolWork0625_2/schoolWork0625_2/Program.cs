using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolWork0625_2
{
    class Program
    {
        static int[] arr = { 10, 20, 43, 54, 22, 19, 23, 3, 23, 20, 666, 77, 88, 200, 43 };
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.Text1(arr);
            //program.Text1_1();
            //program.Text1_2();
            //program.Text2(arr);
            //program.Text2_1();
            //program.Text3(arr);
            //program.Text3_1();
            //program.Text4();
            //program.Text4_1();
            //program.Text4_2();
            //program.Text5();
            //program.Text6();
            //program.Text7();
            program.Text8();

        }
        //输出原数组的元素
        public void printOld()
        {
            Console.Write("原始数组：  ");
            for(int i = 0; i < arr.Length; ++i)
            {
                Console.Write(" "+arr[i]);
            }
            Console.WriteLine();
        }
        //输出更新之后的数组
        public void PrintArray(int[] arr)
        {
            if (arr == Program.arr)
            {
                Console.Write("原始数组：  ");
            }
            else
            {
                Console.Write("更新数组：  ");
            }
            
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();

        }
        //返回该数组中，有多少个素数
        public void Text1(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; ++i)
            {
                int j = 2;
                for (; j < arr[i]; ++j)
                {
                    if (arr[i] % j == 0)
                    {
                        break;
                    }
                }
                if (arr[i] == j)
                {
                    sum++;
                }
            }
            Console.WriteLine("素数个数为："+sum);
        }

        public void Text1_1()
        {
            int sum = 0;
            bool flag = true;
            for(int i = 0; i < arr.Length; ++i)
            {
                int j = 2;
                for (; j < arr[i]; ++j)
                {
                    if (arr[i] % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.Write(" "+arr[i]);
                    sum++;                    
                }
                flag = true;
               
            }
            Console.WriteLine();
            Console.Write("  "+sum);
        }

        public void Text1_2()
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; ++i)
            {
                bool flag = true;
                int j = 2;
                for (; j < arr[i]; ++j)
                {
                    if (arr[i] % j == 0)
                    {
                        flag = false;
                        break;
                    }                    
                }
                if (flag)
                {
                    Console.Write("  "+arr[i]);
                    sum++;
                }
            }
            Console.WriteLine("\n sum = "+sum);
        }

        //数组中，有多少个重数,(注意：当有三个及以上的相同的元素时，就会出现重复计数的可能)
        //1.(目前指的是：数组中重复的数据)
        //2. 一个数字所有位的数字都相同 
        /*
         描述

        所谓众数，就是对于给定的含有N个元素的多重集合，每个元素在S中出现次数最多的成为该元素的重数，
        多重集合S重的重数最大的元素成为众数。例如：S={1,2,2,2,3,5}，则多重集S的众数是2，其重数为3。
             */
        //1.(目前指的是：数组中重复的数据)测试三个及以上的相同的元素时，这样也是没有问题的
        public void Text2(int[] arr)
        {
            PrintArray(arr);
            int sum = 0;
            int index = -1;
            int[] saveArr =new int[arr.Length];
            for(int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine(saveArr.Contains(arr[i]));
                if (!saveArr.Contains(arr[i]))
                {
                    for (int j = i + 1; j < arr.Length; ++j)
                    {
                        if (arr[i] == arr[j])
                        {
                            saveArr[++index] = arr[i];
                            sum++;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("重数个数为："+sum);
        }
        //2. 一个数字所有位的数字都相同 
        public void Text2_1() 
        {
            PrintArray(arr);
            int sum = 0;
            int temp = 0;
            int gw = 0;
            for(int i=0;i<arr.Length;++i)
            {
                gw = arr[i] % 10;
                temp = arr[i] / 10;
                //Console.WriteLine("----------------");
                while(true)
                {
                    if (gw != 0)
                    {
                        if (gw == temp)
                        {
                            sum++;
                            //Console.WriteLine("sum===========" + sum);
                            break;
                        }
                        if (gw != temp % 10)
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                    temp = temp / 10;
                }
                
            }
            Console.WriteLine("sum="+sum);
        }

        //数组中，最小值及最大值，及其所对应的下标
        public void Text3(int[] arr)
        {
            this.printOld();
            int maxValue = 0, minValue = 0;
            int maxIndex = 0, minIndex = 0;

            maxValue = minValue = arr[0];
            for(int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                    maxIndex = i;
                }
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                    minIndex = i;
                }
            }
            Console.WriteLine("最大值："+maxValue+"，下标为："+maxIndex);
            Console.WriteLine("最小值："+minValue + "，下标为：" +minIndex);
        }

        public void Text3_1()
        {
            printOld();
            int maxIndex = 0, minIndex = 0;
            int maxValue = 0, minValue = 0;
            for(int i = 1; i < arr.Length; ++i)
            {
                if (arr[maxIndex] < arr[i])
                {
                    maxIndex = i;
                    
                }
                if (arr[minIndex] > arr[i])
                {
                    minIndex = i;
                }
            }
            maxValue = arr[maxIndex];
            minValue = arr[minIndex];
            Console.WriteLine("maxValue=" + maxValue + ", maxIndex=" + maxIndex);
            Console.WriteLine("minValue=" + minValue + ", minIndex=" + minIndex);
        }


        //在数组中指定的位置插入一个值
        //int index=2;int value=222;插入的下标和值，
        //1. 数组的长度不改变，2. 插入后数组长度有改变

        public void Text4()
        {
            this.printOld();
            int[] arr = { 10, 20, 43, 54, 22, 19, 23, 3, 23, 20, 666, 77, 88, 200, 43 };
            int[] myArr=new int[arr.Length+1] ;
            
            int index = 2;
            int value = 222;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (i < index)
                {
                    myArr[i] = arr[i];
                }                
                else
                {
                    myArr[index] = value;
                    myArr[i + 1] = arr[i];
                }
                
            }
            for(int j = 0; j < myArr.Length; ++j)
            {
                Console.Write(" "+myArr[j]);
            }          
            
        }

        public void Text4_1()
        {
            //使用先新建，后赋值，在后移的方式
            int index = 2;
            int value = 222;
            int[] newArr = new int[arr.Length + 1];
            for(int i = 0; i < arr.Length; ++i)
            {
                newArr[i] = arr[i];
            }
            for(int j = newArr.Length - 1; j > index; --j)
            {
                newArr[j] = newArr[j - 1];//后移

            }
            newArr[index] = value;
            PrintArray(arr);
            PrintArray(newArr);
        }

        public void Text4_2()
        {
            //使用所谓的拼接操作来进行插入：分段赋值。不过前提也是要创建一个新数组。
            int index = 2;
            int value = 222;
            int[] newArr = new int[arr.Length + 1];

            for(int i = 0; i < index; ++i)
            {
                newArr[i] = arr[i];
            }
            for(int i = index; i < arr.Length; ++i)
            {
                newArr[i + 1] = arr[i];
            }
            newArr[index] = value;
            PrintArray(arr);
            PrintArray(newArr);

        }

        //删除了数组中的指定的值int value=666；删除一次就可以了，
        //如果有多个666，也只需要删除一次，后面的不用管。删除后，数组长度要有改变
        public void Text5()
        {
            int[] arr = { 10, 20, 43, 54, 22, 19, 23, 3, 23, 20, 666, 77, 88, 200, 43 };
            int[] newArr= new int[arr.Length-1];
            int value = 666;
            int index = 0;
            for(int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == value)
                {
                    index = i;
                    break;
                }
              
            }
            for(int j = 0; j < arr.Length; ++j)
            {
                if (j < index)
                {
                    newArr[j] = arr[j];
                }
                else
                {
                    if(j!=arr.Length-1)
                    newArr[j] = arr[j+1];
                }                
            }
            for(int k = 0; k < newArr.Length; ++k)
            {
                Console.Write(" "+newArr[k]);
            }
        }

        //删除数组中指定下标的值，int index=3；删除后数组的长度要有改变
        public void Text6()
        {
            this.printOld();
            int[] arr = { 10, 20, 43, 54, 22, 19, 23, 3, 23, 20, 666, 77, 88, 200, 43 };
            int[] myArr = new int[arr.Length - 1];
            int index = 3;
            for(int i = 0; i < arr.Length; ++i)
            {
                if (i < index)
                {
                    myArr[i] = arr[i];
                }
                else if(i<arr.Length-1)
                {
                    myArr[i] = arr[i + 1];
                }
            }

            for(int j = 0; j < myArr.Length; ++j)
            {
                Console.Write(" "+myArr[j]);
            }
            
            
        }

        //删除数组中指定的某一段值，从指定下标删除到指定的下标，int sindex=2;int eindex=7;
        //从下标2删除到下标7，删除后，数组长度要有改变
        public void Text7()
        {
            this.printOld();
            int startIndex = 2, endIndex = 7;
            int deletSum = endIndex - startIndex + 1;
            int[] arr = { 10, 20, 43, 54, 22, 19, 23, 3, 23, 20, 666, 77, 88, 200, 43 };
            int[] myArr = new int[arr.Length - deletSum];

            for(int i = 0; i < arr.Length; ++i)
            {
                if (i < startIndex)
                {
                    myArr[i] = arr[i];
                }
                else
                {
                    if(i<arr.Length-deletSum)
                    myArr[i] = arr[i + deletSum];
                }
            }
            for (int j = 0; j < myArr.Length; ++j)
            {
                Console.Write(" " + myArr[j]);
            }


        }

        //判断一个数是几位数（不能转成字符串）前提条件：输入一个小于2147483647（2的31次方减掉1）的数
        public void Text8()
        {
            string strN = Console.ReadLine();
            int n = int.Parse(strN);
            int sum = 0;
            if (n != 0)//排除一开始n为0的情况
            {
                while (true)
                {
                    if (n != 0)//排除在运算过程中临时值n为0的情况
                    {
                        sum++;
                    }
                    else
                    {
                        break;
                    }
                    n = n / 10;
                }
            }
            else
            {
                sum++;
            }
            Console.WriteLine("sum="+sum);

            //局限性：判断取整情况太多，不现实，其实也就是类似使用数的范围来判断例如：0-9是一位数...
            /*
            int transN = n / 10;
            if (transN == 0)
            {
                Console.WriteLine(n+"是一个一位数");
            }
            else if (transN > 0 && transN < 10)
            {
                Console.WriteLine(n+"是一个两位数");
            }
            else if (transN > 9 && transN < 100)
            {
                Console.WriteLine(n + "是一个三位数");
            }
            */            
        }
    }
}
