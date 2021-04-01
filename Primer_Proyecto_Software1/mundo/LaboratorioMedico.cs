using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioMedico.mundo
{
    class LaboratorioMedico
    {
        /*
         *  Cantidad de areas en el laboratorio 
         */
        public const int CANTIDAD_AREAS = 5;


        /*
         *  Contenedora con las areas del laboratorio
         */
        private AreaLaboratorio[] areas;

       
        public LaboratorioMedico ()
        {
            areas = new AreaLaboratorio[CANTIDAD_AREAS];

            areas[0] = new AreaLaboratorio("Sala de espera", 15);
            areas[1] = new AreaLaboratorio("Optometria", 2);
            areas[2] = new AreaLaboratorio("Otorrinolaringología", 4);
            areas[3] = new AreaLaboratorio("Psicologia", 6);
            areas[3] = new AreaLaboratorio("General", 1);
        }


       


    }
}
