namespace FactoryMethod
{
    internal class Cerveza : BebidasEmbriagantes
    {
        public override int CuantoMeEmbriagaPorHora()
        {
            return 5;
        }
    }
}
