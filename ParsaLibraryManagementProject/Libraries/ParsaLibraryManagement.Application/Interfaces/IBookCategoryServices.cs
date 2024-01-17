﻿using Microsoft.AspNetCore.Http;
using ParsaLibraryManagement.Application.DTOs;

namespace ParsaLibraryManagement.Application.Interfaces
{
    /// <summary>
    ///     Interface for services related to book categories.
    /// </summary>
    /// <remarks>
    ///     This interface defines methods for interacting with and managing book categories.
    /// </remarks>
    public interface IBookCategoryServices
    {
        #region Retrieval

        /// <summary>
        ///     Gets a book category by its ID asynchronously.
        /// </summary>
        /// <param name="bookCategoryId">The ID of the book category to retrieve.</param>
        /// <returns>A task representing the asynchronous operation, yielding a nullable <see cref="BookCategoryDto"/>.</returns>
        Task<BookCategoryDto?> GetCategoryByIdAsync(short bookCategoryId);

        /// <summary>
        ///     Gets all book categories asynchronously.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, yielding a list of <see cref="BookCategoryDto"/>.</returns>
        Task<List<BookCategoryDto>> GetAllCategoriesAsync();

        /// <summary>
        ///     Retrieves all book categories asynchronously that start with the specified prefix.
        /// </summary>
        /// <param name="prefix">The prefix used to filter book categories.</param>
        /// <returns>A task representing the asynchronous operation, returning a list of <see cref="BookCategoryDto"/>.</returns>
        Task<List<BookCategoryDto>> GetCategoriesAsync(string prefix);

        #endregion

        #region Modification

        /// <summary>
        ///     Creates a new book category asynchronously.
        /// </summary>
        /// <param name="bookCategoryDto">The data for the new book category.</param>
        /// <param name="imageFile">The image file associated with the new book category.</param>
        /// <param name="folderName">The folder name where images are stored.</param>
        /// <returns>A task representing the asynchronous operation, yielding a nullable string representing the result message.</returns>
        Task<string?> CreateCategoryAsync(BookCategoryDto bookCategoryDto, IFormFile imageFile, string folderName);

        /// <summary>
        ///     Updates an existing book category asynchronously.
        /// </summary>
        /// <param name="bookCategoryDto">The updated data for the book category.</param>
        /// <param name="imageFile">The updated image file associated with the book category.</param>
        /// <param name="folderName">The folder name where images are stored.</param>
        /// <returns>A task representing the asynchronous operation, yielding a nullable string representing the result message.</returns>
        Task<string?> UpdateCategoryAsync(BookCategoryDto bookCategoryDto, IFormFile imageFile, string folderName);

        #endregion

        #region Deletion

        /// <summary>
        ///     Deletes a book category asynchronously.
        /// </summary>
        /// <param name="categoryId">The ID of the book category to delete.</param>
        /// <param name="folderName">The folder name where images are stored.</param>
        /// <returns>A task representing the asynchronous operation, yielding a nullable string representing the result message.</returns>
        Task<string?> DeleteCategoryAsync(short categoryId, string folderName);

        #endregion

    }
}
