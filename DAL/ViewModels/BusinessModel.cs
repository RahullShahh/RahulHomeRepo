using DAL.DataModels;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class BusinessModel
    {
        [Required]
        public string BsFirstName {  get; set; }  
        public string? BsLastName {  get; set; }
        [Required]
        public string? BusinessPhoneNo {  get; set; }
        [Required]
        public string? BusinessCountryCode {  get; set; }
        [Required]
        public string BsEmail {  get; set; }
        public string BusinessName {  get; set; }
        public int? BsCaseNo {  get; set; }
        public string? Symptoms {  get; set; }
        public string PtFirstName {  get; set; }
        public string PtLastName { get; set;}
        public DateTime? PatientDateOfBirth{  get; set; } 
        public string PtEmail { get; set; }
        public string Street {  get; set; }
        public string? city {  get; set; }
        public string zipcode {  get; set; }
        [Required]
        public int state {  get; set; }
        public List<Region>? Regions { get; set; }
        public string? room {  get; set; }
        public string? PatientPhoneNo { get; set; }  
        public string? PatientCountryCode { get; set; }
    }
}
