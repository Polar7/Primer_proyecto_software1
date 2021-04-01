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
        private AreaDelLaboratorio[] areas;

       
        public LaboratorioMedico ()
        {
            areas = new AreaDelLaboratorio[CANTIDAD_AREAS];

            areas[0] = new AreaDelLaboratorio("Sala de espera", 15);
            areas[1] = new AreaDelLaboratorio("Optometria", 2);
            areas[2] = new AreaDelLaboratorio("Otorrinolaringología", 4);
            areas[3] = new AreaDelLaboratorio("Psicologia", 6);
            areas[3] = new AreaDelLaboratorio("General", 1);
        }


       


    }
}
