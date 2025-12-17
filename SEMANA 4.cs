using System;
using System.Collections.Generic;

namespace AgendaClinica
{
    // Registro: turno inmutable
    public record Turno(string CedulaPaciente, string NombrePaciente, string Medico, DateTime FechaHora);

    // Estructura: datos pequeños y temporales
    public struct Horario
    {
        public int Hora;
        public int Minuto;
    }

    // Clase principal de la agenda
    public class Agenda
    {
        private List<Turno> turnos = new List<Turno>(); // Vector

        public void RegistrarTurno(Turno turno)
        {
            turnos.Add(turno);
        }

        public void MostrarTurnos()
        {
            Console.WriteLine("--- LISTA DE TURNOS ---");
            foreach (var t in turnos)
            {
                Console.WriteLine($"Paciente: {t.NombrePaciente} | Cédula: {t.CedulaPaciente} | Médico: {t.Medico} | Fecha: {t.FechaHora}");
            }
        }

        public void BuscarPorCedula(string cedula)
        {
            Console.WriteLine($"--- TURNOS DEL PACIENTE {cedula} ---");
            foreach (var t in turnos)
            {
                if (t.CedulaPaciente == cedula)
                {
                    Console.WriteLine($"Médico: {t.Medico} | Fecha: {t.FechaHora}");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            // Uso de estructura
            Horario h1 = new Horario { Hora = 9, Minuto = 30 };
            Horario h2 = new Horario { Hora = 11, Minuto = 0 };

            // Creación de registros (records)
            Turno t1 = new Turno("2200350383", "Flor Muñoz", "Dr. Pérez", new DateTime(2025, 6, 20, h1.Hora, h1.Minuto, 0));
            Turno t2 = new Turno("2200350383", "Flor Muñoz", "Dr. Gómez", new DateTime(2025, 6, 22, h2.Hora, h2.Minuto, 0));

            agenda.RegistrarTurno(t1);
            agenda.RegistrarTurno(t2);

            agenda.MostrarTurnos();
            agenda.BuscarPorCedula("0102030405");

            Console.ReadKey();
        }
    }
}
