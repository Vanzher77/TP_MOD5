// See https://aka.ms/new-console-template for more information
public  class HaloGeneric
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Halo User" + SapaUser(" Vanzher"));
    }
    public static Generic SapaUser <Generic>(Generic a)
    {
        return (dynamic) a;
    }
    

}
