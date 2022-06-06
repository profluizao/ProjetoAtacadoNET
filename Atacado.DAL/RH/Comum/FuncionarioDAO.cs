﻿using Atacado.DAL.Ancestral;
using Atacado.FakeDB.RH;
using Atacado.Domain.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.RH.Comum
{
    public class FuncionarioDAO : IActionReadDAO<Funcionario>
    {
        public Funcionario Read(int id)
        {
            Funcionario obj = FuncionarioFakeDB.Funcionarios.SingleOrDefault(fun => fun.Codigo == id);
            return obj;
        }

        public List<Funcionario> ReadAll()
        {
            return FuncionarioFakeDB.Funcionarios;
        }
    }
}
