using System.Collections.Generic;
using System.Linq;
using AbsenApi.Models.Filters;
using AbsenApi.Models.Repository;

namespace AbsenApi.Models.DataManager
{
    public class AbsensiManager : IAbsensiRepository<Absensi>
    {
        readonly EmployeeContext _employeeContext;

        public AbsensiManager(EmployeeContext context)
        {
            _employeeContext = context;
        }

        public IEnumerable<Absensi> GetAll()
        {
            return _employeeContext.Absensi.ToList();
        }

        public void Add(Absensi entity)
        {
            _employeeContext.Absensi.Add(entity);
            _employeeContext.SaveChanges();
        }

        public void Delete(Absensi entity)
        {
            _employeeContext.Absensi.Remove(entity);
            _employeeContext.SaveChanges();
        }

        public IEnumerable<Absensi> Find(AbsensiFilter filter)
        {
            IQueryable<Absensi> query = _employeeContext.Absensi;

            if (filter.Ids.Any())
                query = query.Where(o => filter.Ids.Contains(o.id_absensi));

            if (!string.IsNullOrEmpty(filter.Username))
                query = query.Where(o => o.Username.Contains(filter.Username));

            if (!string.IsNullOrEmpty(filter.Keterangan))
                query = query.Where(o => o.Keterangan.Contains(filter.Keterangan));

            /*if (!string.IsNullOrEmpty(filter.State))
                query = query.Where(o => o.State.Contains(filter.State));

            if (!string.IsNullOrEmpty(filter.CheckIn))
                query = query.Where(o => o.CheckIn.ToString().Contains(filter.CheckIn));

            if (!string.IsNullOrEmpty(filter.Approval))
                  query = query.Where(o => o.Approval.Contains(filter.Approval)); 

            if (!string.IsNullOrEmpty(filter.HeadDivision))
                query = query.Where(o => o.HeadDivision.Contains(filter.HeadDivision));

            if (!string.IsNullOrEmpty(filter.ApprovalByAdmin))
                query = query.Where(o => o.ApprovalByAdmin.Contains(filter.ApprovalByAdmin));*/

          /*  if (filter.SortByUsername.HasValue && filter.SortByUsername.Value == SortByAtOffice.ASC)
                query = query.OrderBy(o => o.Username);

            if (filter.SortByUsername.HasValue && filter.SortByUsername.Value == SortByAtOffice.DESC)
                query = query.OrderByDescending(o => o.Username);*/

            /*      if (filter.SortByDate.HasValue && filter.SortByDate.Value == SortByAtOffice.ASC)
                      query = query.OrderBy(o => o.CheckIn);

                  if (filter.SortByDate.HasValue && filter.SortByDate.Value == SortByAtOffice.DESC)
                      query = query.OrderByDescending(o => o.CheckIn);*/


            return query.ToList();
        }

        public Absensi Get(long id)
        {
            return _employeeContext.Absensi.FirstOrDefault(e => e.id_absensi == id);
        }



        public void Update(Absensi dbEntity, Absensi entity)
        {
            dbEntity.Keterangan = entity.Keterangan;
            dbEntity.waktu_absensi = entity.waktu_absensi;
            dbEntity.Username = entity.Username;

            _employeeContext.SaveChanges();
        }
    }
}
