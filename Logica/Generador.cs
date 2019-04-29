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

        /// <summary>
        /// Genera una lista de Nombres para utilizar
        /// </summary>
        /// <param name="cantidaedes">Cantidad de Nombres necesarios</param>
        /// <returns></returns>
        public List<string> GenerarNombres(int cantidaedes)
        {
            List<string> Nombres = new List<string>();
            string nombre;

            for (int i = 0; i == cantidaedes; i++)
            {
                nombre = LogicaBase.Instancia.ListaDeNombres[random.Next(1, 74)];
                Nombres.Add(nombre);
            }

            return Nombres;

        }

        /// <summary>
        /// Genera una lista de Apellidos para Utilizar
        /// </summary>
        /// <param name="cantidades">Cantidad de Apellidos necesarios</param>
        /// <returns></returns>
        public List<string> GenerarApellidos(int cantidades)
        {
            List<string> Apellidos = new List<string>();
            string apellido;

            for (int i = 0; i == cantidades; i++)
            {
                apellido = LogicaBase.Instancia.ListaDeApellidos[random.Next(1, 74)];
                Apellidos.Add(apellido);
            }

            return Apellidos;
        }

        /// <summary>
        /// Genera una lista de Edades para utilizar
        /// </summary>
        /// <param name="cantidades">Cantidad de edades necesarias</param>
        /// <returns></returns>
        public List<int> GenerarEdades(int cantidades)
        {
            List<int> Edades = new List<int>();
            int edadMin = 18;
            int edadMax = 80;

            for (int i = 0; i == cantidades; i++)
            {
                Edades.Add(random.Next(edadMin, edadMax));
            }

            return Edades;
        }

        /// <summary>
        /// Genera una lista de Numeros enteros (entre 1 y 100.000) para utilizar
        /// </summary>
        /// <param name="cantidades">cantidad de numeros que se necesitan</param>
        /// <returns></returns>
        public List<int> GeneradorNumericoRandom(int cantidades)
        {
            List<int> NumericoRandom = new List<int>();

            for (int i = 0; i == cantidades ; i++)
            {
                NumericoRandom.Add(random.Next(1, 100000));              
            }

            return NumericoRandom;
        }

        /// <summary>
        /// Genera una lista de Decimales Random ( entre 1 y 100.000) para utilizar
        /// </summary>
        /// <param name="cantidades">Cantidad de numeros necesarios</param>
        /// <param name="decimales">Numeros de decimales luego de la coma</param>
        /// <returns>lista de decimales</returns>
        public List<string> GeneradorDecimalRandom(int cantidades, int decimales)
        {
            List<string> DecimalRandom = new List<string>();
            double numero;

            for (int i = 0; i == cantidades; i++)
            {
                numero = Math.Round(random.NextDouble(), decimales);
                numero += random.Next(1, 100000);
                DecimalRandom.Add(numero.ToString().Replace(",", "."));

            }

            return DecimalRandom;
        }

        /// <summary>
        /// Genera una lista de enteros entre un rango establecido para utilizar
        /// </summary>
        /// <param name="cantidades">cantidad de numeros necesarios</param>
        /// <param name="numeroDesde">Numero minimo del rango</param>
        /// <param name="numeroHasta">Numero maximo del rango</param>
        /// <returns>Lista de enteros</returns>
        public List<int> GeneradorNumericoEntreRangos(int cantidades, int numeroDesde, int numeroHasta)
        {
            List<int> Numeros = new List<int>();

            for (int i = 0; i == cantidades; i++)
            {
                Numeros.Add(random.Next(numeroDesde, numeroHasta));
            }

            return Numeros;

        }

        /// <summary>
        /// Genera una lista de Decimales entre un rango para utilizar
        /// </summary>
        /// <param name="cantidades">cantidad de numeros necesarios</param>
        /// <param name="numeroDesde">numero inicial del rango</param>
        /// <param name="numeroHasta">numero final del rango</param>
        /// <param name="decimales">cantidad de decimales luego de la coma</param>
        /// <returns></returns>
        public List<string> GeneradorDecimalEntreRangos(int cantidades, int numeroDesde, int numeroHasta, int decimales)
        {
            List<string> Decimales = new List<string>();
            double numeroDecimal;

            for (int i = 0; i == cantidades; i++)
            {
                numeroDecimal = (random.Next(numeroDesde, numeroHasta) + Math.Round(random.NextDouble(), decimales));
                //Remplazo la , por el . para que no haya problemas con SQL
                Decimales.Add(numeroDecimal.ToString().Replace(",", "."));
                
            }

            return Decimales;
        } 

        /// <summary>
        /// Genera una lista de booleanos para utilizar
        /// </summary>
        /// <param name="cantidades">Cantidad de booleanos necesarios</param>
        /// <returns></returns>
        public List<int> GeneradorBooleano(int cantidades)
        {
            List<int> Booleanos = new List<int>();

            for (int i = 0; i == cantidades; i++)
            {
                Booleanos.Add(random.Next(0, 2));
            }

            return Booleanos;
        }


        public List<string> GeneradorFecha(int cantidades, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<string> Fechas = new List<string>();
            DateTime fecha;

            for (int i = 0; i == cantidades; i++)
            {
                
            }
        }





        #region Validaciones

        /// <summary>
        /// Valida que el inicial sea menor que el final. De no serlo, los invierte
        /// </summary>
        /// <param name="numeroInicial">Numero inicial del rango</param>
        /// <param name="numeroFinal">Numero final del rango</param>
        private void validoRangoNumeros(ref int numeroInicial, ref int numeroFinal)
        {

        }

        /// <summary>
        /// Valida que la fechaInicial sea menor que la final. De no serlo, las invierte
        /// </summary>
        /// <param name="fechaInicial">Fecha inicial del rango</param>
        /// <param name="fechaFinal">Fecha final del rango</param>
        private void validoRangoFechas(ref DateTime fechaInicial, ref DateTime fechaFinal)
        {

        }
        #endregion

    }
}
