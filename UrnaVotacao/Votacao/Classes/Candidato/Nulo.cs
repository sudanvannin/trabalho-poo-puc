﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaVotacao.Votacao.Classes.Candidato
{
    public class Nulo : Candidato, ICandidato
    {
        public Nulo(string partido, string nome, int idade, int numCandidato) : base(partido, nome, idade, numCandidato)
        {

        }
        public virtual void funcaoCandidato()
        {
            MessageBox.Show("Voto Nulo.");
        }
    }
}

