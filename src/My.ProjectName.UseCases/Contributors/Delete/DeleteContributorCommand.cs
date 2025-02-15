﻿using Ardalis.Result;
using Ardalis.SharedKernel;

namespace My.ProjectName.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
