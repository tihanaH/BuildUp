#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
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
	public partial class Clanarina
	{
		private int _iD_clanarina;
		public virtual int ID_clanarina
		{
			get
			{
				return this._iD_clanarina;
			}
			set
			{
				this._iD_clanarina = value;
			}
		}
		
		private string _brojIskaznice;
		public virtual string BrojIskaznice
		{
			get
			{
				return this._brojIskaznice;
			}
			set
			{
				this._brojIskaznice = value;
			}
		}
		
		private System.Nullable<System.Char> _vrsta;
		public virtual System.Nullable<System.Char> Vrsta
		{
			get
			{
				return this._vrsta;
			}
			set
			{
				this._vrsta = value;
			}
		}
		
		private int? _broj_dolazaka;
		public virtual int? Broj_dolazaka
		{
			get
			{
				return this._broj_dolazaka;
			}
			set
			{
				this._broj_dolazaka = value;
			}
		}
		
		private Clan _clan;
		public virtual Clan Clan
		{
			get
			{
				return this._clan;
			}
			set
			{
				this._clan = value;
			}
		}
		
	}
}
#pragma warning restore 1591
