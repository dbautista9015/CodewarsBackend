using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodewarsBackend.Models;
using CodewarsBackend.Services.Context;

namespace CodewarsBackend.Services
{
    public class CohortService
    {
        private readonly DataContext _context;
        public CohortService(DataContext context)
        {
            _context = context;
        }

        //add new cohort
        public bool AddCohort(CohortModel newCohortModel)
        {
            _context.Add(newCohortModel);
            return _context.SaveChanges() != 0;
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


        //change
        // public bool ChangeAdminStatus(string?username)
        // {
        //     bool result=false;
        //     UserModel foundUser=GetUserByUsername(username);
        //     if(foundUser!=null)
        //     {
        //         foundUser.IsAdmin=!foundUser.IsAdmin;
        //         _context.Update<UserModel>(foundUser);
        //         result = _context.SaveChanges()!=0;
        //     }
        //     return result;
        // }

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

    }
}