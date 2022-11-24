class Program
{
    static void Main(string[] args)
    {
        Queue<int> a = new Queue<int>();
        while(true) {
            char n = char.Parse(Console.ReadLine());
            if (n == 'L')
            { 
                a.Push(1);
            }
            else if (n == 'M')
            {
                a.Push(2);
            }
            else if (n == 'S')
            {
                a.Push(3);
            }
            else{break;}
        }

        while(a.GetLength()!=0){
            int n = a.Pop();
            Console.Write(n);

            if (n == 1){a.Push(2);a.Push(2);}
            else if (n == 2){a.Push(3);a.Push(3);a.Push(3);}
        }
    }
}