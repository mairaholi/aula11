using FormasApp.Abstractions;

namespace FormasApp.Shapes;

public class Retangulo : Forma
{
    public override string PrintMe()
    {
        return "Retangulo";
    }
    private double LadoMaior = 2.05f;
    public double LadoMenor = 2.05f;
}
