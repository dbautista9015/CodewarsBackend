using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using CodewarsBackend.Models;
using CodewarsBackend.Services.Context;

namespace CodewarsBackend.Services
{
    public class ReserveService
    {
        private readonly DataContext _context;

        public ReserveService(DataContext context)
        {
            _context=context;
        }

        public List<ReserveModel> CurrentReservationsByUsername(string? username)
        {
            return _context.ReserveInfo.Where(item => item.CodewarsName==username && item.IsCompleted==false&& item.IsDeleted==false).ToList();
        }
        public bool IsItReserved(ReserveModel reservation)
        {
            bool found = false;
                ReserveModel foundReservation = _context.ReserveInfo.SingleOrDefault(item => item.CohortName==reservation.CohortName && item.KataId==reservation.KataId && item.KataLanguage==reservation.KataLanguage && item.IsDeleted==true);

                if(foundReservation!=null)
                {
                    found=true;
                }
            return found ;
        }

        public ReserveModel FindReservationById(int id)
        {
            return _context.ReserveInfo.SingleOrDefault(item => item.Id == id);
        }


        public bool CreateReservation(ReserveModel newReservation)
        {
            bool result = false;
            bool FoundReservation = IsItReserved(newReservation);
            if(!FoundReservation)
            {
                List<ReserveModel>ReservationsByUser=CurrentReservationsByUsername(newReservation.CodewarsName);
                if(ReservationsByUser.Count<3)
                {
                    _context.Add(newReservation);
                    result = _context.SaveChanges()!=0;
                    
                }
                
            }
            return result;
        }

        public bool ChangeReservationCompletedStatus(int id)
        {
            bool result = false;
            ReserveModel foundReservation = FindReservationById(id);
            if(foundReservation !=null)
            {
                foundReservation.IsCompleted=!foundReservation.IsCompleted;
                _context.Update<ReserveModel>(foundReservation);
                result = _context.SaveChanges()!=0;
            }
            return result;
        }

        public bool ChangeReservationStatus(int id)
        {
            bool result = false;
            ReserveModel foundReservation = FindReservationById(id);
            if(foundReservation !=null)
            {
                foundReservation.IsDeleted=!foundReservation.IsDeleted;
                _context.Update<ReserveModel>(foundReservation);
                result = _context.SaveChanges()!=0;
            }
            return result;
        }

        public IEnumerable<ReserveModel>GetAllReservations()
        {
            return _context.ReserveInfo;
        }

         public ReserveModel GetReservationById(int id)
        {
            return _context.ReserveInfo.SingleOrDefault(item=> item.Id == id);
        }

         public IEnumerable<ReserveModel> GetReservationsByUsername(string username)
        {
            return _context.ReserveInfo.Where(item => item.CodewarsName==username);
        }
        public IEnumerable<ReserveModel> GetAllCompletedKataReservations()
        {
            return _context.ReserveInfo.Where(item => item.IsCompleted==true);
        }

          public IEnumerable<ReserveModel>GetReservedKatasByCohortId(string? cohortName)
        {
            return _context.ReserveInfo.Where(item => item.CohortName==cohortName);
        }

         public IEnumerable<ReserveModel> GetAllCompletedKatasByCohortId(string? cohortName)
        {
            return _context.ReserveInfo.Where(item => item.CohortName==cohortName && item.IsCompleted==true);
        }

        public IEnumerable<ReserveModel>GetReservedKatasByKataLanguage(string? kataLanguage)
        {
            return _context.ReserveInfo.Where(item => item.KataLanguage==kataLanguage);
        }


    }
}