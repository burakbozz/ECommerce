﻿namespace ECommerce.WebAPI.Dtos.Products.Responses;

public sealed record ProductResponseDto
    (       
            int Id, 
            string Name,
            int Stock,
            double Price,
            string CategoryName
    );

