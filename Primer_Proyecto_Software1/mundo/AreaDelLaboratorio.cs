using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioMedico.mundo
{
    class AreaDelLaboratorio
    {
        //Hola amiwis ya pude

        //Wenas wenas
        //Otro wenas wenas

        /*
         *  Nombre del area
         */
        private String nombreArea;

        /*
         *  Cantidad de pacientes en el area
         */
        private int cantidadPacientes;

        /*
         *  Capacidad del area
         */
        private int capacidad;

        /*
         *  Primer paciente en el area
         */
        private Paciente primero;


        //-----------------------------------------------------------------
        // Constructores
        //-----------------------------------------------------------------

        /*
         *  Construye una area del laboratorio
         */
        public AreaDelLaboratorio(string pNombreArea, int pCapacidad)
        {
            nombreArea = pNombreArea;
            cantidadPacientes = 0;
            capacidad = pCapacidad;
        }

        //-----------------------------------------------------------------
        // Métodos
        //-----------------------------------------------------------------


        /*
        * Retorna o cambia el nombre del area
        */
        public string NombreArea { get => nombreArea; set => nombreArea = value; }
       
        /*
         * Retorna o cambia la cantidad de pacientes que tiene el area
         */
        public int CantidadPacientes { get => cantidadPacientes; set => cantidadPacientes = value; }
        
        /*
        * Retorna o cambia la capacidad que puede tener el area
        */
        public int Capacidad { get => capacidad; set => capacidad = value; }

        /*
         *  Agrega un paciente al final del area
         */
        public void ingresarPaciente (Paciente pacienteNuevo)
        {
            if ( primero == null )
            {
                primero = pacienteNuevo;
            }
            else
            {
                // Busca el último paciente de la lista
                Paciente p = localizarUltimo();

                // Adiciona el paciente después del último paciente de la lista
                p.insertarDespues(pacienteNuevo);
            }
            cantidadPacientes++;

        }

        public Paciente localizarUltimo()
        {
            Paciente actual = primero;

            if (actual != null)
            {
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
            }
            return actual;
        }

        public void aprobarExamen()
        {

        }
    }
}
