namespace ToDoList.Models 
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ToDoList")]
    public partial class ToDoList
    {
        public int Id { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage= "Required Field")]
        public string ItemName { get; set; }

        [Required]
        
        private DateTime? _DeadLine;
        [Required(ErrorMessage = "Required Field")]
        public DateTime? DeadLine
        {
            get { return _DeadLine == null ? DateTime.Now : _DeadLine; }
            set { _DeadLine = value == null ? DateTime.Now : value; }
        }

        private DateTime? _CreatedDate;

        public DateTime? CreatedDate
        {
            get { return _CreatedDate == null ? DateTime.Now : _CreatedDate; }
            set { _CreatedDate  = value == null ? DateTime.Now : value; }
        }

        private int? _Done;

        public int? Done
        {
            get { return _Done == null ? 0 : _Done; ; }
            set { _Done = value == null ? 0 : value; }
        }



    }
}
