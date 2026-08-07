namespace _5daync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, dynamic> dic = new()
            //{
            //    ["name"] = "张三",
            //    ["age"] = 12
            //};
            ////dic.Add("height", 180);
            ////Console.WriteLine(dic["height"]);
            ////dic.Add("name", "李四");
            //dic.Add("tall", 110);
            //Console.WriteLine(dic["tall"]);
            //dic.Add("money", 100000);
            //Console.WriteLine(dic["money"]);
            //Console.WriteLine(dic.ContainsKey("name"));
            //Console.WriteLine(dic.ContainsKey("wang"));
            //Console.WriteLine(dic.ContainsValue("张三"));
            //Console.WriteLine(dic.ContainsValue("100000"));
            //dic.Remove("age");
            //foreach (var item in dic) 
            //    Console.WriteLine(item);
            //Console.WriteLine(dic.Count);



            //var strongs = dic.Values;
            ////Console.WriteLine(dicKyes);
            ////string[] keyArr = dicKyes.ToArray(); // 将键集合转为数组
            ////foreach (string key in keyArr) Console.WriteLine(key);
            //List<string> keylist = strongs.ToList(); // 将键集合转为list集合
            //foreach (string key in keylist) Console.WriteLine(key);

            //var dicKyes = dic.Keys;
            //Console.WriteLine(dicKyes);
            //string[] keyArr = dicKyes.ToArray();
            //foreach (string key in keyArr) Console.WriteLine(key);
            //List<string> see = dicKyes.ToList();
            //foreach (string key in see) Console.WriteLine(key);
            //var see = dic.Keys;
            ////String[] n = dic.Keys.ToArray();
            ////foreach (var key in n) 
            ////{
            ////    Console.WriteLine(key);
            ////}
            //List <string> sun = dic.Keys.ToList();
            //foreach (string key in sun) 
            //{
            //    Console.WriteLine(key);
            //}
            //var see=dic.Values.ToList();
            //List<dynamic> sun= see.ToList();
            //foreach(dynamic uu in sun) 
            //{
            //    Console.WriteLine(uu);
            //}
            //var sss = dic.Values; // 获取所有字典中 键值 的集合
            //dynamic[] valArr = sss.ToArray(); // 将键值集合转为数组
            //foreach (dynamic val in valArr) Console.WriteLine(val);

            //List<dynamic> sun= sss.ToList();
            //foreach(dynamic s in sun) 
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine(dic.TryAdd("gender", true)); // 添加成功则返回True
            //Console.WriteLine(dic.TryAdd("name", "adsa")); // 添加失败则返回False
            ////foreach (dynamic item in dic) Console.WriteLine(item);
            //Console.WriteLine(dic.TryAdd("ma", "ture"));
            //Console.WriteLine(dic.TryAdd("nan",18));
            //foreach (var item in dic) 
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (dynamic item in dic)
            //{
            //    //Console.WriteLine(item);
            //    //Console.WriteLine(item.Key);
            //    //Console.WriteLine(item.Value);
            ////}
            //foreach (var n in dic.Keys)
            //{
            //    Console.WriteLine(n);
            //}
            //foreach(var c in dic.Values) 
            //{
            //    Console.WriteLine(c);
            ////}
            //foreach (dynamic item in dic.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //Dictionary<dynamic, dynamic> c = new()
            //{
            //    ["sun"]="哈哈"
            //    ["mun"] = 12

            //};
            //List<int> ints = [1, 3, 3, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //for (int i = 0; i < ints.Count; i++)
            //{
            //    int j = ints.LastIndexOf(ints[i]);
            //    while (j != i) 
            //    {ints.RemoveAt(j);

            //    j = ints.LastIndexOf(ints[i]);
            //     }


            //}
            //foreach (int i in ints) 
            //{
            //    Console.WriteLine(i);
            //}
            //[1, 3, 3, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            // List <int> ints= [1, 3, 3, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //for (int i = 0; i < ints.Count; i++)
            //{
            //    int j = ints.LastIndexOf(ints[i]);
            //    while (j != i) 
            //    { 
            //    ints.RemoveAt(i);
            //    j = ints.LastIndexOf(ints[i]);
            //    }
            //}foreach (int i in ints) 
            //{
            //    Console.WriteLine(i);

            //}
            //List<int> ints = [1, 3, 4,5,2,6,8,9,7];
            //for (int i = 0; i < ints.Count-1; i++)
            //{
            //    for (int j = 0; j < ints.Count-1-i; j++) 
            //    if(ints[j] > ints[j+1])
            //    {
            //     int tmp = ints[j];
            //     ints[j] = ints[j + 1];
            //     ints[j+1] = tmp;

            //    }
            //}
            //foreach (int s in ints) 
            //{
            //    Console.WriteLine(s);
            //}















            //List<int> ints= [1, 3, 4, 5, 2, 6, 8, 9, 7];
            //for (int k = 0; k < ints.Count-1; k++)

            //{

            //    for (int i = 0; i < ints.Count - 1-k; i++)
            //        if (ints[i] > ints[i + 1])
            //        {
            //            int op = ints[i];
            //            ints[i] = ints[i + 1];
            //            ints[i + 1] = op;
            //        }

            //}
            //foreach (int c in ints) 
            //{
            //    Console.WriteLine(c);
            //}
            List<int> ints = [1, 3, 4, 5, 2, 6, 8, 9, 7];
            for (int i = ints.Count - 1; i > 0; i--)
            {
                for (int b = 0; b < i; b++)
                {
                    if (ints[b] > ints[b+ 1])
                    {
                        int tpm = ints[b];
                        ints[b] = ints[b + 1];
                        ints[b + 1] = tpm;

                    }
                }

            }
            foreach(int item in ints) 
            {
                Console.WriteLine(item);
            }
            
        }
    }      
}
