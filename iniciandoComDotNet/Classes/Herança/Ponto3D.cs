namespace Classes.Herança
{
    //para herdar de outra classe precisa de dois pontos ->  <classe atual> : <classeASerHerdada>
    public class Ponto3D : Ponto
    {
        public int z;

        public Ponto3D(int x, int y, int z) : base(x, y){
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular(){
            //Faz alguma coisa...
        }

        //sobreescrevendo o método da classe mãe
        public override void CalcularDistancia3()
        {
            //Faz outra coisa...
            base.CalcularDistancia3();
        }
    }
}