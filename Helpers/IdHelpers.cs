using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Helpers
{
    public class IdHelpers
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public string ActivityId => GenerateActivityId();
        public string MeetingId => GenerateMeetingId();
        public string BlotterId => GenerateBlotterId();

        private string GenerateActivityId()
        {
            string Id = "Act-0001";
            try
            {

                if (unitOfWork.ActivitiesRepo.Fetch().Any())
                {
                    Id = "Act-" + ((unitOfWork.ActivitiesRepo.Fetch().OrderByDescending(m => m.Id).FirstOrDefault()?.ActivityId?.Split('-')[1].ToInt() + 1).ToInt().ToString("0000"));

                }
            }
            catch (Exception e)
            {

            }
            return Id;
        }
        private string GenerateMeetingId()
        {
            string Id = "Meeting-0001";
            try
            {

                if (unitOfWork.MeetingsRepo.Fetch().Any())
                {
                    Id = "Meeting-" + (unitOfWork.MeetingsRepo.Fetch().OrderByDescending(m => m.Id).FirstOrDefault()?.MeetingId?.Split('-')[1].ToInt() + 1).ToInt().ToString("0000");

                }
            }
            catch (Exception e)
            {

            }
            return Id;
        }
        private string GenerateBlotterId()
        {
            string Id = "Blotter-0001";
            try
            {

                if (unitOfWork.BlottersRepo.Fetch().Any())
                {
                    Id = "Blotter-" + ((unitOfWork.BlottersRepo.Fetch().OrderByDescending(m => m.Id).FirstOrDefault()?.BlotterId?.Split('-')[1].ToInt() + 1).ToInt().ToString("0000"));

                }
            }
            catch (Exception e)
            {

            }
            return Id;
        }
    }
}
