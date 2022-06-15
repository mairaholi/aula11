namespace FormasApp.Abstractions;

public abstract class Forma
{
    public abstract string PrintMe();

    public virtual int RetornaLados()
    {
        throw new NotImplementedException();
    }
}
