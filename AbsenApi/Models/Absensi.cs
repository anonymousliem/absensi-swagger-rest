using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AbsenApi.Models
{
    public class Absensi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_absensi { get; set; }

        public string Username { get; set; }

        public string Keterangan { get; set; }

        public DateTime waktu_absensi { get; set; }

   
    }
}
