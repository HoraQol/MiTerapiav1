using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pago
    {
        int id;
        int idCita;
        int tipo;
        String numDoc;
        DateTime fecha;

        public Pago(int id, int idCita, int tipo, string numDoc, DateTime fecha)
        {
            this.Id = id;
            this.IdCita = idCita;
            this.Tipo = tipo;
            this.NumDoc = numDoc;
            this.Fecha = fecha;
        }

        public int Id { get => id; set => id = value; }
        public int IdCita { get => idCita; set => idCita = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public string NumDoc { get => numDoc; set => numDoc = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
