public class Program
{
    enum State { Terkunci, Terbuka };
    public static void Main()
    {
        State state = State.Terkunci;
        String[] output = { "Pintu terkunci", "Pintu tidak terkunci" };
        while (true)
        {
            Console.WriteLine(output[(int)state]);
            Console.Write("Enter Command : ");

            string command = Console.ReadLine();
            switch (state)
            {
                case State.Terkunci:
                    if (command == "KunciPintu")
                        state = State.Terkunci;
                        
                    else if (command == "BukaPintu")
                        state = State.Terbuka;
                    else
                        state = State.Terkunci;
                    break;
                case State.Terbuka:
                    
                     if (command == "BukaPintu")
                        state = State.Terbuka;
                    else if (command == "KunciPintu")
                        state = State.Terkunci;
                    else
                        state = State.Terbuka;
                    break;

            }
        }
    }
}
