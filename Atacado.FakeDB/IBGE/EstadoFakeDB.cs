﻿using Atacado.Modelo.IBGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.FakeDB.IBGE
{
    public static class EstadoFakeFB
    {
        private static List<Estado> estados = new List<Estado>();

        public static List<Estado> Estados
        {
            get
            {
                if (estados.Count() == 0)
                {
                    AdicionarEstados();
                }
                return estados;
            }
        }

        private static void AdicionarEstados()
        {
            estados.Add(new Estado(1, "Rondônia", "RO", "Norte"));
            estados.Add(new Estado(2, "Acre", "AC", "Norte"));
            estados.Add(new Estado(3, "Amazonas", "AM", "Norte"));
            estados.Add(new Estado(4, "Roraima", "RR", "Norte"));
            estados.Add(new Estado(5, "Pará", "PA", "Norte"));
            estados.Add(new Estado(6, "Amapá", "AP", "Norte"));
            estados.Add(new Estado(7, "Tocantins", "TO", "Norte"));
            estados.Add(new Estado(8, "Maranhão", "MA", "Nordeste"));
            estados.Add(new Estado(9, "Piauí", "PI", "Nordeste"));
            estados.Add(new Estado(10, "Ceará", "CE", "Nordeste"));
            estados.Add(new Estado(11, "Rio Grande do Norte", "RN", "Nordeste"));
            estados.Add(new Estado(12, "Paraíba", "PB", "Nordeste"));
            estados.Add(new Estado(13, "Pernambuco", "PE", "Nordeste"));
            estados.Add(new Estado(14, "Alagoas", "AL", "Nordeste"));
            estados.Add(new Estado(15, "Sergipe", "SE", "Nordeste"));
            estados.Add(new Estado(16, "Bahia", "BA", "Nordeste"));
            estados.Add(new Estado(17, "Minas Gerais", "MG", "Sudeste"));
            estados.Add(new Estado(18, "Espírito Santo", "ES", "Sudeste"));
            estados.Add(new Estado(19, "Rio de Janeiro", "RJ", "Sudeste"));
            estados.Add(new Estado(20, "São Paulo", "SP", "Sudeste"));
            estados.Add(new Estado(21, "Paraná", "PR", "Sul"));
            estados.Add(new Estado(22, "Santa Catarina", "SC", "Sul"));
            estados.Add(new Estado(23, "Rio Grande do Sul", "RS", "Sul"));
            estados.Add(new Estado(24, "Mato Grosso do Sul", "MS", "Centro-Oeste"));
            estados.Add(new Estado(25, "Mato Grosso", "MT", "Centro-Oeste"));
            estados.Add(new Estado(26, "Goiás", "GO", "Centro-Oeste"));
            estados.Add(new Estado(27, "Distrito Federal", "DF", "Centro-Oeste"));
        }
    }
}
