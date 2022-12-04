using System;
using System.Collections.Generic;
using System.Text;

namespace WASP_PR_3
{
    interface IStoreItem
    {
        double Price { get; set; }
        void DiscountPrice(int percent)
        {
            Price -= Price * percent / 100;
        }
    }
}
