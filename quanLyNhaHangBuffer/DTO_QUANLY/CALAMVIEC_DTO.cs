using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLY
{
    public class CALAMVIEC_DTO
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
        public CALAMVIEC_DTO() { }

        public CALAMVIEC_DTO(int idca, DateTime bd, DateTime kt, int so)
        {
            this.macalam = idca;
            this.giobd = bd;
            this.giokt = kt;
            this.sogio = so;
        }
        public CALAMVIEC_DTO(DateTime bd, DateTime kt, int so)
        {
            this.giobd = bd;
            this.giokt = kt;
            this.sogio = so;
        }
        public CALAMVIEC_DTO(int idca)
        {
            this.macalam = idca;
        }
    }
}
