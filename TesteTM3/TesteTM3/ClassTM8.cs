using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTM3
{
    class ClassTM8
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

        public ClassTM8(double vp, double taxa)
        {
            this.vp = vp;
            this.taxa = taxa;
        }

        public void calcularVf_Rend(double periodo)
        {
            vf = vp * Math.Pow((1 + taxa), periodo);
            rend = vf - vp;
        }
    }
}
