using Grpc.Core;
using System.Threading.Tasks;
using RESTApi;

public class ProductService : ProductService.ProductServiceBase
{
    public override Task<ProductResponse> GetProductDetails(ProductRequest request, ServerCallContext context)
    {
        // Simulate fetching product details. In a real app, this would query the database.
        var productDetails = $"Details for Product ID: {request.ProductId}";

        return Task.FromResult(new ProductResponse
        {
            ProductDetails = productDetails
        });
    }
}
