using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Threading.Channels;

namespace _3day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");



            //小明择偶标准：要么资产在300w以上，要么颜值大于9.5。输入小红的资产和颜值
            //刘小健 10:03:17(多人发送)
            //小红想做车模，车模条件年龄16~22

            //Console.WriteLine("请输入年龄");
            //int age = int.Parse(Console.ReadLine());
            //bool res = age > 16 && age < 22;
            //Console.WriteLine(res);


            //Console.WriteLine("请输入资产");
            //int money = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入颜值");
            //double yanzhi = double.Parse(Console.ReadLine());
            //bool resl = money > 3000000 || yanzhi > 9.5;
            //Console.WriteLine(resl);

            //Console.WriteLine("请输入年龄");
            //int age = int.Parse(Console.ReadLine());
            //bool res = age > 15 && age < 25;
            //Console.WriteLine(res);

            //Console.WriteLine("请输入存款");
            //int money = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入颜值");
            //double yanzhi = double.Parse(Console.ReadLine());
            //bool resl = money > 3000000 || yanzhi > 9.5;
            //Console.WriteLine(resl);

            //作业要求（0~100）：<60,不及格，<80,及格，<90,良好，<100,优秀
            //Console.WriteLine("输入考试成绩（0~100）：");
            //double score = double.Parse(Console.ReadLine());
            //if (score < 60)
            //{
            //    Console.WriteLine("不及格");



            //}
            //else if (score < 80)
            //{
            //    Console.WriteLine("及格");



            //}
            //else if (score < 90)
            //{
            //    Console.WriteLine("良好");


            //}
            //else if (score <= 100)
            //{
            //    Console.WriteLine("优秀");
            //}

            //else { Console.WriteLine("请重新输入（0~100）数字"); }

            //作业2

            //刘小健 14:57:19(多人发送)
            // 输入分数 1~100
            // 判断等级输出
            // 分数90~100  输出A ===> 分数的十位9 / 10
            // 分数80~90   输出B ===> 分数的十位8
            // 分数70~80   输出C ===> 分数的十位7
            // 分数60~70   输出D ===> 分数的十位6
            // 分数1~60    输出F ===> 分数的十位0 / 1 / 2 / 3 / 4 / 5

            //Console.WriteLine("请输入分数（1~100）：");
            //int score = int.Parse(Console.ReadLine());
            //if (score>0 && score<=100)
            //{int n=score/10;

            //    switch (n)
            //    {
            //     case 0: Console.WriteLine($"分数是{score}等级是F"); break;
            //     case 1: Console.WriteLine($"分数是{score}等级是F"); break;
            //     case 2: Console.WriteLine($"分数是{score}等级是F"); break;
            //     case 3: Console.WriteLine($"分数是{score}等级是F"); break;
            //     case 4: Console.WriteLine($"分数是{score}等级是F"); break;
            //     case 5: Console.WriteLine($"分数是{score}等级是F"); break;
            //     case 6: Console.WriteLine($"分数是{score}等级是D"); break;
            //     case 7: Console.WriteLine($"分数是{score}等级是C"); break;
            //     case 8: Console.WriteLine($"分数是{score}等级是B"); break;
            //     case 9: Console.WriteLine($"分数是{score}等级是A"); break;
            //     case 10: Console.WriteLine($"分数是{score}等级是A");break;
            //    }




            //}
            //else { Console.WriteLine($"请重新输入范围的值"); }


            // 输入分数 1~100
            // 判断等级输出
            // 分数90~100  输出A ===> 分数的十位9 / 10
            // 分数80~90   输出B ===> 分数的十位8
            // 分数70~80   输出C ===> 分数的十位7
            // 分数60~70   输出D ===> 分数的十位6
            // 分数1~60    输出F ===> 分数的十位0 / 1 / 2 / 3 / 4 / 5


            //Console.WriteLine("请从新输入1~7");
            //int n = int.Parse(Console.ReadLine());
            //switch (n)
            //{
            //case 1:Console.WriteLine("星期一"); break;
            //case 2: Console.WriteLine("星期二"); break;  
            //case 3: Console.WriteLine("星期三"); break;

            //  case 4: Console.WriteLine("星期四"); break;
            //        case 5: Console.WriteLine("星期五"); break;
            //        case 6:
            //    case 7: Console.WriteLine("周末"); break;


            //    default: Console.WriteLine("输入有误"); break;

            //}

            //Console.WriteLine("请输入（1~7）");
            //int c = int.Parse(Console.ReadLine());
            //switch (c)
            //{
            //    case 1: Console.WriteLine("星期一"); break;
            //    case 2: Console.WriteLine("星期二"); break;
            //    case 3: Console.WriteLine("星期三"); break;
            //    case 4: Console.WriteLine("星期四"); break;
            //    case 5: Console.WriteLine("星期五"); break;
            //    case 6:
            //    case 7: Console.WriteLine("周末"); break;
            //    default:
            //        Console.WriteLine("输入有误"); break;
            //}


            //Console.WriteLine("成绩（0~100）");
            //double score = double.Parse(Console.ReadLine());
            //if (score > 0 && score <= 100)
            //{
            //    string sun = score switch
            //    {
            //        >= 90 => "A",
            //        >= 80 => "B",
            //        >= 70 => "C",
            //        >= 60 => "D",
            //        _ => "F"

            //    };

            //    Console.WriteLine(sun);

            //}
            //    else 
            //    {
            //    Console.WriteLine("请重新输入范围的值");




            ////     }
            //Console.WriteLine("请输入年龄：");
            //int sun=int.Parse(Console.ReadLine());
            //string result = sun>18? "成年" : "未成年";

























        }
    }
}
