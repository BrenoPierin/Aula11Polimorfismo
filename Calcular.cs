namespace Aula11Polimorfismo
{
    public class Calcular
    {
        public string calcular(){
             return "A vida do jogador não pode calcular a vida";
         }

        public string calcular(int vida){
            return "A vida do personagem é " + vida;
        }
        public string calcular(int vida , int escudo){
            return "A vida com escudo do personagem é " + (vida + escudo);
        }
        public string calcular(string nome , string sobrenome){
            return $"o personagem {nome} {sobrenome} está vivo!";
        }
    }
}