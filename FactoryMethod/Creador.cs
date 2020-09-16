namespace FactoryMethod
{
    public class Creador
    {
        public const int vinoTinto = 1;
        public const int cerveza = 2;

        public static BebidasEmbriagantes CreadorBebida(int tipo)
        {
            switch (tipo)
            {
                case vinoTinto:
                    return new VinoTinto();
                case cerveza:
                    return new Cerveza();
                default:
                    return null;
            }
        }
    }
}
