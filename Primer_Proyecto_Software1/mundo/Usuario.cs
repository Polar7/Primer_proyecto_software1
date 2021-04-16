using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioMedico.mundo
{
    /*
     * Clase que moldea un paciente en un laboratorio medico para recibir licencia de conduccion
     */
    class Usuario
    {
        // -----------------------------------------------------------------
        // Atributos
        // -----------------------------------------------------------------

        /**
        * Cedula del usuario
        */
        private int cedula;

        /**
         * Nombre del usuario
         */
        private String nombreCompleto;

        /**
         * Area en la que se ubica el usuario
         */
        private String areaUbicado;

        /**
         * Sexo del usuario
         */
        private char sexo;
    
        /*
         *  Contador que almacena cuantos examenes a aprobado
         */
        private int examenesAprobados;

        /*
        * Indica si el usuario es apto para recibir su licencia
        */
        private bool licenciaAprobada;


        /*
         *  El siguiente usuario en el area
         */
        private Usuario siguiente;

        //-----------------------------------------------------------------
        // Constructores
        //-----------------------------------------------------------------

        /*
         *  Construye un usuario
         */
        public Usuario(int pCedula, string pNombreCompleto, string pAreaUbicado, char pSexo)
        {
            cedula = pCedula;

            nombreCompleto = pNombreCompleto;

            areaUbicado = pAreaUbicado;

            sexo = pSexo;

            examenesAprobados = 0;

            licenciaAprobada = false;

            siguiente = null;
        }


        //-----------------------------------------------------------------
        // Métodos
        //-----------------------------------------------------------------

        /*
         * Retorna o cambia la cedula del usuario
         */
        public int Cedula { get => cedula; set => cedula = value; }

        /*
         * Retorna o cambia el nombre del usuario
         */
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }

        /*
         * Retorna o cambia el area donde está ubicado del usuario
         */
        public string AreaUbicado { get => areaUbicado; set => areaUbicado = value; }

        /*
         * Retorna o cambia sexo del usuario
         */
        public char Sexo { get => sexo; set => sexo = value; }

        /*
         * Retorna o cambia el estado de la licencia del usuario
         */
        public bool LicenciaAprobada { get => licenciaAprobada; set => licenciaAprobada = value; }

        /*
         * Retorna o cambia la cantidad de examanes del usuario
         */
        public int ExamenesAprobados { get => examenesAprobados; set => examenesAprobados = value; }

        /*
         * Retorna o cambia el siguiente usuario en el area
         */
        public Usuario Siguiente { get => siguiente; set => siguiente = value; }


        public void insertarDespues(Usuario nuevoPaciente)
        {
            nuevoPaciente.Siguiente = siguiente;
            siguiente = nuevoPaciente;
        }
        /*
         *  Retorna una cadena con la información del usuario
         */
        public String toString()
        {
            return "[ " + cedula + " ]: " + nombreCompleto;
        }
    }
}
