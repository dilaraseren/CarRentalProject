using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto :IDto
    {
        
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }

        public int ModelYear { get; set; }
        public string Description { get; set; }
        public int DailyPrice { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string RentDate { get; set; }
        public string ReturnDate { get; set; }

    }
}
