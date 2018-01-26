using System;

namespace DP {
    //简单工厂模式
    public class OperationFactory {
        public static Operation CreateOperation (string operater) {
            Operation oper = null;
            switch (operater) {
                case "+":
                    oper = new OperationAdd ();
                    break;
                case "-":
                    oper = new OperationSub ();
                    break;
                case "*":
                    oper = new OperationMul ();
                    break;
                case "/":
                    oper = new OperationDiv ();
                    break;
            }

            return oper;
        }
    }

    public class Operation {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
        public virtual double GetResult () {
            return 0;
        }
    }

    public class OperationAdd : Operation {
        public override double GetResult () {
            return NumberA + NumberB;
        }
    }
    public class OperationSub : Operation {
        public override double GetResult () {
            return NumberA - NumberB;
        }
    }

    public class OperationMul : Operation {
        public override double GetResult () {
            return NumberA * NumberB;
        }
    }

    public class OperationDiv : Operation {
        public override double GetResult () {
            if (NumberB == 0) {
                throw new Exception ("除数不能为0");
            }
            return NumberA / NumberB;
        }
    }

}