using GestaoEscolar.GatWay;
using GestaoEscolar.Models;
using System.Collections.Generic;
namespace GestaoEscolar.Manager
{
    public class AlunoManager
    {
        AlunoGateWay alunoGateWay = new AlunoGateWay();

        public bool Add(Escola escola)
        {
            return alunoGateWay.Add(escola);
        }

        public bool Add(Aluno aluno)
        {
            return alunoGateWay.Add(aluno);
        }

        public List<Escola> PegarDadosEscola()
        {
            return alunoGateWay.PegarDadosEscola();
        }

        public List<Aluno> PegaDadosAluno()
        {
            return alunoGateWay.PegarDadosAluno();
        }

        public bool Atualizar(Escola escola)
        {
            return alunoGateWay.Atualizar(escola);
        }

        public bool Atualizar(Aluno aluno)
        {
            return alunoGateWay.Atualizar(aluno);
        }

        public bool Apagar(int id)
        {
            return alunoGateWay.Apagar(id);
        }

        public bool ApagarAlunos(int id)
        {
            return alunoGateWay.ApagarAluno(id);
        }

    }
}
