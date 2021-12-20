using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReviewManagement
{
    class ManagementOperation
    {
        public static void Display(List<ProductReview> list)
        {
            foreach (ProductReview product in list)
            {
                Console.WriteLine("Productid:" + product.productId + "UserId:" + product.userId + "Rating:" + product.rating
                    + "Review" + product.review + "isLike" + product.isLike);
            }
        }
    }
}
