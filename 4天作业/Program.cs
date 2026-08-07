using System;
using System.Threading.Channels;

namespace _4day随堂练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //int sun = 0;
            //while (i <= 10)
            //{
            //    sun = sun + i;
            //    i++;



            //}
            //Console.WriteLine(sun);
            //int i = 1;
            //int sun= 0;
            //while (i <= 10) 
            //{
            // sun=sun+i;
            //    i++;
            //}
            //Console.WriteLine(sun);
            //Console.WriteLine(i);
            //一到五乘机
            //int i = 1;
            //int ji = 1;
            //while (i<=5) 
            //{
            //    ji = ji * i;
            //    i++;
            //}
            //Console.WriteLine(ji);
            //利用while输出1~5
            //int i = 1;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.WriteLine($"i =>{i}");
            //将1 - 10相加
            //int i = 1;
            //将1 - 30之间的奇数加起来
            //int i = 1;
            //int h = 0;
            //while (i < 30) 
            //{       
            //    if (i % 2 != 0 && i%3 ==0)
            //    {
            //        h = h + i;

            //    }

            //    i++;
            //}
            //Console.WriteLine(h);
            //出50以内所有能被3整除且能被5整除的数字
            //int i = 1; int j = 2;
            //while (i < 50) 
            //{
            //    if (i % 3 == 0 && i % 5 == 0) 
            //    {
            //        j = j + i;
            //        //Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //Console.WriteLine(j);
            ////Console.WriteLine(i);

            //1 - 5相乘
            //int i = 1;
            //逢7就过的游戏中，100以内所有喊过的数字
            //int i = 1;
            //while (i < 100) 
            //{
            //    if (i % 7 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //求100~1000之间所有的水仙花数
            //int i = 100;
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i<=5);

            //for (int i=1;i<=5 ;i++ ) 
            //{
            //    Console.WriteLine(i);
            //}

            //输出1 - 10之间的偶数

            //for (int i=2;i<=10 ;i+=2 ) 
            //{ Console.WriteLine(i); }
            //入职薪水10K，每年涨幅5 %，50年后工资多少？

            //double n = 10;
            //for (int i=1; i<=50;i++ ) 
            //{
            //    n = n * 1.05;

            //}
            //Console.WriteLine( n );
            //List<string> strList = new()
            //List<int> intList = new()
            //{
            //    3,
            //    5,
            //    7,
            //    2,
            //    9
            //};
            //int sum = 0;
            //for (int i = 0; i < 5; i++) 
            //{
            //    sum=sum + intList[i];
            //}
            //Console.WriteLine(sum);
            //List<int> intList = new()
            //int i = 1;
            //int ji = 1; // 累计乘法结果
            //while (i <= 5)
            //{
            //    ji = ji * i;
            //    i++;
            //}
            //Console.WriteLine(ji);
            //遇见7的倍数 就 喊 过
            //int n = 1;
            //int sun = 0;
            //while (n < 100) 
            //{
            //    if (n % 7 != 0) ;
            //    Console.WriteLine(n);
            //    sun = sun + n;
            //    n ++;

            //}
            ////Console.WriteLine(sun);
            //求100~1000之间所有的水仙花数

            //其百位、十位、个位上的数字的 3次方之和 恰好等于这个数本身
            //int i = 100;
            //int sun = 0;
            //while (i < 1000)
            //{
            //    // 判断i是否是水仙花数 ===> 获取i的个十百位数字
            //    int ge = i % 10;
            //    int shi = (i / 10) % 10;
            //    int bai = i / 100;
            //    if (Math.Pow(ge, 3) + Math.Pow(shi, 3) + Math.Pow(bai, 3) == i)
            //    {
            //        Console.WriteLine(i); 
            //    }

            //    i++;
            //}
            //int i = 1;
            //int i = 1;
            //int sun = 0;
            //for (int i=5;i>=1 ;i-- ) 
            //{
            //    Console.WriteLine(i);
            //    sun = sun + i;
            //}
            //Console.WriteLine(sun);
            //for (int i=1;i<=10 ; i++) 
            //{
            //    if(i%2 == 0) 
            //    {
            //        Console.WriteLine(i);

            //    }
            //}
            //入职薪水10K，每年涨幅5 %，50年后工资多少？
            //int i = 1;                                          // 当前年份
            //double n = 10;                                      // 下一年的工资
            //double sun = 0;                                     // 当前年份的到手总工资
            //for (;i<=50 ; i++) 
            //{
            //    sun = sun + n*12;                                  // 当前年份为止拿到手的工资总数
            //    Console.WriteLine(n);
            //    n = n * 1.05;                                   // 下一年的工资
            //    //sun = sun * n * 12;


            //}
            //Console.WriteLine(sun);
            //入职薪水10K，每年涨幅5 %，50年后工资多少？
            //int i = 1;
            //double n = 10;
            //double sun = 0;
            //for (;i<=50 ;i++ )
            //{
            //    sun = sun + n * 12;
            //    n = n * 1.05;

            //}
            //Console.WriteLine(sun);
            //Console.WriteLine(n);
            /// 遍历List：每一个都经历一次
            //List<string> strList = new()
            //{
            //    "aa",
            //    "bb",
            //    "ccc",
            //    "dd",
            //    "eee"
            //};
            //for (int i=0; i<5; i++ ) 
            //{ Console.WriteLine(strList[i]); }
            //List<string> strList = new()
            //{
            //    "aa",
            //    "bb",
            //    "ccc",
            //    "dd",
            //    "eee"
            //};

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(strList[i]);
            ////}
            //List<int> intList = new()
            //{
            //    3,
            //    5,
            //    7,
            //    2,
            //    9
            //};
            //int sun = 0;
            //for (int i=0;i<intList.Count;i++) 
            //{sun += intList[i];

            //}
            //Console.WriteLine(sun);
            //for (var i = 1; i <= 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        break; // 跳过本次循环
            //    }
            //    Console.WriteLine(i);
            //}
            //for (var i = 1; i <= 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        continue; // 跳过本次循环
            //    }
            //    Console.WriteLine(i);
            //}
            //foreach 遍历数组
            //int sun = 0;
            //int[] intArr = { 10, 20, 30, 40 };
            //foreach (int i in intArr) 
            //{
            //    Console.WriteLine(i);
            //    sun =sun + i;
            //Console.WriteLine(sun);
            //foreach 遍历 List集合
            string res = " ";
            //List<string> strList = new List<string>() { "h", "e", "l", "l", "o" };
            //foreach (string str in strList)
            //{
            //    Console.WriteLine(str);
            //    res += str;
            //}
            //Console.WriteLine(res);
            //foreach 遍历字典
            //Dictionary< string, dynamic > userInfo = new Dictionary<string, dynamic>()
            //{
            //    ["name"] = "Tom",
            //    ["age"] = 5,
            //    ["gender"] = 1,
            //    ["hobby"] = "jerry",
            //};
            //foreach (dynamic nm in userInfo) 
            //{
            //    Console.WriteLine(nm);
            //    }
            //输出5行星号，每行5个
            //for (int i = 1; i <= 5; i++)
            //{

            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.WriteLine($"我是第{i}第{j}圈了");

            //    }
            /// 用星号输出直角三角形
            //for (int j = 5; j > 0; j--)    
            //{
            //    //Console.Write(j+ "  ");
            //    for (int i = 1; i <= j; i++) // 内层循环控制了这一行输出的个数(循环次数)
            //    {
            //        Console.Write("*"); // 一行输出的*
            //    }
            //   Console.WriteLine(); // 一行结束 (换行)
            //}





        }
    }
}