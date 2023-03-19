// See https://aka.ms/new-console-template for more information
<<<<<<< HEAD
using System.Security.Cryptography.X509Certificates;
public class program
{
    public static void Main(string[] args)
    {
        //DataGeneric menggunakan generic bertipe integer karena menggunakan angka dalam menginput data
        DataGeneric<int> dat = new DataGeneric<int>(1302213058);
        dat.printData();
    }

}


//class DataGeneric menggunakan Generic T 
class DataGeneric<T>
{
    //mendefinisikan generic T dengan variable Data
    private T Data;

    public DataGeneric(T Data)
    {
        this.Data = Data;
    }
    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + Data);
    }
}
=======
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
>>>>>>> generic-method
