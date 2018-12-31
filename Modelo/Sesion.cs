using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Sesion
    {
        int id;
        int idCita;
        int idTerap;
        DateTime horaInicio;
        int estado;

        public Sesion(int id, int idCita, int idTerap, DateTime horaInicio, int estado)
        {
            this.id = id;
            this.idCita = idCita;
            this.idTerap = idTerap;
            this.horaInicio = horaInicio;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public int IdCita { get => idCita; set => idCita = value; }
        public int IdTerap { get => idTerap; set => idTerap = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
