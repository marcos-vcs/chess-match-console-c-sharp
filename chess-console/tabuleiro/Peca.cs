﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_console.tabuleiro
{
    class Peca
    {

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; set; }
        public Tabuleiro tab { get; set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        { 
            this.tab = tabuleiro;
            this.Cor = cor;
            this.qteMovimentos = 0;
        }

    }
}
