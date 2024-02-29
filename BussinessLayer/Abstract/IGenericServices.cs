using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IGenericServices<T>
    {
        List<T> TGetList();
        void Tinsert(T t);
        void Tdelete(T t);
        void Tupdate(T t);
        T TgetById(int? id);

    }
}
