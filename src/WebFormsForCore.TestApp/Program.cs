﻿#if NETCOREAPP

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Web;

namespace EstrellasDeEsperanza.WebFormsForCore.Test
{
	public class Program
	{

		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorPages();
			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			app.UseStaticFiles();

			//app.UseAuthorization();

			app.UseWebForms();

			app.MapDefaultControllerRoute();
			
			app.Run();

		}
	}
}

#endif