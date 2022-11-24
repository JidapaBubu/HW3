0
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
            int a = n.Pop();
            Console.Write(a);

            if (a == 1){a.Push(2);a.Push(2);}
            else if (a == 2){a.Push(3);a.Push(3);a.Push(3);}
        }
    }
}