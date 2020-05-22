namespace primeiroPOO
{
    public class Personagem
    {
        public string nome ="tony";
        public int idade = 35;
        public string armadura;

        public string Defender(){
            return "personagem defendeu";
        }

        public int Atacar(int forca , int poder){
            return forca * poder;
        }
        
    }
}