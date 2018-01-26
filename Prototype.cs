using System;

namespace DP {
    class Resume : ICloneable {
        private string name { get; set; }
        private string sex { get; set; }
        private int age { get; set; }
        private string timeArea { get; set; }
        private string company { get; set; }

        private WorkExperience work;

        public Resume (string name) {
            this.name = name;
            this.work = new WorkExperience ();
        }

        private Resume (WorkExperience work) {
            this.work = (WorkExperience) work.Clone ();
        }

        public void SetPersonalInfo (string sex, int age) {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience (string workDate, string company) {
            work.WorkDate = workDate;
            work.Company = company;
        }

        public void Display () {
            Console.WriteLine ("{0} {1} {2}", name, sex, age);
            Console.WriteLine ("工作经历：{0} {1}", work.WorkDate, work.Company);
        }

        public object Clone () {
            Resume obj = new Resume (this.work);
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;
            return obj;
        }
    }

    class WorkExperience : ICloneable {
        public string WorkDate { get; set; }
        public string Company { get; set; }

        public object Clone () {
            return (Object) this.MemberwiseClone ();
        }
    }
}