using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SparkPlug.WebForm.Core.Model
{
    public class FormSubmissionRequest
    {
        //[Required]
        //public string CustomerName { get; set; }

        //[Required]
        //[EmailAddress]

        //public string CustomerEmail { get; set; }

        //[Required]

        //public string CustomerMessage { get; set; }


        //public string _formName { get; set; }


        //public string _formDomainName { get; set; }
        [Required]
        [JsonPropertyName("customerName")]
        public string CustomerName { get; set; }

        [Required]
        [EmailAddress]
        [JsonPropertyName("CustomerEmail")]
        public string CustomerEmail { get; set; }

        [Required]
        [JsonPropertyName("customerMessage")]
        public string CustomerMessage { get; set; }

        [Required]
        //[JsonPropertyName("_formName")]
        public string _formName { get; set; }

        [Required]
        //[JsonPropertyName("_formDomainName")]
        public string _formDomainName { get; set; }
    }
}
