﻿using BlogPessoal.src.models;
using System.Collections.Generic;
using BlogPessoal.src.dtos;
using System.Threading.Tasks;

namespace BlogPessoal.src.repositories
{/// <summary>
/// <para>Sumary: Interface to represent CRUD actions in themes</para>
/// <para>Criado por: Karol Oliveira</para>
/// <para>Versão: 1.0</para>
/// <para>Data: 29/04/2022</para>
/// </summary>
    public interface ITheme
    { 
       Task AddThemeAsync(AddThemeDTO theme);
        Task UpdateThemeAsync(UpdateThemeDTO theme);
        Task DeleteThemeAsync(int id);
        Task<ThemeModel> GetThemeByIdAsync(int id);
        Task<List<ThemeModel>> GetAllThemesAsync();
        Task<List<ThemeModel>> GetThemeByDescriptionAsync(string description);
    }
}