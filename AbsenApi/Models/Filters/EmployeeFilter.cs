using System.Collections.Generic;

namespace AbsenApi.Models.Filters
{
    public enum SortByAtOffice
    {
        ASC,
        DESC
    }

    public class EmployeeFilter
    {
        public EmployeeFilter()
        {
            Ids = new List<long>();
        }

        public string Username { get; set; }

        public string Name { get; set; }
        
        public string Role { get; set; }

        public string Password { get; set; }

        public SortByAtOffice? SortByUsername { get; set; }

        public SortByAtOffice? SortByDate { get; set; }
        public List<long> Ids { get; set; }
    }
}