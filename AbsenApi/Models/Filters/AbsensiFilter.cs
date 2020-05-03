using System.Collections.Generic;


namespace AbsenApi.Models.Filters
{
    public enum SortByKehadiran
    {
        ASC,
        DESC
    }
    public class AbsensiFilter
    {
        public AbsensiFilter() { 
        Ids = new List<long>();
        }

        public string Username { get; set; }

        public string Keterangan { get; set; }

        public SortByKehadiran? SortByWaktu { get; set; }

        public SortByKehadiran? SortByUsername { get; set; }

        public List<long> Ids { get; set; }
    }


}
