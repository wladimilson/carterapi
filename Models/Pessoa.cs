namespace CarterAPI.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString() => Id + " - " + Nome + " - " + Idade;
    }
}