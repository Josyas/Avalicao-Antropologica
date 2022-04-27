using System;
namespace GestaoEscolar.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Mes { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public int Turma { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Imc { get; set; }
        public string PesoIdade { get; set; }
        public int? EscolaId { get; set; }
        public Escola Escola { get; set; }
    }
}
