using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Terapeuta
    {
        int id;
        String nombre;
        String apPat;
        String apMat;
        String telef;
        int estado;

        public Terapeuta(int id, string nombre, string apPat, string apMat, string telef, int estado)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.ApPat = apPat;
            this.ApMat = apMat;
            this.Telef = telef;
            this.Estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApPat { get => apPat; set => apPat = value; }
        public string ApMat { get => apMat; set => apMat = value; }
        public string Telef { get => telef; set => telef = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
