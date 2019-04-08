using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Domain
{
    public class Result
    {

        [Key]
        public long ResultId { get; set; }
        //Carrera
        public String Career { get; set; }
        //Resultado del test
        public float TestResult { get; set; }
        //Resultados de la persona
        public Person Person { get; set; }
        public long PersonId { get; set; }
    }
}
