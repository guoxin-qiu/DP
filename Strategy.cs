using System;

namespace DP {
    /*
    策略模式是一种定义一系列算法的方法，
    从概念上来看，所有这些算法完成的都是相同的工作，只是实现不同，
    它们可以用相同的方式调用所有的算法，减少了各类算法类与使用算法之间的耦合。

    策略模式的Strategy类层次为Context定义了一系列可供重用的算法和行为。
    继承有助于析取这些算法中的公共功能。

    策略模式简化了单元测试，每个算法都有自己的封装，可以通过自己的接口单独测试。
     */
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