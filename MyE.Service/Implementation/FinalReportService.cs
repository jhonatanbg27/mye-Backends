using System.Collections.Generic;
using System.Text;
using MyE.Entity;
using MyE.Repository;

namespace MyE.Service.Implementation
{
    public class FinalReportService :IFinalReportService
    {
        private IFinalReportService finalRepository;
        public FinalReportService(IFinalReportService finalRepository)
        {
            this.finalRepository=finalRepository;
        }
        public bool Delete(int id)
        {
            return finalRepository.Delete(id);
        }

        public FinalReport Get(int id)
        {
            return finalRepository.Get(id);
        }

        public IEnumerable<FinalReport> GetAll()
        {
            return finalRepository.GetAll();
        }

        public bool Save(FinalReport entity)
        {
            return finalRepository.Save(entity);
        }

        public bool Update(FinalReport entity)
        {
            return finalRepository.Update(entity);
        }
        public IEnumerable<FinalReport> GetFinalReportsByMemberShip(int membershipId)
        {
            return finalRepository.GetFinalReportsByMemberShip(membershipId);
        }

    }
}