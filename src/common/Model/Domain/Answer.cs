using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Domain
{
    public class Answer
    {
        //Id de la respuesta
        [Key]
        public long AnswerId { get; set; }

        //Pregunta
        public Question Question { get; set; }
        public int QuestionId { get; set; }
        
        //Opcion respondida
        public Option Option { get; set; }
        public int OptionId { get; set; }

        //Persona que respondio
        public Person Person { get; set; }
        public long PersonId { get; set; }
    }
}
