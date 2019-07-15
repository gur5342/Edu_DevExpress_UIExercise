using DevChinook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevChinook.DAL
{
    public static class CustomerDAL
    {
        public static List<Customer> search()
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                var query = from x in context.Customers
                            select x;

                foreach (var item in query)
                {
                    item.Name = item.FirstName + " " + item.LastName;
                    item.FullAddress = item.Address + " " + item.City + " " + item.State + (item.State == null ? null : " ") + item.Country + " " + (item.State == null ? null : " ") + item.PostalCode;
                }

                var customers = query.ToList();

                return customers;
            }
        }

        //public static List<ChartModel> makeChartData()
        //{
        //    using (ChinookEntities context = new ChinookEntities())
        //    {
        //        List<ChartModel> chartModels = new List<ChartModel>();
        //        var countries = context.Customers.GroupBy(x => x.Country).Select(x => x);


        //    }

        //    }
        }
    }
