using E_Commerce.Model.Ecommerces.Reviews;

namespace E_Commerce.Core.Reviews.Interface
{
    public interface IReviewCreator
    {
        void CreateReview(ReviewRequestModel reviewRequestModel);
    }
}