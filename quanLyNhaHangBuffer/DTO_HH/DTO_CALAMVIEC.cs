using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLY
{
    public class DTO_CALAMVIEC
    {
        private int macalam;
        private DateTime giobd;
        private DateTime giokt;
        private int sogio;

        public int Macalam
        {
            get { return macalam; }   
            set { macalam = value; }
        }
        public DateTime GioBD
        {
            get { return giobd; }
            set { giobd = value; }
        }
        public DateTime GioKT
        {
            get { return giokt; }
            set { giokt = value; }
        }
        public int Sogio
        {
            get { return sogio; }
            set { sogio = value; }
        }
        public DTO_CALAMVIEC() { }

        public DTO_CALAMVIEC(int idca, DateTime bd, DateTime kt, int so)
        {
            this.macalam = idca;
            this.giobd = bd;
            this.giokt = kt;
            this.sogio = so;
        }
        public DTO_CALAMVIEC(DateTime bd, DateTime kt, int so)
        {
            this.giobd = bd;
            this.giokt = kt;
            this.sogio = so;
        }
        public DTO_CALAMVIEC(int idca)
        {
            this.macalam = idca;
        }
    }
}
