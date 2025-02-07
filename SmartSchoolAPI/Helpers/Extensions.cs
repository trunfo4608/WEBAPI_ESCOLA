﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SmartSchoolAPI.Data;
using static System.Net.WebRequestMethods;

namespace SmartSchoolAPI.Helpers
{
    public static class Extensions
    {

        public static void  AddPagination(this HttpResponse response,
            int currentPage, int itemsPage, int totalItems, int totalPages)
        {
            var paginationHeader = new PaginationHeader(currentPage, itemsPage, totalItems, totalPages);

            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();

            response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader, camelCaseFormatter));
            response.Headers.Add("Acces-Control-Expose-Header", "Pagination");

        }
    }
}
