﻿using Infrastructure.Contexts;
using Infrastructure.Entities.HomeEntities;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Repositories.HomeRepository;

public class DarkLightRepository(DataContext context) : Repo<DarkLightEntity>(context)
{
    private readonly DataContext _context = context;

    public override async Task<ResponseResult> GetAllAsync()
    {
        try
        {
            IEnumerable<DarkLightEntity> result = await _context.DarkLight.ToListAsync();
            return ResponseFactory.Ok(result);
        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }
}