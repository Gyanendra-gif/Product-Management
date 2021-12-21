using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Project Review Management Program");
            ProductReview product = new ProductReview();
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){productId=1, userId=1, rating=5, review="Good", isLike=true},
                new ProductReview(){productId=2, userId=2, rating=4, review="Bad", isLike=true},
                new ProductReview(){productId=3, userId=3, rating=3, review="Average", isLike=true},
                new ProductReview(){productId=4, userId=4, rating=5, review="Good", isLike=true},
                new ProductReview(){productId=5, userId=5, rating=5, review="Good", isLike=true},
                new ProductReview(){productId=6, userId=6, rating=5, review="Poor", isLike=true},
                new ProductReview(){productId=7, userId=7, rating=5, review="Good", isLike=true},
                new ProductReview(){productId=8, userId=8, rating=5, review="Average", isLike=true},
                new ProductReview(){productId=9, userId=9, rating=5, review="Good", isLike=true},
                new ProductReview(){productId=10, userId=10, rating=5, review="Good", isLike=true}
            };
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-Display Data, 2-Retrive Data, 3-Display Data Based on Product Id, 4-Count Product Id, 5-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ManagementOperation.Display(list);
                        break;
                    case 2:
                        ManagementOperation.SelectTopRatingsRecords(list);
                        break;
                    case 3:
                        ManagementOperation.SelectRecordsBasedOnProductId(list);
                        break;
                    case 4:
                        ManagementOperation.CountingProductId(list);
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
