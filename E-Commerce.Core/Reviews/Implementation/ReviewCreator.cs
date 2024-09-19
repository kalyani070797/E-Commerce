using E_Commerce.Core.Reviews.Interface;
using E_Commerce.Infrastructure.Tables.Ecommerces;
using E_Commerce.Infrastructure.UseDbContext;
using E_Commerce.Model.Ecommerces.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Reviews.Implementation
{
    public class ReviewCreator(ECommerceDbContext eCommerceDb) : IReviewCreator
    {
        public void CreateReview(ReviewRequestModel reviewRequestModel)
        {
            var createReview = new Review()
            {
                CustomerId = reviewRequestModel.CustomerId,
                ProductId = reviewRequestModel.ProductId,
                Rating = reviewRequestModel.Rating,
                Comment = reviewRequestModel.Comment,
                CreatedOn = reviewRequestModel.CreatedOn,
            };
            eCommerceDb.Review.Add(createReview);
            eCommerceDb.SaveChanges();
        }
    }
}
