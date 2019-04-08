using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Domain
{
    public class Question
    {
        //Id de la pregunta
        [Key]
        public int QuestionId { get; set; }
        //Descripcion
        public string Description { get; set; }
        //Orden de la pregunta, 1,2,3
        public int Order { get; set; }
        //Opciones de la pregunta
        public List<Option> Options { get; set; }
    }
}
