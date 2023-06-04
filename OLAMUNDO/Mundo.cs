namespace OLAMUNDO;

public class Mundo
{

    static void Main(string[] args)
    {
        var terra = new OLAMUNDO.Mundo();
        terra.Mensagem("Olá mundo da Terra");

    }

    public void Mensagem(string msg)
    {
        Console.WriteLine(msg);
    }
}
