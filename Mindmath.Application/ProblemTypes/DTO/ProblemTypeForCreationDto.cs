﻿namespace Mindmath.Application.ProblemTypes.DTO
{
	public record ProblemTypeForCreationDto
	{
		public string Name { get; init; }
		public string Description { get; init; }
	}
}