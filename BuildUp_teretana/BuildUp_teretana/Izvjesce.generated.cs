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
	public partial class Izvjesce
	{
		private int _iD_izvjesce;
		public virtual int ID_izvjesce
		{
			get
			{
				return this._iD_izvjesce;
			}
			set
			{
				this._iD_izvjesce = value;
			}
		}
		
		private int? _brojIskaznice;
		public virtual int? BrojIskaznice
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
		
		private string _mjesec;
		public virtual string Mjesec
		{
			get
			{
				return this._mjesec;
			}
			set
			{
				this._mjesec = value;
			}
		}
		
		private string _godina;
		public virtual string Godina
		{
			get
			{
				return this._godina;
			}
			set
			{
				this._godina = value;
			}
		}
		
		private int? _tezina;
		public virtual int? Tezina
		{
			get
			{
				return this._tezina;
			}
			set
			{
				this._tezina = value;
			}
		}
		
		private int? _obujamPrsa;
		public virtual int? ObujamPrsa
		{
			get
			{
				return this._obujamPrsa;
			}
			set
			{
				this._obujamPrsa = value;
			}
		}
		
		private int? _obujamStruka;
		public virtual int? ObujamStruka
		{
			get
			{
				return this._obujamStruka;
			}
			set
			{
				this._obujamStruka = value;
			}
		}
		
		private int? _obujamBokova;
		public virtual int? ObujamBokova
		{
			get
			{
				return this._obujamBokova;
			}
			set
			{
				this._obujamBokova = value;
			}
		}
		
		private int? _potrosnjaKalorija;
		public virtual int? PotrosnjaKalorija
		{
			get
			{
				return this._potrosnjaKalorija;
			}
			set
			{
				this._potrosnjaKalorija = value;
			}
		}
		
		private int? _masnoTkvio;
		public virtual int? MasnoTkvio
		{
			get
			{
				return this._masnoTkvio;
			}
			set
			{
				this._masnoTkvio = value;
			}
		}
		
		private int? _list;
		public virtual int? List
		{
			get
			{
				return this._list;
			}
			set
			{
				this._list = value;
			}
		}
		
		private int? _bMI;
		public virtual int? BMI
		{
			get
			{
				return this._bMI;
			}
			set
			{
				this._bMI = value;
			}
		}
		
		private int? _biceps;
		public virtual int? Biceps
		{
			get
			{
				return this._biceps;
			}
			set
			{
				this._biceps = value;
			}
		}
		
		private int? _bedro;
		public virtual int? Bedro
		{
			get
			{
				return this._bedro;
			}
			set
			{
				this._bedro = value;
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
