using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Domain
{
    public class Option
    {
        [Key]
        public int OptionId { get; set; }
        //Dexcripcion de la opcion
        public string Desciption { get; set; }
        //Orden 
        public int Order { get; set; }
        //Valor que representa la opcion
        public float Value { get; set; }

        //Pregunta la que pertence
        public Question Question { get; set; }
        public int QuestionId { get; set; }
    }
}
