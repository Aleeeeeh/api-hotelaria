﻿using api_hotelaria.Services;

namespace api_hotelaria.Config;

public static class GerenciadorServicos
{
    public static void GerenciadorDeServicos(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(Program));
        services.AddScoped<HospedeService>();
        services.AddScoped<QuartoService>();
        services.AddScoped<ReservaService>();
        services.AddScoped<PagamentoService>();

        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }
}
