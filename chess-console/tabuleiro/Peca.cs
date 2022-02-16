using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_console.tabuleiro
{
    abstract class Peca
    {

        public Posicao? Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int? qteMovimentos { get; set; }
        public Tabuleiro tab { get; set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.tab = tabuleiro;
            this.Cor = cor;
            this.qteMovimentos = 0;
        }

        public abstract bool[,] MovimentosPossiveis();

        public void IncrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public void DecrementarQteMovimentos()
        {
            qteMovimentos--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < tab.Linhas; i++) 
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (mat[i,j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {

            return MovimentosPossiveis()[pos.Linha, pos.Coluna];

        }


    }
}
