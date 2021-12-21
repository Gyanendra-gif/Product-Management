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
            ManagementOperation operation = new ManagementOperation();
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
                new ProductReview(){productId=10, userId=10, rating=5, review="Good", isLike=true},
                new ProductReview(){productId=11, userId=10, rating=5, review="Good", isLike=true},
                new ProductReview(){productId=12, userId=10, rating=5, review="Bad", isLike=true},
                new ProductReview(){productId=13, userId=10, rating=5, review="Poor", isLike=true},
                new ProductReview(){productId=14, userId=10, rating=5, review="Good", isLike=true},
                new ProductReview(){productId=15, userId=10, rating=5, review="Bad", isLike=true}
            };
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-Display Data, 2-Retrive Data, 3-Display Data Based on Product Id, 4-Count Product Id, " +
                    "5-Retreive by ProductId, 6-Skip Records, 7-Data Table, 8-Review Records, 9-Average of Records, 10-Retrive Product and Review, 11-Retrive Data Where UserId=10, 12-Exit");
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
                        ManagementOperation.RetriveProductIdAndReviw(list);
                        break;
                    case 6:
                        ManagementOperation.SkipTopRatingsRecords(list);
                        break;
                    case 7:
                        operation.ProductReviewDataTable(list);
                        break;
                    case 8:
                        operation.RetriveRecordsFromDataTable();
                        break;
                    case 9:
                        operation.AveragePerProductId(list);
                        break;
                    case 10:
                        operation.RetreiveProductIdAndReview(list, "nice");
                        break;
                    case 11:
                        operation.RetriveRecordsFromDataTableWhereUserId();
                        break;
                    case 12:
                        flag = false;
                        break;
                }
            }
        }
    }
}
