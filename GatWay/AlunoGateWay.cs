using GestaoEscolar.Models;
using System.Collections.Generic;
using System.Linq;
namespace GestaoEscolar.GatWay
{
    public class AlunoGateWay
    {
        AppDbContext dbContext = new AppDbContext();

        public bool Add(Escola escola)
        {
            dbContext.Escolas.Add(escola);
            return dbContext.SaveChanges() > 0;
        }

        public bool Add(Aluno aluno)
        {
            dbContext.Alunos.Add(aluno);
            return dbContext.SaveChanges() > 0;
        }

        public List<Escola> PegarDadosEscola()
        {
            return dbContext.Escolas.ToList();
        }

        public List<Aluno> PegarDadosAluno()
        {
            return dbContext.Alunos.ToList();
        }

        public bool Atualizar(Escola escola)
        {
            var dbData = dbContext.Escolas.FirstOrDefault(e => e.Id == escola.Id);
            if (dbData == null)
            {
                return false;
            }
            dbData.Nome = escola.Nome;
            return dbContext.SaveChanges() > 0;
        }

        public bool Atualizar(Aluno aluno)
        {
            var dbData = dbContext.Alunos.FirstOrDefault(e => e.Id == aluno.Id);
            if (dbData == null)
            {
                return false;
            }
            dbData.Id = aluno.Id;
            dbData.Nome = aluno.Nome;
            dbData.Idade = aluno.Idade;
            dbData.Mes = aluno.Mes;
            dbData.DataNascimento = aluno.DataNascimento;
            dbData.Sexo = aluno.Sexo;
            dbData.Turma = aluno.Turma;
            dbData.Peso = aluno.Peso;
            dbData.Altura = aluno.Altura;
            dbData.EscolaId = aluno.EscolaId;
            dbData.Imc = aluno.Imc;
            dbData.PesoIdade = aluno.PesoIdade;

            return dbContext.SaveChanges() > 0;
        }

        public bool Apagar(int id)
        {
            var escola = dbContext.Escolas.FirstOrDefault(e => e.Id == id);
            if (escola == null)
            {
                return false;
            }
            dbContext.Escolas.Remove(escola);
            return dbContext.SaveChanges() > 0;
        }

        public bool ApagarAluno(int id)
        {
            var aluno = dbContext.Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null)
            {
                return false;
            }
            dbContext.Alunos.Remove(aluno);
            return dbContext.SaveChanges() > 0;
        }
    }
}
