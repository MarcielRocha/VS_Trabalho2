namespace OLAMUNDO;

public class Mundo
{

    static void Main(string[] args)
    {
        var terra = new OLAMUNDO.Mundo();
        terra.Mensagem("Olá mundo da Terra");
        terra.Conta(560,780);

    }

    public void Mensagem(string msg)
    {
        Console.WriteLine(msg);
    }

    public void Conta(int a, int b)
    {
        int c = a * b;
        Console.WriteLine(c);
    }
}
