using System;

namespace Logica
{
    public class Constantes
    {
        /// <summary>
        /// VALORES CONSTANTES UTILIZADAS POR EL SISTEMA
        /// </summary>
        /// 
        /// <autor>
        /// Elementary Solutions
        /// </autor>
        

        /////////////////////////////////////////
        //// VALORES POR DEFAULT DEL SISTEMA ////
        /////////////////////////////////////////
        public const double DBA_Version = 1.1; //
        public const int DBA_Idioma = 0;       //
        public const int DBA_Motor = 0;        //
        /////////////////////////////////////////


        /// <summary> Idiomas disponibles para seleccionar en el sistema </summary>
        public const int IdiomaEspañol = 0;
        public const int IdiomaIngles = 1;
        public const int IdiomaJapones = 2; // NO DISPONIBLE
        public const int IdiomaFrances = 3; // NO DISPONIBLE
        /////////////////////////////////////////////////////////////////////////////


        ///<summary> Motores de Base de datos disponibles para seleccionar en el sistema </summary>
        public const int SQLServer = 0; 
        public const int MySQL = 1;
        public const int PostgreSQL = 2; //NO DISPONIBLE
        public const int OracleSQL = 3; // NO DISPONIBLE
        public const int Informix = 4; // NO DISPONIBLE
        ///////////////////////////////////////////////////////////////////////////////////////////



        ///<summary> Erroers del sistema </summary>

    }
}
