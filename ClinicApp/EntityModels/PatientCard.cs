using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicApp.EntityModels
{
    public enum Gender
    {
        [Description("Мужской")]
        Male,
        [Description("Женский")]
        Female
    };
    public class PatientCard
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Gender Gender { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateOfBirth { get; set; }
        public String Address { get; set; }
        public String PhoneNumber { get; set; }
        public List<Request> Requests { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }
    }
}
