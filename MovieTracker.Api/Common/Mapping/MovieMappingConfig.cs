using Mapster;

using MovieTracker.Application.Movie.Common;
using MovieTracker.Application.Movie.Querise.GetMovie;
using MovieTracker.Contracts.Movie;

namespace MovieTracker.Api.Common.Mapping;

public class MovieMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Guid, MovieQuery>()
            .Map(dest => dest.Id, src => src);

        config.NewConfig<MovieResult, MovieResponse>()
            .Map(dest => dest, src => src.Movie);
    }
}
