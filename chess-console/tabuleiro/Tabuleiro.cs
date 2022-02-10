﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_console.tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            Pecas = new Peca[linhas,colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return this.Pecas[linha, coluna];
        }


    }
}
