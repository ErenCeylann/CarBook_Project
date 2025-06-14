using CarBook.Application.Features.CQRS.Handlers.AboutHandler;
using CarBook.Application.Features.CQRS.Handlers.BannerHandler;
using CarBook.Application.Features.CQRS.Handlers.BrandHandler;
using CarBook.Application.Features.CQRS.Handlers.CarHandler;
using CarBook.Application.Features.CQRS.Handlers.CategoryHandler;
using CarBook.Application.Features.CQRS.Handlers.ContactHandler;
using CarBook.Application.Features.RepositoryPattern;
using CarBook.Application.Interfaces.AppUserInterfaces;
using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Application.Interfaces.CarDescriptionInterfaces;
using CarBook.Application.Interfaces.CarFeatureInterfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Application.Interfaces.CarPricengInterfaces;
using CarBook.Application.Interfaces.RentACarInterfaces;
using CarBook.Application.Interfaces.ReviewInterfaces;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using CarBook.Application.Interfaces.TagCloudInterfaces;
using CarBook.Application.Interfaces;
using CarBook.Persistence.Context;
using CarBook.Persistence.Repository.AppUserRepositories;
using CarBook.Persistence.Repository.BlogRepository;
using CarBook.Persistence.Repository.CarDescriptionRepositories;
using CarBook.Persistence.Repository.CarFeatureRepositories;
using CarBook.Persistence.Repository.CarPricingRepositories;
using CarBook.Persistence.Repository.CarRepositories;
using CarBook.Persistence.Repository.CommentRepositories;
using CarBook.Persistence.Repository.RentACarRepository;
using CarBook.Persistence.Repository.ReviewRepositories;
using CarBook.Persistence.Repository.StatisticsRepositories;
using CarBook.Persistence.Repository.TagCloudRepositories;
using CarBook.Persistence.Repository;

namespace CarBook.Api.Extensions
{
    public static class ServiceRegistrationExtensions
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services)
        {
            services.AddScoped<GetAboutQueryHandler>();
            services.AddScoped<GetAboutByIdQueryHandler>();
            services.AddScoped<CreateAboutCommandHandler>();
            services.AddScoped<UpdateAboutCommandHandler>();
            services.AddScoped<RemoveAboutCommandHandler>();

            services.AddScoped<GetBannerQueryHandler>();
            services.AddScoped<GetBannerByIdQueryHandler>();
            services.AddScoped<CreateBannerCommandHandler>();
            services.AddScoped<UpdateBannerCommandHandler>();
            services.AddScoped<RemoveBannerCommandHandler>();

            services.AddScoped<GetBrandByIdQueryHandler>();
            services.AddScoped<GetBrandQueryHandler>();
            services.AddScoped<CreateBrandCommandHandler>();
            services.AddScoped<UpdateBrandQueryHandler>();
            services.AddScoped<RemoveBrandCommandHandler>();

            services.AddScoped<GetCarByIdQueryHandler>();
            services.AddScoped<GetCarQueryHandler>();
            services.AddScoped<CreateCarCommandHandler>();
            services.AddScoped<UpdateCarQueryHandler>();
            services.AddScoped<RemoveCarQueryHandler>();
            services.AddScoped<GetCarWithBrandQueryHandler>();
            services.AddScoped<GetLast5CarsWithBrandHandler>();
            services.AddScoped<GetBrandByCarCountHandler>();


            services.AddScoped<GetCategoryByIdQueryHandler>();
            services.AddScoped<GetCategoryQueryHandler>();
            services.AddScoped<CreateCategoryCommandHandler>();
            services.AddScoped<UpdateCategoryQueryHandler>();
            services.AddScoped<RemoveCategoryCommandHandler>();

            services.AddScoped<GetContactByIdQueryHandler>();
            services.AddScoped<GetContactQueryHandler>();
            services.AddScoped<CreateContactCommandHandler>();
            services.AddScoped<UpdateContactQueryHandler>();
            services.AddScoped<RemoveContactCommandHandler>();


            services.AddScoped<CarBookContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(ICarRepositories), typeof(CarRepository));
            services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
            services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingReposityory));
            services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
            services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));
            services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));
            services.AddScoped(typeof(IRentACarRepository), typeof(RentACarRepository));
            services.AddScoped(typeof(ICarFeatureRepository), typeof(CarFeatureRepository));
            services.AddScoped(typeof(ICarDescriptionRepository), typeof(CarDescriptionRepository));
            services.AddScoped(typeof(IReviewRepository), typeof(ReviewRepository));
            services.AddScoped(typeof(IAppUserRepository), typeof(AppUserRepository));

            return services;
        }
    }
}

