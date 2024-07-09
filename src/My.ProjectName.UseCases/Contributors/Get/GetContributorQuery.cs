using Ardalis.Result;
using Ardalis.SharedKernel;

namespace My.ProjectName.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
