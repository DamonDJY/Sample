using Ardalis.Result;
using Ardalis.SharedKernel;

namespace DamonPros.Sample.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
