using System;
using Array;
class Arra{
    public static void Main(){
        Arrays arr=new Arrays();

        for(int i=0;i<Arrays.MAX_ARR;i++)
        {
            arr.Add(i);
        }
        arr.Print();
        arr.remove(5);
        arr.remove(6);
        arr.Print();

    }
    

}
