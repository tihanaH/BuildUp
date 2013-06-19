﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using BuildUp_teretana;

namespace BuildUp_teretana	
{
	public partial class BuildUp : OpenAccessContext, IBuildUpUnitOfWork
	{
		private static string connectionStringName = @"Connection";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
				
		private static MetadataSource metadataSource = XmlMetadataSource.FromAssemblyResource("BuildUp.rlinq");
		
		public BuildUp()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public BuildUp(string connection)
			:base(connection, backend, metadataSource)
		{ }
		
		public BuildUp(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public BuildUp(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public BuildUp(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<Zaposlenik> Zaposleniks 
		{
			get
			{
				return this.GetAll<Zaposlenik>();
			}
		}
		
		public IQueryable<VrijemeNaSpravi> VrijemeNaSpravis 
		{
			get
			{
				return this.GetAll<VrijemeNaSpravi>();
			}
		}
		
		public IQueryable<Sprava> Spravas 
		{
			get
			{
				return this.GetAll<Sprava>();
			}
		}
		
		public IQueryable<Izvjesce> Izvjesces 
		{
			get
			{
				return this.GetAll<Izvjesce>();
			}
		}
		
		public IQueryable<Clanarina> Clanarinas 
		{
			get
			{
				return this.GetAll<Clanarina>();
			}
		}
		
		public IQueryable<Clan> Clans 
		{
			get
			{
				return this.GetAll<Clan>();
			}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "PostgreSql";
			backend.ProviderName = "Npgsql";
			return backend;
		}
	}
	
	public interface IBuildUpUnitOfWork : IUnitOfWork
	{
		IQueryable<Zaposlenik> Zaposleniks
		{
			get;
		}
		IQueryable<VrijemeNaSpravi> VrijemeNaSpravis
		{
			get;
		}
		IQueryable<Sprava> Spravas
		{
			get;
		}
		IQueryable<Izvjesce> Izvjesces
		{
			get;
		}
		IQueryable<Clanarina> Clanarinas
		{
			get;
		}
		IQueryable<Clan> Clans
		{
			get;
		}
	}
}
#pragma warning restore 1591