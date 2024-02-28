namespace HR{
    //Super Parent for all classes is Object class
    //Any function which is virtual in base class (super class)
    //can be overrided into derived (sub) or child class


    
    public class Employee
    { 
        //Data Members  
        private  double basic_sal;
        private  double hra;
        private  double da;

        public string BasicSalary{
            get{return basic_sal;}
            set{basic_sal=value;}
        }

        public double HRA{
            get{return hra;}
            set{hra=value;}
        }

        public double DA{
            get{return da;}
            set{da=value;}
        }


        //Constructor chaining: to improve code readability
        public Employee():this(15000,6000,500)
        {  }

        public Employee(double sal, double hra, double da){
            this.basic_sal=sal;
            this.hra=hra;
            this.da=da;
        }

        //Method overrding: Change behaviour of Parent virtual method
        public override string ToString(){
            string str=" basic Salary="+ basic_sal+ ", HRA="+hra+ " Daily Allowance="+da;
            return base.ToString() + str;
        }

        //Any function declared as Virtual can be overrided into child classes
        public virtual double CalculateSalary ()
        {
            return basic_sal + hra+ da;
        }

    }
}


//Each class in .net is inherited from Object Class
//Object class has some methods
//GetType()---------------reflection
//GetHashCode()-----------getting hash code
//Equals()----------------to check equality of two objects of same class
// virtual ToString()--------------converts objects state data into string format

