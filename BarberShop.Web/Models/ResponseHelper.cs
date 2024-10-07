﻿using BarberShop.Web.Core;

namespace BarberShop.Web.Models
{
    public static class ResponseHelper<T>
    {
        public static Response<T> MakeResponseSuccess(T model, string message = "Tarea realizada con exito") 
        {
            return new Response<T>
            {
                IsSucces = true,
                Message = message,
                Result = model,
            };
        }
        public static Response<T> MakeResponseFail(Exception ex, string message = "Error al generar la solicitud")
        {
            return new Response<T>
            {
                Errors = new List<string>
                {
                    ex.Message
                },
                IsSucces = false,
                Message = message,
            };
        }
    }
}
