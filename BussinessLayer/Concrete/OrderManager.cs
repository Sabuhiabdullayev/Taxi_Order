using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessLayer.Concrete
{
    public class OrderManager : IOrderServices
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void Tdelete(Order t)
        {
            _orderDal.Delete(t);
        }

        public Order TgetById(int? id)
        {
            return _orderDal.GetById(id);
        }

        public List<Order> TGetList()
        {
            return _orderDal.GetList();
        }

        public void Tinsert(Order t)
        {
            _orderDal.Insert(t);
        }

        public void Tupdate(Order t)
        {
            _orderDal.Update(t);
        }
    }
}
