using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool IsItReserved(ReserveModel reservation)
        {
            bool found = false;
                ReserveModel foundReservation = _context.ReserveInfo.SingleOrDefault(item => item.CohortId==reservation.CohortId && item.KataId==reservation.KataId && item.KataLanguage==reservation.KataLanguage && item.IsDeleted==false);

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
                _context.Add(newReservation);
            }
            return _context.SaveChanges()!=0;
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

          public IEnumerable<ReserveModel>GetReservedKatasByCohortId(int id)
        {
            return _context.ReserveInfo.Where(item => item.CohortId==id);
        }

         public IEnumerable<ReserveModel> GetAllCompletedKatasByCohortId(int id)
        {
            return _context.ReserveInfo.Where(item => item.CohortId==id && item.IsCompleted==true);
        }

        public IEnumerable<ReserveModel>GetReservedKatasByKataLanguage(string? kataLanguage)
        {
            return _context.ReserveInfo.Where(item => item.KataLanguage==kataLanguage);
        }


    }
}