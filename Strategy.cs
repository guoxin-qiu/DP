using System;

namespace DP {
    #region
    /*
    策略模式是一种定义一系列算法的方法，
    从概念上来看，所有这些算法完成的都是相同的工作，只是实现不同，
    它们可以用相同的方式调用所有的算法，减少了各类算法类与使用算法之间的耦合。

    策略模式的Strategy类层次为Context定义了一系列可供重用的算法和行为。
    继承有助于析取这些算法中的公共功能。

    策略模式简化了单元测试，每个算法都有自己的封装，可以通过自己的接口单独测试。

    当不同的行为堆砌在一个类中，就很难避免使用条件语句来选择合适的行为。
    将这些行为封装在一个个独立的Strategy类中，可以在使用这些行为的类中消除条件语句。

    策略模式是用来封装算法的，但在实践过程中，我们发现可以用它来封装几乎任何类型的规则，
    只要在分析过程中听到需要在不同时间应用不同的业务规则，就可以考虑使用策略模式来封装
    这种变化的可能性。

    在基本的策略模式中，选择具体实现的职责由客户端对象承担，并转给策略模式的Context对象。
     */
     #endregion
    class CashContext {
        private CashSuper cashSuper;
        public CashContext (string type) {
            switch (type) {
                case "正价":
                    cashSuper = new CashNormal ();
                    break;
                case "满300减100":
                    cashSuper = new CashReturn (300, 100);
                    break;
                case "8折":
                    cashSuper = new CashRebate (0.8);
                    break;
                default:
                 cashSuper = new CashNormal ();
                    break;
            }
        }
        public double GetResult (double money) {
            return cashSuper.AcceptCash (money);
        }
    }

    abstract class CashSuper {
        //算法方法
        public abstract double AcceptCash (double money);
    }
    class CashNormal : CashSuper {
        public override double AcceptCash (double money) {
            return money;
        }
    }

    class CashRebate : CashSuper {
        private double moneyRebate = 1d;

        public CashRebate (double moneyRebate) {
            this.moneyRebate = moneyRebate;
        }
        public override double AcceptCash (double money) {
            return money * moneyRebate;
        }
    }

    class CashReturn : CashSuper {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;
        public CashReturn (double moneyCondition, double moneyReturn) {
            this.moneyCondition = moneyCondition;
            this.moneyReturn = moneyReturn;
        }

        public override double AcceptCash (double money) {
            double result = money;
            if (money >= moneyCondition) {
                result = money - Math.Floor (money / moneyCondition) * moneyReturn;
            }
            return result;
        }
    }
}