using System;

namespace DP {
    public class Tester {
        public static void ObserverTest () {
            Boss huhansan = new Boss ();
            StockObserver tongshiA = new StockObserver ("A", huhansan);
            NBAObserver tongshiB = new NBAObserver ("B", huhansan);

            huhansan.Update += tongshiA.CloseStockMarket;
            huhansan.Update += tongshiB.CloseNBADirectSeeding;

            huhansan.SubjectState = "我胡汉三回来了";
            huhansan.Notify ();
        }
        public static void TemplateTest () {
            Console.WriteLine ("学生甲抄的试卷：");
            TestPaper studentA = new TestPaperA ();
            studentA.Question1 ();
            studentA.Question2 ();
            studentA.Question3 ();
            Console.WriteLine ("学生乙抄的试卷：");
            TestPaper studentB = new TestPaperB ();
            studentB.Question1 ();
            studentB.Question2 ();
            studentB.Question3 ();
        }

        public static void DecoratorTest () {
            Person xc = new Person ("Little");
            Sneakers sk = new Sneakers ();
            LeatherShoes ls = new LeatherShoes ();
            Necktie tie = new Necktie ();
            BigTrouser bt = new BigTrouser ();
            //When
            sk.Decorate (xc);
            ls.Decorate (sk);
            tie.Decorate (ls);
            bt.Decorate (tie);
            //Then
            bt.Show ();
        }

        public static void PrototypeTest () {
            Resume a = new Resume ("BigBo");
            a.SetPersonalInfo ("Man", 29);
            a.SetWorkExperience ("1998-2000", "xx Company");

            Resume b = (Resume) a.Clone ();
            b.SetWorkExperience ("1998-2006", "xx-xx Company");

            Resume c = (Resume) a.Clone ();
            c.SetWorkExperience ("1998-2003", "xx-xx-xx Company");

            a.Display ();
            b.Display ();
            c.Display ();
        }

        public static void ProxyTest () {
            var girl = new SchoolGirl ("Lucy");
            var proxy = new Proxy (girl);
            //When
            proxy.GiveDolls ();
            proxy.GiveChocolate ();
            proxy.GiveFlowers ();
        }
        public static void SimpleFactoryTest () {
            Operation oper = OperationFactory.CreateOperation ("+");
            oper.NumberA = 3;
            oper.NumberB = 5;
            Console.WriteLine (oper.GetResult ());
        }

        public static void StrategyTest () {
            CashContext cashContext = new CashContext ("满300减100");
            double totalPrice = 0.0d;
            //When
            totalPrice = cashContext.GetResult (960d);
            Console.WriteLine (totalPrice);
        }

    }
}