namespace Classes.Metodos
{
    public class Out
    {
        //palavra chave out permite retornar o resultado de um ou mais valores referentes aos resultados do método
        static void Dividir(int x, int y, out int resultado, out int resto){
            resultado = x / y;
            resto = x % y;
        }

        public static void Dividir(){
            Dividir(10, 3, out int resultado, out int resto);
            System.Console.WriteLine("{0} {1}", resultado, resto);
        }
    }
}