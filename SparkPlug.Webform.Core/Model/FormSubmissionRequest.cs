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

        public string _formName { get; set; }

        [Required]

        public string _formDomainName { get; set; }
    }
}
