using Ardalis.Result;
using Ardalis.SharedKernel;

namespace DamonPros.Sample.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
