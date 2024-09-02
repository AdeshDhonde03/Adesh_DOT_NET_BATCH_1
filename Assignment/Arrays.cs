using System;
namespace Array
{
    class Arrays{
        int[] arr;
        int index;
        public const int MAX_ARR=10;
        const int ExpandMultiply=2;
    
    public Arrays(){
        index=0;
        arr=new int[MAX_ARR];
    }
    public void Add(int data){
        if(index>=arr.Length)
        {
            Expand();
        }
        
         arr[index]=data;
         index++;
        
    }
    public void remove(int data)
    {
        int Location=indexof(data);
        if(Location==-1)
        {
            return;
        }
        arr[Location]=arr[index-1];
        index--;
    }
    public void Print()
    {
        for(int i=0;i<index;i++)
        {
            Console.Write("["+arr[i] +"]");
        }
        Console.WriteLine();
    }
    public int indexof(int data)
    {
        for(int i=0;i<index;i++)
        {
            if(arr[i]==data)
                return i;

        }
        return -1;
    }

    }
    private void Expand(){
        int[] newItem=new int[arr.Length*ExpandMultiply];
        for(int i=0;i<arr.Length;i++)
        {
            newItem[i]=Item[i];
        }
        Item=newItem;
    }
    
}