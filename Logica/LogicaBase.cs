using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Logica
{
    public class LogicaBase
    {

        #region "Singleton"

        //Declaracion de instancia
        private static LogicaBase instancia = new LogicaBase();

        //Constructor privado para no acceder a ella desde fuera
        private LogicaBase() { }

        //Metodo publico para acceder a ella

        public static LogicaBase Instancia
        {
            get
            {
                if (instancia is null)
                {
                    instancia = new LogicaBase();
                }

                return instancia;
            }
        }


        #endregion

        #region Propiedaedades

        //Propiedades de la LogicaBase //////////////////////////////////////////////////////////////      
        private int idiomaSelccionado = Constantes.DBA_Idioma;          //Idioma en el que funcionara el programa
        private int MotorBD = Constantes.DBA_Motor;                     //Motor de BD que se utilizara para generar la sintaxis del script
        private readonly double versionDBA = Constantes.DBA_Version;    //Version del Software 
        private string rutaDeEjecucion;                                 //Ruta en la que se ejecuta la aplicación

        ///////////////////////////////////////////////////////////////////////////////////////////////

        //Listas Automaticas del sistema 
        List<string> Nombres = new List<string>();
        List<string> Apellidos = new List<string>();

        #endregion

        #region Acceso a Propiedades


        public int MotorDeBD
        {
            get { return MotorBD; }
            set { MotorBD = value; }
        }

        public int Idioma
        {
            get { return idiomaSelccionado; }
            set { idiomaSelccionado = value; }
        }

        public double VersionDBA
        {
            get { return versionDBA; }
        }

        public string RutaDeEjecucion
        {
            get { return rutaDeEjecucion; }
            set { rutaDeEjecucion = value; }
        }

        public List<string> ListaDeNombres
        {
            get { return Nombres; }
        }

        public List<string> ListaDeApellidos
        {
            get { return Apellidos; }
        }

        #endregion

        #region Metodos

        ///<summary>Configura los parametros necesarios para hacer funcionar la aplicacion</summary>
        public bool ConfigurarListasAutomaticas()
        {
            CargarNombres();
            CargarApellidos();

            return true;
        }


        /// <summary>Genera una lista de nombres que el sistema podra utilizar/// </summary>
        private void CargarNombres()
        {
            string rutaArchivo = rutaDeEjecucion + "\\Lista Generadores";
            string nombLista = "\\Nombres.txt";
            FileStream fs;

            try
            {
                if (!(Directory.Exists(rutaArchivo)))
                {
                    //Si la carpeta no existe la creo
                    Directory.CreateDirectory(rutaArchivo);
                }

                //Si no existe el txt, lo creo y lo agrego a la base
                if (!File.Exists(rutaArchivo + nombLista))
                {
                    fs = File.Create(rutaArchivo + nombLista);
                    fs.Close();

                    StreamWriter escribir = new StreamWriter(rutaArchivo + nombLista);

                    #region Nombres


                    escribir.WriteLine("##################################################################");
                    escribir.WriteLine("### LISTA CON 150 NOMBRES PARA GENERADOR AUTOMATICO DE NOMBRES ###");
                    escribir.WriteLine("###------------------------------------------------------------###");
                    escribir.WriteLine("###                     ELEMENTARY SOLUTIONS                   ###");
                    escribir.WriteLine("##################################################################");
                    escribir.WriteLine("");
                    escribir.WriteLine("");

                    escribir.WriteLine("      <---- Comienzo de la lista ---->");
                    escribir.WriteLine("");

                    escribir.WriteLine("Aarón");
                    escribir.WriteLine("Abel");
                    escribir.WriteLine("Abelardo");
                    escribir.WriteLine("Abraham");
                    escribir.WriteLine("Adam");

                    escribir.WriteLine("");

                    escribir.WriteLine("Aida");
                    escribir.WriteLine("Aisha");
                    escribir.WriteLine("Alia");
                    escribir.WriteLine("Amina");
                    escribir.WriteLine("Ana Laura");

                    escribir.WriteLine("");

                    escribir.WriteLine("Agustin");
                    escribir.WriteLine("Alejandro");
                    escribir.WriteLine("Amadeo");
                    escribir.WriteLine("Augusto");
                    escribir.WriteLine("Baltasar");

                    escribir.WriteLine("");

                    escribir.WriteLine("Anabel");
                    escribir.WriteLine("Ana Maria");
                    escribir.WriteLine("Amira");
                    escribir.WriteLine("Agustina");
                    escribir.WriteLine("Daniela");

                    escribir.WriteLine("");

                    escribir.WriteLine("Bartolomeo");
                    escribir.WriteLine("Blas");
                    escribir.WriteLine("Bruno");
                    escribir.WriteLine("Camilo");
                    escribir.WriteLine("Carlos");

                    escribir.WriteLine("");

                    escribir.WriteLine("Abigail");
                    escribir.WriteLine("Abril");
                    escribir.WriteLine("Adriana");
                    escribir.WriteLine("Aldana");
                    escribir.WriteLine("Alfonsina");

                    escribir.WriteLine("");

                    escribir.WriteLine("Cayetano");
                    escribir.WriteLine("César");
                    escribir.WriteLine("Christian");
                    escribir.WriteLine("Cristian");
                    escribir.WriteLine("Clemente");

                    escribir.WriteLine("");

                    escribir.WriteLine("Barbara");
                    escribir.WriteLine("Beatriz");
                    escribir.WriteLine("Belen");
                    escribir.WriteLine("Betiana");
                    escribir.WriteLine("Betty");


                    escribir.WriteLine("");

                    escribir.WriteLine("Conrado");
                    escribir.WriteLine("Joaquin");
                    escribir.WriteLine("Joel");
                    escribir.WriteLine("Jordi");
                    escribir.WriteLine("Jorge");

                    escribir.WriteLine("");

                    escribir.WriteLine("Brenda");
                    escribir.WriteLine("Camila");
                    escribir.WriteLine("Carmen");
                    escribir.WriteLine("Cecilia");
                    escribir.WriteLine("Celestina");

                    escribir.WriteLine("");

                    escribir.WriteLine("Jose Luis");
                    escribir.WriteLine("Juan");
                    escribir.WriteLine("Brahim");
                    escribir.WriteLine("Leonardo");
                    escribir.WriteLine("Emiliano");

                    escribir.WriteLine("");

                    escribir.WriteLine("Casandra");
                    escribir.WriteLine("Celeste");
                    escribir.WriteLine("Cinthia");
                    escribir.WriteLine("Clarisa");
                    escribir.WriteLine("Consuelo");

                    escribir.WriteLine("");

                    escribir.WriteLine("Cayetano");
                    escribir.WriteLine("Conrado");
                    escribir.WriteLine("Fabricio");
                    escribir.WriteLine("Facundo");
                    escribir.WriteLine("Fabian");

                    escribir.WriteLine("");

                    escribir.WriteLine("Cristina");
                    escribir.WriteLine("Dafne");
                    escribir.WriteLine("Dalma");
                    escribir.WriteLine("Debora");
                    escribir.WriteLine("Dora");

                    escribir.WriteLine("");

                    escribir.WriteLine("Federico");
                    escribir.WriteLine("Diego");
                    escribir.WriteLine("Leopoldo");
                    escribir.WriteLine("Enrique");
                    escribir.WriteLine("Matias");

                    escribir.WriteLine("");

                    escribir.WriteLine("Doris");
                    escribir.WriteLine("Edith");
                    escribir.WriteLine("Elena");
                    escribir.WriteLine("Elian");
                    escribir.WriteLine("Eloisa");

                    escribir.WriteLine("");

                    escribir.WriteLine("Sebastian");
                    escribir.WriteLine("Santiago");
                    escribir.WriteLine("Lucas");
                    escribir.WriteLine("Javier");
                    escribir.WriteLine("Marcos");

                    escribir.WriteLine("");

                    escribir.WriteLine("Elizabeth");
                    escribir.WriteLine("Emma");
                    escribir.WriteLine("Erika");
                    escribir.WriteLine("Esmeralda");
                    escribir.WriteLine("Eugenia");

                    escribir.WriteLine("");

                    escribir.WriteLine("Martin");
                    escribir.WriteLine("Luciano");
                    escribir.WriteLine("Samuel");
                    escribir.WriteLine("Pedro");
                    escribir.WriteLine("Pablo");

                    escribir.WriteLine("");

                    escribir.WriteLine("Fabiana");
                    escribir.WriteLine("Felicia");
                    escribir.WriteLine("Fernanda");
                    escribir.WriteLine("Fiorella");
                    escribir.WriteLine("Frida");

                    escribir.WriteLine("");

                    escribir.WriteLine("Marcelo");
                    escribir.WriteLine("Ignacio");
                    escribir.WriteLine("Patricio");
                    escribir.WriteLine("Alexis");
                    escribir.WriteLine("Gaston");

                    escribir.WriteLine("");

                    escribir.WriteLine("Gabriela");
                    escribir.WriteLine("Gala");
                    escribir.WriteLine("Georgina");
                    escribir.WriteLine("Giannina");
                    escribir.WriteLine("Giselle");

                    escribir.WriteLine("");

                    escribir.WriteLine("Mario");
                    escribir.WriteLine("Ramon");
                    escribir.WriteLine("Ruben");
                    escribir.WriteLine("Jaime");
                    escribir.WriteLine("Damian");

                    escribir.WriteLine("");

                    escribir.WriteLine("Heidi");
                    escribir.WriteLine("Hilaria");
                    escribir.WriteLine("Helena");
                    escribir.WriteLine("Ines");
                    escribir.WriteLine("Iris");

                    escribir.WriteLine("");

                    escribir.WriteLine("Daniel");
                    escribir.WriteLine("Fernado");
                    escribir.WriteLine("Paul");
                    escribir.WriteLine("Jesus");
                    escribir.WriteLine("Walter");

                    escribir.WriteLine("");

                    escribir.WriteLine("Irma");
                    escribir.WriteLine("Ivonne");
                    escribir.WriteLine("Melissa");
                    escribir.WriteLine("Leticia");
                    escribir.WriteLine("Valeria");

                    escribir.WriteLine("");

                    escribir.WriteLine("Valerio");
                    escribir.WriteLine("Victor");
                    escribir.WriteLine("Vladimir");
                    escribir.WriteLine("Williams");
                    escribir.WriteLine("Washington");

                    escribir.WriteLine("");

                    escribir.WriteLine("Julia");
                    escribir.WriteLine("Jimena");
                    escribir.WriteLine("Lilian");
                    escribir.WriteLine("Maite");
                    escribir.WriteLine("Stella");

                    escribir.WriteLine("");

                    escribir.WriteLine("Woody");
                    escribir.WriteLine("Wilson");
                    escribir.WriteLine("Tyler");
                    escribir.WriteLine("Mauro");

                    escribir.WriteLine("");

                    escribir.WriteLine("Vanessa");
                    escribir.WriteLine("Veronica");
                    escribir.WriteLine("Ursula");
                    escribir.WriteLine("Zoey");
                    escribir.WriteLine("Lucrecia");

                    escribir.WriteLine("");

                    #endregion

                    escribir.Close();

                }

                //Creamos un objeto StreamReader que permite leer archivos
                StreamReader leer = new StreamReader(rutaArchivo + nombLista);

                //Cargo la lista en memoria
                int contador = 0;
                string linea;
                while (!leer.EndOfStream)
                {
                    contador++;

                    //Leemos cada linea del archivo TXT
                    linea = leer.ReadLine();

                    if (string.IsNullOrEmpty(linea))
                    {
                        continue;
                    }

                    if (contador > 9)
                    {
                        Nombres.Add(linea);
                    }
                }

                leer.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>Genera una lista de apellidos que el sistema podra utilizar</summary>
        private void CargarApellidos()
        {
            string rutaArchivo = rutaDeEjecucion + "\\Lista Generadores";
            string nombLista = "\\Apellidos.txt";
            FileStream fs;

            try
            {
                if (!Directory.Exists(rutaArchivo))
                {
                    //Si el directorio no existe, lo creo
                    Directory.CreateDirectory(rutaArchivo);
                }

                if (!File.Exists(rutaArchivo + nombLista))
                {
                    //Si la lista no existe, la creo
                    fs = File.Create(rutaArchivo + nombLista);
                    fs.Close();

                    StreamWriter escribir = new StreamWriter(rutaArchivo + nombLista);

                    #region Apellidos

                    escribir.WriteLine("######################################################################");
                    escribir.WriteLine("### LISTA CON 100 APELLIDOS PARA GENERADOR AUTOMATICO DE APELLIDOS ###");
                    escribir.WriteLine("###----------------------------------------------------------------###");
                    escribir.WriteLine("###                       ELEMENTARY COMPANY                       ###");
                    escribir.WriteLine("######################################################################");
                    escribir.WriteLine("");
                    escribir.WriteLine("");

                    escribir.WriteLine("      <---- Comienzo de la lista ---->");
                    escribir.WriteLine("");

                    escribir.WriteLine("Abad");
                    escribir.WriteLine("Abadia");
                    escribir.WriteLine("Abajo");
                    escribir.WriteLine("Abarca");
                    escribir.WriteLine("Abellana");
                    escribir.WriteLine("Abengoza");
                    escribir.WriteLine("Abiego");
                    escribir.WriteLine("Abina");
                    escribir.WriteLine("Abréu");
                    escribir.WriteLine("Abril");
                    escribir.WriteLine("Acuña");
                    escribir.WriteLine("Acosta");
                    escribir.WriteLine("Acuña");
                    escribir.WriteLine("Adán");
                    escribir.WriteLine("Agar");
                    escribir.WriteLine("Alvez");
                    escribir.WriteLine("Aguado");
                    escribir.WriteLine("Aguirre");
                    escribir.WriteLine("Ahajadas");
                    escribir.WriteLine("Aimerich");
                    escribir.WriteLine("Agudo");
                    escribir.WriteLine("Araújo");
                    escribir.WriteLine("Araciel");
                    escribir.WriteLine("Arauco");

                    escribir.WriteLine("");

                    escribir.WriteLine("Bacara");
                    escribir.WriteLine("Bada");
                    escribir.WriteLine("Badia");
                    escribir.WriteLine("Balboa");
                    escribir.WriteLine("Balbuena");
                    escribir.WriteLine("Baldovinos");
                    escribir.WriteLine("Ballero");
                    escribir.WriteLine("Ballastros");
                    escribir.WriteLine("Banda");
                    escribir.WriteLine("Balzoa");
                    escribir.WriteLine("Barahona");
                    escribir.WriteLine("Barber");
                    escribir.WriteLine("Barceló");
                    escribir.WriteLine("Barnuevo");
                    escribir.WriteLine("Bas");
                    escribir.WriteLine("Bayer");
                    escribir.WriteLine("Bautista");
                    escribir.WriteLine("Bazan");
                    escribir.WriteLine("Bascones");
                    escribir.WriteLine("Bustamante");
                    escribir.WriteLine("Busto");
                    escribir.WriteLine("Burell");

                    escribir.WriteLine("");

                    escribir.WriteLine("Caballero");
                    escribir.WriteLine("Cabezas");
                    escribir.WriteLine("Cabra");
                    escribir.WriteLine("Cabrales");
                    escribir.WriteLine("Calella");
                    escribir.WriteLine("Camero");
                    escribir.WriteLine("Calvo");
                    escribir.WriteLine("Caminero");
                    escribir.WriteLine("Calatrava");
                    escribir.WriteLine("Calleja");
                    escribir.WriteLine("Carballo");
                    escribir.WriteLine("Carbajal");
                    escribir.WriteLine("Camparros");
                    escribir.WriteLine("Canillas");
                    escribir.WriteLine("Canal");
                    escribir.WriteLine("Carrasco");
                    escribir.WriteLine("Carreño");
                    escribir.WriteLine("Carrillo");
                    escribir.WriteLine("Casas");
                    escribir.WriteLine("Cascos");
                    escribir.WriteLine("Castañer");
                    escribir.WriteLine("Castejon");
                    escribir.WriteLine("Catalá");
                    escribir.WriteLine("Castillo");
                    escribir.WriteLine("Cesped");
                    escribir.WriteLine("Cima");
                    escribir.WriteLine("Clavijo");
                    escribir.WriteLine("Cobo");

                    escribir.WriteLine("");

                    escribir.WriteLine("De Arcas");
                    escribir.WriteLine("De Castro");
                    escribir.WriteLine("Doliva");
                    escribir.WriteLine("Donat");
                    escribir.WriteLine("Donaire");
                    escribir.WriteLine("Doncel");
                    escribir.WriteLine("Donis");
                    escribir.WriteLine("Dorcas");
                    escribir.WriteLine("Dulce");
                    escribir.WriteLine("Durán");
                    escribir.WriteLine("Duero");
                    escribir.WriteLine("Duque");
                    escribir.WriteLine("De Rivero");
                    escribir.WriteLine("Del Potro");
                    escribir.WriteLine("Denis");
                    escribir.WriteLine("Donate");
                    escribir.WriteLine("Deglio");


                    escribir.WriteLine("");

                    escribir.WriteLine("Echague");
                    escribir.WriteLine("Echábarri");
                    escribir.WriteLine("Echanove");
                    escribir.WriteLine("Eizaga");
                    escribir.WriteLine("Elcano");
                    escribir.WriteLine("Elizalde");
                    escribir.WriteLine("Elias");
                    escribir.WriteLine("Elordi");
                    escribir.WriteLine("Elorriaga");
                    escribir.WriteLine("Elorza");
                    escribir.WriteLine("Ena");
                    escribir.WriteLine("Encina");
                    escribir.WriteLine("Enciso");
                    escribir.WriteLine("Ercille");
                    escribir.WriteLine("Escalante");
                    escribir.WriteLine("Escobar");
                    escribir.WriteLine("Escavias");
                    escribir.WriteLine("Escama");
                    escribir.WriteLine("Escudero");
                    escribir.WriteLine("Espaser");
                    escribir.WriteLine("Esquerdo");
                    escribir.WriteLine("Espinosa");
                    escribir.WriteLine("Estébanez");

                    escribir.WriteLine("");

                    escribir.WriteLine("Ferreri");
                    escribir.WriteLine("Fernandez");
                    escribir.WriteLine("Fagundez");
                    escribir.WriteLine("Fieltro");

                    escribir.WriteLine("");

                    escribir.WriteLine("Gavira");
                    escribir.WriteLine("Gaztelu");
                    escribir.WriteLine("Giraldo");
                    escribir.WriteLine("Gispert");
                    escribir.WriteLine("Godoy");
                    escribir.WriteLine("Goicoechea");
                    escribir.WriteLine("Goiri");
                    escribir.WriteLine("Golfín");
                    escribir.WriteLine("Góngora");
                    escribir.WriteLine("Goñi");
                    escribir.WriteLine("Gordon");
                    escribir.WriteLine("Gorostidi");
                    escribir.WriteLine("Grandes");
                    escribir.WriteLine("Guadalajara");
                    escribir.WriteLine("Guerra");
                    escribir.WriteLine("Guiral");
                    escribir.WriteLine("Guirao");
                    escribir.WriteLine("Gitano");
                    escribir.WriteLine("Goya");
                    escribir.WriteLine("Gurruchaga");

                    escribir.WriteLine("");

                    escribir.WriteLine("Hedilla");
                    escribir.WriteLine("Hera");
                    escribir.WriteLine("Hermosa");
                    escribir.WriteLine("Hernani");
                    escribir.WriteLine("Hermida");

                    escribir.WriteLine("");

                    escribir.WriteLine("Laborda");
                    escribir.WriteLine("Lago");
                    escribir.WriteLine("Lama");
                    escribir.WriteLine("Lanza");
                    escribir.WriteLine("Latorre");
                    escribir.WriteLine("Lecumberri");
                    escribir.WriteLine("Lecuona");
                    escribir.WriteLine("Legazpi");
                    escribir.WriteLine("León");
                    escribir.WriteLine("Lerma");
                    escribir.WriteLine("Liaño");
                    escribir.WriteLine("Linares");
                    escribir.WriteLine("Llamas");
                    escribir.WriteLine("Llave");
                    escribir.WriteLine("Llanos");

                    escribir.WriteLine("");

                    escribir.WriteLine("Nadal");
                    escribir.WriteLine("Narváez");
                    escribir.WriteLine("Navaja");
                    escribir.WriteLine("Navarro");
                    escribir.WriteLine("Naves");
                    escribir.WriteLine("Neira");
                    escribir.WriteLine("Neyra");
                    escribir.WriteLine("Nogueira");
                    escribir.WriteLine("Nogués");
                    escribir.WriteLine("Nova");
                    escribir.WriteLine("Nieto");
                    escribir.WriteLine("Neyra");

                    escribir.WriteLine("");

                    escribir.WriteLine("O Donell");
                    escribir.WriteLine("Ojeda");
                    escribir.WriteLine("Oliva");
                    escribir.WriteLine("Olivares");
                    escribir.WriteLine("Oller");
                    escribir.WriteLine("Olid");
                    escribir.WriteLine("Olmedo");
                    escribir.WriteLine("Olmo");
                    escribir.WriteLine("Ontiveros");
                    escribir.WriteLine("Oraa");
                    escribir.WriteLine("Olivender");

                    escribir.WriteLine("");

                    escribir.WriteLine("Pereira");
                    escribir.WriteLine("Pereyra");
                    escribir.WriteLine("Perez");
                    escribir.WriteLine("Pauloz");
                    escribir.WriteLine("Porsime");

                    escribir.WriteLine("");

                    escribir.WriteLine("Quindós");
                    escribir.WriteLine("Quintana");
                    escribir.WriteLine("Quintero");
                    escribir.WriteLine("Quiroga");
                    escribir.WriteLine("Quirós");
                    escribir.WriteLine("Quiñones");
                    escribir.WriteLine("Quindós");
                    escribir.WriteLine("Quiza");
                    escribir.WriteLine("Quantum");

                    escribir.WriteLine("");

                    escribir.WriteLine("Redondo");
                    escribir.WriteLine("Rendón");
                    escribir.WriteLine("Requena");
                    escribir.WriteLine("Revilla");
                    escribir.WriteLine("Ribas");
                    escribir.WriteLine("Rico");
                    escribir.WriteLine("Rincón");
                    escribir.WriteLine("Río");
                    escribir.WriteLine("Ripol");
                    escribir.WriteLine("Riquer");
                    escribir.WriteLine("Rivelles");
                    escribir.WriteLine("Rivero");
                    escribir.WriteLine("Roa");
                    escribir.WriteLine("Robles");
                    escribir.WriteLine("Romay");
                    escribir.WriteLine("Romany");
                    escribir.WriteLine("Rojo");
                    escribir.WriteLine("Roca");
                    escribir.WriteLine("Roldán");
                    escribir.WriteLine("Rosa");
                    escribir.WriteLine("Romero");
                    escribir.WriteLine("Rovira");
                    escribir.WriteLine("Rubiales");
                    escribir.WriteLine("Rubio");
                    escribir.WriteLine("Rueda");
                    escribir.WriteLine("Rubalcava");
                    escribir.WriteLine("Rosales");

                    escribir.WriteLine("");

                    escribir.WriteLine("Saavedra");
                    escribir.WriteLine("Sabater");
                    escribir.WriteLine("Sacristán");
                    escribir.WriteLine("Sáenz");
                    escribir.WriteLine("Sagarra");
                    escribir.WriteLine("Sainz");
                    escribir.WriteLine("Sala");
                    escribir.WriteLine("Salaberry");
                    escribir.WriteLine("Salazar");
                    escribir.WriteLine("Salcedo");
                    escribir.WriteLine("Sales");
                    escribir.WriteLine("Salgado");
                    escribir.WriteLine("Salinas");
                    escribir.WriteLine("Samaniego");
                    escribir.WriteLine("Sanchez");
                    escribir.WriteLine("Sanchiz");
                    escribir.WriteLine("Santos");
                    escribir.WriteLine("Sanz");
                    escribir.WriteLine("Sardá");
                    escribir.WriteLine("Sartorius");
                    escribir.WriteLine("Schnieper");
                    escribir.WriteLine("Segura");
                    escribir.WriteLine("Seguro");
                    escribir.WriteLine("Serna");

                    escribir.WriteLine("");

                    escribir.WriteLine("Vahamonde");
                    escribir.WriteLine("Vegas");
                    escribir.WriteLine("Vagano");

                    #endregion

                    escribir.Close();
                }

                //Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
                StreamReader leer = new StreamReader(rutaArchivo + nombLista);

                //Si la lista ya existeo fue creada, la cargo en memoria
                int contador = 0;
                string linea;

                while (!leer.EndOfStream)
                {
                    contador++;

                    //Leemos cada linea del archivo TXT
                    linea = leer.ReadLine();

                    //Si la linea esta vacia, evito agregarla a la lista
                    if (string.IsNullOrEmpty(linea))
                    {
                        continue;
                    }

                    if (contador > 9)
                    {
                        Apellidos.Add(linea);
                    }
                }

                leer.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion



    }
}
