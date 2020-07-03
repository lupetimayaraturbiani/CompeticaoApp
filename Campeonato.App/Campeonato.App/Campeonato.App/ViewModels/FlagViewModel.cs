using Campeonato_App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato_App.ViewModels
{
    public class FlagViewModel
    {
        public List<Jogo> jogos { get; set; }


        public FlagViewModel()
        {
            jogos = new List<Jogo>
            {
                new Jogo
                {
                    id = 1,
                    placarCasa = 0,
                    placarVisitante = 0,
                    penaltisCasa = 4,
                    penaltisVisitante = 3,
                    estadio = "Arena Fonte Nova",
                    data = DateTime.Now,
                    selecaoCasaNome = "Holanda",
                    selecaoVisitanteNome = "Costa Rica",
                    bandeiraCasa = "Holanda_Bandeira.jpg",
                    bandeiraVisitante = "Costa_rica_Bandeira.jpg"
                },

                new Jogo
                {
                    id = 2,
                    placarCasa = 1,
                    placarVisitante = 7,
                    penaltisCasa = 0,
                    penaltisVisitante = 0,
                    estadio = "Mineirão",
                    data = DateTime.Now,
                    selecaoCasaNome = "Brasil",
                    selecaoVisitanteNome = "Alemanha",
                    bandeiraCasa = "Brasil_Bandeira.jpg",
                    bandeiraVisitante = "Alemanha_Bandeira.jpg"
                }
            };
        }
    }
}
