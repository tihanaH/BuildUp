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

namespace BuildUp_teretana	
{
	public partial class Zaposlenik
	{
		private string _korisnickoIme;
		public virtual string KorisnickoIme
		{
			get
			{
				return this._korisnickoIme;
			}
			set
			{
				this._korisnickoIme = value;
			}
		}
		
		private string _lozinka;
		public virtual string Lozinka
		{
			get
			{
				return this._lozinka;
			}
			set
			{
				this._lozinka = value;
			}
		}
		
		private string _ime;
		public virtual string Ime
		{
			get
			{
				return this._ime;
			}
			set
			{
				this._ime = value;
			}
		}
		
		private string _prezime;
		public virtual string Prezime
		{
			get
			{
				return this._prezime;
			}
			set
			{
				this._prezime = value;
			}
		}
		
		private string _kontakt;
		public virtual string Kontakt
		{
			get
			{
				return this._kontakt;
			}
			set
			{
				this._kontakt = value;
			}
		}
		
	}
}
#pragma warning restore 1591