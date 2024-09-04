using System;
namespace adesh
{
    public class Int
    {
        private
    
        int data;
        
            public Int()
            {
                data=0;
            }
            public Int(int data)
            {
                this.data=data;
            }
            public void setData(int data)
            {
                this.data=data;
            }
            public float ToFloat(int data)
            {
                return(float)(this.data);
            }

            public int Addition(Int a,Int b)
            {
                return(a.data + b.data);
            }
            public int Substraction(Int a,Int b)
            {
                return(a.data- b.data);
            }
            public int Multiplication(Int a,Int b)
            {
                return(a.data * b.data);
            }
    
        
    }

        public class FLOAT
        {
            private
            int data;

            public FLOAT()
            {
                data=0;
            }
            public FLOAT(int data)
            {
                this.data=data;
            }
            public void setData(int data)
            {
                this.data=data;
            }
             public float ToInt(int data)
            {
                return(int)(this.data);
            }
           public float Addition(FLOAT a,FLOAT b)
            {
                return(a.data + b.data);
            }
            public float Substraction(FLOAT a,FLOAT b)
            {
                return (a.data - b.data);
            }
            public float Division(FLOAT a,FLOAT b)
            {
                return(a.data/ b.data);
            }
        }
}    

