using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class ContactUsManager : IContactUsServices
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void Tdelete(ContactUs t)
        {
            _contactUsDal.Delete(t);
        }

        public ContactUs TgetById(int? id)
        {
            return _contactUsDal.GetById(id);
        }

        public List<ContactUs> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public void Tinsert(ContactUs t)
        {
            _contactUsDal.Insert(t);
        }

        public void Tupdate(ContactUs t)
        {
            _contactUsDal.Update(t);
        }
    }
}
