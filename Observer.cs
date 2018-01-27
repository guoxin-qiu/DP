using System;
using System.Collections.Generic;

namespace DP {
    #region
    /*
    观察者模式又叫发布-订阅（Publish/Subscribe）模式
    观察者模式定义了一种一对多的依赖关系，让多个观察者对象同时监听某一个主题对象。
    这个主题对象在状态发生变化时，会通知所有观察者对象，使它们能够自动更新自己。

    将一个系统分割成一系列相互协作的类，需要维护相关对象的一致性。不希望为了维持一致性
    而使各类紧密耦合，这样会给维护、扩展和重用带来不便。

    当一个对象的改变需要同时改变其他对象，而且不知道有多少对象待改变，应该考虑使用观察者模式。
     */
    #endregion
    interface ISubject {
        void Notify ();
        string SubjectState { get; set; }
    }

    class Boss : ISubject {
        public delegate void EventHandler ();
        public event EventHandler Update;
        public string SubjectState { get; set; }
        public void Notify () {
            Update ();
        }
    }

    class StockObserver {
        private string name;
        private ISubject subject;
        public StockObserver (string name, ISubject sub) {
            this.name = name;
            this.subject = sub;
        }

        public void CloseStockMarket () {
            Console.WriteLine ("{0} {1} 关闭股票行情，继续工作！", subject.SubjectState, name);
        }
    }

    class NBAObserver {
        private string name;
        private ISubject subject;
        public NBAObserver (string name, ISubject sub) {
            this.name = name;
            this.subject = sub;
        }

        public void CloseNBADirectSeeding () {
            Console.WriteLine ("{0} {1} 关闭NBA直播，继续工作！", subject.SubjectState, name);
        }
    }
}