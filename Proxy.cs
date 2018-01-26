using System;

namespace DP {
    #region 
    /*
    远程代理，为一个对象在不同的地址空间提供局部代表。
    这样可以隐藏一个对象存在于不同地址空间的事实。

    虚拟代理，根据需要创建开销很大的对象。
    通过它来存放实例化需要很长时间的真实对象。

    安全代理，用来控制真是对象访问时的权限。

    智能指引，当调用真实的对象时，代理处理另外一些事。
     */
    #endregion
    class SchoolGirl {
        public string Name { get; private set; }
        public SchoolGirl (string name) {
            Name = name;
        }
    }

    interface GiveGift {
        void GiveDolls ();
        void GiveFlowers ();
        void GiveChocolate ();
    }

    class Pursuit : GiveGift {
        private SchoolGirl schoolGirl;
        public Pursuit (SchoolGirl schoolGirl) {
            this.schoolGirl = schoolGirl;
        }

        public void GiveChocolate () {
            Console.WriteLine ("{0} 送你巧克力", schoolGirl.Name);
        }

        public void GiveDolls () {
            Console.WriteLine ("{0} 送你洋娃娃", schoolGirl.Name);
        }

        public void GiveFlowers () {
            Console.WriteLine ("{0} 送你鲜花", schoolGirl.Name);
        }
    }

    class Proxy : GiveGift {
        Pursuit pursuit;
        public Proxy (SchoolGirl schoolGirl) {
            pursuit = new Pursuit (schoolGirl);
        }

        public void GiveChocolate () {
            pursuit.GiveChocolate ();
        }

        public void GiveDolls () {
            pursuit.GiveDolls ();
        }

        public void GiveFlowers () {
            pursuit.GiveFlowers ();
        }
    }
}