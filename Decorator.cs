using System;

namespace DP {
    class Person {
        private string name;
        public Person () { }
        public Person (string name) {
            this.name = name;
        }

        public virtual void Show () {
            Console.WriteLine ("装扮的{0}", name);
        }
    }

    class Finery : Person {
        protected Person component;

        public void Decorate (Person component) {
            this.component = component;
        }

        public override void Show () {
            if (component != null) {
                component.Show ();
            }
        }
    }

    class TShirts : Finery {
        public override void Show () {
            Console.Write ("大T恤 ");
            base.Show ();
        }
    }

    class BigTrouser : Finery {
        public override void Show () {
            Console.Write ("垮裤 ");
            base.Show ();
        }
    }

    class Sneakers : Finery {
        public override void Show () {
            Console.Write ("球鞋 ");
            base.Show ();
        }
    }

    class BusinessSuit : Finery {
        public override void Show () {
            Console.Write ("西装 ");
            base.Show ();
        }
    }
    class Necktie : Finery {
        public override void Show () {
            Console.Write ("领带 ");
            base.Show ();
        }
    }
    class LeatherShoes : Finery {
        public override void Show () {
            Console.Write ("皮鞋 ");
            base.Show ();
        }
    }
}