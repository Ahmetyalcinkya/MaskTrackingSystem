using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class PttManager : SupplierService
    {
        private ApplicantService _applicantService;

        public PttManager(ApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            if(_applicantService.CheckPerson(person)){
                Console.WriteLine(person.FirstName + " already a mask!");
            } else {
                Console.WriteLine(person.FirstName + " does not have a mask yet!");
            }
        }
    }
}
