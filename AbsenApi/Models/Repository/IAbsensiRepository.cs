﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbsenApi.Models.Filters;

namespace AbsenApi.Models.Repository
{
    public interface IAbsensiRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);

        void Delete(TEntity entity);
        IEnumerable<Absensi> Find(AbsensiFilter filter);
    }
}