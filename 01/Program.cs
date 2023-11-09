using Animal;
public class Program
{
    static void Main(string[] args)
    {
        new Dog().Print();
        new Cat().Print();
    }
}

//C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe
/*
csc *.cs 
csc /out:Program.exe Program.cs Cat.cs Dog.cs 
*/