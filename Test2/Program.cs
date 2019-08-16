using NewLife.Caching;
using NewLife.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using XCode.Code;
using XCode.Membership;

namespace Test2
{
    internal class Program
    {
        public class UserInfo
        {
            public string Name { get; set; }
            public string Age { get; set; }
        }

        public class TOKEN
        {
            public List<UserInfo> UserInfos { get; set; }
            public int? UI { get; set; }
            public DateTime? DT { get; set; }
            //public string ? NAME { get; set; }
        }

        private static void Main(string[] args)
        {
            //var squares = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            //var result = squares.Select(c => c * c);
            //foreach (int num in result)
            //{
            //    Console.WriteLine(num);
            //}
            XTrace.UseConsole();

            // 激活FullRedis，否则Redis.Create会得到默认的Redis对象
            FullRedis.Register();

            Test1();

            Console.ReadKey();
            // 启用控制台日志
        }

        private static void Test1()
        {
            var ic = Redis.Create("127.0.0.1:6379", 3);
            ic.Log = XTrace.Log;

            // 简单操作
            Console.WriteLine("共有缓存对象 {0} 个", ic.Count);

            ic.Set("name", "Test");
            Console.WriteLine(ic.Get<String>("name"));
            ic.Set("Zcw", "ZYH");
            Console.WriteLine(ic.Get<string>("Zcw"));

            UserInfo UI = new UserInfo();
            UI.Name = "LLLLL";
            UI.Age = "12";

            ic.Set("MyList", UI);
            var User = ic.Get<UserInfo>("MyList");
            Console.WriteLine(User.Name);
            var list = ic.GetList<UserInfo>("Userlist");

            //ic.Set("time", DateTime.Now, 1);
            //Console.WriteLine(ic.Get<DateTime>("time").ToFullString());
            //Thread.Sleep(1100);
            //Console.WriteLine(ic.Get<DateTime>("time").ToFullString());

            //// 列表
            //var list = ic.GetList<DateTime>("list");
            //list.Add(DateTime.Now);
            //list.Add(DateTime.Now.Date);
            //list.RemoveAt(1);
            //Console.WriteLine(list[list.Count - 1].ToFullString());

            //// 字典
            //var dic = ic.GetDictionary<DateTime>("dic");
            //dic.Add("xxx", DateTime.Now);
            //Console.WriteLine(dic["xxx"].ToFullString());

            // 队列
            var mq = ic.GetQueue<String>("queue");
            mq.Add(new[] { "abc", "g", "e", "m" });
            var arr = mq.Take(3);
            Console.WriteLine(arr.Join(","));

            //// 集合
            //var set = ic.GetSet<String>("sss");
            //set.Add("xx1");
            //set.Add("xx2");
            //set.Add("xx3");
            //Console.WriteLine(set.Count);
            //Console.WriteLine(set.Contains("xx2"));

            //Console.WriteLine("共有缓存对象 {0} 个", ic.Count);
        }
    }
}