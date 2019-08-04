using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolWork0626_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //string str = "abcF@123g@ABcd00@55addf@abck";
            //program.PrintString(str);

            //Console.WriteLine("IndexOf="+ program.IndexOf(str, 'g'));
            //Console.WriteLine("IndexOf="+ program.IndexOf(str, 10,'a'));

            //Console.WriteLine("IndexOf="+program.IndexOf(str,"ABc"));
            //Console.WriteLine("IndexOf="+program.IndexOf(str,5,"ABc"));

            //Console.WriteLine("LastIndexOf="+program.LastIndexOf(str,'@'));
            //Console.WriteLine("LastIndexof=" + program.LastIndexOf(str,"ABc"));

            //string str1 = "woaini,zhongguo";
            //string str2 = "woaini,myhome";
            //Console.WriteLine("Equals=" + program.Equals(str1, str2));

            //program.Replace(str,"123","xjyhero");

            //Console.WriteLine("SubString=" + program.SubString(str,5,10));
            //Console.WriteLine("SubString2=" + program.SubString2(str,5,4));

            //Console.WriteLine("ToUpper="+program.ToUpper(str));
            //Console.WriteLine("ToLower="+program.ToLower(str));

            //string myString = "  woaini zhongguo  ";
            //Console.WriteLine("Timer="+program.Timer(myString));

            //Console.WriteLine("Insert=" + program.Insert(str,5,"i love you"));
            //Console.WriteLine("Remove=" + program.Remove(str,5,5));


            //string str1 = ",woaini,zhongguo,nanchang,haha,woyeaini";
            //program.PrintString(str1);
            //Console.WriteLine("Split=");
            //program.PrintStringsz(program.Split(str1, ','));


            //Console.WriteLine(program.SumStr("9999", "999"));

        }
        
        //输出原始字符串
        public void PrintString(string str)
        {
            Console.WriteLine("原始字符串：");
            for(int i = 0; i < str.Length; ++i)
            {
                Console.Write(i+" : "+str[i]+",\t");
                if ((i+1 )% 8 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("原始字符串："+str);
        }


        //1:求指定的字符串，在指定字符串，第一次出现的位置,单字符，用''单引号引起来。
        //int indexOf(string str, char s);
        //        如:int n = indexOf(str, 'g'); 在这里返回g的下标即可。
        public int IndexOf(string str,char s)
        {
            for(int i = 0; i < str.Length; ++i)
            {
                if (str[i] == s)
                {
                    return i;
                }
            }
            return -1;
        }

        //1:求指定的字符串，在指定字符串，从指定的位置开始查找，第一次出现的位置,单字符，用''单引号引起来。
        //int indexOf(string str, int index, char s);
        //        如:int n = indexOf(str,，10, 'a'); 在这里返回g的下标即可。
        public int IndexOf(string str,int index,char s)
        {
            for(int i = index; i < str.Length; ++i)
            {
                if (str[i] == s)
                {
                    return i;
                }
            }
            return -1;
        }

        //2:求指定的字符串，在指定字符串，第一次出现的位置:
        //int indexOf(string str, string s);
        //        如:int n = indexOf(str, "ABc"); 在这里返回A的下标即可。

        public int IndexOf(string str,string s)
        {
            for(int i = 0; i < str.Length; ++i)
            {
                if (str[i] == s[0])
                {
                    int j = 1;
                    int index = i;//避免i在比较的后期发生变化
                    for (; j < s.Length; ++j)
                    {
                        
                        if (str[++index] != s[j])
                        {
                            break;
                        }
                    }
                    if (j == s.Length)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        //1:求指定的字符串，在指定字符串，从指定的位置开始查找，第一次出现的位置,单字符，用''单引号引起来。
        //int indexOf(string str, int index, string s);
        public int IndexOf(string str,int index1,string s)
        {
            for (int i = index1; i < str.Length; ++i)
            {
                if (str[i] == s[0])
                {
                    int j = 1;
                    int index = i;//避免i在比较的后期发生变化
                    for (; j < s.Length; ++j)
                    {

                        if (str[++index] != s[j])
                        {
                            break;
                        }
                    }
                    if (j == s.Length)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }



        //3:求指定的字符，在指定字符串，最后一次出现的位置:
        //int lastIndexOf(string str, char s);
        //        如:int n = indexOf(str, 'a'); 在这里返回g的下标即可。

        public int LastIndexOf(string str,char s)
        {
            for(int i = str.Length - 1; i >= 0; --i)
            {
                if (str[i] == s)
                {
                    return i;
                }
            }            
            return -1;
        }

        //4:求指定的字符串，在指定字符串 ，最后一次出现的位置:
        //int lastIndexOf(string str, char s);
        //        如:int n = indexOf(str, "cd0"); 在这里返回g的下标即可。

        public int LastIndexOf(string str,string s)
        {
            for(int i = str.Length - 1; i >= 0; --i)
            {
                if (str[i] == s[s.Length-1])
                {
                    int j = s.Length-2;
                    for (; j >=0; --j)
                    {
                        if (str[--i] != s[j])//注意这里是--i，反过来的
                        {
                            break;
                        }
                    }
                    if (j == -1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        //5:比较两个字符串的值是否完全一样
        //bool Equals(string str1, string str2);

        public bool Equals(string str1,string str2)
        {
            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; ++i)
                {
                    if (str1[i] != str2[i])
                    {
                        return false;
                    }
                }                
            }
            else
            {
                return false;
            }
            return true;
        }

        //6:把指定的字符串 替换成指定的字符串
        //(考虑一下：如果字符串中含有多个指定替换的子字符串，？？并且如果替换的子字符串中恰好就包含有被替换的子字符串呢？)
        //上面两个问题该如何解决呢？转换成第二次或第n次出现被替换子字符串的index
        //极限情况：aaaaaaaa,该字符串中子串aa出现了几次？4or7？
        //void replace(string str, string oldstr, string newStr);
        //        如： replace(str,"abc",'vvv');//把字符串str中，所有的abc换成,vvv

        public void Replace(string str, string oldStr, string newStr)
        {
            char[] s = new char[str.Length + (newStr.Length - oldStr.Length)];
            int startIndex = this.IndexOf(str, oldStr);
            int endIndex = startIndex + newStr.Length - 1;
            for (int i = 0; i < startIndex; ++i)
            {
                s[i] = str[i];
            }
            for (int j = startIndex; j <= endIndex; ++j)
            {
                s[j] = newStr[j - startIndex];
            }
            for (int k = endIndex + 1; k < s.Length; ++k)
            {
                s[k] = str[k - newStr.Length + oldStr.Length];
            }
            for (int n = 0; n < s.Length; ++n)
            {
                Console.Write("" + s[n]);
            }

        }

        //
        public string Replace_1(string str, string oldStr, string newStr)
        {
            char[] s = new char[str.Length + (newStr.Length - oldStr.Length)];
            string newString = "";
            int startIndex = this.IndexOf(str, oldStr);
            int endIndex = startIndex + newStr.Length - 1;
            for (int i = 0; i < startIndex; ++i)
            {
                s[i] = str[i];
            }
            for (int j = startIndex; j <= endIndex; ++j)
            {
                s[j] = newStr[j - startIndex];
            }
            for (int k = endIndex + 1; k < s.Length; ++k)
            {
                s[k] = str[k - newStr.Length + oldStr.Length];
            }
            for (int n = 0; n < s.Length; ++n)
            {
                newString = newString + s[n];
            }
            return newString;

        }

        //7:截取字符串中，从指定下标位置到结束下标位置的值,返回截取的字符串值
        //string subString(string str, int sindex, int endindex);
        //        如：string st = subString(str, 5, 10);
        public string SubString(string str,int startIndex,int endIndex)
        {
            string returnStr = "";
            for(int i = startIndex; i <= endIndex; ++i)
            {
                returnStr = returnStr+str[i];
            }
            return returnStr;
        }

        //8:截取字符串中从指定位置开始，到指定长度的值
        //string subString(string str, int index, int length);
        //        从下标5开始载，往后载4个.
        //        如：string st2 = subString(str, 5, 4); 则返回"23gA"

        public string SubString2(string str,int index,int length)
        {
            string returnStr = "";
            for(int i = index; i <= index + length; ++i)
            {
                returnStr = returnStr + str[i];
            }
            return returnStr;
        }

        //9:把字符串中，所有小写换成大写,并返回转换后的新值
        //string toUpper(string str);
        //        string newStr = toUpper(str); 返回 ABCF123GABCD0055ADDFABCK

        public string ToUpper(string str)
        {
            string newString="";
            char[] s = new char[str.Length];
            for(int j = 0; j < str.Length; ++j)
            {
                s[j] = str[j];
            }
            for(int i = 0; i < str.Length; ++i)
            {
                if (str[i] >= 97 && str[i] <= 112)
                {
                    //char s =(char)(str[i] - 32);
                    s[i] = (char)(str[i] - 32);
                }
            }
            for(int k = 0; k < s.Length; ++k)
            {
                newString = newString + s[k];
            }
            return newString;
        }

        //10:把字符串中，所有大写换成小写,并返回转换后的新值
        //string toLower(string str);
        //        string newStr = toLower(str); 返回 abcf123gabcd0055addfabck
        public string ToLower(string str)
        {
            string newString = "";
            char[] s = new char[str.Length];
            for (int j = 0; j < str.Length; ++j)
            {
                s[j] = str[j];
            }
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    s[i] = (char)(str[i] + 32);
                }
            }
            for (int k = 0; k < s.Length; ++k)
            {
                newString = newString + s[k];
            }
            return newString;
        }

        //11:删除字符串两边的空格
        //string Timer();
        public string Timer(string myString) 
        {
            int frontIndex = -1;
            int behindIndex = -1;
            for(int i = 0; i < myString.Length; ++i)
            {
                if(myString[i]!=' ')
                {
                    frontIndex = i;
                    break;
                }
            }
            for(int j = myString.Length - 1; j >= 0; --j)
            {
                if(myString[j]!=' ')
                {
                    behindIndex = j;
                    break;
                }
            }
            return this.SubString(myString, frontIndex, behindIndex);
        }

        //12:在字符串指定的位置上插入的一个新的字符串内容
        //string Insert(string str, int index, string insValue);
        public string Insert(string str, int index,string insValue)
        {
            string newString = "";
            char[] s = new char[str.Length+insValue.Length];
            int i = 0;
            for (; i < index; ++i)
            {
                s[i] = str[i];
            }
            for(; i <index + insValue.Length; ++i)
            {
                s[i] = insValue[i-index];
            }
            for (; i < s.Length; ++i)
            {
                s[i] = str[i-insValue.Length];
            }
            for (int k = 0; k < s.Length; ++k)
            {
                newString = newString + s[k];
            }
            return newString;
        }

        //13:删除字符串，从指定的位置开始，往后删除n个
        //string Remove(string str, int startIndex, int Length);
        public string Remove(string str,int startIndex,int Length)
        {
            string newString = "";
            char[] s = new char[str.Length - Length];
            for(int i = 0; i < startIndex ; ++i)
            {
                s[i] = str[i];
            }
            for(int j = startIndex + Length; j < str.Length; ++j)
            {
                s[j - startIndex] = str[j];
            }
            for (int k = 0; k < s.Length; ++k)
            {
                newString = newString + s[k];
            }
            return newString;
        }
        
        //14:将字符串用指定的字符，分割成一个字符串数组,返回一个数组
        //string[] split(string str, char exp);
        public string[] Split(string str,char exp)
        {
            int[] expIndex = new int[str.Length];
            int sum = -1;
            for(int i = 0; i < str.Length; ++i)
            {
                if (str[i] == exp)
                {
                    sum = sum + 1;
                    expIndex[sum] = i;//分隔字符所在的index
                }
            }
            int expGs = sum + 1;
            int splitStringLen = expGs+1;
            string[] splitString = new string[splitStringLen];

            for (int i = 0; i <splitStringLen; ++i)
            {
                //splitString[i] = this.SubString(str, expIndex[i], expIndex[i+1]);
                if (i == 0)
                {
                    splitString[i] = this.SubString(str,0,expIndex[i]-1);
                }
                else
                {
                    if (i == expGs )
                    {
                        splitString[i] = this.SubString(str, expIndex[i-1] + 1, str.Length - 1);
                    }
                    else
                    {
                        splitString[i] = this.SubString(str, expIndex[i - 1] + 1, expIndex[i] - 1);
                    }
                }
            }
            return splitString;
        }
        public void PrintStringsz(string[] strsz) 
        {
            Console.WriteLine();
            for(int i = 0; i < strsz.Length; ++i)
            {
                Console.Write(" "+strsz[i]);
            }
        }


        //字符串转成数值然后相加求和
        //string str1 = "8934923472895029845230432983217348593234";
        //string str2 = "4532340235899045023809234823049820323848";
          //  123456
          //+  78989

        public string SumStr(string str1,string str2)
        {
            int cw = str1.Length - str2.Length;
            if (cw < 0)
            {
                string temp;
                temp = str1;
                str1 = str2;
                str2 = temp;
                cw = -cw;
            }

            int[] str1sz = new int[str1.Length];
            int[] str2sz = new int[str2.Length];
            int jw = 0;
            int[] Sumsz = new int[str1.Length];            

            for(int i = str1.Length-1; i >=0; --i)
            {
                str1sz[i] = str1[i] - 48;
            }
            for(int j = str2.Length - 1; j >= 0; --j)
            {
                str2sz[j] = str2[j] - 48;
            }

            for(int k = str1.Length - 1; k >=cw; --k)
            {
                if (str1sz[k] + str2sz[k-cw]+jw >= 10)
                {
                    Sumsz[k] = str1sz[k] + str2sz[k-cw]+jw - 10;
                    jw = 1;
                }
                else
                {
                    Sumsz[k] = str1sz[k] + str2sz[k-cw]+jw;
                    jw = 0;
                }
            }

            for(int i = cw - 1; i >= 0; --i)
            {
                if (str1sz[i] + jw == 10)
                {
                    if (i == 0)
                    {
                        Sumsz[i] = 10;
                    }
                    else
                    {
                        Sumsz[i] = 0;
                        jw = 1;
                    }
                }
                else
                {
                    Sumsz[i] = str1sz[i] + jw;
                }
            }

            string strSum = "";
            for(int n = 0; n < Sumsz.Length; ++n)
            {
                strSum =strSum+Sumsz[n] ;
            }
            return strSum;
        }
        




    }
}
