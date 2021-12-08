namespace Classes.Metodos
{
    public class Ref
    {
        //palavra chave ref permite alterar o valor da variável que está sendo passada
        static void Inverter(ref int x, ref int y){
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter(){
            int i = 1, j = 2;
            Inverter(ref i, ref j);
            System.Console.WriteLine($"{i} {j}");   
        }
    }
}