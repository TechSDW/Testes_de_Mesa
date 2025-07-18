﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMesa3
{
    class ClassTM7
    {
        private double vp;
        public void setVp(double vp) { this.vp = vp; }
        public double getVp() { return this.vp; }

        private double taxa;
        public void setTaxa(double taxa) { this.taxa = taxa; }
        public double getTaxa() { return this.taxa; }

        private double vf;
        public void setVf(double vf) { this.vf = vf; }
        public double getVf() { return this.vf; }

        private double rend;
        public double getRend() { return this.rend; }

        public ClassTM7(double vp, double taxa)
        {
            this.vp = vp;
            this.taxa = taxa;
        }

        public void calcularVf_Rend(int periodo)
        {
            vf = vp * Math.Pow((1 + taxa), periodo);
            rend = vf - vp;
        }
    }
}
