using System;

namespace DP {
    #region
    /*
    模板方法模式提供代码复用平台，通过把不变行为搬到超类，去除子类中的重复代码。
     */
    #endregion
    class TestPaper {
        public void Question1 () {
            Console.WriteLine ("杨过得到，后来给了郭靖，炼成了倚天剑、屠龙刀的玄铁可能是【】 a.球磨铸铁 b.马口铁 c.高速合金钢 d.碳素纤维");
            Console.WriteLine ("答案：【{0}】", Answer1 ());
        }
        protected virtual string Answer1 () {
            return "";
        }
        public void Question2 () {
            Console.WriteLine ("杨过、程英、陆无双铲除无情花，造成【】 a.使这种植物不再害人 b.使一种珍惜物种灭绝 c.破坏了那个生物圈的生态平衡 d.造成该地区沙漠化");
            Console.WriteLine ("答案：【{0}】", Answer2 ());
        }
        protected virtual string Answer2 () {
            return "";
        }
        public void Question3 () {
            Console.WriteLine ("蓝凤凰致使华山师徒、桃谷六仙呕吐不止，如果你是大夫，会给他们开什么药【】 a.阿司匹林 b.牛黄解毒片 c.氟哌酸 d.让他们和大量的牛奶 e.以上全不对");
            Console.WriteLine ("答案：【{0}】", Answer3 ());
        }
        protected virtual string Answer3 () {
            return "";
        }
    }

    class TestPaperA : TestPaper {
        protected override string Answer1 () {
            return "b";
        }
        protected override string Answer2 () {
            return "c";
        }
        protected override string Answer3 () {
            return "a";
        }
    }

    class TestPaperB : TestPaper {
        protected override string Answer1 () {
            return "c";
        }
        protected override string Answer2 () {
            return "a";
        }
        protected override string Answer3 () {
            return "a";
        }
    }
}