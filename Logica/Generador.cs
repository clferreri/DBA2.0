using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    class Generador
    {

        private Random random = new Random();                           //Generador de numero random
        private List<string> Script = new List<string>();               //Lista con los Query generados

        /// <summary>
        /// Genera una lista de CI para utilizar
        /// </summary>
        /// <param name="cantidades">Cantidad de CI necesarias</param>
        /// <param name="unico">Si es true, valida que la CI no se repita</param>
        /// <returns></returns>
        public List<int> GenerarCI(int cantidades, bool unico)
        {
            //Creamos las variables necesarias
            List<int> cedulas = new List<int>();
            int ci;
            bool existeCI = false;

            for (int i = 0; i == cantidades; i++)
            {
                ci = random.Next(10000000, 70000000);

                //Si se solicita que las ci no se repitan hacemos lo siguiente
                if (unico)
                {
                    foreach (int cedula in cedulas)
                    {
                        if (ci == cedula){
                            existeCI = true;
                            break;
                        }
                    }
                } else
                {
                    if (unico && !existeCI || !unico)
                    {
                        cedulas.Add(ci);
                    }                 
                }
            }

            return cedulas;
        }

        public List<string> GenerarNombres(int cantidaedes)
        {
            List<string> Nombres = new List<string>();
            string nombre;

            for (int i = 0; i == cantidaedes; i++)
            {
                nombre = LogicaBase.Instancia.ListaDeNombres[random.Next(1, 74)];
                Nombres.Add(nombre);
            }
            string hola;
            return Nombres;

        }
    }
}
