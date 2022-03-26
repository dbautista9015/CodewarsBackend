using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodewarsBackend.Models;
using CodewarsBackend.Services.Context;
using Microsoft.AspNetCore.Http.Features;

namespace CodewarsBackend.Services
{
    public class CohortService
    {
        private readonly DataContext _context;
        public CohortService(DataContext context)
        {
            _context = context;
        }

        public bool AddCohort(CohortModel newCohortModel)
        {
            bool result = false;
            bool doesCohortExist = _context.CohortInfo.SingleOrDefault(cohort => cohort.CohortName == newCohortModel.CohortName)!=null;
            if(!doesCohortExist)
            {
                 _context.Add(newCohortModel);
                result= _context.SaveChanges() != 0;
            }
           
            return result;
        }

        public IEnumerable<CohortModel> GetAllCohorts()
        {
            return _context.CohortInfo;
        }

        public CohortModel GetCohortById(int id)
        {
            return _context.CohortInfo.SingleOrDefault(item => item.Id == id);
        }

        public CohortModel GetCohortByCohortName(string cohortName)
        {
            return _context.CohortInfo.SingleOrDefault(item => item.CohortName == cohortName);
        }

        public IEnumerable<CohortModel> GetArchivedCohorts()
        {
            return _context.CohortInfo.Where(item => item.IsArchived);
        }

        public bool ArchiveByCohortName(string? cohortName)
        {
            bool result=false;
            CohortModel foundCohort=GetCohortByCohortName(cohortName);
            if(foundCohort != null)
            {
                foundCohort.IsArchived=!foundCohort.IsArchived;
                _context.Update<CohortModel>(foundCohort);
                result = _context.SaveChanges()!=0;
            }
            return result;
        }

        //delete a cohort
        public bool DeleteByCohortName(string? cohortName)
        {
            bool result=false;
            CohortModel foundCohort=GetCohortByCohortName(cohortName);
            if(foundCohort != null)
            {
                foundCohort.IsDeleted=!foundCohort.IsDeleted;
                _context.Update<CohortModel>(foundCohort);
                result = _context.SaveChanges()!=0;
            }
            return result;
        }

        public bool DeleteByCohortId(int cohortId)
        {
            bool result=false;
            CohortModel foundCohort=GetCohortById(cohortId);
            if(foundCohort != null)
            {
                foundCohort.IsDeleted=!foundCohort.IsDeleted;
                _context.Update<CohortModel>(foundCohort);
                result = _context.SaveChanges()!=0;
            }
            return result;
        }

        public bool UpdateCohortLvlDifficulty(string? cohortName, int lvlDiffculty)
        {
            bool result=false;
            CohortModel foundCohort=GetCohortByCohortName(cohortName);
            if(foundCohort != null)
            {
                foundCohort.LvlDifficulty = lvlDiffculty;
                _context.Update<CohortModel>(foundCohort);
                result = _context.SaveChanges()!=0;
            }
            return result;
        }

        public bool EditCohortName(string? oldCohortName, string? updatedCohortName)
        {
            bool result=false;
            CohortModel foundCohort=GetCohortByCohortName(oldCohortName);
            if(foundCohort != null)
            {
                foundCohort.CohortName = updatedCohortName;
                _context.Update<CohortModel>(foundCohort);
                result = _context.SaveChanges()!=0;
            }
            return result;        
        }

    }
}