// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from MONO_STRICT on 2014-05-08 11:14:03Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace SchismDB
{
	using System;
	using System.ComponentModel;
	using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
	using DbLinq.Data.Linq;
	using DbLinq.Vendor;
#endif  // MONO_STRICT
	using System.Data.Linq.Mapping;
	using System.Diagnostics;
	
	
	public partial class MonoStrict : DataContext
	{
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
		
		
		public MonoStrict(string connectionString) : 
				base(connectionString)
		{
			this.OnCreated();
		}
		
		public MonoStrict(string connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public MonoStrict(IDbConnection connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public Table<Armor> Armor
		{
			get
			{
				return this.GetTable<Armor>();
			}
		}
		
		public Table<ArmorAttributeBonus> ArmorAttributeBonus
		{
			get
			{
				return this.GetTable<ArmorAttributeBonus>();
			}
		}
		
		public Table<ArmorDerivedStatBonus> ArmorDerivedStatBonus
		{
			get
			{
				return this.GetTable<ArmorDerivedStatBonus>();
			}
		}
		
		public Table<ArmorSkillBonus> ArmorSkillBonus
		{
			get
			{
				return this.GetTable<ArmorSkillBonus>();
			}
		}
		
		public Table<AssaultRifleBarrels> AssaultRifleBarrels
		{
			get
			{
				return this.GetTable<AssaultRifleBarrels>();
			}
		}
		
		public Table<AssaultRifleBody> AssaultRifleBody
		{
			get
			{
				return this.GetTable<AssaultRifleBody>();
			}
		}
		
		public Table<AssaultRifleMagazines> AssaultRifleMagazines
		{
			get
			{
				return this.GetTable<AssaultRifleMagazines>();
			}
		}
		
		public Table<AssaultRifleMechanism> AssaultRifleMechanism
		{
			get
			{
				return this.GetTable<AssaultRifleMechanism>();
			}
		}
		
		public Table<AssaultRifles> AssaultRifles
		{
			get
			{
				return this.GetTable<AssaultRifles>();
			}
		}
		
		public Table<AssaultRifleSight> AssaultRifleSight
		{
			get
			{
				return this.GetTable<AssaultRifleSight>();
			}
		}
		
		public Table<AssaultRifleStock> AssaultRifleStock
		{
			get
			{
				return this.GetTable<AssaultRifleStock>();
			}
		}
		
		public Table<AugmentationAbilities> AugmentationAbilities
		{
			get
			{
				return this.GetTable<AugmentationAbilities>();
			}
		}
		
		public Table<AugmentationAttributeBuffs> AugmentationAttributeBuffs
		{
			get
			{
				return this.GetTable<AugmentationAttributeBuffs>();
			}
		}
		
		public Table<AugmentationDerivedStatBuffs> AugmentationDerivedStatBuffs
		{
			get
			{
				return this.GetTable<AugmentationDerivedStatBuffs>();
			}
		}
		
		public Table<Augmentations> Augmentations
		{
			get
			{
				return this.GetTable<Augmentations>();
			}
		}
		
		public Table<AugmentationSkillBuffs> AugmentationSkillBuffs
		{
			get
			{
				return this.GetTable<AugmentationSkillBuffs>();
			}
		}
		
		public Table<BaseAttributes> BaseAttributes
		{
			get
			{
				return this.GetTable<BaseAttributes>();
			}
		}
		
		public Table<BaseItems> BaseItems
		{
			get
			{
				return this.GetTable<BaseItems>();
			}
		}
		
		public Table<Character> Character
		{
			get
			{
				return this.GetTable<Character>();
			}
		}
		
		public Table<CharacterAttributes> CharacterAttributes
		{
			get
			{
				return this.GetTable<CharacterAttributes>();
			}
		}
		
		public Table<CharacterAugmentations> CharacterAugmentations
		{
			get
			{
				return this.GetTable<CharacterAugmentations>();
			}
		}
		
		public Table<CharacterDerivedStats> CharacterDerivedStats
		{
			get
			{
				return this.GetTable<CharacterDerivedStats>();
			}
		}
		
		public Table<CharacterGroup> CharacterGroup
		{
			get
			{
				return this.GetTable<CharacterGroup>();
			}
		}
		
		public Table<CharacterInventory> CharacterInventory
		{
			get
			{
				return this.GetTable<CharacterInventory>();
			}
		}
		
		public Table<CharacterSkills> CharacterSkills
		{
			get
			{
				return this.GetTable<CharacterSkills>();
			}
		}
		
		public Table<ContainerInventories> ContainerInventories
		{
			get
			{
				return this.GetTable<ContainerInventories>();
			}
		}
		
		public Table<Containers> Containers
		{
			get
			{
				return this.GetTable<Containers>();
			}
		}
		
		public Table<DerivedStatComponents> DerivedStatComponents
		{
			get
			{
				return this.GetTable<DerivedStatComponents>();
			}
		}
		
		public Table<DerivedStats> DerivedStats
		{
			get
			{
				return this.GetTable<DerivedStats>();
			}
		}
		
		public Table<PistolBarrels> PistolBarrels
		{
			get
			{
				return this.GetTable<PistolBarrels>();
			}
		}
		
		public Table<PistolBody> PistolBody
		{
			get
			{
				return this.GetTable<PistolBody>();
			}
		}
		
		public Table<PistolMagazines> PistolMagazines
		{
			get
			{
				return this.GetTable<PistolMagazines>();
			}
		}
		
		public Table<PistolMechanisms> PistolMechanisms
		{
			get
			{
				return this.GetTable<PistolMechanisms>();
			}
		}
		
		public Table<Pistols> Pistols
		{
			get
			{
				return this.GetTable<Pistols>();
			}
		}
		
		public Table<PistolSights> PistolSights
		{
			get
			{
				return this.GetTable<PistolSights>();
			}
		}
		
		public Table<ShotgunBarrels> ShotgunBarrels
		{
			get
			{
				return this.GetTable<ShotgunBarrels>();
			}
		}
		
		public Table<ShotgunBodys> ShotgunBodys
		{
			get
			{
				return this.GetTable<ShotgunBodys>();
			}
		}
		
		public Table<ShotgunMagazines> ShotgunMagazines
		{
			get
			{
				return this.GetTable<ShotgunMagazines>();
			}
		}
		
		public Table<ShotgunMechanisms> ShotgunMechanisms
		{
			get
			{
				return this.GetTable<ShotgunMechanisms>();
			}
		}
		
		public Table<Shotguns> Shotguns
		{
			get
			{
				return this.GetTable<Shotguns>();
			}
		}
		
		public Table<ShotgunSights> ShotgunSights
		{
			get
			{
				return this.GetTable<ShotgunSights>();
			}
		}
		
		public Table<ShotgunStocks> ShotgunStocks
		{
			get
			{
				return this.GetTable<ShotgunStocks>();
			}
		}
		
		public Table<SkillAttributeRequirements> SkillAttributeRequirements
		{
			get
			{
				return this.GetTable<SkillAttributeRequirements>();
			}
		}
		
		public Table<Skills> Skills
		{
			get
			{
				return this.GetTable<Skills>();
			}
		}
		
		public Table<SkillSpecializations> SkillSpecializations
		{
			get
			{
				return this.GetTable<SkillSpecializations>();
			}
		}
		
		public Table<SkillSubSkills> SkillSubSkills
		{
			get
			{
				return this.GetTable<SkillSubSkills>();
			}
		}
		
		public Table<SniperRifleBarrels> SniperRifleBarrels
		{
			get
			{
				return this.GetTable<SniperRifleBarrels>();
			}
		}
		
		public Table<SniperRifleBodies> SniperRifleBodies
		{
			get
			{
				return this.GetTable<SniperRifleBodies>();
			}
		}
		
		public Table<SniperRifleMagazines> SniperRifleMagazines
		{
			get
			{
				return this.GetTable<SniperRifleMagazines>();
			}
		}
		
		public Table<SniperRifleMechanisms> SniperRifleMechanisms
		{
			get
			{
				return this.GetTable<SniperRifleMechanisms>();
			}
		}
		
		public Table<SniperRifles> SniperRifles
		{
			get
			{
				return this.GetTable<SniperRifles>();
			}
		}
		
		public Table<SniperRifleSights> SniperRifleSights
		{
			get
			{
				return this.GetTable<SniperRifleSights>();
			}
		}
		
		public Table<SniperRifleStocks> SniperRifleStocks
		{
			get
			{
				return this.GetTable<SniperRifleStocks>();
			}
		}
		
		public Table<Specializations> Specializations
		{
			get
			{
				return this.GetTable<Specializations>();
			}
		}
		
		public Table<SubmachinegunBarrels> SubmachinegunBarrels
		{
			get
			{
				return this.GetTable<SubmachinegunBarrels>();
			}
		}
		
		public Table<SubmachinegunBodies> SubmachinegunBodies
		{
			get
			{
				return this.GetTable<SubmachinegunBodies>();
			}
		}
		
		public Table<SubmachinegunMagazines> SubmachinegunMagazines
		{
			get
			{
				return this.GetTable<SubmachinegunMagazines>();
			}
		}
		
		public Table<SubmachinegunMechanisms> SubmachinegunMechanisms
		{
			get
			{
				return this.GetTable<SubmachinegunMechanisms>();
			}
		}
		
		public Table<SubmachinegunSights> SubmachinegunSights
		{
			get
			{
				return this.GetTable<SubmachinegunSights>();
			}
		}
		
		public Table<SubmachinegunStocks> SubmachinegunStocks
		{
			get
			{
				return this.GetTable<SubmachinegunStocks>();
			}
		}
		
		public Table<Submachinguns> Submachinguns
		{
			get
			{
				return this.GetTable<Submachinguns>();
			}
		}
		
		public Table<SubSkills> SubSkills
		{
			get
			{
				return this.GetTable<SubSkills>();
			}
		}
	}
	
	#region Start MONO_STRICT
#if MONO_STRICT

	public partial class MonoStrict
	{
		
		public MonoStrict(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
	}
	#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT
	
	public partial class MonoStrict
	{
		
		public MonoStrict(IDbConnection connection) : 
				base(connection, new DbLinq.Sqlite.SqliteVendor())
		{
			this.OnCreated();
		}
		
		public MonoStrict(IDbConnection connection, IVendor sqlDialect) : 
				base(connection, sqlDialect)
		{
			this.OnCreated();
		}
		
		public MonoStrict(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) : 
				base(connection, mappingSource, sqlDialect)
		{
			this.OnCreated();
		}
	}
	#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
	#endregion
	
	[Table(Name="main.Armor")]
	public partial class Armor : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _armorID;
		
		private string _armorName;
		
		private string _armorSlot;
		
		private System.Nullable<int> _baseProtection;
		
		private string _description;
		
		private string _material;
		
		private System.Nullable<int> _minLevel;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnArmorIDChanged();
		
		partial void OnArmorIDChanging(int value);
		
		partial void OnArmorNameChanged();
		
		partial void OnArmorNameChanging(string value);
		
		partial void OnArmorSlotChanged();
		
		partial void OnArmorSlotChanging(string value);
		
		partial void OnBaseProtectionChanged();
		
		partial void OnBaseProtectionChanging(System.Nullable<int> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnMaterialChanged();
		
		partial void OnMaterialChanging(string value);
		
		partial void OnMinLevelChanged();
		
		partial void OnMinLevelChanging(System.Nullable<int> value);
		#endregion
		
		
		public Armor()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_armorID", Name="ArmorID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ArmorID
		{
			get
			{
				return this._armorID;
			}
			set
			{
				if ((_armorID != value))
				{
					this.OnArmorIDChanging(value);
					this.SendPropertyChanging();
					this._armorID = value;
					this.SendPropertyChanged("ArmorID");
					this.OnArmorIDChanged();
				}
			}
		}
		
		[Column(Storage="_armorName", Name="ArmorName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ArmorName
		{
			get
			{
				return this._armorName;
			}
			set
			{
				if (((_armorName == value) 
							== false))
				{
					this.OnArmorNameChanging(value);
					this.SendPropertyChanging();
					this._armorName = value;
					this.SendPropertyChanged("ArmorName");
					this.OnArmorNameChanged();
				}
			}
		}
		
		[Column(Storage="_armorSlot", Name="ArmorSlot", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ArmorSlot
		{
			get
			{
				return this._armorSlot;
			}
			set
			{
				if (((_armorSlot == value) 
							== false))
				{
					this.OnArmorSlotChanging(value);
					this.SendPropertyChanging();
					this._armorSlot = value;
					this.SendPropertyChanged("ArmorSlot");
					this.OnArmorSlotChanged();
				}
			}
		}
		
		[Column(Storage="_baseProtection", Name="BaseProtection", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> BaseProtection
		{
			get
			{
				return this._baseProtection;
			}
			set
			{
				if ((_baseProtection != value))
				{
					this.OnBaseProtectionChanging(value);
					this.SendPropertyChanging();
					this._baseProtection = value;
					this.SendPropertyChanged("BaseProtection");
					this.OnBaseProtectionChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_material", Name="Material", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Material
		{
			get
			{
				return this._material;
			}
			set
			{
				if (((_material == value) 
							== false))
				{
					this.OnMaterialChanging(value);
					this.SendPropertyChanging();
					this._material = value;
					this.SendPropertyChanged("Material");
					this.OnMaterialChanged();
				}
			}
		}
		
		[Column(Storage="_minLevel", Name="MinLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MinLevel
		{
			get
			{
				return this._minLevel;
			}
			set
			{
				if ((_minLevel != value))
				{
					this.OnMinLevelChanging(value);
					this.SendPropertyChanging();
					this._minLevel = value;
					this.SendPropertyChanged("MinLevel");
					this.OnMinLevelChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.ArmorAttributeBonus")]
	public partial class ArmorAttributeBonus : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _armorAttributeBonusID;
		
		private string _armorName;
		
		private string _attribute;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnArmorAttributeBonusIDChanged();
		
		partial void OnArmorAttributeBonusIDChanging(int value);
		
		partial void OnArmorNameChanged();
		
		partial void OnArmorNameChanging(string value);
		
		partial void OnAttributeChanged();
		
		partial void OnAttributeChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public ArmorAttributeBonus()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_armorAttributeBonusID", Name="ArmorAttributeBonusID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ArmorAttributeBonusID
		{
			get
			{
				return this._armorAttributeBonusID;
			}
			set
			{
				if ((_armorAttributeBonusID != value))
				{
					this.OnArmorAttributeBonusIDChanging(value);
					this.SendPropertyChanging();
					this._armorAttributeBonusID = value;
					this.SendPropertyChanged("ArmorAttributeBonusID");
					this.OnArmorAttributeBonusIDChanged();
				}
			}
		}
		
		[Column(Storage="_armorName", Name="ArmorName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ArmorName
		{
			get
			{
				return this._armorName;
			}
			set
			{
				if (((_armorName == value) 
							== false))
				{
					this.OnArmorNameChanging(value);
					this.SendPropertyChanging();
					this._armorName = value;
					this.SendPropertyChanged("ArmorName");
					this.OnArmorNameChanged();
				}
			}
		}
		
		[Column(Storage="_attribute", Name="Attribute", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Attribute
		{
			get
			{
				return this._attribute;
			}
			set
			{
				if (((_attribute == value) 
							== false))
				{
					this.OnAttributeChanging(value);
					this.SendPropertyChanging();
					this._attribute = value;
					this.SendPropertyChanged("Attribute");
					this.OnAttributeChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.ArmorDerivedStatBonus")]
	public partial class ArmorDerivedStatBonus : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _armorDerivedStatBonusID;
		
		private string _armorName;
		
		private string _derivedStat;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnArmorDerivedStatBonusIDChanged();
		
		partial void OnArmorDerivedStatBonusIDChanging(int value);
		
		partial void OnArmorNameChanged();
		
		partial void OnArmorNameChanging(string value);
		
		partial void OnDerivedStatChanged();
		
		partial void OnDerivedStatChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public ArmorDerivedStatBonus()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_armorDerivedStatBonusID", Name="ArmorDerivedStatBonusID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ArmorDerivedStatBonusID
		{
			get
			{
				return this._armorDerivedStatBonusID;
			}
			set
			{
				if ((_armorDerivedStatBonusID != value))
				{
					this.OnArmorDerivedStatBonusIDChanging(value);
					this.SendPropertyChanging();
					this._armorDerivedStatBonusID = value;
					this.SendPropertyChanged("ArmorDerivedStatBonusID");
					this.OnArmorDerivedStatBonusIDChanged();
				}
			}
		}
		
		[Column(Storage="_armorName", Name="ArmorName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ArmorName
		{
			get
			{
				return this._armorName;
			}
			set
			{
				if (((_armorName == value) 
							== false))
				{
					this.OnArmorNameChanging(value);
					this.SendPropertyChanging();
					this._armorName = value;
					this.SendPropertyChanged("ArmorName");
					this.OnArmorNameChanged();
				}
			}
		}
		
		[Column(Storage="_derivedStat", Name="DerivedStat", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DerivedStat
		{
			get
			{
				return this._derivedStat;
			}
			set
			{
				if (((_derivedStat == value) 
							== false))
				{
					this.OnDerivedStatChanging(value);
					this.SendPropertyChanging();
					this._derivedStat = value;
					this.SendPropertyChanged("DerivedStat");
					this.OnDerivedStatChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.ArmorSkillBonus")]
	public partial class ArmorSkillBonus : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _armorID;
		
		private string _armorName;
		
		private string _skill;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnArmorIDChanged();
		
		partial void OnArmorIDChanging(int value);
		
		partial void OnArmorNameChanged();
		
		partial void OnArmorNameChanging(string value);
		
		partial void OnSkillChanged();
		
		partial void OnSkillChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public ArmorSkillBonus()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_armorID", Name="ArmorID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ArmorID
		{
			get
			{
				return this._armorID;
			}
			set
			{
				if ((_armorID != value))
				{
					this.OnArmorIDChanging(value);
					this.SendPropertyChanging();
					this._armorID = value;
					this.SendPropertyChanged("ArmorID");
					this.OnArmorIDChanged();
				}
			}
		}
		
		[Column(Storage="_armorName", Name="ArmorName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ArmorName
		{
			get
			{
				return this._armorName;
			}
			set
			{
				if (((_armorName == value) 
							== false))
				{
					this.OnArmorNameChanging(value);
					this.SendPropertyChanging();
					this._armorName = value;
					this.SendPropertyChanged("ArmorName");
					this.OnArmorNameChanged();
				}
			}
		}
		
		[Column(Storage="_skill", Name="Skill", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Skill
		{
			get
			{
				return this._skill;
			}
			set
			{
				if (((_skill == value) 
							== false))
				{
					this.OnSkillChanging(value);
					this.SendPropertyChanging();
					this._skill = value;
					this.SendPropertyChanged("Skill");
					this.OnSkillChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.AssaultRifleBarrels")]
	public partial class AssaultRifleBarrels : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private System.Nullable<float> _minDamage;
		
		private System.Nullable<float> _range;
		
		private string _rarity;
		
		private int _rifleBarrelID;
		
		private string _rifleBarrelName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnMinDamageChanged();
		
		partial void OnMinDamageChanging(System.Nullable<float> value);
		
		partial void OnRangeChanged();
		
		partial void OnRangeChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRifleBarrelIDChanged();
		
		partial void OnRifleBarrelIDChanging(int value);
		
		partial void OnRifleBarrelNameChanged();
		
		partial void OnRifleBarrelNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public AssaultRifleBarrels()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_minDamage", Name="MinDamage", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> MinDamage
		{
			get
			{
				return this._minDamage;
			}
			set
			{
				if ((_minDamage != value))
				{
					this.OnMinDamageChanging(value);
					this.SendPropertyChanging();
					this._minDamage = value;
					this.SendPropertyChanged("MinDamage");
					this.OnMinDamageChanged();
				}
			}
		}
		
		[Column(Storage="_range", Name="Range", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Range
		{
			get
			{
				return this._range;
			}
			set
			{
				if ((_range != value))
				{
					this.OnRangeChanging(value);
					this.SendPropertyChanging();
					this._range = value;
					this.SendPropertyChanged("Range");
					this.OnRangeChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rifleBarrelID", Name="RifleBarrelID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int RifleBarrelID
		{
			get
			{
				return this._rifleBarrelID;
			}
			set
			{
				if ((_rifleBarrelID != value))
				{
					this.OnRifleBarrelIDChanging(value);
					this.SendPropertyChanging();
					this._rifleBarrelID = value;
					this.SendPropertyChanged("RifleBarrelID");
					this.OnRifleBarrelIDChanged();
				}
			}
		}
		
		[Column(Storage="_rifleBarrelName", Name="RifleBarrelName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RifleBarrelName
		{
			get
			{
				return this._rifleBarrelName;
			}
			set
			{
				if (((_rifleBarrelName == value) 
							== false))
				{
					this.OnRifleBarrelNameChanging(value);
					this.SendPropertyChanging();
					this._rifleBarrelName = value;
					this.SendPropertyChanged("RifleBarrelName");
					this.OnRifleBarrelNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.AssaultRifleBody")]
	public partial class AssaultRifleBody : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _assaultRifleBodyID;
		
		private string _assaultRifleBodyName;
		
		private string _calibre;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private System.Nullable<float> _maxDamage;
		
		private string _rarity;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAssaultRifleBodyIDChanged();
		
		partial void OnAssaultRifleBodyIDChanging(int value);
		
		partial void OnAssaultRifleBodyNameChanged();
		
		partial void OnAssaultRifleBodyNameChanging(string value);
		
		partial void OnCalibreChanged();
		
		partial void OnCalibreChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnMaxDamageChanged();
		
		partial void OnMaxDamageChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public AssaultRifleBody()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_assaultRifleBodyID", Name="AssaultRifleBodyID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AssaultRifleBodyID
		{
			get
			{
				return this._assaultRifleBodyID;
			}
			set
			{
				if ((_assaultRifleBodyID != value))
				{
					this.OnAssaultRifleBodyIDChanging(value);
					this.SendPropertyChanging();
					this._assaultRifleBodyID = value;
					this.SendPropertyChanged("AssaultRifleBodyID");
					this.OnAssaultRifleBodyIDChanged();
				}
			}
		}
		
		[Column(Storage="_assaultRifleBodyName", Name="AssaultRifleBodyName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AssaultRifleBodyName
		{
			get
			{
				return this._assaultRifleBodyName;
			}
			set
			{
				if (((_assaultRifleBodyName == value) 
							== false))
				{
					this.OnAssaultRifleBodyNameChanging(value);
					this.SendPropertyChanging();
					this._assaultRifleBodyName = value;
					this.SendPropertyChanged("AssaultRifleBodyName");
					this.OnAssaultRifleBodyNameChanged();
				}
			}
		}
		
		[Column(Storage="_calibre", Name="Calibre", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Calibre
		{
			get
			{
				return this._calibre;
			}
			set
			{
				if (((_calibre == value) 
							== false))
				{
					this.OnCalibreChanging(value);
					this.SendPropertyChanging();
					this._calibre = value;
					this.SendPropertyChanged("Calibre");
					this.OnCalibreChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_maxDamage", Name="MaxDamage", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> MaxDamage
		{
			get
			{
				return this._maxDamage;
			}
			set
			{
				if ((_maxDamage != value))
				{
					this.OnMaxDamageChanging(value);
					this.SendPropertyChanging();
					this._maxDamage = value;
					this.SendPropertyChanged("MaxDamage");
					this.OnMaxDamageChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.AssaultRifleMagazines")]
	public partial class AssaultRifleMagazines : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _assaultRifleMagazineID;
		
		private string _assaultRifleMagazineName;
		
		private System.Nullable<int> _capacity;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private string _rarity;
		
		private System.Nullable<float> _rateOfFire;
		
		private System.Nullable<float> _reloadSpeed;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAssaultRifleMagazineIDChanged();
		
		partial void OnAssaultRifleMagazineIDChanging(int value);
		
		partial void OnAssaultRifleMagazineNameChanged();
		
		partial void OnAssaultRifleMagazineNameChanging(string value);
		
		partial void OnCapacityChanged();
		
		partial void OnCapacityChanging(System.Nullable<int> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public AssaultRifleMagazines()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_assaultRifleMagazineID", Name="AssaultRifleMagazineID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AssaultRifleMagazineID
		{
			get
			{
				return this._assaultRifleMagazineID;
			}
			set
			{
				if ((_assaultRifleMagazineID != value))
				{
					this.OnAssaultRifleMagazineIDChanging(value);
					this.SendPropertyChanging();
					this._assaultRifleMagazineID = value;
					this.SendPropertyChanged("AssaultRifleMagazineID");
					this.OnAssaultRifleMagazineIDChanged();
				}
			}
		}
		
		[Column(Storage="_assaultRifleMagazineName", Name="AssaultRifleMagazineName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AssaultRifleMagazineName
		{
			get
			{
				return this._assaultRifleMagazineName;
			}
			set
			{
				if (((_assaultRifleMagazineName == value) 
							== false))
				{
					this.OnAssaultRifleMagazineNameChanging(value);
					this.SendPropertyChanging();
					this._assaultRifleMagazineName = value;
					this.SendPropertyChanged("AssaultRifleMagazineName");
					this.OnAssaultRifleMagazineNameChanged();
				}
			}
		}
		
		[Column(Storage="_capacity", Name="Capacity", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Capacity
		{
			get
			{
				return this._capacity;
			}
			set
			{
				if ((_capacity != value))
				{
					this.OnCapacityChanging(value);
					this.SendPropertyChanging();
					this._capacity = value;
					this.SendPropertyChanged("Capacity");
					this.OnCapacityChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.AssaultRifleMechanism")]
	public partial class AssaultRifleMechanism : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _assaultRifleMechanismID;
		
		private string _assaultRifleName;
		
		private string _burstType;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private string _rarity;
		
		private System.Nullable<float> _rateOfFire;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAssaultRifleMechanismIDChanged();
		
		partial void OnAssaultRifleMechanismIDChanging(int value);
		
		partial void OnAssaultRifleNameChanged();
		
		partial void OnAssaultRifleNameChanging(string value);
		
		partial void OnBurstTypeChanged();
		
		partial void OnBurstTypeChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public AssaultRifleMechanism()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_assaultRifleMechanismID", Name="AssaultRifleMechanismID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AssaultRifleMechanismID
		{
			get
			{
				return this._assaultRifleMechanismID;
			}
			set
			{
				if ((_assaultRifleMechanismID != value))
				{
					this.OnAssaultRifleMechanismIDChanging(value);
					this.SendPropertyChanging();
					this._assaultRifleMechanismID = value;
					this.SendPropertyChanged("AssaultRifleMechanismID");
					this.OnAssaultRifleMechanismIDChanged();
				}
			}
		}
		
		[Column(Storage="_assaultRifleName", Name="AssaultRifleName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AssaultRifleName
		{
			get
			{
				return this._assaultRifleName;
			}
			set
			{
				if (((_assaultRifleName == value) 
							== false))
				{
					this.OnAssaultRifleNameChanging(value);
					this.SendPropertyChanging();
					this._assaultRifleName = value;
					this.SendPropertyChanged("AssaultRifleName");
					this.OnAssaultRifleNameChanged();
				}
			}
		}
		
		[Column(Storage="_burstType", Name="BurstType", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BurstType
		{
			get
			{
				return this._burstType;
			}
			set
			{
				if (((_burstType == value) 
							== false))
				{
					this.OnBurstTypeChanging(value);
					this.SendPropertyChanging();
					this._burstType = value;
					this.SendPropertyChanged("BurstType");
					this.OnBurstTypeChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.AssaultRifles")]
	public partial class AssaultRifles : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private int _assaultRifleID;
		
		private string _assaultRifleName;
		
		private System.Nullable<int> _barrelID;
		
		private System.Nullable<int> _bodyID;
		
		private string _burstType;
		
		private string _calibre;
		
		private string _description;
		
		private System.Nullable<int> _magazineCapacity;
		
		private System.Nullable<int> _magazineID;
		
		private System.Nullable<int> _maxDamage;
		
		private System.Nullable<int> _mechanismID;
		
		private System.Nullable<int> _minDamage;
		
		private System.Nullable<int> _minLevel;
		
		private System.Nullable<float> _range;
		
		private string _rarity;
		
		private System.Nullable<float> _rateOfFire;
		
		private System.Nullable<float> _reloadSpeed;
		
		private System.Nullable<int> _sightID;
		
		private System.Nullable<int> _stockID;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnAssaultRifleIDChanged();
		
		partial void OnAssaultRifleIDChanging(int value);
		
		partial void OnAssaultRifleNameChanged();
		
		partial void OnAssaultRifleNameChanging(string value);
		
		partial void OnBarrelIDChanged();
		
		partial void OnBarrelIDChanging(System.Nullable<int> value);
		
		partial void OnBodyIDChanged();
		
		partial void OnBodyIDChanging(System.Nullable<int> value);
		
		partial void OnBurstTypeChanged();
		
		partial void OnBurstTypeChanging(string value);
		
		partial void OnCalibreChanged();
		
		partial void OnCalibreChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnMagazineCapacityChanged();
		
		partial void OnMagazineCapacityChanging(System.Nullable<int> value);
		
		partial void OnMagazineIDChanged();
		
		partial void OnMagazineIDChanging(System.Nullable<int> value);
		
		partial void OnMaxDamageChanged();
		
		partial void OnMaxDamageChanging(System.Nullable<int> value);
		
		partial void OnMechanismIDChanged();
		
		partial void OnMechanismIDChanging(System.Nullable<int> value);
		
		partial void OnMinDamageChanged();
		
		partial void OnMinDamageChanging(System.Nullable<int> value);
		
		partial void OnMinLevelChanged();
		
		partial void OnMinLevelChanging(System.Nullable<int> value);
		
		partial void OnRangeChanged();
		
		partial void OnRangeChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnSightIDChanged();
		
		partial void OnSightIDChanging(System.Nullable<int> value);
		
		partial void OnStockIDChanged();
		
		partial void OnStockIDChanging(System.Nullable<int> value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public AssaultRifles()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_assaultRifleID", Name="AssaultRifleID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AssaultRifleID
		{
			get
			{
				return this._assaultRifleID;
			}
			set
			{
				if ((_assaultRifleID != value))
				{
					this.OnAssaultRifleIDChanging(value);
					this.SendPropertyChanging();
					this._assaultRifleID = value;
					this.SendPropertyChanged("AssaultRifleID");
					this.OnAssaultRifleIDChanged();
				}
			}
		}
		
		[Column(Storage="_assaultRifleName", Name="AssaultRifleName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AssaultRifleName
		{
			get
			{
				return this._assaultRifleName;
			}
			set
			{
				if (((_assaultRifleName == value) 
							== false))
				{
					this.OnAssaultRifleNameChanging(value);
					this.SendPropertyChanging();
					this._assaultRifleName = value;
					this.SendPropertyChanged("AssaultRifleName");
					this.OnAssaultRifleNameChanged();
				}
			}
		}
		
		[Column(Storage="_barrelID", Name="BarrelID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> BarrelID
		{
			get
			{
				return this._barrelID;
			}
			set
			{
				if ((_barrelID != value))
				{
					this.OnBarrelIDChanging(value);
					this.SendPropertyChanging();
					this._barrelID = value;
					this.SendPropertyChanged("BarrelID");
					this.OnBarrelIDChanged();
				}
			}
		}
		
		[Column(Storage="_bodyID", Name="BodyID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> BodyID
		{
			get
			{
				return this._bodyID;
			}
			set
			{
				if ((_bodyID != value))
				{
					this.OnBodyIDChanging(value);
					this.SendPropertyChanging();
					this._bodyID = value;
					this.SendPropertyChanged("BodyID");
					this.OnBodyIDChanged();
				}
			}
		}
		
		[Column(Storage="_burstType", Name="BurstType", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BurstType
		{
			get
			{
				return this._burstType;
			}
			set
			{
				if (((_burstType == value) 
							== false))
				{
					this.OnBurstTypeChanging(value);
					this.SendPropertyChanging();
					this._burstType = value;
					this.SendPropertyChanged("BurstType");
					this.OnBurstTypeChanged();
				}
			}
		}
		
		[Column(Storage="_calibre", Name="Calibre", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Calibre
		{
			get
			{
				return this._calibre;
			}
			set
			{
				if (((_calibre == value) 
							== false))
				{
					this.OnCalibreChanging(value);
					this.SendPropertyChanging();
					this._calibre = value;
					this.SendPropertyChanged("Calibre");
					this.OnCalibreChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_magazineCapacity", Name="MagazineCapacity", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MagazineCapacity
		{
			get
			{
				return this._magazineCapacity;
			}
			set
			{
				if ((_magazineCapacity != value))
				{
					this.OnMagazineCapacityChanging(value);
					this.SendPropertyChanging();
					this._magazineCapacity = value;
					this.SendPropertyChanged("MagazineCapacity");
					this.OnMagazineCapacityChanged();
				}
			}
		}
		
		[Column(Storage="_magazineID", Name="MagazineID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MagazineID
		{
			get
			{
				return this._magazineID;
			}
			set
			{
				if ((_magazineID != value))
				{
					this.OnMagazineIDChanging(value);
					this.SendPropertyChanging();
					this._magazineID = value;
					this.SendPropertyChanged("MagazineID");
					this.OnMagazineIDChanged();
				}
			}
		}
		
		[Column(Storage="_maxDamage", Name="MaxDamage", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MaxDamage
		{
			get
			{
				return this._maxDamage;
			}
			set
			{
				if ((_maxDamage != value))
				{
					this.OnMaxDamageChanging(value);
					this.SendPropertyChanging();
					this._maxDamage = value;
					this.SendPropertyChanged("MaxDamage");
					this.OnMaxDamageChanged();
				}
			}
		}
		
		[Column(Storage="_mechanismID", Name="MechanismID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MechanismID
		{
			get
			{
				return this._mechanismID;
			}
			set
			{
				if ((_mechanismID != value))
				{
					this.OnMechanismIDChanging(value);
					this.SendPropertyChanging();
					this._mechanismID = value;
					this.SendPropertyChanged("MechanismID");
					this.OnMechanismIDChanged();
				}
			}
		}
		
		[Column(Storage="_minDamage", Name="MinDamage", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MinDamage
		{
			get
			{
				return this._minDamage;
			}
			set
			{
				if ((_minDamage != value))
				{
					this.OnMinDamageChanging(value);
					this.SendPropertyChanging();
					this._minDamage = value;
					this.SendPropertyChanged("MinDamage");
					this.OnMinDamageChanged();
				}
			}
		}
		
		[Column(Storage="_minLevel", Name="MinLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MinLevel
		{
			get
			{
				return this._minLevel;
			}
			set
			{
				if ((_minLevel != value))
				{
					this.OnMinLevelChanging(value);
					this.SendPropertyChanging();
					this._minLevel = value;
					this.SendPropertyChanged("MinLevel");
					this.OnMinLevelChanged();
				}
			}
		}
		
		[Column(Storage="_range", Name="Range", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Range
		{
			get
			{
				return this._range;
			}
			set
			{
				if ((_range != value))
				{
					this.OnRangeChanging(value);
					this.SendPropertyChanging();
					this._range = value;
					this.SendPropertyChanged("Range");
					this.OnRangeChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_sightID", Name="SightID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SightID
		{
			get
			{
				return this._sightID;
			}
			set
			{
				if ((_sightID != value))
				{
					this.OnSightIDChanging(value);
					this.SendPropertyChanging();
					this._sightID = value;
					this.SendPropertyChanged("SightID");
					this.OnSightIDChanged();
				}
			}
		}
		
		[Column(Storage="_stockID", Name="StockID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> StockID
		{
			get
			{
				return this._stockID;
			}
			set
			{
				if ((_stockID != value))
				{
					this.OnStockIDChanging(value);
					this.SendPropertyChanging();
					this._stockID = value;
					this.SendPropertyChanged("StockID");
					this.OnStockIDChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.AssaultRifleSight")]
	public partial class AssaultRifleSight : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private int _assaultRifleSightID;
		
		private string _assaultRifleSightName;
		
		private System.Nullable<int> _engLevel;
		
		private System.Nullable<float> _range;
		
		private string _rarity;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnAssaultRifleSightIDChanged();
		
		partial void OnAssaultRifleSightIDChanging(int value);
		
		partial void OnAssaultRifleSightNameChanged();
		
		partial void OnAssaultRifleSightNameChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRangeChanged();
		
		partial void OnRangeChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public AssaultRifleSight()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_assaultRifleSightID", Name="AssaultRifleSightID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AssaultRifleSightID
		{
			get
			{
				return this._assaultRifleSightID;
			}
			set
			{
				if ((_assaultRifleSightID != value))
				{
					this.OnAssaultRifleSightIDChanging(value);
					this.SendPropertyChanging();
					this._assaultRifleSightID = value;
					this.SendPropertyChanged("AssaultRifleSightID");
					this.OnAssaultRifleSightIDChanged();
				}
			}
		}
		
		[Column(Storage="_assaultRifleSightName", Name="AssaultRifleSightName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AssaultRifleSightName
		{
			get
			{
				return this._assaultRifleSightName;
			}
			set
			{
				if (((_assaultRifleSightName == value) 
							== false))
				{
					this.OnAssaultRifleSightNameChanging(value);
					this.SendPropertyChanging();
					this._assaultRifleSightName = value;
					this.SendPropertyChanged("AssaultRifleSightName");
					this.OnAssaultRifleSightNameChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_range", Name="Range", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Range
		{
			get
			{
				return this._range;
			}
			set
			{
				if ((_range != value))
				{
					this.OnRangeChanging(value);
					this.SendPropertyChanging();
					this._range = value;
					this.SendPropertyChanged("Range");
					this.OnRangeChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.AssaultRifleStock")]
	public partial class AssaultRifleStock : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private int _assaultRifleID;
		
		private string _assaultRifleName;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private string _rarity;
		
		private System.Nullable<float> _reloadSpeed;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnAssaultRifleIDChanged();
		
		partial void OnAssaultRifleIDChanging(int value);
		
		partial void OnAssaultRifleNameChanged();
		
		partial void OnAssaultRifleNameChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public AssaultRifleStock()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_assaultRifleID", Name="AssaultRifleID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AssaultRifleID
		{
			get
			{
				return this._assaultRifleID;
			}
			set
			{
				if ((_assaultRifleID != value))
				{
					this.OnAssaultRifleIDChanging(value);
					this.SendPropertyChanging();
					this._assaultRifleID = value;
					this.SendPropertyChanged("AssaultRifleID");
					this.OnAssaultRifleIDChanged();
				}
			}
		}
		
		[Column(Storage="_assaultRifleName", Name="AssaultRifleName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AssaultRifleName
		{
			get
			{
				return this._assaultRifleName;
			}
			set
			{
				if (((_assaultRifleName == value) 
							== false))
				{
					this.OnAssaultRifleNameChanging(value);
					this.SendPropertyChanging();
					this._assaultRifleName = value;
					this.SendPropertyChanged("AssaultRifleName");
					this.OnAssaultRifleNameChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.AugmentationAbilities")]
	public partial class AugmentationAbilities : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _augmentationName;
		
		private int _augmentationSkillEffectID;
		
		private System.Nullable<int> _augmentationValue;
		
		private string _skillName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAugmentationNameChanged();
		
		partial void OnAugmentationNameChanging(string value);
		
		partial void OnAugmentationSkillEffectIDChanged();
		
		partial void OnAugmentationSkillEffectIDChanging(int value);
		
		partial void OnAugmentationValueChanged();
		
		partial void OnAugmentationValueChanging(System.Nullable<int> value);
		
		partial void OnSkillNameChanged();
		
		partial void OnSkillNameChanging(string value);
		#endregion
		
		
		public AugmentationAbilities()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_augmentationName", Name="AugmentationName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AugmentationName
		{
			get
			{
				return this._augmentationName;
			}
			set
			{
				if (((_augmentationName == value) 
							== false))
				{
					this.OnAugmentationNameChanging(value);
					this.SendPropertyChanging();
					this._augmentationName = value;
					this.SendPropertyChanged("AugmentationName");
					this.OnAugmentationNameChanged();
				}
			}
		}
		
		[Column(Storage="_augmentationSkillEffectID", Name="AugmentationSkillEffectID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AugmentationSkillEffectID
		{
			get
			{
				return this._augmentationSkillEffectID;
			}
			set
			{
				if ((_augmentationSkillEffectID != value))
				{
					this.OnAugmentationSkillEffectIDChanging(value);
					this.SendPropertyChanging();
					this._augmentationSkillEffectID = value;
					this.SendPropertyChanged("AugmentationSkillEffectID");
					this.OnAugmentationSkillEffectIDChanged();
				}
			}
		}
		
		[Column(Storage="_augmentationValue", Name="AugmentationValue", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> AugmentationValue
		{
			get
			{
				return this._augmentationValue;
			}
			set
			{
				if ((_augmentationValue != value))
				{
					this.OnAugmentationValueChanging(value);
					this.SendPropertyChanging();
					this._augmentationValue = value;
					this.SendPropertyChanged("AugmentationValue");
					this.OnAugmentationValueChanged();
				}
			}
		}
		
		[Column(Storage="_skillName", Name="SkillName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SkillName
		{
			get
			{
				return this._skillName;
			}
			set
			{
				if (((_skillName == value) 
							== false))
				{
					this.OnSkillNameChanging(value);
					this.SendPropertyChanging();
					this._skillName = value;
					this.SendPropertyChanged("SkillName");
					this.OnSkillNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.AugmentationAttributeBuffs")]
	public partial class AugmentationAttributeBuffs : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _attributeName;
		
		private int _augmentationAttributeEffectID;
		
		private string _augmentationName;
		
		private System.Nullable<int> _augmentationValue;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAttributeNameChanged();
		
		partial void OnAttributeNameChanging(string value);
		
		partial void OnAugmentationAttributeEffectIDChanged();
		
		partial void OnAugmentationAttributeEffectIDChanging(int value);
		
		partial void OnAugmentationNameChanged();
		
		partial void OnAugmentationNameChanging(string value);
		
		partial void OnAugmentationValueChanged();
		
		partial void OnAugmentationValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public AugmentationAttributeBuffs()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_attributeName", Name="AttributeName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AttributeName
		{
			get
			{
				return this._attributeName;
			}
			set
			{
				if (((_attributeName == value) 
							== false))
				{
					this.OnAttributeNameChanging(value);
					this.SendPropertyChanging();
					this._attributeName = value;
					this.SendPropertyChanged("AttributeName");
					this.OnAttributeNameChanged();
				}
			}
		}
		
		[Column(Storage="_augmentationAttributeEffectID", Name="AugmentationAttributeEffectID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AugmentationAttributeEffectID
		{
			get
			{
				return this._augmentationAttributeEffectID;
			}
			set
			{
				if ((_augmentationAttributeEffectID != value))
				{
					this.OnAugmentationAttributeEffectIDChanging(value);
					this.SendPropertyChanging();
					this._augmentationAttributeEffectID = value;
					this.SendPropertyChanged("AugmentationAttributeEffectID");
					this.OnAugmentationAttributeEffectIDChanged();
				}
			}
		}
		
		[Column(Storage="_augmentationName", Name="AugmentationName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AugmentationName
		{
			get
			{
				return this._augmentationName;
			}
			set
			{
				if (((_augmentationName == value) 
							== false))
				{
					this.OnAugmentationNameChanging(value);
					this.SendPropertyChanging();
					this._augmentationName = value;
					this.SendPropertyChanged("AugmentationName");
					this.OnAugmentationNameChanged();
				}
			}
		}
		
		[Column(Storage="_augmentationValue", Name="AugmentationValue", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> AugmentationValue
		{
			get
			{
				return this._augmentationValue;
			}
			set
			{
				if ((_augmentationValue != value))
				{
					this.OnAugmentationValueChanging(value);
					this.SendPropertyChanging();
					this._augmentationValue = value;
					this.SendPropertyChanged("AugmentationValue");
					this.OnAugmentationValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.AugmentationDerivedStatBuffs")]
	public partial class AugmentationDerivedStatBuffs : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _augmentationDerivedStatEffectID;
		
		private System.Nullable<int> _augmentationEffect;
		
		private string _augmentationName;
		
		private string _derivedStatName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAugmentationDerivedStatEffectIDChanged();
		
		partial void OnAugmentationDerivedStatEffectIDChanging(int value);
		
		partial void OnAugmentationEffectChanged();
		
		partial void OnAugmentationEffectChanging(System.Nullable<int> value);
		
		partial void OnAugmentationNameChanged();
		
		partial void OnAugmentationNameChanging(string value);
		
		partial void OnDerivedStatNameChanged();
		
		partial void OnDerivedStatNameChanging(string value);
		#endregion
		
		
		public AugmentationDerivedStatBuffs()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_augmentationDerivedStatEffectID", Name="AugmentationDerivedStatEffectID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AugmentationDerivedStatEffectID
		{
			get
			{
				return this._augmentationDerivedStatEffectID;
			}
			set
			{
				if ((_augmentationDerivedStatEffectID != value))
				{
					this.OnAugmentationDerivedStatEffectIDChanging(value);
					this.SendPropertyChanging();
					this._augmentationDerivedStatEffectID = value;
					this.SendPropertyChanged("AugmentationDerivedStatEffectID");
					this.OnAugmentationDerivedStatEffectIDChanged();
				}
			}
		}
		
		[Column(Storage="_augmentationEffect", Name="AugmentationEffect", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> AugmentationEffect
		{
			get
			{
				return this._augmentationEffect;
			}
			set
			{
				if ((_augmentationEffect != value))
				{
					this.OnAugmentationEffectChanging(value);
					this.SendPropertyChanging();
					this._augmentationEffect = value;
					this.SendPropertyChanged("AugmentationEffect");
					this.OnAugmentationEffectChanged();
				}
			}
		}
		
		[Column(Storage="_augmentationName", Name="AugmentationName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AugmentationName
		{
			get
			{
				return this._augmentationName;
			}
			set
			{
				if (((_augmentationName == value) 
							== false))
				{
					this.OnAugmentationNameChanging(value);
					this.SendPropertyChanging();
					this._augmentationName = value;
					this.SendPropertyChanged("AugmentationName");
					this.OnAugmentationNameChanged();
				}
			}
		}
		
		[Column(Storage="_derivedStatName", Name="DerivedStatName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DerivedStatName
		{
			get
			{
				return this._derivedStatName;
			}
			set
			{
				if (((_derivedStatName == value) 
							== false))
				{
					this.OnDerivedStatNameChanging(value);
					this.SendPropertyChanging();
					this._derivedStatName = value;
					this.SendPropertyChanged("DerivedStatName");
					this.OnDerivedStatNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.Augmentations")]
	public partial class Augmentations : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _augmentationDescription;
		
		private int _augmentationID;
		
		private string _augmentationName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAugmentationDescriptionChanged();
		
		partial void OnAugmentationDescriptionChanging(string value);
		
		partial void OnAugmentationIDChanged();
		
		partial void OnAugmentationIDChanging(int value);
		
		partial void OnAugmentationNameChanged();
		
		partial void OnAugmentationNameChanging(string value);
		#endregion
		
		
		public Augmentations()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_augmentationDescription", Name="AugmentationDescription", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AugmentationDescription
		{
			get
			{
				return this._augmentationDescription;
			}
			set
			{
				if (((_augmentationDescription == value) 
							== false))
				{
					this.OnAugmentationDescriptionChanging(value);
					this.SendPropertyChanging();
					this._augmentationDescription = value;
					this.SendPropertyChanged("AugmentationDescription");
					this.OnAugmentationDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_augmentationID", Name="AugmentationID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AugmentationID
		{
			get
			{
				return this._augmentationID;
			}
			set
			{
				if ((_augmentationID != value))
				{
					this.OnAugmentationIDChanging(value);
					this.SendPropertyChanging();
					this._augmentationID = value;
					this.SendPropertyChanged("AugmentationID");
					this.OnAugmentationIDChanged();
				}
			}
		}
		
		[Column(Storage="_augmentationName", Name="AugmentationName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AugmentationName
		{
			get
			{
				return this._augmentationName;
			}
			set
			{
				if (((_augmentationName == value) 
							== false))
				{
					this.OnAugmentationNameChanging(value);
					this.SendPropertyChanging();
					this._augmentationName = value;
					this.SendPropertyChanged("AugmentationName");
					this.OnAugmentationNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.AugmentationSkillBuffs")]
	public partial class AugmentationSkillBuffs : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _augmentationID;
		
		private string _augmentationName;
		
		private string _buffSkillName;
		
		private System.Nullable<int> _buffSkillValue;
		
		private int _skillBuffID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAugmentationIDChanged();
		
		partial void OnAugmentationIDChanging(System.Nullable<int> value);
		
		partial void OnAugmentationNameChanged();
		
		partial void OnAugmentationNameChanging(string value);
		
		partial void OnBuffSkillNameChanged();
		
		partial void OnBuffSkillNameChanging(string value);
		
		partial void OnBuffSkillValueChanged();
		
		partial void OnBuffSkillValueChanging(System.Nullable<int> value);
		
		partial void OnSkillBuffIDChanged();
		
		partial void OnSkillBuffIDChanging(int value);
		#endregion
		
		
		public AugmentationSkillBuffs()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_augmentationID", Name="AugmentationID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> AugmentationID
		{
			get
			{
				return this._augmentationID;
			}
			set
			{
				if ((_augmentationID != value))
				{
					this.OnAugmentationIDChanging(value);
					this.SendPropertyChanging();
					this._augmentationID = value;
					this.SendPropertyChanged("AugmentationID");
					this.OnAugmentationIDChanged();
				}
			}
		}
		
		[Column(Storage="_augmentationName", Name="AugmentationName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AugmentationName
		{
			get
			{
				return this._augmentationName;
			}
			set
			{
				if (((_augmentationName == value) 
							== false))
				{
					this.OnAugmentationNameChanging(value);
					this.SendPropertyChanging();
					this._augmentationName = value;
					this.SendPropertyChanged("AugmentationName");
					this.OnAugmentationNameChanged();
				}
			}
		}
		
		[Column(Storage="_buffSkillName", Name="BuffSkillName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BuffSkillName
		{
			get
			{
				return this._buffSkillName;
			}
			set
			{
				if (((_buffSkillName == value) 
							== false))
				{
					this.OnBuffSkillNameChanging(value);
					this.SendPropertyChanging();
					this._buffSkillName = value;
					this.SendPropertyChanged("BuffSkillName");
					this.OnBuffSkillNameChanged();
				}
			}
		}
		
		[Column(Storage="_buffSkillValue", Name="BuffSkillValue", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> BuffSkillValue
		{
			get
			{
				return this._buffSkillValue;
			}
			set
			{
				if ((_buffSkillValue != value))
				{
					this.OnBuffSkillValueChanging(value);
					this.SendPropertyChanging();
					this._buffSkillValue = value;
					this.SendPropertyChanged("BuffSkillValue");
					this.OnBuffSkillValueChanged();
				}
			}
		}
		
		[Column(Storage="_skillBuffID", Name="SkillBuffID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SkillBuffID
		{
			get
			{
				return this._skillBuffID;
			}
			set
			{
				if ((_skillBuffID != value))
				{
					this.OnSkillBuffIDChanging(value);
					this.SendPropertyChanging();
					this._skillBuffID = value;
					this.SendPropertyChanged("SkillBuffID");
					this.OnSkillBuffIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.BaseAttributes")]
	public partial class BaseAttributes : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _attributeDescription;
		
		private int _attributeID;
		
		private System.Nullable<int> _attributeMaxValue;
		
		private System.Nullable<int> _attributeMinValue;
		
		private string _attributName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAttributeDescriptionChanged();
		
		partial void OnAttributeDescriptionChanging(string value);
		
		partial void OnAttributeIDChanged();
		
		partial void OnAttributeIDChanging(int value);
		
		partial void OnAttributeMaxValueChanged();
		
		partial void OnAttributeMaxValueChanging(System.Nullable<int> value);
		
		partial void OnAttributeMinValueChanged();
		
		partial void OnAttributeMinValueChanging(System.Nullable<int> value);
		
		partial void OnAttributNameChanged();
		
		partial void OnAttributNameChanging(string value);
		#endregion
		
		
		public BaseAttributes()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_attributeDescription", Name="AttributeDescription", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AttributeDescription
		{
			get
			{
				return this._attributeDescription;
			}
			set
			{
				if (((_attributeDescription == value) 
							== false))
				{
					this.OnAttributeDescriptionChanging(value);
					this.SendPropertyChanging();
					this._attributeDescription = value;
					this.SendPropertyChanged("AttributeDescription");
					this.OnAttributeDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_attributeID", Name="AttributeID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AttributeID
		{
			get
			{
				return this._attributeID;
			}
			set
			{
				if ((_attributeID != value))
				{
					this.OnAttributeIDChanging(value);
					this.SendPropertyChanging();
					this._attributeID = value;
					this.SendPropertyChanged("AttributeID");
					this.OnAttributeIDChanged();
				}
			}
		}
		
		[Column(Storage="_attributeMaxValue", Name="AttributeMaxValue", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> AttributeMaxValue
		{
			get
			{
				return this._attributeMaxValue;
			}
			set
			{
				if ((_attributeMaxValue != value))
				{
					this.OnAttributeMaxValueChanging(value);
					this.SendPropertyChanging();
					this._attributeMaxValue = value;
					this.SendPropertyChanged("AttributeMaxValue");
					this.OnAttributeMaxValueChanged();
				}
			}
		}
		
		[Column(Storage="_attributeMinValue", Name="AttributeMinValue", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> AttributeMinValue
		{
			get
			{
				return this._attributeMinValue;
			}
			set
			{
				if ((_attributeMinValue != value))
				{
					this.OnAttributeMinValueChanging(value);
					this.SendPropertyChanging();
					this._attributeMinValue = value;
					this.SendPropertyChanged("AttributeMinValue");
					this.OnAttributeMinValueChanged();
				}
			}
		}
		
		[Column(Storage="_attributName", Name="AttributName", DbType="TEXT", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string AttributName
		{
			get
			{
				return this._attributName;
			}
			set
			{
				if (((_attributName == value) 
							== false))
				{
					this.OnAttributNameChanging(value);
					this.SendPropertyChanging();
					this._attributName = value;
					this.SendPropertyChanged("AttributName");
					this.OnAttributNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.BaseItems")]
	public partial class BaseItems : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _baseItemDescription;
		
		private string _baseItemIcon;
		
		private int _baseItemID;
		
		private string _baseItemModel;
		
		private string _baseItemName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBaseItemDescriptionChanged();
		
		partial void OnBaseItemDescriptionChanging(string value);
		
		partial void OnBaseItemIconChanged();
		
		partial void OnBaseItemIconChanging(string value);
		
		partial void OnBaseItemIDChanged();
		
		partial void OnBaseItemIDChanging(int value);
		
		partial void OnBaseItemModelChanged();
		
		partial void OnBaseItemModelChanging(string value);
		
		partial void OnBaseItemNameChanged();
		
		partial void OnBaseItemNameChanging(string value);
		#endregion
		
		
		public BaseItems()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_baseItemDescription", Name="BaseItemDescription", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BaseItemDescription
		{
			get
			{
				return this._baseItemDescription;
			}
			set
			{
				if (((_baseItemDescription == value) 
							== false))
				{
					this.OnBaseItemDescriptionChanging(value);
					this.SendPropertyChanging();
					this._baseItemDescription = value;
					this.SendPropertyChanged("BaseItemDescription");
					this.OnBaseItemDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_baseItemIcon", Name="BaseItemIcon", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BaseItemIcon
		{
			get
			{
				return this._baseItemIcon;
			}
			set
			{
				if (((_baseItemIcon == value) 
							== false))
				{
					this.OnBaseItemIconChanging(value);
					this.SendPropertyChanging();
					this._baseItemIcon = value;
					this.SendPropertyChanged("BaseItemIcon");
					this.OnBaseItemIconChanged();
				}
			}
		}
		
		[Column(Storage="_baseItemID", Name="BaseItemID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int BaseItemID
		{
			get
			{
				return this._baseItemID;
			}
			set
			{
				if ((_baseItemID != value))
				{
					this.OnBaseItemIDChanging(value);
					this.SendPropertyChanging();
					this._baseItemID = value;
					this.SendPropertyChanged("BaseItemID");
					this.OnBaseItemIDChanged();
				}
			}
		}
		
		[Column(Storage="_baseItemModel", Name="BaseItemModel", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BaseItemModel
		{
			get
			{
				return this._baseItemModel;
			}
			set
			{
				if (((_baseItemModel == value) 
							== false))
				{
					this.OnBaseItemModelChanging(value);
					this.SendPropertyChanging();
					this._baseItemModel = value;
					this.SendPropertyChanged("BaseItemModel");
					this.OnBaseItemModelChanged();
				}
			}
		}
		
		[Column(Storage="_baseItemName", Name="BaseItemName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BaseItemName
		{
			get
			{
				return this._baseItemName;
			}
			set
			{
				if (((_baseItemName == value) 
							== false))
				{
					this.OnBaseItemNameChanging(value);
					this.SendPropertyChanging();
					this._baseItemName = value;
					this.SendPropertyChanged("BaseItemName");
					this.OnBaseItemNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.Character")]
	public partial class Character : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _characterGender;
		
		private int _characterID;
		
		private string _characterName;
		
		private string _umA;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCharacterGenderChanged();
		
		partial void OnCharacterGenderChanging(string value);
		
		partial void OnCharacterIDChanged();
		
		partial void OnCharacterIDChanging(int value);
		
		partial void OnCharacterNameChanged();
		
		partial void OnCharacterNameChanging(string value);
		
		partial void OnUmAChanged();
		
		partial void OnUmAChanging(string value);
		#endregion
		
		
		public Character()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_characterGender", Name="CharacterGender", DbType="VARCHAR(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CharacterGender
		{
			get
			{
				return this._characterGender;
			}
			set
			{
				if (((_characterGender == value) 
							== false))
				{
					this.OnCharacterGenderChanging(value);
					this.SendPropertyChanging();
					this._characterGender = value;
					this.SendPropertyChanged("CharacterGender");
					this.OnCharacterGenderChanged();
				}
			}
		}
		
		[Column(Storage="_characterID", Name="CharacterID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CharacterID
		{
			get
			{
				return this._characterID;
			}
			set
			{
				if ((_characterID != value))
				{
					this.OnCharacterIDChanging(value);
					this.SendPropertyChanging();
					this._characterID = value;
					this.SendPropertyChanged("CharacterID");
					this.OnCharacterIDChanged();
				}
			}
		}
		
		[Column(Storage="_characterName", Name="CharacterName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CharacterName
		{
			get
			{
				return this._characterName;
			}
			set
			{
				if (((_characterName == value) 
							== false))
				{
					this.OnCharacterNameChanging(value);
					this.SendPropertyChanging();
					this._characterName = value;
					this.SendPropertyChanged("CharacterName");
					this.OnCharacterNameChanged();
				}
			}
		}
		
		[Column(Storage="_umA", Name="UMA", DbType="VARCHAR(8000)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UmA
		{
			get
			{
				return this._umA;
			}
			set
			{
				if (((_umA == value) 
							== false))
				{
					this.OnUmAChanging(value);
					this.SendPropertyChanging();
					this._umA = value;
					this.SendPropertyChanged("UmA");
					this.OnUmAChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.CharacterAttributes")]
	public partial class CharacterAttributes : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _attributeName;
		
		private System.Nullable<int> _attributeValue;
		
		private int _characterAttributeID;
		
		private System.Nullable<int> _characterID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAttributeNameChanged();
		
		partial void OnAttributeNameChanging(string value);
		
		partial void OnAttributeValueChanged();
		
		partial void OnAttributeValueChanging(System.Nullable<int> value);
		
		partial void OnCharacterAttributeIDChanged();
		
		partial void OnCharacterAttributeIDChanging(int value);
		
		partial void OnCharacterIDChanged();
		
		partial void OnCharacterIDChanging(System.Nullable<int> value);
		#endregion
		
		
		public CharacterAttributes()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_attributeName", Name="AttributeName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AttributeName
		{
			get
			{
				return this._attributeName;
			}
			set
			{
				if (((_attributeName == value) 
							== false))
				{
					this.OnAttributeNameChanging(value);
					this.SendPropertyChanging();
					this._attributeName = value;
					this.SendPropertyChanged("AttributeName");
					this.OnAttributeNameChanged();
				}
			}
		}
		
		[Column(Storage="_attributeValue", Name="AttributeValue", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> AttributeValue
		{
			get
			{
				return this._attributeValue;
			}
			set
			{
				if ((_attributeValue != value))
				{
					this.OnAttributeValueChanging(value);
					this.SendPropertyChanging();
					this._attributeValue = value;
					this.SendPropertyChanged("AttributeValue");
					this.OnAttributeValueChanged();
				}
			}
		}
		
		[Column(Storage="_characterAttributeID", Name="CharacterAttributeID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CharacterAttributeID
		{
			get
			{
				return this._characterAttributeID;
			}
			set
			{
				if ((_characterAttributeID != value))
				{
					this.OnCharacterAttributeIDChanging(value);
					this.SendPropertyChanging();
					this._characterAttributeID = value;
					this.SendPropertyChanged("CharacterAttributeID");
					this.OnCharacterAttributeIDChanged();
				}
			}
		}
		
		[Column(Storage="_characterID", Name="CharacterID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> CharacterID
		{
			get
			{
				return this._characterID;
			}
			set
			{
				if ((_characterID != value))
				{
					this.OnCharacterIDChanging(value);
					this.SendPropertyChanging();
					this._characterID = value;
					this.SendPropertyChanged("CharacterID");
					this.OnCharacterIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.CharacterAugmentations")]
	public partial class CharacterAugmentations : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _augmentation;
		
		private int _characterAugmentationID;
		
		private System.Nullable<int> _characterID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAugmentationChanged();
		
		partial void OnAugmentationChanging(string value);
		
		partial void OnCharacterAugmentationIDChanged();
		
		partial void OnCharacterAugmentationIDChanging(int value);
		
		partial void OnCharacterIDChanged();
		
		partial void OnCharacterIDChanging(System.Nullable<int> value);
		#endregion
		
		
		public CharacterAugmentations()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_augmentation", Name="Augmentation", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Augmentation
		{
			get
			{
				return this._augmentation;
			}
			set
			{
				if (((_augmentation == value) 
							== false))
				{
					this.OnAugmentationChanging(value);
					this.SendPropertyChanging();
					this._augmentation = value;
					this.SendPropertyChanged("Augmentation");
					this.OnAugmentationChanged();
				}
			}
		}
		
		[Column(Storage="_characterAugmentationID", Name="CharacterAugmentationID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CharacterAugmentationID
		{
			get
			{
				return this._characterAugmentationID;
			}
			set
			{
				if ((_characterAugmentationID != value))
				{
					this.OnCharacterAugmentationIDChanging(value);
					this.SendPropertyChanging();
					this._characterAugmentationID = value;
					this.SendPropertyChanged("CharacterAugmentationID");
					this.OnCharacterAugmentationIDChanged();
				}
			}
		}
		
		[Column(Storage="_characterID", Name="CharacterID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> CharacterID
		{
			get
			{
				return this._characterID;
			}
			set
			{
				if ((_characterID != value))
				{
					this.OnCharacterIDChanging(value);
					this.SendPropertyChanging();
					this._characterID = value;
					this.SendPropertyChanged("CharacterID");
					this.OnCharacterIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.CharacterDerivedStats")]
	public partial class CharacterDerivedStats : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _characterDerivedStatsID;
		
		private System.Nullable<int> _characterID;
		
		private string _derivedStatName;
		
		private System.Nullable<int> _derivedStatValue;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCharacterDerivedStatsIDChanged();
		
		partial void OnCharacterDerivedStatsIDChanging(int value);
		
		partial void OnCharacterIDChanged();
		
		partial void OnCharacterIDChanging(System.Nullable<int> value);
		
		partial void OnDerivedStatNameChanged();
		
		partial void OnDerivedStatNameChanging(string value);
		
		partial void OnDerivedStatValueChanged();
		
		partial void OnDerivedStatValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public CharacterDerivedStats()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_characterDerivedStatsID", Name="CharacterDerivedStatsID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CharacterDerivedStatsID
		{
			get
			{
				return this._characterDerivedStatsID;
			}
			set
			{
				if ((_characterDerivedStatsID != value))
				{
					this.OnCharacterDerivedStatsIDChanging(value);
					this.SendPropertyChanging();
					this._characterDerivedStatsID = value;
					this.SendPropertyChanged("CharacterDerivedStatsID");
					this.OnCharacterDerivedStatsIDChanged();
				}
			}
		}
		
		[Column(Storage="_characterID", Name="CharacterID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> CharacterID
		{
			get
			{
				return this._characterID;
			}
			set
			{
				if ((_characterID != value))
				{
					this.OnCharacterIDChanging(value);
					this.SendPropertyChanging();
					this._characterID = value;
					this.SendPropertyChanged("CharacterID");
					this.OnCharacterIDChanged();
				}
			}
		}
		
		[Column(Storage="_derivedStatName", Name="DerivedStatName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DerivedStatName
		{
			get
			{
				return this._derivedStatName;
			}
			set
			{
				if (((_derivedStatName == value) 
							== false))
				{
					this.OnDerivedStatNameChanging(value);
					this.SendPropertyChanging();
					this._derivedStatName = value;
					this.SendPropertyChanged("DerivedStatName");
					this.OnDerivedStatNameChanged();
				}
			}
		}
		
		[Column(Storage="_derivedStatValue", Name="DerivedStatValue", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> DerivedStatValue
		{
			get
			{
				return this._derivedStatValue;
			}
			set
			{
				if ((_derivedStatValue != value))
				{
					this.OnDerivedStatValueChanging(value);
					this.SendPropertyChanging();
					this._derivedStatValue = value;
					this.SendPropertyChanged("DerivedStatValue");
					this.OnDerivedStatValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.CharacterGroup")]
	public partial class CharacterGroup : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _character1id;
		
		private System.Nullable<int> _character2id;
		
		private System.Nullable<int> _character3id;
		
		private System.Nullable<int> _character4id;
		
		private System.Nullable<int> _character5id;
		
		private System.Nullable<int> _character6id;
		
		private System.Nullable<int> _characterGroupID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCharacter1idChanged();
		
		partial void OnCharacter1idChanging(System.Nullable<int> value);
		
		partial void OnCharacter2idChanged();
		
		partial void OnCharacter2idChanging(System.Nullable<int> value);
		
		partial void OnCharacter3idChanged();
		
		partial void OnCharacter3idChanging(System.Nullable<int> value);
		
		partial void OnCharacter4idChanged();
		
		partial void OnCharacter4idChanging(System.Nullable<int> value);
		
		partial void OnCharacter5idChanged();
		
		partial void OnCharacter5idChanging(System.Nullable<int> value);
		
		partial void OnCharacter6idChanged();
		
		partial void OnCharacter6idChanging(System.Nullable<int> value);
		
		partial void OnCharacterGroupIDChanged();
		
		partial void OnCharacterGroupIDChanging(System.Nullable<int> value);
		#endregion
		
		
		public CharacterGroup()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_character1id", Name="Character1ID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Character1id
		{
			get
			{
				return this._character1id;
			}
			set
			{
				if ((_character1id != value))
				{
					this.OnCharacter1idChanging(value);
					this.SendPropertyChanging();
					this._character1id = value;
					this.SendPropertyChanged("Character1id");
					this.OnCharacter1idChanged();
				}
			}
		}
		
		[Column(Storage="_character2id", Name="Character2ID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Character2id
		{
			get
			{
				return this._character2id;
			}
			set
			{
				if ((_character2id != value))
				{
					this.OnCharacter2idChanging(value);
					this.SendPropertyChanging();
					this._character2id = value;
					this.SendPropertyChanged("Character2id");
					this.OnCharacter2idChanged();
				}
			}
		}
		
		[Column(Storage="_character3id", Name="Character3ID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Character3id
		{
			get
			{
				return this._character3id;
			}
			set
			{
				if ((_character3id != value))
				{
					this.OnCharacter3idChanging(value);
					this.SendPropertyChanging();
					this._character3id = value;
					this.SendPropertyChanged("Character3id");
					this.OnCharacter3idChanged();
				}
			}
		}
		
		[Column(Storage="_character4id", Name="Character4ID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Character4id
		{
			get
			{
				return this._character4id;
			}
			set
			{
				if ((_character4id != value))
				{
					this.OnCharacter4idChanging(value);
					this.SendPropertyChanging();
					this._character4id = value;
					this.SendPropertyChanged("Character4id");
					this.OnCharacter4idChanged();
				}
			}
		}
		
		[Column(Storage="_character5id", Name="Character5ID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Character5id
		{
			get
			{
				return this._character5id;
			}
			set
			{
				if ((_character5id != value))
				{
					this.OnCharacter5idChanging(value);
					this.SendPropertyChanging();
					this._character5id = value;
					this.SendPropertyChanged("Character5id");
					this.OnCharacter5idChanged();
				}
			}
		}
		
		[Column(Storage="_character6id", Name="Character6ID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Character6id
		{
			get
			{
				return this._character6id;
			}
			set
			{
				if ((_character6id != value))
				{
					this.OnCharacter6idChanging(value);
					this.SendPropertyChanging();
					this._character6id = value;
					this.SendPropertyChanged("Character6id");
					this.OnCharacter6idChanged();
				}
			}
		}
		
		[Column(Storage="_characterGroupID", Name="CharacterGroupID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> CharacterGroupID
		{
			get
			{
				return this._characterGroupID;
			}
			set
			{
				if ((_characterGroupID != value))
				{
					this.OnCharacterGroupIDChanging(value);
					this.SendPropertyChanging();
					this._characterGroupID = value;
					this.SendPropertyChanged("CharacterGroupID");
					this.OnCharacterGroupIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.CharacterInventory")]
	public partial class CharacterInventory : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _characterInventoryID;
		
		private string _characterName;
		
		private System.Nullable<int> _itemID;
		
		private string _itemType;
		
		private System.Nullable<int> _quantity;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCharacterInventoryIDChanged();
		
		partial void OnCharacterInventoryIDChanging(int value);
		
		partial void OnCharacterNameChanged();
		
		partial void OnCharacterNameChanging(string value);
		
		partial void OnItemIDChanged();
		
		partial void OnItemIDChanging(System.Nullable<int> value);
		
		partial void OnItemTypeChanged();
		
		partial void OnItemTypeChanging(string value);
		
		partial void OnQuantityChanged();
		
		partial void OnQuantityChanging(System.Nullable<int> value);
		#endregion
		
		
		public CharacterInventory()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_characterInventoryID", Name="CharacterInventoryID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CharacterInventoryID
		{
			get
			{
				return this._characterInventoryID;
			}
			set
			{
				if ((_characterInventoryID != value))
				{
					this.OnCharacterInventoryIDChanging(value);
					this.SendPropertyChanging();
					this._characterInventoryID = value;
					this.SendPropertyChanged("CharacterInventoryID");
					this.OnCharacterInventoryIDChanged();
				}
			}
		}
		
		[Column(Storage="_characterName", Name="CharacterName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CharacterName
		{
			get
			{
				return this._characterName;
			}
			set
			{
				if (((_characterName == value) 
							== false))
				{
					this.OnCharacterNameChanging(value);
					this.SendPropertyChanging();
					this._characterName = value;
					this.SendPropertyChanged("CharacterName");
					this.OnCharacterNameChanged();
				}
			}
		}
		
		[Column(Storage="_itemID", Name="ItemID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ItemID
		{
			get
			{
				return this._itemID;
			}
			set
			{
				if ((_itemID != value))
				{
					this.OnItemIDChanging(value);
					this.SendPropertyChanging();
					this._itemID = value;
					this.SendPropertyChanged("ItemID");
					this.OnItemIDChanged();
				}
			}
		}
		
		[Column(Storage="_itemType", Name="ItemType", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ItemType
		{
			get
			{
				return this._itemType;
			}
			set
			{
				if (((_itemType == value) 
							== false))
				{
					this.OnItemTypeChanging(value);
					this.SendPropertyChanging();
					this._itemType = value;
					this.SendPropertyChanged("ItemType");
					this.OnItemTypeChanged();
				}
			}
		}
		
		[Column(Storage="_quantity", Name="Quantity", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((_quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.CharacterSkills")]
	public partial class CharacterSkills : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _characterID;
		
		private int _characterSkillID;
		
		private string _skillName;
		
		private System.Nullable<int> _skillValue;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCharacterIDChanged();
		
		partial void OnCharacterIDChanging(System.Nullable<int> value);
		
		partial void OnCharacterSkillIDChanged();
		
		partial void OnCharacterSkillIDChanging(int value);
		
		partial void OnSkillNameChanged();
		
		partial void OnSkillNameChanging(string value);
		
		partial void OnSkillValueChanged();
		
		partial void OnSkillValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public CharacterSkills()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_characterID", Name="CharacterID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> CharacterID
		{
			get
			{
				return this._characterID;
			}
			set
			{
				if ((_characterID != value))
				{
					this.OnCharacterIDChanging(value);
					this.SendPropertyChanging();
					this._characterID = value;
					this.SendPropertyChanged("CharacterID");
					this.OnCharacterIDChanged();
				}
			}
		}
		
		[Column(Storage="_characterSkillID", Name="CharacterSkillID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CharacterSkillID
		{
			get
			{
				return this._characterSkillID;
			}
			set
			{
				if ((_characterSkillID != value))
				{
					this.OnCharacterSkillIDChanging(value);
					this.SendPropertyChanging();
					this._characterSkillID = value;
					this.SendPropertyChanged("CharacterSkillID");
					this.OnCharacterSkillIDChanged();
				}
			}
		}
		
		[Column(Storage="_skillName", Name="SkillName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SkillName
		{
			get
			{
				return this._skillName;
			}
			set
			{
				if (((_skillName == value) 
							== false))
				{
					this.OnSkillNameChanging(value);
					this.SendPropertyChanging();
					this._skillName = value;
					this.SendPropertyChanged("SkillName");
					this.OnSkillNameChanged();
				}
			}
		}
		
		[Column(Storage="_skillValue", Name="SkillValue", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SkillValue
		{
			get
			{
				return this._skillValue;
			}
			set
			{
				if ((_skillValue != value))
				{
					this.OnSkillValueChanging(value);
					this.SendPropertyChanging();
					this._skillValue = value;
					this.SendPropertyChanged("SkillValue");
					this.OnSkillValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.ContainerInventories")]
	public partial class ContainerInventories : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _containerID;
		
		private int _containerInventoryID;
		
		private System.Nullable<int> _itemID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnContainerIDChanged();
		
		partial void OnContainerIDChanging(System.Nullable<int> value);
		
		partial void OnContainerInventoryIDChanged();
		
		partial void OnContainerInventoryIDChanging(int value);
		
		partial void OnItemIDChanged();
		
		partial void OnItemIDChanging(System.Nullable<int> value);
		#endregion
		
		
		public ContainerInventories()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_containerID", Name="ContainerID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ContainerID
		{
			get
			{
				return this._containerID;
			}
			set
			{
				if ((_containerID != value))
				{
					this.OnContainerIDChanging(value);
					this.SendPropertyChanging();
					this._containerID = value;
					this.SendPropertyChanged("ContainerID");
					this.OnContainerIDChanged();
				}
			}
		}
		
		[Column(Storage="_containerInventoryID", Name="ContainerInventoryID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ContainerInventoryID
		{
			get
			{
				return this._containerInventoryID;
			}
			set
			{
				if ((_containerInventoryID != value))
				{
					this.OnContainerInventoryIDChanging(value);
					this.SendPropertyChanging();
					this._containerInventoryID = value;
					this.SendPropertyChanged("ContainerInventoryID");
					this.OnContainerInventoryIDChanged();
				}
			}
		}
		
		[Column(Storage="_itemID", Name="ItemID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ItemID
		{
			get
			{
				return this._itemID;
			}
			set
			{
				if ((_itemID != value))
				{
					this.OnItemIDChanging(value);
					this.SendPropertyChanging();
					this._itemID = value;
					this.SendPropertyChanged("ItemID");
					this.OnItemIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.Containers")]
	public partial class Containers : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _containerID;
		
		private string _containerType;
		
		private string _description;
		
		private System.Nullable<int> _locationID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnContainerIDChanged();
		
		partial void OnContainerIDChanging(int value);
		
		partial void OnContainerTypeChanged();
		
		partial void OnContainerTypeChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnLocationIDChanged();
		
		partial void OnLocationIDChanging(System.Nullable<int> value);
		#endregion
		
		
		public Containers()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_containerID", Name="ContainerID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ContainerID
		{
			get
			{
				return this._containerID;
			}
			set
			{
				if ((_containerID != value))
				{
					this.OnContainerIDChanging(value);
					this.SendPropertyChanging();
					this._containerID = value;
					this.SendPropertyChanged("ContainerID");
					this.OnContainerIDChanged();
				}
			}
		}
		
		[Column(Storage="_containerType", Name="ContainerType", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ContainerType
		{
			get
			{
				return this._containerType;
			}
			set
			{
				if (((_containerType == value) 
							== false))
				{
					this.OnContainerTypeChanging(value);
					this.SendPropertyChanging();
					this._containerType = value;
					this.SendPropertyChanged("ContainerType");
					this.OnContainerTypeChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_locationID", Name="LocationID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> LocationID
		{
			get
			{
				return this._locationID;
			}
			set
			{
				if ((_locationID != value))
				{
					this.OnLocationIDChanging(value);
					this.SendPropertyChanging();
					this._locationID = value;
					this.SendPropertyChanged("LocationID");
					this.OnLocationIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.DerivedStatComponents")]
	public partial class DerivedStatComponents : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _derivedStatComponentID;
		
		private string _derivedStatName;
		
		private string _statName;
		
		private System.Nullable<int> _statValue;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDerivedStatComponentIDChanged();
		
		partial void OnDerivedStatComponentIDChanging(int value);
		
		partial void OnDerivedStatNameChanged();
		
		partial void OnDerivedStatNameChanging(string value);
		
		partial void OnStatNameChanged();
		
		partial void OnStatNameChanging(string value);
		
		partial void OnStatValueChanged();
		
		partial void OnStatValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public DerivedStatComponents()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_derivedStatComponentID", Name="DerivedStatComponentID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int DerivedStatComponentID
		{
			get
			{
				return this._derivedStatComponentID;
			}
			set
			{
				if ((_derivedStatComponentID != value))
				{
					this.OnDerivedStatComponentIDChanging(value);
					this.SendPropertyChanging();
					this._derivedStatComponentID = value;
					this.SendPropertyChanged("DerivedStatComponentID");
					this.OnDerivedStatComponentIDChanged();
				}
			}
		}
		
		[Column(Storage="_derivedStatName", Name="DerivedStatName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DerivedStatName
		{
			get
			{
				return this._derivedStatName;
			}
			set
			{
				if (((_derivedStatName == value) 
							== false))
				{
					this.OnDerivedStatNameChanging(value);
					this.SendPropertyChanging();
					this._derivedStatName = value;
					this.SendPropertyChanged("DerivedStatName");
					this.OnDerivedStatNameChanged();
				}
			}
		}
		
		[Column(Storage="_statName", Name="StatName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string StatName
		{
			get
			{
				return this._statName;
			}
			set
			{
				if (((_statName == value) 
							== false))
				{
					this.OnStatNameChanging(value);
					this.SendPropertyChanging();
					this._statName = value;
					this.SendPropertyChanged("StatName");
					this.OnStatNameChanged();
				}
			}
		}
		
		[Column(Storage="_statValue", Name="StatValue", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> StatValue
		{
			get
			{
				return this._statValue;
			}
			set
			{
				if ((_statValue != value))
				{
					this.OnStatValueChanging(value);
					this.SendPropertyChanging();
					this._statValue = value;
					this.SendPropertyChanged("StatValue");
					this.OnStatValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.DerivedStats")]
	public partial class DerivedStats : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _derivedStatDescription;
		
		private int _derivedStatID;
		
		private string _derivedStatName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDerivedStatDescriptionChanged();
		
		partial void OnDerivedStatDescriptionChanging(string value);
		
		partial void OnDerivedStatIDChanged();
		
		partial void OnDerivedStatIDChanging(int value);
		
		partial void OnDerivedStatNameChanged();
		
		partial void OnDerivedStatNameChanging(string value);
		#endregion
		
		
		public DerivedStats()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_derivedStatDescription", Name="DerivedStatDescription", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DerivedStatDescription
		{
			get
			{
				return this._derivedStatDescription;
			}
			set
			{
				if (((_derivedStatDescription == value) 
							== false))
				{
					this.OnDerivedStatDescriptionChanging(value);
					this.SendPropertyChanging();
					this._derivedStatDescription = value;
					this.SendPropertyChanged("DerivedStatDescription");
					this.OnDerivedStatDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_derivedStatID", Name="DerivedStatID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int DerivedStatID
		{
			get
			{
				return this._derivedStatID;
			}
			set
			{
				if ((_derivedStatID != value))
				{
					this.OnDerivedStatIDChanging(value);
					this.SendPropertyChanging();
					this._derivedStatID = value;
					this.SendPropertyChanged("DerivedStatID");
					this.OnDerivedStatIDChanged();
				}
			}
		}
		
		[Column(Storage="_derivedStatName", Name="DerivedStatName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DerivedStatName
		{
			get
			{
				return this._derivedStatName;
			}
			set
			{
				if (((_derivedStatName == value) 
							== false))
				{
					this.OnDerivedStatNameChanging(value);
					this.SendPropertyChanging();
					this._derivedStatName = value;
					this.SendPropertyChanged("DerivedStatName");
					this.OnDerivedStatNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.PistolBarrels")]
	public partial class PistolBarrels : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private System.Nullable<float> _minDamage;
		
		private int _pistolBarrelID;
		
		private string _pistolBarrelName;
		
		private System.Nullable<float> _range;
		
		private string _rarity;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnMinDamageChanged();
		
		partial void OnMinDamageChanging(System.Nullable<float> value);
		
		partial void OnPistolBarrelIDChanged();
		
		partial void OnPistolBarrelIDChanging(int value);
		
		partial void OnPistolBarrelNameChanged();
		
		partial void OnPistolBarrelNameChanging(string value);
		
		partial void OnRangeChanged();
		
		partial void OnRangeChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public PistolBarrels()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_minDamage", Name="MinDamage", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> MinDamage
		{
			get
			{
				return this._minDamage;
			}
			set
			{
				if ((_minDamage != value))
				{
					this.OnMinDamageChanging(value);
					this.SendPropertyChanging();
					this._minDamage = value;
					this.SendPropertyChanged("MinDamage");
					this.OnMinDamageChanged();
				}
			}
		}
		
		[Column(Storage="_pistolBarrelID", Name="PistolBarrelID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PistolBarrelID
		{
			get
			{
				return this._pistolBarrelID;
			}
			set
			{
				if ((_pistolBarrelID != value))
				{
					this.OnPistolBarrelIDChanging(value);
					this.SendPropertyChanging();
					this._pistolBarrelID = value;
					this.SendPropertyChanged("PistolBarrelID");
					this.OnPistolBarrelIDChanged();
				}
			}
		}
		
		[Column(Storage="_pistolBarrelName", Name="PistolBarrelName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PistolBarrelName
		{
			get
			{
				return this._pistolBarrelName;
			}
			set
			{
				if (((_pistolBarrelName == value) 
							== false))
				{
					this.OnPistolBarrelNameChanging(value);
					this.SendPropertyChanging();
					this._pistolBarrelName = value;
					this.SendPropertyChanged("PistolBarrelName");
					this.OnPistolBarrelNameChanged();
				}
			}
		}
		
		[Column(Storage="_range", Name="Range", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Range
		{
			get
			{
				return this._range;
			}
			set
			{
				if ((_range != value))
				{
					this.OnRangeChanging(value);
					this.SendPropertyChanging();
					this._range = value;
					this.SendPropertyChanged("Range");
					this.OnRangeChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.PistolBody")]
	public partial class PistolBody : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _calibre;
		
		private System.Nullable<int> _engLevel;
		
		private System.Nullable<float> _maxDamage;
		
		private int _pistolBodyID;
		
		private string _pistolBodyName;
		
		private string _rarity;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCalibreChanged();
		
		partial void OnCalibreChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnMaxDamageChanged();
		
		partial void OnMaxDamageChanging(System.Nullable<float> value);
		
		partial void OnPistolBodyIDChanged();
		
		partial void OnPistolBodyIDChanging(int value);
		
		partial void OnPistolBodyNameChanged();
		
		partial void OnPistolBodyNameChanging(string value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public PistolBody()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_calibre", Name="Calibre", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Calibre
		{
			get
			{
				return this._calibre;
			}
			set
			{
				if (((_calibre == value) 
							== false))
				{
					this.OnCalibreChanging(value);
					this.SendPropertyChanging();
					this._calibre = value;
					this.SendPropertyChanged("Calibre");
					this.OnCalibreChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_maxDamage", Name="MaxDamage", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> MaxDamage
		{
			get
			{
				return this._maxDamage;
			}
			set
			{
				if ((_maxDamage != value))
				{
					this.OnMaxDamageChanging(value);
					this.SendPropertyChanging();
					this._maxDamage = value;
					this.SendPropertyChanged("MaxDamage");
					this.OnMaxDamageChanged();
				}
			}
		}
		
		[Column(Storage="_pistolBodyID", Name="PistolBodyID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PistolBodyID
		{
			get
			{
				return this._pistolBodyID;
			}
			set
			{
				if ((_pistolBodyID != value))
				{
					this.OnPistolBodyIDChanging(value);
					this.SendPropertyChanging();
					this._pistolBodyID = value;
					this.SendPropertyChanged("PistolBodyID");
					this.OnPistolBodyIDChanged();
				}
			}
		}
		
		[Column(Storage="_pistolBodyName", Name="PistolBodyName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PistolBodyName
		{
			get
			{
				return this._pistolBodyName;
			}
			set
			{
				if (((_pistolBodyName == value) 
							== false))
				{
					this.OnPistolBodyNameChanging(value);
					this.SendPropertyChanging();
					this._pistolBodyName = value;
					this.SendPropertyChanged("PistolBodyName");
					this.OnPistolBodyNameChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.PistolMagazines")]
	public partial class PistolMagazines : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _capacity;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private int _magazineID;
		
		private string _name;
		
		private string _rarity;
		
		private System.Nullable<float> _rateOfFire;
		
		private System.Nullable<float> _reloadSpeed;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCapacityChanged();
		
		partial void OnCapacityChanging(System.Nullable<int> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnMagazineIDChanged();
		
		partial void OnMagazineIDChanging(int value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public PistolMagazines()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_capacity", Name="Capacity", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Capacity
		{
			get
			{
				return this._capacity;
			}
			set
			{
				if ((_capacity != value))
				{
					this.OnCapacityChanging(value);
					this.SendPropertyChanging();
					this._capacity = value;
					this.SendPropertyChanged("Capacity");
					this.OnCapacityChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_magazineID", Name="MagazineID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int MagazineID
		{
			get
			{
				return this._magazineID;
			}
			set
			{
				if ((_magazineID != value))
				{
					this.OnMagazineIDChanging(value);
					this.SendPropertyChanging();
					this._magazineID = value;
					this.SendPropertyChanged("MagazineID");
					this.OnMagazineIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="Name", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.PistolMechanisms")]
	public partial class PistolMechanisms : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _burstType;
		
		private System.Nullable<int> _engLevel;
		
		private int _pistolMechanismID;
		
		private string _pistolMechanismName;
		
		private string _pistolMechanismRarity;
		
		private System.Nullable<int> _pistolMechanismValue;
		
		private string _pistonMechanismDescription;
		
		private System.Nullable<float> _rateOfFire;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBurstTypeChanged();
		
		partial void OnBurstTypeChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnPistolMechanismIDChanged();
		
		partial void OnPistolMechanismIDChanging(int value);
		
		partial void OnPistolMechanismNameChanged();
		
		partial void OnPistolMechanismNameChanging(string value);
		
		partial void OnPistolMechanismRarityChanged();
		
		partial void OnPistolMechanismRarityChanging(string value);
		
		partial void OnPistolMechanismValueChanged();
		
		partial void OnPistolMechanismValueChanging(System.Nullable<int> value);
		
		partial void OnPistonMechanismDescriptionChanged();
		
		partial void OnPistonMechanismDescriptionChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		#endregion
		
		
		public PistolMechanisms()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_burstType", Name="BurstType", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BurstType
		{
			get
			{
				return this._burstType;
			}
			set
			{
				if (((_burstType == value) 
							== false))
				{
					this.OnBurstTypeChanging(value);
					this.SendPropertyChanging();
					this._burstType = value;
					this.SendPropertyChanged("BurstType");
					this.OnBurstTypeChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_pistolMechanismID", Name="PistolMechanismID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PistolMechanismID
		{
			get
			{
				return this._pistolMechanismID;
			}
			set
			{
				if ((_pistolMechanismID != value))
				{
					this.OnPistolMechanismIDChanging(value);
					this.SendPropertyChanging();
					this._pistolMechanismID = value;
					this.SendPropertyChanged("PistolMechanismID");
					this.OnPistolMechanismIDChanged();
				}
			}
		}
		
		[Column(Storage="_pistolMechanismName", Name="PistolMechanismName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PistolMechanismName
		{
			get
			{
				return this._pistolMechanismName;
			}
			set
			{
				if (((_pistolMechanismName == value) 
							== false))
				{
					this.OnPistolMechanismNameChanging(value);
					this.SendPropertyChanging();
					this._pistolMechanismName = value;
					this.SendPropertyChanged("PistolMechanismName");
					this.OnPistolMechanismNameChanged();
				}
			}
		}
		
		[Column(Storage="_pistolMechanismRarity", Name="PistolMechanismRarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PistolMechanismRarity
		{
			get
			{
				return this._pistolMechanismRarity;
			}
			set
			{
				if (((_pistolMechanismRarity == value) 
							== false))
				{
					this.OnPistolMechanismRarityChanging(value);
					this.SendPropertyChanging();
					this._pistolMechanismRarity = value;
					this.SendPropertyChanged("PistolMechanismRarity");
					this.OnPistolMechanismRarityChanged();
				}
			}
		}
		
		[Column(Storage="_pistolMechanismValue", Name="PistolMechanismValue", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> PistolMechanismValue
		{
			get
			{
				return this._pistolMechanismValue;
			}
			set
			{
				if ((_pistolMechanismValue != value))
				{
					this.OnPistolMechanismValueChanging(value);
					this.SendPropertyChanging();
					this._pistolMechanismValue = value;
					this.SendPropertyChanged("PistolMechanismValue");
					this.OnPistolMechanismValueChanged();
				}
			}
		}
		
		[Column(Storage="_pistonMechanismDescription", Name="PistonMechanismDescription", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PistonMechanismDescription
		{
			get
			{
				return this._pistonMechanismDescription;
			}
			set
			{
				if (((_pistonMechanismDescription == value) 
							== false))
				{
					this.OnPistonMechanismDescriptionChanging(value);
					this.SendPropertyChanging();
					this._pistonMechanismDescription = value;
					this.SendPropertyChanged("PistonMechanismDescription");
					this.OnPistonMechanismDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.Pistols")]
	public partial class Pistols : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private System.Nullable<int> _barrelID;
		
		private System.Nullable<int> _bodyID;
		
		private string _burstType;
		
		private string _calibre;
		
		private string _description;
		
		private System.Nullable<int> _magazineCapacity;
		
		private System.Nullable<int> _magazineID;
		
		private System.Nullable<float> _maxDamage;
		
		private System.Nullable<int> _mechanismID;
		
		private System.Nullable<float> _minDamage;
		
		private System.Nullable<int> _minLevel;
		
		private int _pistolID;
		
		private string _pistolName;
		
		private System.Nullable<float> _range;
		
		private string _rarity;
		
		private System.Nullable<float> _rateOfFire;
		
		private System.Nullable<float> _reloadSpeed;
		
		private System.Nullable<int> _sightID;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnBarrelIDChanged();
		
		partial void OnBarrelIDChanging(System.Nullable<int> value);
		
		partial void OnBodyIDChanged();
		
		partial void OnBodyIDChanging(System.Nullable<int> value);
		
		partial void OnBurstTypeChanged();
		
		partial void OnBurstTypeChanging(string value);
		
		partial void OnCalibreChanged();
		
		partial void OnCalibreChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnMagazineCapacityChanged();
		
		partial void OnMagazineCapacityChanging(System.Nullable<int> value);
		
		partial void OnMagazineIDChanged();
		
		partial void OnMagazineIDChanging(System.Nullable<int> value);
		
		partial void OnMaxDamageChanged();
		
		partial void OnMaxDamageChanging(System.Nullable<float> value);
		
		partial void OnMechanismIDChanged();
		
		partial void OnMechanismIDChanging(System.Nullable<int> value);
		
		partial void OnMinDamageChanged();
		
		partial void OnMinDamageChanging(System.Nullable<float> value);
		
		partial void OnMinLevelChanged();
		
		partial void OnMinLevelChanging(System.Nullable<int> value);
		
		partial void OnPistolIDChanged();
		
		partial void OnPistolIDChanging(int value);
		
		partial void OnPistolNameChanged();
		
		partial void OnPistolNameChanging(string value);
		
		partial void OnRangeChanged();
		
		partial void OnRangeChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnSightIDChanged();
		
		partial void OnSightIDChanging(System.Nullable<int> value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public Pistols()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_barrelID", Name="BarrelID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> BarrelID
		{
			get
			{
				return this._barrelID;
			}
			set
			{
				if ((_barrelID != value))
				{
					this.OnBarrelIDChanging(value);
					this.SendPropertyChanging();
					this._barrelID = value;
					this.SendPropertyChanged("BarrelID");
					this.OnBarrelIDChanged();
				}
			}
		}
		
		[Column(Storage="_bodyID", Name="BodyID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> BodyID
		{
			get
			{
				return this._bodyID;
			}
			set
			{
				if ((_bodyID != value))
				{
					this.OnBodyIDChanging(value);
					this.SendPropertyChanging();
					this._bodyID = value;
					this.SendPropertyChanged("BodyID");
					this.OnBodyIDChanged();
				}
			}
		}
		
		[Column(Storage="_burstType", Name="BurstType", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BurstType
		{
			get
			{
				return this._burstType;
			}
			set
			{
				if (((_burstType == value) 
							== false))
				{
					this.OnBurstTypeChanging(value);
					this.SendPropertyChanging();
					this._burstType = value;
					this.SendPropertyChanged("BurstType");
					this.OnBurstTypeChanged();
				}
			}
		}
		
		[Column(Storage="_calibre", Name="Calibre", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Calibre
		{
			get
			{
				return this._calibre;
			}
			set
			{
				if (((_calibre == value) 
							== false))
				{
					this.OnCalibreChanging(value);
					this.SendPropertyChanging();
					this._calibre = value;
					this.SendPropertyChanged("Calibre");
					this.OnCalibreChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_magazineCapacity", Name="MagazineCapacity", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MagazineCapacity
		{
			get
			{
				return this._magazineCapacity;
			}
			set
			{
				if ((_magazineCapacity != value))
				{
					this.OnMagazineCapacityChanging(value);
					this.SendPropertyChanging();
					this._magazineCapacity = value;
					this.SendPropertyChanged("MagazineCapacity");
					this.OnMagazineCapacityChanged();
				}
			}
		}
		
		[Column(Storage="_magazineID", Name="MagazineID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MagazineID
		{
			get
			{
				return this._magazineID;
			}
			set
			{
				if ((_magazineID != value))
				{
					this.OnMagazineIDChanging(value);
					this.SendPropertyChanging();
					this._magazineID = value;
					this.SendPropertyChanged("MagazineID");
					this.OnMagazineIDChanged();
				}
			}
		}
		
		[Column(Storage="_maxDamage", Name="MaxDamage", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> MaxDamage
		{
			get
			{
				return this._maxDamage;
			}
			set
			{
				if ((_maxDamage != value))
				{
					this.OnMaxDamageChanging(value);
					this.SendPropertyChanging();
					this._maxDamage = value;
					this.SendPropertyChanged("MaxDamage");
					this.OnMaxDamageChanged();
				}
			}
		}
		
		[Column(Storage="_mechanismID", Name="MechanismID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MechanismID
		{
			get
			{
				return this._mechanismID;
			}
			set
			{
				if ((_mechanismID != value))
				{
					this.OnMechanismIDChanging(value);
					this.SendPropertyChanging();
					this._mechanismID = value;
					this.SendPropertyChanged("MechanismID");
					this.OnMechanismIDChanged();
				}
			}
		}
		
		[Column(Storage="_minDamage", Name="MinDamage", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> MinDamage
		{
			get
			{
				return this._minDamage;
			}
			set
			{
				if ((_minDamage != value))
				{
					this.OnMinDamageChanging(value);
					this.SendPropertyChanging();
					this._minDamage = value;
					this.SendPropertyChanged("MinDamage");
					this.OnMinDamageChanged();
				}
			}
		}
		
		[Column(Storage="_minLevel", Name="MinLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MinLevel
		{
			get
			{
				return this._minLevel;
			}
			set
			{
				if ((_minLevel != value))
				{
					this.OnMinLevelChanging(value);
					this.SendPropertyChanging();
					this._minLevel = value;
					this.SendPropertyChanged("MinLevel");
					this.OnMinLevelChanged();
				}
			}
		}
		
		[Column(Storage="_pistolID", Name="PistolID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PistolID
		{
			get
			{
				return this._pistolID;
			}
			set
			{
				if ((_pistolID != value))
				{
					this.OnPistolIDChanging(value);
					this.SendPropertyChanging();
					this._pistolID = value;
					this.SendPropertyChanged("PistolID");
					this.OnPistolIDChanged();
				}
			}
		}
		
		[Column(Storage="_pistolName", Name="PistolName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PistolName
		{
			get
			{
				return this._pistolName;
			}
			set
			{
				if (((_pistolName == value) 
							== false))
				{
					this.OnPistolNameChanging(value);
					this.SendPropertyChanging();
					this._pistolName = value;
					this.SendPropertyChanged("PistolName");
					this.OnPistolNameChanged();
				}
			}
		}
		
		[Column(Storage="_range", Name="Range", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Range
		{
			get
			{
				return this._range;
			}
			set
			{
				if ((_range != value))
				{
					this.OnRangeChanging(value);
					this.SendPropertyChanging();
					this._range = value;
					this.SendPropertyChanged("Range");
					this.OnRangeChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_sightID", Name="SightID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SightID
		{
			get
			{
				return this._sightID;
			}
			set
			{
				if ((_sightID != value))
				{
					this.OnSightIDChanging(value);
					this.SendPropertyChanging();
					this._sightID = value;
					this.SendPropertyChanged("SightID");
					this.OnSightIDChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.PistolSights")]
	public partial class PistolSights : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private System.Nullable<float> _range;
		
		private string _rarity;
		
		private int _sightID;
		
		private string _sightName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRangeChanged();
		
		partial void OnRangeChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnSightIDChanged();
		
		partial void OnSightIDChanging(int value);
		
		partial void OnSightNameChanged();
		
		partial void OnSightNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public PistolSights()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_range", Name="Range", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Range
		{
			get
			{
				return this._range;
			}
			set
			{
				if ((_range != value))
				{
					this.OnRangeChanging(value);
					this.SendPropertyChanging();
					this._range = value;
					this.SendPropertyChanged("Range");
					this.OnRangeChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_sightID", Name="SightID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SightID
		{
			get
			{
				return this._sightID;
			}
			set
			{
				if ((_sightID != value))
				{
					this.OnSightIDChanging(value);
					this.SendPropertyChanging();
					this._sightID = value;
					this.SendPropertyChanged("SightID");
					this.OnSightIDChanged();
				}
			}
		}
		
		[Column(Storage="_sightName", Name="SightName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SightName
		{
			get
			{
				return this._sightName;
			}
			set
			{
				if (((_sightName == value) 
							== false))
				{
					this.OnSightNameChanging(value);
					this.SendPropertyChanging();
					this._sightName = value;
					this.SendPropertyChanged("SightName");
					this.OnSightNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.ShotgunBarrels")]
	public partial class ShotgunBarrels : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private System.Nullable<float> _minDamage;
		
		private System.Nullable<float> _range;
		
		private string _rarity;
		
		private int _shotgunBarrelID;
		
		private string _shotgunBarrelName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnMinDamageChanged();
		
		partial void OnMinDamageChanging(System.Nullable<float> value);
		
		partial void OnRangeChanged();
		
		partial void OnRangeChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnShotgunBarrelIDChanged();
		
		partial void OnShotgunBarrelIDChanging(int value);
		
		partial void OnShotgunBarrelNameChanged();
		
		partial void OnShotgunBarrelNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public ShotgunBarrels()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_minDamage", Name="MinDamage", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> MinDamage
		{
			get
			{
				return this._minDamage;
			}
			set
			{
				if ((_minDamage != value))
				{
					this.OnMinDamageChanging(value);
					this.SendPropertyChanging();
					this._minDamage = value;
					this.SendPropertyChanged("MinDamage");
					this.OnMinDamageChanged();
				}
			}
		}
		
		[Column(Storage="_range", Name="Range", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Range
		{
			get
			{
				return this._range;
			}
			set
			{
				if ((_range != value))
				{
					this.OnRangeChanging(value);
					this.SendPropertyChanging();
					this._range = value;
					this.SendPropertyChanged("Range");
					this.OnRangeChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_shotgunBarrelID", Name="ShotgunBarrelID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ShotgunBarrelID
		{
			get
			{
				return this._shotgunBarrelID;
			}
			set
			{
				if ((_shotgunBarrelID != value))
				{
					this.OnShotgunBarrelIDChanging(value);
					this.SendPropertyChanging();
					this._shotgunBarrelID = value;
					this.SendPropertyChanged("ShotgunBarrelID");
					this.OnShotgunBarrelIDChanged();
				}
			}
		}
		
		[Column(Storage="_shotgunBarrelName", Name="ShotgunBarrelName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ShotgunBarrelName
		{
			get
			{
				return this._shotgunBarrelName;
			}
			set
			{
				if (((_shotgunBarrelName == value) 
							== false))
				{
					this.OnShotgunBarrelNameChanging(value);
					this.SendPropertyChanging();
					this._shotgunBarrelName = value;
					this.SendPropertyChanged("ShotgunBarrelName");
					this.OnShotgunBarrelNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.ShotgunBodys")]
	public partial class ShotgunBodys : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _calibre;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private System.Nullable<float> _maxDamage;
		
		private string _rarity;
		
		private int _shotgunBodyID;
		
		private string _shotgunBodyName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCalibreChanged();
		
		partial void OnCalibreChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnMaxDamageChanged();
		
		partial void OnMaxDamageChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnShotgunBodyIDChanged();
		
		partial void OnShotgunBodyIDChanging(int value);
		
		partial void OnShotgunBodyNameChanged();
		
		partial void OnShotgunBodyNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public ShotgunBodys()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_calibre", Name="Calibre", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Calibre
		{
			get
			{
				return this._calibre;
			}
			set
			{
				if (((_calibre == value) 
							== false))
				{
					this.OnCalibreChanging(value);
					this.SendPropertyChanging();
					this._calibre = value;
					this.SendPropertyChanged("Calibre");
					this.OnCalibreChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_maxDamage", Name="MaxDamage", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> MaxDamage
		{
			get
			{
				return this._maxDamage;
			}
			set
			{
				if ((_maxDamage != value))
				{
					this.OnMaxDamageChanging(value);
					this.SendPropertyChanging();
					this._maxDamage = value;
					this.SendPropertyChanged("MaxDamage");
					this.OnMaxDamageChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_shotgunBodyID", Name="ShotgunBodyID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ShotgunBodyID
		{
			get
			{
				return this._shotgunBodyID;
			}
			set
			{
				if ((_shotgunBodyID != value))
				{
					this.OnShotgunBodyIDChanging(value);
					this.SendPropertyChanging();
					this._shotgunBodyID = value;
					this.SendPropertyChanged("ShotgunBodyID");
					this.OnShotgunBodyIDChanged();
				}
			}
		}
		
		[Column(Storage="_shotgunBodyName", Name="ShotgunBodyName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ShotgunBodyName
		{
			get
			{
				return this._shotgunBodyName;
			}
			set
			{
				if (((_shotgunBodyName == value) 
							== false))
				{
					this.OnShotgunBodyNameChanging(value);
					this.SendPropertyChanging();
					this._shotgunBodyName = value;
					this.SendPropertyChanged("ShotgunBodyName");
					this.OnShotgunBodyNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.ShotgunMagazines")]
	public partial class ShotgunMagazines : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _capacity;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private string _rarity;
		
		private System.Nullable<float> _rateOfFire;
		
		private System.Nullable<float> _reloadSpeed;
		
		private int _shotgunMagazineID;
		
		private string _shotgunMagazineName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCapacityChanged();
		
		partial void OnCapacityChanging(System.Nullable<int> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnShotgunMagazineIDChanged();
		
		partial void OnShotgunMagazineIDChanging(int value);
		
		partial void OnShotgunMagazineNameChanged();
		
		partial void OnShotgunMagazineNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public ShotgunMagazines()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_capacity", Name="Capacity", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Capacity
		{
			get
			{
				return this._capacity;
			}
			set
			{
				if ((_capacity != value))
				{
					this.OnCapacityChanging(value);
					this.SendPropertyChanging();
					this._capacity = value;
					this.SendPropertyChanged("Capacity");
					this.OnCapacityChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_shotgunMagazineID", Name="ShotgunMagazineID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ShotgunMagazineID
		{
			get
			{
				return this._shotgunMagazineID;
			}
			set
			{
				if ((_shotgunMagazineID != value))
				{
					this.OnShotgunMagazineIDChanging(value);
					this.SendPropertyChanging();
					this._shotgunMagazineID = value;
					this.SendPropertyChanged("ShotgunMagazineID");
					this.OnShotgunMagazineIDChanged();
				}
			}
		}
		
		[Column(Storage="_shotgunMagazineName", Name="ShotgunMagazineName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ShotgunMagazineName
		{
			get
			{
				return this._shotgunMagazineName;
			}
			set
			{
				if (((_shotgunMagazineName == value) 
							== false))
				{
					this.OnShotgunMagazineNameChanging(value);
					this.SendPropertyChanging();
					this._shotgunMagazineName = value;
					this.SendPropertyChanged("ShotgunMagazineName");
					this.OnShotgunMagazineNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.ShotgunMechanisms")]
	public partial class ShotgunMechanisms : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _burstType;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private string _rarity;
		
		private System.Nullable<float> _rateOfFire;
		
		private int _shotgunMechanismID;
		
		private string _shotgunMechanismName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBurstTypeChanged();
		
		partial void OnBurstTypeChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		
		partial void OnShotgunMechanismIDChanged();
		
		partial void OnShotgunMechanismIDChanging(int value);
		
		partial void OnShotgunMechanismNameChanged();
		
		partial void OnShotgunMechanismNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public ShotgunMechanisms()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_burstType", Name="BurstType", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BurstType
		{
			get
			{
				return this._burstType;
			}
			set
			{
				if (((_burstType == value) 
							== false))
				{
					this.OnBurstTypeChanging(value);
					this.SendPropertyChanging();
					this._burstType = value;
					this.SendPropertyChanged("BurstType");
					this.OnBurstTypeChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		[Column(Storage="_shotgunMechanismID", Name="ShotgunMechanismID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ShotgunMechanismID
		{
			get
			{
				return this._shotgunMechanismID;
			}
			set
			{
				if ((_shotgunMechanismID != value))
				{
					this.OnShotgunMechanismIDChanging(value);
					this.SendPropertyChanging();
					this._shotgunMechanismID = value;
					this.SendPropertyChanged("ShotgunMechanismID");
					this.OnShotgunMechanismIDChanged();
				}
			}
		}
		
		[Column(Storage="_shotgunMechanismName", Name="ShotgunMechanismName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ShotgunMechanismName
		{
			get
			{
				return this._shotgunMechanismName;
			}
			set
			{
				if (((_shotgunMechanismName == value) 
							== false))
				{
					this.OnShotgunMechanismNameChanging(value);
					this.SendPropertyChanging();
					this._shotgunMechanismName = value;
					this.SendPropertyChanged("ShotgunMechanismName");
					this.OnShotgunMechanismNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.Shotguns")]
	public partial class Shotguns : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private System.Nullable<int> _barrelID;
		
		private System.Nullable<int> _bodyID;
		
		private string _burstType;
		
		private string _calibre;
		
		private string _description;
		
		private System.Nullable<int> _magazineCapacity;
		
		private System.Nullable<int> _magazineID;
		
		private System.Nullable<int> _maxDamage;
		
		private System.Nullable<int> _mechanismID;
		
		private System.Nullable<int> _minDamage;
		
		private System.Nullable<int> _minLevel;
		
		private System.Nullable<float> _range;
		
		private string _rarity;
		
		private System.Nullable<float> _rateOfFire;
		
		private System.Nullable<float> _reloadSpeed;
		
		private int _shotgunID;
		
		private string _shotgunName;
		
		private System.Nullable<int> _sightID;
		
		private System.Nullable<int> _stockID;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnBarrelIDChanged();
		
		partial void OnBarrelIDChanging(System.Nullable<int> value);
		
		partial void OnBodyIDChanged();
		
		partial void OnBodyIDChanging(System.Nullable<int> value);
		
		partial void OnBurstTypeChanged();
		
		partial void OnBurstTypeChanging(string value);
		
		partial void OnCalibreChanged();
		
		partial void OnCalibreChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnMagazineCapacityChanged();
		
		partial void OnMagazineCapacityChanging(System.Nullable<int> value);
		
		partial void OnMagazineIDChanged();
		
		partial void OnMagazineIDChanging(System.Nullable<int> value);
		
		partial void OnMaxDamageChanged();
		
		partial void OnMaxDamageChanging(System.Nullable<int> value);
		
		partial void OnMechanismIDChanged();
		
		partial void OnMechanismIDChanging(System.Nullable<int> value);
		
		partial void OnMinDamageChanged();
		
		partial void OnMinDamageChanging(System.Nullable<int> value);
		
		partial void OnMinLevelChanged();
		
		partial void OnMinLevelChanging(System.Nullable<int> value);
		
		partial void OnRangeChanged();
		
		partial void OnRangeChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnShotgunIDChanged();
		
		partial void OnShotgunIDChanging(int value);
		
		partial void OnShotgunNameChanged();
		
		partial void OnShotgunNameChanging(string value);
		
		partial void OnSightIDChanged();
		
		partial void OnSightIDChanging(System.Nullable<int> value);
		
		partial void OnStockIDChanged();
		
		partial void OnStockIDChanging(System.Nullable<int> value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public Shotguns()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_barrelID", Name="BarrelID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> BarrelID
		{
			get
			{
				return this._barrelID;
			}
			set
			{
				if ((_barrelID != value))
				{
					this.OnBarrelIDChanging(value);
					this.SendPropertyChanging();
					this._barrelID = value;
					this.SendPropertyChanged("BarrelID");
					this.OnBarrelIDChanged();
				}
			}
		}
		
		[Column(Storage="_bodyID", Name="BodyID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> BodyID
		{
			get
			{
				return this._bodyID;
			}
			set
			{
				if ((_bodyID != value))
				{
					this.OnBodyIDChanging(value);
					this.SendPropertyChanging();
					this._bodyID = value;
					this.SendPropertyChanged("BodyID");
					this.OnBodyIDChanged();
				}
			}
		}
		
		[Column(Storage="_burstType", Name="BurstType", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BurstType
		{
			get
			{
				return this._burstType;
			}
			set
			{
				if (((_burstType == value) 
							== false))
				{
					this.OnBurstTypeChanging(value);
					this.SendPropertyChanging();
					this._burstType = value;
					this.SendPropertyChanged("BurstType");
					this.OnBurstTypeChanged();
				}
			}
		}
		
		[Column(Storage="_calibre", Name="Calibre", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Calibre
		{
			get
			{
				return this._calibre;
			}
			set
			{
				if (((_calibre == value) 
							== false))
				{
					this.OnCalibreChanging(value);
					this.SendPropertyChanging();
					this._calibre = value;
					this.SendPropertyChanged("Calibre");
					this.OnCalibreChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_magazineCapacity", Name="MagazineCapacity", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MagazineCapacity
		{
			get
			{
				return this._magazineCapacity;
			}
			set
			{
				if ((_magazineCapacity != value))
				{
					this.OnMagazineCapacityChanging(value);
					this.SendPropertyChanging();
					this._magazineCapacity = value;
					this.SendPropertyChanged("MagazineCapacity");
					this.OnMagazineCapacityChanged();
				}
			}
		}
		
		[Column(Storage="_magazineID", Name="MagazineID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MagazineID
		{
			get
			{
				return this._magazineID;
			}
			set
			{
				if ((_magazineID != value))
				{
					this.OnMagazineIDChanging(value);
					this.SendPropertyChanging();
					this._magazineID = value;
					this.SendPropertyChanged("MagazineID");
					this.OnMagazineIDChanged();
				}
			}
		}
		
		[Column(Storage="_maxDamage", Name="MaxDamage", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MaxDamage
		{
			get
			{
				return this._maxDamage;
			}
			set
			{
				if ((_maxDamage != value))
				{
					this.OnMaxDamageChanging(value);
					this.SendPropertyChanging();
					this._maxDamage = value;
					this.SendPropertyChanged("MaxDamage");
					this.OnMaxDamageChanged();
				}
			}
		}
		
		[Column(Storage="_mechanismID", Name="MechanismID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MechanismID
		{
			get
			{
				return this._mechanismID;
			}
			set
			{
				if ((_mechanismID != value))
				{
					this.OnMechanismIDChanging(value);
					this.SendPropertyChanging();
					this._mechanismID = value;
					this.SendPropertyChanged("MechanismID");
					this.OnMechanismIDChanged();
				}
			}
		}
		
		[Column(Storage="_minDamage", Name="MinDamage", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MinDamage
		{
			get
			{
				return this._minDamage;
			}
			set
			{
				if ((_minDamage != value))
				{
					this.OnMinDamageChanging(value);
					this.SendPropertyChanging();
					this._minDamage = value;
					this.SendPropertyChanged("MinDamage");
					this.OnMinDamageChanged();
				}
			}
		}
		
		[Column(Storage="_minLevel", Name="MinLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MinLevel
		{
			get
			{
				return this._minLevel;
			}
			set
			{
				if ((_minLevel != value))
				{
					this.OnMinLevelChanging(value);
					this.SendPropertyChanging();
					this._minLevel = value;
					this.SendPropertyChanged("MinLevel");
					this.OnMinLevelChanged();
				}
			}
		}
		
		[Column(Storage="_range", Name="Range", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Range
		{
			get
			{
				return this._range;
			}
			set
			{
				if ((_range != value))
				{
					this.OnRangeChanging(value);
					this.SendPropertyChanging();
					this._range = value;
					this.SendPropertyChanged("Range");
					this.OnRangeChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_shotgunID", Name="ShotgunID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ShotgunID
		{
			get
			{
				return this._shotgunID;
			}
			set
			{
				if ((_shotgunID != value))
				{
					this.OnShotgunIDChanging(value);
					this.SendPropertyChanging();
					this._shotgunID = value;
					this.SendPropertyChanged("ShotgunID");
					this.OnShotgunIDChanged();
				}
			}
		}
		
		[Column(Storage="_shotgunName", Name="ShotgunName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ShotgunName
		{
			get
			{
				return this._shotgunName;
			}
			set
			{
				if (((_shotgunName == value) 
							== false))
				{
					this.OnShotgunNameChanging(value);
					this.SendPropertyChanging();
					this._shotgunName = value;
					this.SendPropertyChanged("ShotgunName");
					this.OnShotgunNameChanged();
				}
			}
		}
		
		[Column(Storage="_sightID", Name="SightID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SightID
		{
			get
			{
				return this._sightID;
			}
			set
			{
				if ((_sightID != value))
				{
					this.OnSightIDChanging(value);
					this.SendPropertyChanging();
					this._sightID = value;
					this.SendPropertyChanged("SightID");
					this.OnSightIDChanged();
				}
			}
		}
		
		[Column(Storage="_stockID", Name="StockID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> StockID
		{
			get
			{
				return this._stockID;
			}
			set
			{
				if ((_stockID != value))
				{
					this.OnStockIDChanging(value);
					this.SendPropertyChanging();
					this._stockID = value;
					this.SendPropertyChanged("StockID");
					this.OnStockIDChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.ShotgunSights")]
	public partial class ShotgunSights : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private System.Nullable<float> _range;
		
		private string _rarity;
		
		private int _shotgunSightID;
		
		private string _shotgunSightName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRangeChanged();
		
		partial void OnRangeChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnShotgunSightIDChanged();
		
		partial void OnShotgunSightIDChanging(int value);
		
		partial void OnShotgunSightNameChanged();
		
		partial void OnShotgunSightNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public ShotgunSights()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_range", Name="Range", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Range
		{
			get
			{
				return this._range;
			}
			set
			{
				if ((_range != value))
				{
					this.OnRangeChanging(value);
					this.SendPropertyChanging();
					this._range = value;
					this.SendPropertyChanged("Range");
					this.OnRangeChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_shotgunSightID", Name="ShotgunSightID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ShotgunSightID
		{
			get
			{
				return this._shotgunSightID;
			}
			set
			{
				if ((_shotgunSightID != value))
				{
					this.OnShotgunSightIDChanging(value);
					this.SendPropertyChanging();
					this._shotgunSightID = value;
					this.SendPropertyChanged("ShotgunSightID");
					this.OnShotgunSightIDChanged();
				}
			}
		}
		
		[Column(Storage="_shotgunSightName", Name="ShotgunSightName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ShotgunSightName
		{
			get
			{
				return this._shotgunSightName;
			}
			set
			{
				if (((_shotgunSightName == value) 
							== false))
				{
					this.OnShotgunSightNameChanging(value);
					this.SendPropertyChanging();
					this._shotgunSightName = value;
					this.SendPropertyChanged("ShotgunSightName");
					this.OnShotgunSightNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.ShotgunStocks")]
	public partial class ShotgunStocks : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private string _rarity;
		
		private System.Nullable<float> _reloadSpeed;
		
		private int _shotgunStockID;
		
		private string _shotgunStockName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnShotgunStockIDChanged();
		
		partial void OnShotgunStockIDChanging(int value);
		
		partial void OnShotgunStockNameChanged();
		
		partial void OnShotgunStockNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public ShotgunStocks()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_shotgunStockID", Name="ShotgunStockID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ShotgunStockID
		{
			get
			{
				return this._shotgunStockID;
			}
			set
			{
				if ((_shotgunStockID != value))
				{
					this.OnShotgunStockIDChanging(value);
					this.SendPropertyChanging();
					this._shotgunStockID = value;
					this.SendPropertyChanged("ShotgunStockID");
					this.OnShotgunStockIDChanged();
				}
			}
		}
		
		[Column(Storage="_shotgunStockName", Name="ShotgunStockName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ShotgunStockName
		{
			get
			{
				return this._shotgunStockName;
			}
			set
			{
				if (((_shotgunStockName == value) 
							== false))
				{
					this.OnShotgunStockNameChanging(value);
					this.SendPropertyChanging();
					this._shotgunStockName = value;
					this.SendPropertyChanged("ShotgunStockName");
					this.OnShotgunStockNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SkillAttributeRequirements")]
	public partial class SkillAttributeRequirements : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _requiredAttributeID;
		
		private System.Nullable<int> _requiredValue;
		
		private string _skillName;
		
		private int _skillRequirementID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnRequiredAttributeIDChanged();
		
		partial void OnRequiredAttributeIDChanging(System.Nullable<int> value);
		
		partial void OnRequiredValueChanged();
		
		partial void OnRequiredValueChanging(System.Nullable<int> value);
		
		partial void OnSkillNameChanged();
		
		partial void OnSkillNameChanging(string value);
		
		partial void OnSkillRequirementIDChanged();
		
		partial void OnSkillRequirementIDChanging(int value);
		#endregion
		
		
		public SkillAttributeRequirements()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_requiredAttributeID", Name="RequiredAttributeID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> RequiredAttributeID
		{
			get
			{
				return this._requiredAttributeID;
			}
			set
			{
				if ((_requiredAttributeID != value))
				{
					this.OnRequiredAttributeIDChanging(value);
					this.SendPropertyChanging();
					this._requiredAttributeID = value;
					this.SendPropertyChanged("RequiredAttributeID");
					this.OnRequiredAttributeIDChanged();
				}
			}
		}
		
		[Column(Storage="_requiredValue", Name="RequiredValue", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> RequiredValue
		{
			get
			{
				return this._requiredValue;
			}
			set
			{
				if ((_requiredValue != value))
				{
					this.OnRequiredValueChanging(value);
					this.SendPropertyChanging();
					this._requiredValue = value;
					this.SendPropertyChanged("RequiredValue");
					this.OnRequiredValueChanged();
				}
			}
		}
		
		[Column(Storage="_skillName", Name="SkillName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SkillName
		{
			get
			{
				return this._skillName;
			}
			set
			{
				if (((_skillName == value) 
							== false))
				{
					this.OnSkillNameChanging(value);
					this.SendPropertyChanging();
					this._skillName = value;
					this.SendPropertyChanged("SkillName");
					this.OnSkillNameChanged();
				}
			}
		}
		
		[Column(Storage="_skillRequirementID", Name="SkillRequirementID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SkillRequirementID
		{
			get
			{
				return this._skillRequirementID;
			}
			set
			{
				if ((_skillRequirementID != value))
				{
					this.OnSkillRequirementIDChanging(value);
					this.SendPropertyChanging();
					this._skillRequirementID = value;
					this.SendPropertyChanged("SkillRequirementID");
					this.OnSkillRequirementIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.Skills")]
	public partial class Skills : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _skillDescription;
		
		private int _skillID;
		
		private string _skillName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnSkillDescriptionChanged();
		
		partial void OnSkillDescriptionChanging(string value);
		
		partial void OnSkillIDChanged();
		
		partial void OnSkillIDChanging(int value);
		
		partial void OnSkillNameChanged();
		
		partial void OnSkillNameChanging(string value);
		#endregion
		
		
		public Skills()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_skillDescription", Name="SkillDescription", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SkillDescription
		{
			get
			{
				return this._skillDescription;
			}
			set
			{
				if (((_skillDescription == value) 
							== false))
				{
					this.OnSkillDescriptionChanging(value);
					this.SendPropertyChanging();
					this._skillDescription = value;
					this.SendPropertyChanged("SkillDescription");
					this.OnSkillDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_skillID", Name="SkillID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SkillID
		{
			get
			{
				return this._skillID;
			}
			set
			{
				if ((_skillID != value))
				{
					this.OnSkillIDChanging(value);
					this.SendPropertyChanging();
					this._skillID = value;
					this.SendPropertyChanged("SkillID");
					this.OnSkillIDChanged();
				}
			}
		}
		
		[Column(Storage="_skillName", Name="SkillName", DbType="TEXT", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string SkillName
		{
			get
			{
				return this._skillName;
			}
			set
			{
				if (((_skillName == value) 
							== false))
				{
					this.OnSkillNameChanging(value);
					this.SendPropertyChanging();
					this._skillName = value;
					this.SendPropertyChanged("SkillName");
					this.OnSkillNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SkillSpecializations")]
	public partial class SkillSpecializations : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _skillID;
		
		private string _skillName;
		
		private int _skillSpecializationID;
		
		private string _specializationName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnSkillIDChanged();
		
		partial void OnSkillIDChanging(System.Nullable<int> value);
		
		partial void OnSkillNameChanged();
		
		partial void OnSkillNameChanging(string value);
		
		partial void OnSkillSpecializationIDChanged();
		
		partial void OnSkillSpecializationIDChanging(int value);
		
		partial void OnSpecializationNameChanged();
		
		partial void OnSpecializationNameChanging(string value);
		#endregion
		
		
		public SkillSpecializations()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_skillID", Name="SkillID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SkillID
		{
			get
			{
				return this._skillID;
			}
			set
			{
				if ((_skillID != value))
				{
					this.OnSkillIDChanging(value);
					this.SendPropertyChanging();
					this._skillID = value;
					this.SendPropertyChanged("SkillID");
					this.OnSkillIDChanged();
				}
			}
		}
		
		[Column(Storage="_skillName", Name="SkillName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SkillName
		{
			get
			{
				return this._skillName;
			}
			set
			{
				if (((_skillName == value) 
							== false))
				{
					this.OnSkillNameChanging(value);
					this.SendPropertyChanging();
					this._skillName = value;
					this.SendPropertyChanged("SkillName");
					this.OnSkillNameChanged();
				}
			}
		}
		
		[Column(Storage="_skillSpecializationID", Name="SkillSpecializationID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SkillSpecializationID
		{
			get
			{
				return this._skillSpecializationID;
			}
			set
			{
				if ((_skillSpecializationID != value))
				{
					this.OnSkillSpecializationIDChanging(value);
					this.SendPropertyChanging();
					this._skillSpecializationID = value;
					this.SendPropertyChanged("SkillSpecializationID");
					this.OnSkillSpecializationIDChanged();
				}
			}
		}
		
		[Column(Storage="_specializationName", Name="SpecializationName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SpecializationName
		{
			get
			{
				return this._specializationName;
			}
			set
			{
				if (((_specializationName == value) 
							== false))
				{
					this.OnSpecializationNameChanging(value);
					this.SendPropertyChanging();
					this._specializationName = value;
					this.SendPropertyChanged("SpecializationName");
					this.OnSpecializationNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SkillSubSkills")]
	public partial class SkillSubSkills : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _skillID;
		
		private string _skillName;
		
		private int _skillSubSkillID;
		
		private string _subSkill;
		
		private string _subSkillDescription;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnSkillIDChanged();
		
		partial void OnSkillIDChanging(System.Nullable<int> value);
		
		partial void OnSkillNameChanged();
		
		partial void OnSkillNameChanging(string value);
		
		partial void OnSkillSubSkillIDChanged();
		
		partial void OnSkillSubSkillIDChanging(int value);
		
		partial void OnSubSkillChanged();
		
		partial void OnSubSkillChanging(string value);
		
		partial void OnSubSkillDescriptionChanged();
		
		partial void OnSubSkillDescriptionChanging(string value);
		#endregion
		
		
		public SkillSubSkills()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_skillID", Name="SkillID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SkillID
		{
			get
			{
				return this._skillID;
			}
			set
			{
				if ((_skillID != value))
				{
					this.OnSkillIDChanging(value);
					this.SendPropertyChanging();
					this._skillID = value;
					this.SendPropertyChanged("SkillID");
					this.OnSkillIDChanged();
				}
			}
		}
		
		[Column(Storage="_skillName", Name="SkillName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SkillName
		{
			get
			{
				return this._skillName;
			}
			set
			{
				if (((_skillName == value) 
							== false))
				{
					this.OnSkillNameChanging(value);
					this.SendPropertyChanging();
					this._skillName = value;
					this.SendPropertyChanged("SkillName");
					this.OnSkillNameChanged();
				}
			}
		}
		
		[Column(Storage="_skillSubSkillID", Name="SkillSubSkillID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SkillSubSkillID
		{
			get
			{
				return this._skillSubSkillID;
			}
			set
			{
				if ((_skillSubSkillID != value))
				{
					this.OnSkillSubSkillIDChanging(value);
					this.SendPropertyChanging();
					this._skillSubSkillID = value;
					this.SendPropertyChanged("SkillSubSkillID");
					this.OnSkillSubSkillIDChanged();
				}
			}
		}
		
		[Column(Storage="_subSkill", Name="SubSkill", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SubSkill
		{
			get
			{
				return this._subSkill;
			}
			set
			{
				if (((_subSkill == value) 
							== false))
				{
					this.OnSubSkillChanging(value);
					this.SendPropertyChanging();
					this._subSkill = value;
					this.SendPropertyChanged("SubSkill");
					this.OnSubSkillChanged();
				}
			}
		}
		
		[Column(Storage="_subSkillDescription", Name="SubSkillDescription", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SubSkillDescription
		{
			get
			{
				return this._subSkillDescription;
			}
			set
			{
				if (((_subSkillDescription == value) 
							== false))
				{
					this.OnSubSkillDescriptionChanging(value);
					this.SendPropertyChanging();
					this._subSkillDescription = value;
					this.SendPropertyChanged("SubSkillDescription");
					this.OnSubSkillDescriptionChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SniperRifleBarrels")]
	public partial class SniperRifleBarrels : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private System.Nullable<float> _minDamage;
		
		private System.Nullable<float> _range;
		
		private string _rarity;
		
		private int _sniperRifleBarrelID;
		
		private string _sniperRifleBarrelName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnMinDamageChanged();
		
		partial void OnMinDamageChanging(System.Nullable<float> value);
		
		partial void OnRangeChanged();
		
		partial void OnRangeChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnSniperRifleBarrelIDChanged();
		
		partial void OnSniperRifleBarrelIDChanging(int value);
		
		partial void OnSniperRifleBarrelNameChanged();
		
		partial void OnSniperRifleBarrelNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public SniperRifleBarrels()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_minDamage", Name="MinDamage", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> MinDamage
		{
			get
			{
				return this._minDamage;
			}
			set
			{
				if ((_minDamage != value))
				{
					this.OnMinDamageChanging(value);
					this.SendPropertyChanging();
					this._minDamage = value;
					this.SendPropertyChanged("MinDamage");
					this.OnMinDamageChanged();
				}
			}
		}
		
		[Column(Storage="_range", Name="Range", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Range
		{
			get
			{
				return this._range;
			}
			set
			{
				if ((_range != value))
				{
					this.OnRangeChanging(value);
					this.SendPropertyChanging();
					this._range = value;
					this.SendPropertyChanged("Range");
					this.OnRangeChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_sniperRifleBarrelID", Name="SniperRifleBarrelID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SniperRifleBarrelID
		{
			get
			{
				return this._sniperRifleBarrelID;
			}
			set
			{
				if ((_sniperRifleBarrelID != value))
				{
					this.OnSniperRifleBarrelIDChanging(value);
					this.SendPropertyChanging();
					this._sniperRifleBarrelID = value;
					this.SendPropertyChanged("SniperRifleBarrelID");
					this.OnSniperRifleBarrelIDChanged();
				}
			}
		}
		
		[Column(Storage="_sniperRifleBarrelName", Name="SniperRifleBarrelName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SniperRifleBarrelName
		{
			get
			{
				return this._sniperRifleBarrelName;
			}
			set
			{
				if (((_sniperRifleBarrelName == value) 
							== false))
				{
					this.OnSniperRifleBarrelNameChanging(value);
					this.SendPropertyChanging();
					this._sniperRifleBarrelName = value;
					this.SendPropertyChanged("SniperRifleBarrelName");
					this.OnSniperRifleBarrelNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SniperRifleBodies")]
	public partial class SniperRifleBodies : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _calibre;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private System.Nullable<float> _maxDamage;
		
		private string _rarity;
		
		private int _sniperRifleBodyID;
		
		private string _sniperRifleBodyName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCalibreChanged();
		
		partial void OnCalibreChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnMaxDamageChanged();
		
		partial void OnMaxDamageChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnSniperRifleBodyIDChanged();
		
		partial void OnSniperRifleBodyIDChanging(int value);
		
		partial void OnSniperRifleBodyNameChanged();
		
		partial void OnSniperRifleBodyNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public SniperRifleBodies()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_calibre", Name="Calibre", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Calibre
		{
			get
			{
				return this._calibre;
			}
			set
			{
				if (((_calibre == value) 
							== false))
				{
					this.OnCalibreChanging(value);
					this.SendPropertyChanging();
					this._calibre = value;
					this.SendPropertyChanged("Calibre");
					this.OnCalibreChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_maxDamage", Name="MaxDamage", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> MaxDamage
		{
			get
			{
				return this._maxDamage;
			}
			set
			{
				if ((_maxDamage != value))
				{
					this.OnMaxDamageChanging(value);
					this.SendPropertyChanging();
					this._maxDamage = value;
					this.SendPropertyChanged("MaxDamage");
					this.OnMaxDamageChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_sniperRifleBodyID", Name="SniperRifleBodyID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SniperRifleBodyID
		{
			get
			{
				return this._sniperRifleBodyID;
			}
			set
			{
				if ((_sniperRifleBodyID != value))
				{
					this.OnSniperRifleBodyIDChanging(value);
					this.SendPropertyChanging();
					this._sniperRifleBodyID = value;
					this.SendPropertyChanged("SniperRifleBodyID");
					this.OnSniperRifleBodyIDChanged();
				}
			}
		}
		
		[Column(Storage="_sniperRifleBodyName", Name="SniperRifleBodyName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SniperRifleBodyName
		{
			get
			{
				return this._sniperRifleBodyName;
			}
			set
			{
				if (((_sniperRifleBodyName == value) 
							== false))
				{
					this.OnSniperRifleBodyNameChanging(value);
					this.SendPropertyChanging();
					this._sniperRifleBodyName = value;
					this.SendPropertyChanged("SniperRifleBodyName");
					this.OnSniperRifleBodyNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SniperRifleMagazines")]
	public partial class SniperRifleMagazines : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _capacity;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private string _rarity;
		
		private System.Nullable<float> _rateOfFire;
		
		private System.Nullable<float> _reloadSpeed;
		
		private int _sniperRifleMagazineID;
		
		private string _sniperRifleMagazineName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCapacityChanged();
		
		partial void OnCapacityChanging(System.Nullable<int> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnSniperRifleMagazineIDChanged();
		
		partial void OnSniperRifleMagazineIDChanging(int value);
		
		partial void OnSniperRifleMagazineNameChanged();
		
		partial void OnSniperRifleMagazineNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public SniperRifleMagazines()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_capacity", Name="Capacity", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Capacity
		{
			get
			{
				return this._capacity;
			}
			set
			{
				if ((_capacity != value))
				{
					this.OnCapacityChanging(value);
					this.SendPropertyChanging();
					this._capacity = value;
					this.SendPropertyChanged("Capacity");
					this.OnCapacityChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_sniperRifleMagazineID", Name="SniperRifleMagazineID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SniperRifleMagazineID
		{
			get
			{
				return this._sniperRifleMagazineID;
			}
			set
			{
				if ((_sniperRifleMagazineID != value))
				{
					this.OnSniperRifleMagazineIDChanging(value);
					this.SendPropertyChanging();
					this._sniperRifleMagazineID = value;
					this.SendPropertyChanged("SniperRifleMagazineID");
					this.OnSniperRifleMagazineIDChanged();
				}
			}
		}
		
		[Column(Storage="_sniperRifleMagazineName", Name="SniperRifleMagazineName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SniperRifleMagazineName
		{
			get
			{
				return this._sniperRifleMagazineName;
			}
			set
			{
				if (((_sniperRifleMagazineName == value) 
							== false))
				{
					this.OnSniperRifleMagazineNameChanging(value);
					this.SendPropertyChanging();
					this._sniperRifleMagazineName = value;
					this.SendPropertyChanged("SniperRifleMagazineName");
					this.OnSniperRifleMagazineNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SniperRifleMechanisms")]
	public partial class SniperRifleMechanisms : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _burstType;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private string _rarity;
		
		private System.Nullable<float> _rateOfFire;
		
		private int _sniperRifleMechanismID;
		
		private string _sniperRifleMechanismName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBurstTypeChanged();
		
		partial void OnBurstTypeChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		
		partial void OnSniperRifleMechanismIDChanged();
		
		partial void OnSniperRifleMechanismIDChanging(int value);
		
		partial void OnSniperRifleMechanismNameChanged();
		
		partial void OnSniperRifleMechanismNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public SniperRifleMechanisms()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_burstType", Name="BurstType", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BurstType
		{
			get
			{
				return this._burstType;
			}
			set
			{
				if (((_burstType == value) 
							== false))
				{
					this.OnBurstTypeChanging(value);
					this.SendPropertyChanging();
					this._burstType = value;
					this.SendPropertyChanged("BurstType");
					this.OnBurstTypeChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		[Column(Storage="_sniperRifleMechanismID", Name="SniperRifleMechanismID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SniperRifleMechanismID
		{
			get
			{
				return this._sniperRifleMechanismID;
			}
			set
			{
				if ((_sniperRifleMechanismID != value))
				{
					this.OnSniperRifleMechanismIDChanging(value);
					this.SendPropertyChanging();
					this._sniperRifleMechanismID = value;
					this.SendPropertyChanged("SniperRifleMechanismID");
					this.OnSniperRifleMechanismIDChanged();
				}
			}
		}
		
		[Column(Storage="_sniperRifleMechanismName", Name="SniperRifleMechanismName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SniperRifleMechanismName
		{
			get
			{
				return this._sniperRifleMechanismName;
			}
			set
			{
				if (((_sniperRifleMechanismName == value) 
							== false))
				{
					this.OnSniperRifleMechanismNameChanging(value);
					this.SendPropertyChanging();
					this._sniperRifleMechanismName = value;
					this.SendPropertyChanged("SniperRifleMechanismName");
					this.OnSniperRifleMechanismNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SniperRifles")]
	public partial class SniperRifles : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _barrelID;
		
		private System.Nullable<int> _bodyID;
		
		private string _burstType;
		
		private string _calibre;
		
		private string _description;
		
		private System.Nullable<int> _magazineCapacity;
		
		private System.Nullable<int> _magazineID;
		
		private System.Nullable<int> _maxDamage;
		
		private System.Nullable<int> _mechanismID;
		
		private System.Nullable<int> _minDamage;
		
		private System.Nullable<int> _minLevel;
		
		private System.Nullable<float> _range;
		
		private string _rarity;
		
		private System.Nullable<float> _rateOfFire;
		
		private System.Nullable<float> _reloadSpeed;
		
		private System.Nullable<int> _sightID;
		
		private int _sniperRifleID;
		
		private string _sniperRifleName;
		
		private System.Nullable<int> _stockID;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBarrelIDChanged();
		
		partial void OnBarrelIDChanging(System.Nullable<int> value);
		
		partial void OnBodyIDChanged();
		
		partial void OnBodyIDChanging(System.Nullable<int> value);
		
		partial void OnBurstTypeChanged();
		
		partial void OnBurstTypeChanging(string value);
		
		partial void OnCalibreChanged();
		
		partial void OnCalibreChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnMagazineCapacityChanged();
		
		partial void OnMagazineCapacityChanging(System.Nullable<int> value);
		
		partial void OnMagazineIDChanged();
		
		partial void OnMagazineIDChanging(System.Nullable<int> value);
		
		partial void OnMaxDamageChanged();
		
		partial void OnMaxDamageChanging(System.Nullable<int> value);
		
		partial void OnMechanismIDChanged();
		
		partial void OnMechanismIDChanging(System.Nullable<int> value);
		
		partial void OnMinDamageChanged();
		
		partial void OnMinDamageChanging(System.Nullable<int> value);
		
		partial void OnMinLevelChanged();
		
		partial void OnMinLevelChanging(System.Nullable<int> value);
		
		partial void OnRangeChanged();
		
		partial void OnRangeChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnSightIDChanged();
		
		partial void OnSightIDChanging(System.Nullable<int> value);
		
		partial void OnSniperRifleIDChanged();
		
		partial void OnSniperRifleIDChanging(int value);
		
		partial void OnSniperRifleNameChanged();
		
		partial void OnSniperRifleNameChanging(string value);
		
		partial void OnStockIDChanged();
		
		partial void OnStockIDChanging(System.Nullable<int> value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public SniperRifles()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_barrelID", Name="BarrelID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> BarrelID
		{
			get
			{
				return this._barrelID;
			}
			set
			{
				if ((_barrelID != value))
				{
					this.OnBarrelIDChanging(value);
					this.SendPropertyChanging();
					this._barrelID = value;
					this.SendPropertyChanged("BarrelID");
					this.OnBarrelIDChanged();
				}
			}
		}
		
		[Column(Storage="_bodyID", Name="BodyID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> BodyID
		{
			get
			{
				return this._bodyID;
			}
			set
			{
				if ((_bodyID != value))
				{
					this.OnBodyIDChanging(value);
					this.SendPropertyChanging();
					this._bodyID = value;
					this.SendPropertyChanged("BodyID");
					this.OnBodyIDChanged();
				}
			}
		}
		
		[Column(Storage="_burstType", Name="BurstType", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BurstType
		{
			get
			{
				return this._burstType;
			}
			set
			{
				if (((_burstType == value) 
							== false))
				{
					this.OnBurstTypeChanging(value);
					this.SendPropertyChanging();
					this._burstType = value;
					this.SendPropertyChanged("BurstType");
					this.OnBurstTypeChanged();
				}
			}
		}
		
		[Column(Storage="_calibre", Name="Calibre", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Calibre
		{
			get
			{
				return this._calibre;
			}
			set
			{
				if (((_calibre == value) 
							== false))
				{
					this.OnCalibreChanging(value);
					this.SendPropertyChanging();
					this._calibre = value;
					this.SendPropertyChanged("Calibre");
					this.OnCalibreChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_magazineCapacity", Name="MagazineCapacity", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MagazineCapacity
		{
			get
			{
				return this._magazineCapacity;
			}
			set
			{
				if ((_magazineCapacity != value))
				{
					this.OnMagazineCapacityChanging(value);
					this.SendPropertyChanging();
					this._magazineCapacity = value;
					this.SendPropertyChanged("MagazineCapacity");
					this.OnMagazineCapacityChanged();
				}
			}
		}
		
		[Column(Storage="_magazineID", Name="MagazineID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MagazineID
		{
			get
			{
				return this._magazineID;
			}
			set
			{
				if ((_magazineID != value))
				{
					this.OnMagazineIDChanging(value);
					this.SendPropertyChanging();
					this._magazineID = value;
					this.SendPropertyChanged("MagazineID");
					this.OnMagazineIDChanged();
				}
			}
		}
		
		[Column(Storage="_maxDamage", Name="MaxDamage", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MaxDamage
		{
			get
			{
				return this._maxDamage;
			}
			set
			{
				if ((_maxDamage != value))
				{
					this.OnMaxDamageChanging(value);
					this.SendPropertyChanging();
					this._maxDamage = value;
					this.SendPropertyChanged("MaxDamage");
					this.OnMaxDamageChanged();
				}
			}
		}
		
		[Column(Storage="_mechanismID", Name="MechanismID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MechanismID
		{
			get
			{
				return this._mechanismID;
			}
			set
			{
				if ((_mechanismID != value))
				{
					this.OnMechanismIDChanging(value);
					this.SendPropertyChanging();
					this._mechanismID = value;
					this.SendPropertyChanged("MechanismID");
					this.OnMechanismIDChanged();
				}
			}
		}
		
		[Column(Storage="_minDamage", Name="MinDamage", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MinDamage
		{
			get
			{
				return this._minDamage;
			}
			set
			{
				if ((_minDamage != value))
				{
					this.OnMinDamageChanging(value);
					this.SendPropertyChanging();
					this._minDamage = value;
					this.SendPropertyChanged("MinDamage");
					this.OnMinDamageChanged();
				}
			}
		}
		
		[Column(Storage="_minLevel", Name="MinLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MinLevel
		{
			get
			{
				return this._minLevel;
			}
			set
			{
				if ((_minLevel != value))
				{
					this.OnMinLevelChanging(value);
					this.SendPropertyChanging();
					this._minLevel = value;
					this.SendPropertyChanged("MinLevel");
					this.OnMinLevelChanged();
				}
			}
		}
		
		[Column(Storage="_range", Name="Range", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Range
		{
			get
			{
				return this._range;
			}
			set
			{
				if ((_range != value))
				{
					this.OnRangeChanging(value);
					this.SendPropertyChanging();
					this._range = value;
					this.SendPropertyChanged("Range");
					this.OnRangeChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_sightID", Name="SightID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SightID
		{
			get
			{
				return this._sightID;
			}
			set
			{
				if ((_sightID != value))
				{
					this.OnSightIDChanging(value);
					this.SendPropertyChanging();
					this._sightID = value;
					this.SendPropertyChanged("SightID");
					this.OnSightIDChanged();
				}
			}
		}
		
		[Column(Storage="_sniperRifleID", Name="SniperRifleID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SniperRifleID
		{
			get
			{
				return this._sniperRifleID;
			}
			set
			{
				if ((_sniperRifleID != value))
				{
					this.OnSniperRifleIDChanging(value);
					this.SendPropertyChanging();
					this._sniperRifleID = value;
					this.SendPropertyChanged("SniperRifleID");
					this.OnSniperRifleIDChanged();
				}
			}
		}
		
		[Column(Storage="_sniperRifleName", Name="SniperRifleName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SniperRifleName
		{
			get
			{
				return this._sniperRifleName;
			}
			set
			{
				if (((_sniperRifleName == value) 
							== false))
				{
					this.OnSniperRifleNameChanging(value);
					this.SendPropertyChanging();
					this._sniperRifleName = value;
					this.SendPropertyChanged("SniperRifleName");
					this.OnSniperRifleNameChanged();
				}
			}
		}
		
		[Column(Storage="_stockID", Name="StockID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> StockID
		{
			get
			{
				return this._stockID;
			}
			set
			{
				if ((_stockID != value))
				{
					this.OnStockIDChanging(value);
					this.SendPropertyChanging();
					this._stockID = value;
					this.SendPropertyChanged("StockID");
					this.OnStockIDChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SniperRifleSights")]
	public partial class SniperRifleSights : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private System.Nullable<float> _range;
		
		private string _rarity;
		
		private int _sniperRifleSightID;
		
		private string _sniperRifleSightName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRangeChanged();
		
		partial void OnRangeChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnSniperRifleSightIDChanged();
		
		partial void OnSniperRifleSightIDChanging(int value);
		
		partial void OnSniperRifleSightNameChanged();
		
		partial void OnSniperRifleSightNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public SniperRifleSights()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_range", Name="Range", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Range
		{
			get
			{
				return this._range;
			}
			set
			{
				if ((_range != value))
				{
					this.OnRangeChanging(value);
					this.SendPropertyChanging();
					this._range = value;
					this.SendPropertyChanged("Range");
					this.OnRangeChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_sniperRifleSightID", Name="SniperRifleSightID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SniperRifleSightID
		{
			get
			{
				return this._sniperRifleSightID;
			}
			set
			{
				if ((_sniperRifleSightID != value))
				{
					this.OnSniperRifleSightIDChanging(value);
					this.SendPropertyChanging();
					this._sniperRifleSightID = value;
					this.SendPropertyChanged("SniperRifleSightID");
					this.OnSniperRifleSightIDChanged();
				}
			}
		}
		
		[Column(Storage="_sniperRifleSightName", Name="SniperRifleSightName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SniperRifleSightName
		{
			get
			{
				return this._sniperRifleSightName;
			}
			set
			{
				if (((_sniperRifleSightName == value) 
							== false))
				{
					this.OnSniperRifleSightNameChanging(value);
					this.SendPropertyChanging();
					this._sniperRifleSightName = value;
					this.SendPropertyChanged("SniperRifleSightName");
					this.OnSniperRifleSightNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SniperRifleStocks")]
	public partial class SniperRifleStocks : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private string _rarity;
		
		private System.Nullable<float> _reloadSpeed;
		
		private int _sniperRifleStockID;
		
		private string _sniperRifleStockName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnSniperRifleStockIDChanged();
		
		partial void OnSniperRifleStockIDChanging(int value);
		
		partial void OnSniperRifleStockNameChanged();
		
		partial void OnSniperRifleStockNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public SniperRifleStocks()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_sniperRifleStockID", Name="SniperRifleStockID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SniperRifleStockID
		{
			get
			{
				return this._sniperRifleStockID;
			}
			set
			{
				if ((_sniperRifleStockID != value))
				{
					this.OnSniperRifleStockIDChanging(value);
					this.SendPropertyChanging();
					this._sniperRifleStockID = value;
					this.SendPropertyChanged("SniperRifleStockID");
					this.OnSniperRifleStockIDChanged();
				}
			}
		}
		
		[Column(Storage="_sniperRifleStockName", Name="SniperRifleStockName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SniperRifleStockName
		{
			get
			{
				return this._sniperRifleStockName;
			}
			set
			{
				if (((_sniperRifleStockName == value) 
							== false))
				{
					this.OnSniperRifleStockNameChanging(value);
					this.SendPropertyChanging();
					this._sniperRifleStockName = value;
					this.SendPropertyChanged("SniperRifleStockName");
					this.OnSniperRifleStockNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.Specializations")]
	public partial class Specializations : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _description;
		
		private string _specializaitonName;
		
		private int _specializationID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnSpecializaitonNameChanged();
		
		partial void OnSpecializaitonNameChanging(string value);
		
		partial void OnSpecializationIDChanged();
		
		partial void OnSpecializationIDChanging(int value);
		#endregion
		
		
		public Specializations()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_specializaitonName", Name="SpecializaitonName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SpecializaitonName
		{
			get
			{
				return this._specializaitonName;
			}
			set
			{
				if (((_specializaitonName == value) 
							== false))
				{
					this.OnSpecializaitonNameChanging(value);
					this.SendPropertyChanging();
					this._specializaitonName = value;
					this.SendPropertyChanged("SpecializaitonName");
					this.OnSpecializaitonNameChanged();
				}
			}
		}
		
		[Column(Storage="_specializationID", Name="SpecializationID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SpecializationID
		{
			get
			{
				return this._specializationID;
			}
			set
			{
				if ((_specializationID != value))
				{
					this.OnSpecializationIDChanging(value);
					this.SendPropertyChanging();
					this._specializationID = value;
					this.SendPropertyChanged("SpecializationID");
					this.OnSpecializationIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SubmachinegunBarrels")]
	public partial class SubmachinegunBarrels : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private System.Nullable<float> _minDamage;
		
		private System.Nullable<float> _range;
		
		private string _rarity;
		
		private int _submachinegunBarrelID;
		
		private string _submachinegunBarrelName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnMinDamageChanged();
		
		partial void OnMinDamageChanging(System.Nullable<float> value);
		
		partial void OnRangeChanged();
		
		partial void OnRangeChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnSubmachinegunBarrelIDChanged();
		
		partial void OnSubmachinegunBarrelIDChanging(int value);
		
		partial void OnSubmachinegunBarrelNameChanged();
		
		partial void OnSubmachinegunBarrelNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public SubmachinegunBarrels()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_minDamage", Name="MinDamage", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> MinDamage
		{
			get
			{
				return this._minDamage;
			}
			set
			{
				if ((_minDamage != value))
				{
					this.OnMinDamageChanging(value);
					this.SendPropertyChanging();
					this._minDamage = value;
					this.SendPropertyChanged("MinDamage");
					this.OnMinDamageChanged();
				}
			}
		}
		
		[Column(Storage="_range", Name="Range", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Range
		{
			get
			{
				return this._range;
			}
			set
			{
				if ((_range != value))
				{
					this.OnRangeChanging(value);
					this.SendPropertyChanging();
					this._range = value;
					this.SendPropertyChanged("Range");
					this.OnRangeChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_submachinegunBarrelID", Name="SubmachinegunBarrelID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SubmachinegunBarrelID
		{
			get
			{
				return this._submachinegunBarrelID;
			}
			set
			{
				if ((_submachinegunBarrelID != value))
				{
					this.OnSubmachinegunBarrelIDChanging(value);
					this.SendPropertyChanging();
					this._submachinegunBarrelID = value;
					this.SendPropertyChanged("SubmachinegunBarrelID");
					this.OnSubmachinegunBarrelIDChanged();
				}
			}
		}
		
		[Column(Storage="_submachinegunBarrelName", Name="SubmachinegunBarrelName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SubmachinegunBarrelName
		{
			get
			{
				return this._submachinegunBarrelName;
			}
			set
			{
				if (((_submachinegunBarrelName == value) 
							== false))
				{
					this.OnSubmachinegunBarrelNameChanging(value);
					this.SendPropertyChanging();
					this._submachinegunBarrelName = value;
					this.SendPropertyChanged("SubmachinegunBarrelName");
					this.OnSubmachinegunBarrelNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SubmachinegunBodies")]
	public partial class SubmachinegunBodies : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _calibre;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private System.Nullable<float> _maxDamage;
		
		private string _rarity;
		
		private int _submachinegunBodyID;
		
		private string _submachinegunBodyName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCalibreChanged();
		
		partial void OnCalibreChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnMaxDamageChanged();
		
		partial void OnMaxDamageChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnSubmachinegunBodyIDChanged();
		
		partial void OnSubmachinegunBodyIDChanging(int value);
		
		partial void OnSubmachinegunBodyNameChanged();
		
		partial void OnSubmachinegunBodyNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public SubmachinegunBodies()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_calibre", Name="Calibre", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Calibre
		{
			get
			{
				return this._calibre;
			}
			set
			{
				if (((_calibre == value) 
							== false))
				{
					this.OnCalibreChanging(value);
					this.SendPropertyChanging();
					this._calibre = value;
					this.SendPropertyChanged("Calibre");
					this.OnCalibreChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_maxDamage", Name="MaxDamage", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> MaxDamage
		{
			get
			{
				return this._maxDamage;
			}
			set
			{
				if ((_maxDamage != value))
				{
					this.OnMaxDamageChanging(value);
					this.SendPropertyChanging();
					this._maxDamage = value;
					this.SendPropertyChanged("MaxDamage");
					this.OnMaxDamageChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_submachinegunBodyID", Name="SubmachinegunBodyID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SubmachinegunBodyID
		{
			get
			{
				return this._submachinegunBodyID;
			}
			set
			{
				if ((_submachinegunBodyID != value))
				{
					this.OnSubmachinegunBodyIDChanging(value);
					this.SendPropertyChanging();
					this._submachinegunBodyID = value;
					this.SendPropertyChanged("SubmachinegunBodyID");
					this.OnSubmachinegunBodyIDChanged();
				}
			}
		}
		
		[Column(Storage="_submachinegunBodyName", Name="SubmachinegunBodyName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SubmachinegunBodyName
		{
			get
			{
				return this._submachinegunBodyName;
			}
			set
			{
				if (((_submachinegunBodyName == value) 
							== false))
				{
					this.OnSubmachinegunBodyNameChanging(value);
					this.SendPropertyChanging();
					this._submachinegunBodyName = value;
					this.SendPropertyChanged("SubmachinegunBodyName");
					this.OnSubmachinegunBodyNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SubmachinegunMagazines")]
	public partial class SubmachinegunMagazines : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _capacity;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private string _rarity;
		
		private System.Nullable<float> _rateOfFire;
		
		private System.Nullable<float> _reloadSpeed;
		
		private int _submachinegunMagazineID;
		
		private string _submachinegunMagazineName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCapacityChanged();
		
		partial void OnCapacityChanging(System.Nullable<int> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnSubmachinegunMagazineIDChanged();
		
		partial void OnSubmachinegunMagazineIDChanging(int value);
		
		partial void OnSubmachinegunMagazineNameChanged();
		
		partial void OnSubmachinegunMagazineNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public SubmachinegunMagazines()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_capacity", Name="Capacity", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Capacity
		{
			get
			{
				return this._capacity;
			}
			set
			{
				if ((_capacity != value))
				{
					this.OnCapacityChanging(value);
					this.SendPropertyChanging();
					this._capacity = value;
					this.SendPropertyChanged("Capacity");
					this.OnCapacityChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_submachinegunMagazineID", Name="SubmachinegunMagazineID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SubmachinegunMagazineID
		{
			get
			{
				return this._submachinegunMagazineID;
			}
			set
			{
				if ((_submachinegunMagazineID != value))
				{
					this.OnSubmachinegunMagazineIDChanging(value);
					this.SendPropertyChanging();
					this._submachinegunMagazineID = value;
					this.SendPropertyChanged("SubmachinegunMagazineID");
					this.OnSubmachinegunMagazineIDChanged();
				}
			}
		}
		
		[Column(Storage="_submachinegunMagazineName", Name="SubmachinegunMagazineName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SubmachinegunMagazineName
		{
			get
			{
				return this._submachinegunMagazineName;
			}
			set
			{
				if (((_submachinegunMagazineName == value) 
							== false))
				{
					this.OnSubmachinegunMagazineNameChanging(value);
					this.SendPropertyChanging();
					this._submachinegunMagazineName = value;
					this.SendPropertyChanged("SubmachinegunMagazineName");
					this.OnSubmachinegunMagazineNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SubmachinegunMechanisms")]
	public partial class SubmachinegunMechanisms : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _burstType;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private string _rarity;
		
		private System.Nullable<float> _rateOfFire;
		
		private int _submachinegunMechanismID;
		
		private string _submachinegunMechanismName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBurstTypeChanged();
		
		partial void OnBurstTypeChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		
		partial void OnSubmachinegunMechanismIDChanged();
		
		partial void OnSubmachinegunMechanismIDChanging(int value);
		
		partial void OnSubmachinegunMechanismNameChanged();
		
		partial void OnSubmachinegunMechanismNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public SubmachinegunMechanisms()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_burstType", Name="BurstType", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BurstType
		{
			get
			{
				return this._burstType;
			}
			set
			{
				if (((_burstType == value) 
							== false))
				{
					this.OnBurstTypeChanging(value);
					this.SendPropertyChanging();
					this._burstType = value;
					this.SendPropertyChanged("BurstType");
					this.OnBurstTypeChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		[Column(Storage="_submachinegunMechanismID", Name="SubmachinegunMechanismID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SubmachinegunMechanismID
		{
			get
			{
				return this._submachinegunMechanismID;
			}
			set
			{
				if ((_submachinegunMechanismID != value))
				{
					this.OnSubmachinegunMechanismIDChanging(value);
					this.SendPropertyChanging();
					this._submachinegunMechanismID = value;
					this.SendPropertyChanged("SubmachinegunMechanismID");
					this.OnSubmachinegunMechanismIDChanged();
				}
			}
		}
		
		[Column(Storage="_submachinegunMechanismName", Name="SubmachinegunMechanismName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SubmachinegunMechanismName
		{
			get
			{
				return this._submachinegunMechanismName;
			}
			set
			{
				if (((_submachinegunMechanismName == value) 
							== false))
				{
					this.OnSubmachinegunMechanismNameChanging(value);
					this.SendPropertyChanging();
					this._submachinegunMechanismName = value;
					this.SendPropertyChanged("SubmachinegunMechanismName");
					this.OnSubmachinegunMechanismNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SubmachinegunSights")]
	public partial class SubmachinegunSights : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private string _rarity;
		
		private System.Nullable<float> _reloadSpeed;
		
		private int _submachinegunSightID;
		
		private string _submachinegunSightName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnSubmachinegunSightIDChanged();
		
		partial void OnSubmachinegunSightIDChanging(int value);
		
		partial void OnSubmachinegunSightNameChanged();
		
		partial void OnSubmachinegunSightNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public SubmachinegunSights()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_submachinegunSightID", Name="SubmachinegunSightID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SubmachinegunSightID
		{
			get
			{
				return this._submachinegunSightID;
			}
			set
			{
				if ((_submachinegunSightID != value))
				{
					this.OnSubmachinegunSightIDChanging(value);
					this.SendPropertyChanging();
					this._submachinegunSightID = value;
					this.SendPropertyChanged("SubmachinegunSightID");
					this.OnSubmachinegunSightIDChanged();
				}
			}
		}
		
		[Column(Storage="_submachinegunSightName", Name="SubmachinegunSightName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SubmachinegunSightName
		{
			get
			{
				return this._submachinegunSightName;
			}
			set
			{
				if (((_submachinegunSightName == value) 
							== false))
				{
					this.OnSubmachinegunSightNameChanging(value);
					this.SendPropertyChanging();
					this._submachinegunSightName = value;
					this.SendPropertyChanged("SubmachinegunSightName");
					this.OnSubmachinegunSightNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SubmachinegunStocks")]
	public partial class SubmachinegunStocks : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private string _description;
		
		private System.Nullable<int> _engLevel;
		
		private string _rarity;
		
		private System.Nullable<float> _reloadSpeed;
		
		private int _submachinegunStockID;
		
		private string _submachinegunStockName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnEngLevelChanged();
		
		partial void OnEngLevelChanging(System.Nullable<int> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnSubmachinegunStockIDChanged();
		
		partial void OnSubmachinegunStockIDChanging(int value);
		
		partial void OnSubmachinegunStockNameChanged();
		
		partial void OnSubmachinegunStockNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public SubmachinegunStocks()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_engLevel", Name="EngLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EngLevel
		{
			get
			{
				return this._engLevel;
			}
			set
			{
				if ((_engLevel != value))
				{
					this.OnEngLevelChanging(value);
					this.SendPropertyChanging();
					this._engLevel = value;
					this.SendPropertyChanged("EngLevel");
					this.OnEngLevelChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_submachinegunStockID", Name="SubmachinegunStockID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SubmachinegunStockID
		{
			get
			{
				return this._submachinegunStockID;
			}
			set
			{
				if ((_submachinegunStockID != value))
				{
					this.OnSubmachinegunStockIDChanging(value);
					this.SendPropertyChanging();
					this._submachinegunStockID = value;
					this.SendPropertyChanged("SubmachinegunStockID");
					this.OnSubmachinegunStockIDChanged();
				}
			}
		}
		
		[Column(Storage="_submachinegunStockName", Name="SubmachinegunStockName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SubmachinegunStockName
		{
			get
			{
				return this._submachinegunStockName;
			}
			set
			{
				if (((_submachinegunStockName == value) 
							== false))
				{
					this.OnSubmachinegunStockNameChanging(value);
					this.SendPropertyChanging();
					this._submachinegunStockName = value;
					this.SendPropertyChanged("SubmachinegunStockName");
					this.OnSubmachinegunStockNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.Submachinguns")]
	public partial class Submachinguns : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<float> _accuracy;
		
		private System.Nullable<int> _barrelID;
		
		private System.Nullable<int> _bodyID;
		
		private string _burstType;
		
		private string _calibre;
		
		private string _description;
		
		private System.Nullable<int> _magazineCapacity;
		
		private System.Nullable<int> _magazineID;
		
		private System.Nullable<int> _maxDamage;
		
		private System.Nullable<int> _mechanismID;
		
		private System.Nullable<int> _minDamage;
		
		private System.Nullable<int> _minLevel;
		
		private System.Nullable<float> _range;
		
		private string _rarity;
		
		private System.Nullable<float> _rateOfFire;
		
		private System.Nullable<float> _reloadSpeed;
		
		private System.Nullable<int> _sightID;
		
		private System.Nullable<int> _stockID;
		
		private int _submachinegunID;
		
		private string _submachinegunName;
		
		private System.Nullable<int> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccuracyChanged();
		
		partial void OnAccuracyChanging(System.Nullable<float> value);
		
		partial void OnBarrelIDChanged();
		
		partial void OnBarrelIDChanging(System.Nullable<int> value);
		
		partial void OnBodyIDChanged();
		
		partial void OnBodyIDChanging(System.Nullable<int> value);
		
		partial void OnBurstTypeChanged();
		
		partial void OnBurstTypeChanging(string value);
		
		partial void OnCalibreChanged();
		
		partial void OnCalibreChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnMagazineCapacityChanged();
		
		partial void OnMagazineCapacityChanging(System.Nullable<int> value);
		
		partial void OnMagazineIDChanged();
		
		partial void OnMagazineIDChanging(System.Nullable<int> value);
		
		partial void OnMaxDamageChanged();
		
		partial void OnMaxDamageChanging(System.Nullable<int> value);
		
		partial void OnMechanismIDChanged();
		
		partial void OnMechanismIDChanging(System.Nullable<int> value);
		
		partial void OnMinDamageChanged();
		
		partial void OnMinDamageChanging(System.Nullable<int> value);
		
		partial void OnMinLevelChanged();
		
		partial void OnMinLevelChanging(System.Nullable<int> value);
		
		partial void OnRangeChanged();
		
		partial void OnRangeChanging(System.Nullable<float> value);
		
		partial void OnRarityChanged();
		
		partial void OnRarityChanging(string value);
		
		partial void OnRateOfFireChanged();
		
		partial void OnRateOfFireChanging(System.Nullable<float> value);
		
		partial void OnReloadSpeedChanged();
		
		partial void OnReloadSpeedChanging(System.Nullable<float> value);
		
		partial void OnSightIDChanged();
		
		partial void OnSightIDChanging(System.Nullable<int> value);
		
		partial void OnStockIDChanged();
		
		partial void OnStockIDChanging(System.Nullable<int> value);
		
		partial void OnSubmachinegunIDChanged();
		
		partial void OnSubmachinegunIDChanging(int value);
		
		partial void OnSubmachinegunNameChanged();
		
		partial void OnSubmachinegunNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<int> value);
		#endregion
		
		
		public Submachinguns()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accuracy", Name="Accuracy", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Accuracy
		{
			get
			{
				return this._accuracy;
			}
			set
			{
				if ((_accuracy != value))
				{
					this.OnAccuracyChanging(value);
					this.SendPropertyChanging();
					this._accuracy = value;
					this.SendPropertyChanged("Accuracy");
					this.OnAccuracyChanged();
				}
			}
		}
		
		[Column(Storage="_barrelID", Name="BarrelID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> BarrelID
		{
			get
			{
				return this._barrelID;
			}
			set
			{
				if ((_barrelID != value))
				{
					this.OnBarrelIDChanging(value);
					this.SendPropertyChanging();
					this._barrelID = value;
					this.SendPropertyChanged("BarrelID");
					this.OnBarrelIDChanged();
				}
			}
		}
		
		[Column(Storage="_bodyID", Name="BodyID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> BodyID
		{
			get
			{
				return this._bodyID;
			}
			set
			{
				if ((_bodyID != value))
				{
					this.OnBodyIDChanging(value);
					this.SendPropertyChanging();
					this._bodyID = value;
					this.SendPropertyChanged("BodyID");
					this.OnBodyIDChanged();
				}
			}
		}
		
		[Column(Storage="_burstType", Name="BurstType", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BurstType
		{
			get
			{
				return this._burstType;
			}
			set
			{
				if (((_burstType == value) 
							== false))
				{
					this.OnBurstTypeChanging(value);
					this.SendPropertyChanging();
					this._burstType = value;
					this.SendPropertyChanged("BurstType");
					this.OnBurstTypeChanged();
				}
			}
		}
		
		[Column(Storage="_calibre", Name="Calibre", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Calibre
		{
			get
			{
				return this._calibre;
			}
			set
			{
				if (((_calibre == value) 
							== false))
				{
					this.OnCalibreChanging(value);
					this.SendPropertyChanging();
					this._calibre = value;
					this.SendPropertyChanged("Calibre");
					this.OnCalibreChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="Description", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_magazineCapacity", Name="MagazineCapacity", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MagazineCapacity
		{
			get
			{
				return this._magazineCapacity;
			}
			set
			{
				if ((_magazineCapacity != value))
				{
					this.OnMagazineCapacityChanging(value);
					this.SendPropertyChanging();
					this._magazineCapacity = value;
					this.SendPropertyChanged("MagazineCapacity");
					this.OnMagazineCapacityChanged();
				}
			}
		}
		
		[Column(Storage="_magazineID", Name="MagazineID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MagazineID
		{
			get
			{
				return this._magazineID;
			}
			set
			{
				if ((_magazineID != value))
				{
					this.OnMagazineIDChanging(value);
					this.SendPropertyChanging();
					this._magazineID = value;
					this.SendPropertyChanged("MagazineID");
					this.OnMagazineIDChanged();
				}
			}
		}
		
		[Column(Storage="_maxDamage", Name="MaxDamage", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MaxDamage
		{
			get
			{
				return this._maxDamage;
			}
			set
			{
				if ((_maxDamage != value))
				{
					this.OnMaxDamageChanging(value);
					this.SendPropertyChanging();
					this._maxDamage = value;
					this.SendPropertyChanged("MaxDamage");
					this.OnMaxDamageChanged();
				}
			}
		}
		
		[Column(Storage="_mechanismID", Name="MechanismID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MechanismID
		{
			get
			{
				return this._mechanismID;
			}
			set
			{
				if ((_mechanismID != value))
				{
					this.OnMechanismIDChanging(value);
					this.SendPropertyChanging();
					this._mechanismID = value;
					this.SendPropertyChanged("MechanismID");
					this.OnMechanismIDChanged();
				}
			}
		}
		
		[Column(Storage="_minDamage", Name="MinDamage", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MinDamage
		{
			get
			{
				return this._minDamage;
			}
			set
			{
				if ((_minDamage != value))
				{
					this.OnMinDamageChanging(value);
					this.SendPropertyChanging();
					this._minDamage = value;
					this.SendPropertyChanged("MinDamage");
					this.OnMinDamageChanged();
				}
			}
		}
		
		[Column(Storage="_minLevel", Name="MinLevel", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MinLevel
		{
			get
			{
				return this._minLevel;
			}
			set
			{
				if ((_minLevel != value))
				{
					this.OnMinLevelChanging(value);
					this.SendPropertyChanging();
					this._minLevel = value;
					this.SendPropertyChanged("MinLevel");
					this.OnMinLevelChanged();
				}
			}
		}
		
		[Column(Storage="_range", Name="Range", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Range
		{
			get
			{
				return this._range;
			}
			set
			{
				if ((_range != value))
				{
					this.OnRangeChanging(value);
					this.SendPropertyChanging();
					this._range = value;
					this.SendPropertyChanged("Range");
					this.OnRangeChanged();
				}
			}
		}
		
		[Column(Storage="_rarity", Name="Rarity", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rarity
		{
			get
			{
				return this._rarity;
			}
			set
			{
				if (((_rarity == value) 
							== false))
				{
					this.OnRarityChanging(value);
					this.SendPropertyChanging();
					this._rarity = value;
					this.SendPropertyChanged("Rarity");
					this.OnRarityChanged();
				}
			}
		}
		
		[Column(Storage="_rateOfFire", Name="RateOfFire", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> RateOfFire
		{
			get
			{
				return this._rateOfFire;
			}
			set
			{
				if ((_rateOfFire != value))
				{
					this.OnRateOfFireChanging(value);
					this.SendPropertyChanging();
					this._rateOfFire = value;
					this.SendPropertyChanged("RateOfFire");
					this.OnRateOfFireChanged();
				}
			}
		}
		
		[Column(Storage="_reloadSpeed", Name="ReloadSpeed", DbType="FLOAT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> ReloadSpeed
		{
			get
			{
				return this._reloadSpeed;
			}
			set
			{
				if ((_reloadSpeed != value))
				{
					this.OnReloadSpeedChanging(value);
					this.SendPropertyChanging();
					this._reloadSpeed = value;
					this.SendPropertyChanged("ReloadSpeed");
					this.OnReloadSpeedChanged();
				}
			}
		}
		
		[Column(Storage="_sightID", Name="SightID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SightID
		{
			get
			{
				return this._sightID;
			}
			set
			{
				if ((_sightID != value))
				{
					this.OnSightIDChanging(value);
					this.SendPropertyChanging();
					this._sightID = value;
					this.SendPropertyChanged("SightID");
					this.OnSightIDChanged();
				}
			}
		}
		
		[Column(Storage="_stockID", Name="StockID", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> StockID
		{
			get
			{
				return this._stockID;
			}
			set
			{
				if ((_stockID != value))
				{
					this.OnStockIDChanging(value);
					this.SendPropertyChanging();
					this._stockID = value;
					this.SendPropertyChanged("StockID");
					this.OnStockIDChanged();
				}
			}
		}
		
		[Column(Storage="_submachinegunID", Name="SubmachinegunID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SubmachinegunID
		{
			get
			{
				return this._submachinegunID;
			}
			set
			{
				if ((_submachinegunID != value))
				{
					this.OnSubmachinegunIDChanging(value);
					this.SendPropertyChanging();
					this._submachinegunID = value;
					this.SendPropertyChanged("SubmachinegunID");
					this.OnSubmachinegunIDChanged();
				}
			}
		}
		
		[Column(Storage="_submachinegunName", Name="submachinegunName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SubmachinegunName
		{
			get
			{
				return this._submachinegunName;
			}
			set
			{
				if (((_submachinegunName == value) 
							== false))
				{
					this.OnSubmachinegunNameChanging(value);
					this.SendPropertyChanging();
					this._submachinegunName = value;
					this.SendPropertyChanged("SubmachinegunName");
					this.OnSubmachinegunNameChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="INTEGER", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.SubSkills")]
	public partial class SubSkills : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _subSkillDescription;
		
		private int _subSkillID;
		
		private string _subSkillName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnSubSkillDescriptionChanged();
		
		partial void OnSubSkillDescriptionChanging(string value);
		
		partial void OnSubSkillIDChanged();
		
		partial void OnSubSkillIDChanging(int value);
		
		partial void OnSubSkillNameChanged();
		
		partial void OnSubSkillNameChanging(string value);
		#endregion
		
		
		public SubSkills()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_subSkillDescription", Name="SubSkillDescription", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SubSkillDescription
		{
			get
			{
				return this._subSkillDescription;
			}
			set
			{
				if (((_subSkillDescription == value) 
							== false))
				{
					this.OnSubSkillDescriptionChanging(value);
					this.SendPropertyChanging();
					this._subSkillDescription = value;
					this.SendPropertyChanged("SubSkillDescription");
					this.OnSubSkillDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_subSkillID", Name="SubSkillID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SubSkillID
		{
			get
			{
				return this._subSkillID;
			}
			set
			{
				if ((_subSkillID != value))
				{
					this.OnSubSkillIDChanging(value);
					this.SendPropertyChanging();
					this._subSkillID = value;
					this.SendPropertyChanged("SubSkillID");
					this.OnSubSkillIDChanged();
				}
			}
		}
		
		[Column(Storage="_subSkillName", Name="SubSkillName", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SubSkillName
		{
			get
			{
				return this._subSkillName;
			}
			set
			{
				if (((_subSkillName == value) 
							== false))
				{
					this.OnSubSkillNameChanging(value);
					this.SendPropertyChanging();
					this._subSkillName = value;
					this.SendPropertyChanged("SubSkillName");
					this.OnSubSkillNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
