using System;
using System.Collections.Generic;
using System.Linq;

namespace CampaniaVacunacionCOVID
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1️⃣ Crear conjunto total de ciudadanos (500)
            HashSet<string> ciudadanos = GenerarCiudadanos(500);

            // 2️⃣ Crear conjunto vacunados Pfizer (75)
            HashSet<string> pfizer = SeleccionarVacunados(ciudadanos, 75, 1);

            // 3️⃣ Crear conjunto vacunados AstraZeneca (75)
            HashSet<string> astraZeneca = SeleccionarVacunados(ciudadanos, 75, 2);

            // 🔹 Unión de vacunados
            HashSet<string> vacunados = new HashSet<string>(pfizer);
            vacunados.UnionWith(astraZeneca);

            // 🔹 Ciudadanos no vacunados
            HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
            noVacunados.ExceptWith(vacunados);

            // 🔹 Ciudadanos con ambas dosis
            HashSet<string> ambasDosis = new HashSet<string>(pfizer);
            ambasDosis.IntersectWith(astraZeneca);

            // 🔹 Solo Pfizer
            HashSet<string> soloPfizer = new HashSet<string>(pfizer);
            soloPfizer.ExceptWith(astraZeneca);

            // 🔹 Solo AstraZeneca
            HashSet<string> soloAstra = new HashSet<string>(astraZeneca);
            soloAstra.ExceptWith(pfizer);

            // Mostrar resultados
            MostrarResultados("CIUDADANOS NO VACUNADOS", noVacunados);
            MostrarResultados("CIUDADANOS CON AMBAS DOSIS", ambasDosis);
            MostrarResultados("CIUDADANOS SOLO PFIZER", soloPfizer);
            MostrarResultados("CIUDADANOS SOLO ASTRAZENECA", soloAstra);

            Console.ReadKey();
        }

        // Método para generar ciudadanos ficticios
        static HashSet<string> GenerarCiudadanos(int cantidad)
        {
            HashSet<string> lista = new HashSet<string>();

            for (int i = 1; i <= cantidad; i++)
            {
                lista.Add($"Ciudadano {i}");
            }

            return lista;
        }

        // Método para seleccionar vacunados de forma pseudoaleatoria
        static HashSet<string> SeleccionarVacunados(HashSet<string> ciudadanos, int cantidad, int semilla)
        {
            Random rnd = new Random(semilla);
            List<string> lista = ciudadanos.ToList();
            HashSet<string> vacunados = new HashSet<string>();

            while (vacunados.Count < cantidad)
            {
                int index = rnd.Next(lista.Count);
                vacunados.Add(lista[index]);
            }

            return vacunados;
        }

        // Método para mostrar resultados
        static void MostrarResultados(string titulo, HashSet<string> conjunto)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine(titulo);
            Console.WriteLine("Total: " + conjunto.Count);
            Console.WriteLine("========================================");

            foreach (var ciudadano in conjunto)
            {
                Console.WriteLine(ciudadano);
            }
        }
    }
}