using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        int id;
        String nombre;
        String apPat;
        String apMat;
        int tipoDocIdent;
        int numDocIdent;
        DateTime fechaNac;
        int categ;
        String telefono;
        int estado;

        public Cliente(int id, string nombre, string apPat, string apMat, int tipoDocIdent, int numDocIdent, DateTime fechaNac, int categ, string telefono, int estado)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.ApPat = apPat;
            this.ApMat = apMat;
            this.TipoDocIdent = tipoDocIdent;
            this.NumDocIdent = numDocIdent;
            this.FechaNac = fechaNac;
            this.Categ = categ;
            this.Telefono = telefono;
            this.Estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApPat { get => apPat; set => apPat = value; }
        public string ApMat { get => apMat; set => apMat = value; }
        public int TipoDocIdent { get => tipoDocIdent; set => tipoDocIdent = value; }
        public int NumDocIdent { get => numDocIdent; set => numDocIdent = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public int Categ { get => categ; set => categ = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
