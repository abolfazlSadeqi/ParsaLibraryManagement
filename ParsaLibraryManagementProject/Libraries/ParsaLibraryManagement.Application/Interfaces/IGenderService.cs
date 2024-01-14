﻿using ParsaLibraryManagement.Application.DTOs;

namespace ParsaLibraryManagement.Application.Interfaces;

/// <summary>
///     Interface for services related to Gender.
/// </summary>
/// <remarks>
///     This interface defines methods for interacting with and managing Gender entities.
/// </remarks>
public interface IGenderService
{
    /// <summary>
    ///     Creates a new gender asynchronously.
    /// </summary>
    /// <param name="command">The data for the new gender.</param>
    /// <returns>A task representing the asynchronous operation, yielding a nullable string representing the result message.</returns>
    Task<string?> CreateGenderAsync(GenderDto command);

    /// <summary>
    ///     Gets a gender by its ID asynchronously.
    /// </summary>
    /// <param name="id">The ID of the gender to retrieve.</param>
    /// <returns>A task representing the asynchronous operation, yielding a nullable <see cref="GenderDto"/>.</returns>
    Task<GenderDto?> GetGenderByAsync(short id);

    /// <summary>
    ///     Updates an existing gender asynchronously.
    /// </summary>
    /// <param name="command">The updated data for the gender.</param>
    /// <returns>A task representing the asynchronous operation, yielding a non-nullable string representing the result message.</returns>
    Task<string?> UpdateGenderAsync(GenderDto command);

    /// <summary>
    ///     Gets all genders asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, yielding a list of <see cref="GenderDto"/>.</returns>
    Task<List<GenderDto>> GetGendersAsync();
}
