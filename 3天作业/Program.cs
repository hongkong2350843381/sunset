using System.Diagnostics;
using System.Threading.Channels;

namespace 第三天复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            //1、条件分支
            // 数学对象
            // Math.PI()
            // Math.Abs()
            // Math.rodund()
            // Math.Ceiling
            // Math.Floor()
            // Math.Max()
            // Math.Min()
            // Math.Pow()
            // Math.Sqrt()
            // 类型推到：var 变量 = 值
            // 任意类型：dynamic 变量 = 值
            // 匿名类：new {键名=键值 }
            // 集合：
            // Dictionay<键名类型，键值类型> 变量名 = new Dictionnay<键名类型，键值类型>（）{ ~~~};
            // Dictionay<键名类型，键值类型> 变量名 = new Dictionay<键名类型，键值类型>（）();
            // 访问
            // 变量名[键名]
            // 修改
            // 变量名[键名] = 值
            // 新增
            // 变量名.Add()
            // 删除
            // 变量名.Remove()
            // 获取数量
            // 变量名.Count
            // 了解
            // 变量名.TyGetvalue(键名，out dynamic val)
            // 清空
            // 变量名.Clear()

            //     数组：固定长的容量，可以存储多个类型的数据
            //           访问修改，通过下标
            //           不可以新增删除
            //     List集合：新增型数组
            //            List<元素类型>
            //            通过下标访问修改
            //     List方法：
            //            Add 向末位新增一个数据
            //            AddRange 向末位新增多和数据
            //            Insert 在指定位置新增一个数据
            //            Remove 删除指定数据
            //            RemoveAt 删除指定下标的数据
            //            RemoveRange 删除指定下标开始的指定数量的数据
            //            Clear 清空集合
            //            IndexOf 获取指定数据的下标（-1）
            //            LastIndexOf 获取指定数据的最后一个下标（-1）
            //            Contains 判断集合中是否包含指定数据
            //            GetRange 获取指定下标开始的指定数量的数据
            //            Reverse 反转集合

            //   2、运算符关系
            //         > >= < <= == !=
            //         也叫比较运算符，关系运算的结果是布尔值
            //         关系运算，比较运算 =====> 运算结果一定是布尔值
            ////         > >= < <= == !=
            //             Console.WriteLine("请输入第一个数字");
            //             int nl =int.Parse(Console.ReadLine());
            //             Console.WriteLine("请输入第二个数字" );
            //             int nll = int.Parse(Console.ReadLine());
            //             bool res = nl > nll;
            //             bool res = nl < nll;
            //             bool res = nl >= nll;
            //             bool res = nl >= nll;
            //             bool res = nl == nll;
            //             bool res = nl != nll;
            //             Console.WriteLine(res);

            //逻辑运算
            //符号：&&  || ！ & |        
            //短路运算和非短路运算区别
            //&&表示并且，连续两个条件，表示两个条件同时成立，整体才算成立。
            //例如：小红想做车模，车模条件年龄16~22岁

            //Console.WriteLine("请输入年龄");
            //int age =int.Parse(Console.ReadLine());
            //bool res = age > 16 && age < 22;
            //Console.WriteLine(res);

            //||表示或者，连接两个条件，表示两个条件就算有一个条件成立，结果则成立
            //例如：小明择偶标准；要么资产在30000以上，要么颜值9.5分以上

            //Console.WriteLine("请输入财产");
            //int moneey =int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入颜值");
            //int yz =int.Parse(Console.ReadLine());
            //bool res = moneey > 300000 || yz > 9.5;
            //Console.WriteLine(res);


            //!取反 true 变false ；false 变 true 
            //bool isman = false;
            //isman = !isman;
            //Console.WriteLine(isman);

            //Console.WriteLine("请输入的年龄");
            //int age = int.Parse(Console.ReadLine());
            //bool res = !(age < 16 || age > 22);
            //Console.WriteLine(res);

            //短路运算
            //`&&`的短路运算：因为并且连接的两个条件，当左边为true的情况时，没有办法得到最终的结果，所以一定会执行右边的条件；当左边为false的时候，已经可以得到最终的结果了，右边的条件就不会执行了
            //int n = 0;
            //int num = 1;
            //bool res = n > num && n < num++;
            // //n > num 执行为false, res就是false;那么 n < num++不会执行
            // bool res = n < num && n > num++;
            //  n<num 执行为true; 此时需要继续执行 n<num++
            ////Console.WriteLine(res);
            //  Console.WriteLine(num); // 2

            //`||`的短路运算：因为或者连接的两个条件，当左边为true的时候，已经可以得到最终的结果了，所以右边的条件就不会去执行了；当左边为false的时候，不能得到最终的结果，才会去执行右边的条件。
            //int n = 0;
            //int num = 1;
            ////bool res = n > num || n < num++;
            ////// n > num 执行为false,需要继续执行 n < num++;
            //bool res = n < num || n < num++;
            ////// n < num 执行为true,不会执行 n < num++;
            //Console.WriteLine(num);
            //Console.WriteLine(res);

            //// &不断路
            //int n = 0;
            //int num = 1;
            //bool res = n > num & n < num++;
            //Console.WriteLine(res);
            //Console.WriteLine(num);


            // |不断路
            //int n = 0;
            //int num = 1;
            //bool res = n < num | n < num++;
            //Console.WriteLine(res);
            //Console.WriteLine(num);

            //分支语句
            //    单分支：双分支
            //    Console.WriteLine("请输入年龄");
            //    int age = int.Parse(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("成年");

            //} else 
            //{
            //    Console.WriteLine("未成年");
            //}
            //案例：输入年份，判断是否是闰年(普通闰年：能被4整除但不能被100整除 / 世纪闰年：可以被400整除)



            //多分支
            //int year = int.Parse(Console.ReadLine());
            //if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            //{
            //    Console.WriteLine($"闰年:{year}");
            //}
            //else
            //{
            //    Console.WriteLine($"{year}不是闰年");
            //}

            //Console.WriteLine("请输入考试成绩(1~100)：");
            //double score = double.Parse(Console.ReadLine());
            //if (score < 60) Console.WriteLine("不及格");
            //else if (score < 80) Console.WriteLine("及格");
            //else if (score < 90) Console.WriteLine("良好");
            //else if (score <= 100) Console.WriteLine("优秀");
            //else Console.WriteLine("请输入正确的分数");

            //int a = 10;
            //int b=20;
            //int c = 30;
            //if (a > b) 
            //{
            //    if (a > c)
            //    {
            //        Console.WriteLine($"最大值就是{a}");
            //        Console.WriteLine($"最大值就是{c}");
            //    }
            //    else
            //    {
            //     if(b > c) 
            //        {
            //            Console.WriteLine($"最大值就是{b}");
            //            Console.WriteLine($"最大值就是{c}");


            //        }

            //    }
            //}

            ////switch分支
            //Console.WriteLine("请输入（1~7）");
            //int n =int.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 1: Console.WriteLine("星期一"); break;
            //    case 2: Console.WriteLine("星期二"); break;
            //    case 3: Console.WriteLine("星期三"); break;
            //    case 4: Console.WriteLine("星期四"); break;
            //    case 5: Console.WriteLine("星期五"); break;
            //    case 6: Console.WriteLine("星期六"); break;
            //    case 7: Console.WriteLine("星期七"); break;
            //        Console.WriteLine(n);
            //}


            ////穿透switch
            //Console.WriteLine("请输入1-7");
            //int n = int.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 1: Console.WriteLine("星期一"); break;
            //    case 2: Console.WriteLine("星期二"); break;
            //    case 3: Console.WriteLine("星期三"); break;
            //    case 4: Console.WriteLine("星期四"); break;
            //    case 5: Console.WriteLine("星期五"); break;
            //    case 6: // 穿透
            //    case 7: Console.WriteLine("周末"); break;
            //    default: Console.WriteLine("输入有误"); break;
            //}


            // 1,3,5,7,8,10,12 31天
            // 2  ===> 28天
            // 4,6,9,11 30天

            //Console.WriteLine("请输入月份：");
            //int y = int.Parse(Console.ReadLine());
            //switch (y) 
            //{ 
            //     case 1:
            //     case 3:
            //    case 5: Console.WriteLine("31天"); break;
            //    case 7: Console.WriteLine("31天"); break;
            //    case 8: Console.WriteLine("31天"); break;
            //    case 10: Console.WriteLine("31天"); break;
            //    case 12: Console.WriteLine("31天"); break;
            //    case 2: Console.WriteLine("28天"); break;
            //    case 9: 
            //    case 4: 
            //    case 6: 
            //    case 11: Console.WriteLine("30天"); break;
            //    default: Console.WriteLine("输入有误"); break;
            //}
            
            //三运运算
            int a = 1;
            int b = 2;
            int max = 0;
            if (a > b) {  max = a; } else { max = b; }
            //Console.WriteLine(max);
            max = a > b ? a : b;
            Console.WriteLine(max);


































        }
    }
}
