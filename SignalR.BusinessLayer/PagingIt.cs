using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer
{
    public static class PagingIt<T>
    {
        /// <summary>
        /// This method paging a list depends on parameters;
        ///     datalist : A list will be provided,
        ///     countInterval : List count needed for paging,
        ///     order : Which page that will be shown. etc --> countInterval=20 and order 3 then third 20 page  will be shown.    
        /// </summary>
        public static List<T> ListPaging(List<T> datalist, int countInterval, int order)
        {

            List<T> list;

            if (order <= 0 || countInterval >= datalist.Count())
            {
                list = datalist;
            }
            else if (order == 1 && countInterval * order <= datalist.Count())
            {
                list = datalist.Take(countInterval).ToList();
            }
            else if (order > 1 && countInterval * order <= datalist.Count())
            {
                list = datalist.Skip((order - 1) * countInterval).Take(countInterval).ToList();
            }
            else if (order > 1 && countInterval * order > datalist.Count())
            {
                list = datalist.Skip((order - 1) * countInterval).Take(datalist.Count() - ((order - 1) * countInterval)).ToList();
            }
            else
            {
                list = new List<T>();
            }

            return list;
        }
    }
}
