using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabungan_GUI
{
    public class Tabungan
    {        
        private int saldo, biayaAdministrasi;

        public Tabungan(int saldoawal)
        {            
            this.saldo = saldoawal;
        }

        public Boolean setorUang(int nominal)
        {
            if (this.saldo < this.biayaAdministrasi)
            {
                return false;
            } else
            {
                this.saldo -= this.biayaAdministrasi;
                this.saldo += nominal;
                return true;
            }
            
        }

        public Boolean tarikUangIDR(int nominal)
        {
            if (this.saldo < nominal)
            {
                return false;                
            }
            else
            {
                this.saldo -= nominal;
                return true;
            }            
        }

        public Boolean tarikUangUSD(int nominal)
        {
            if (this.saldo < (nominal * 15000) + 50)
            {
                return false;
            }
            else
            {
                this.saldo -= 50;
                this.saldo -= (nominal * 15000);
                return true;
            }                        
        }

        public int getSaldo()
        {
            return this.saldo;
        }                   

        public void biayaAdmin(int biaya)
        {
            this.biayaAdministrasi = biaya;
        }
    }
}
