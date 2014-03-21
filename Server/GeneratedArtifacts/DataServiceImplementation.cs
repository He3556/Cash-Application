﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::ApplicationData.Implementation.ApplicationDataObjectContext>
    {
    
        public ApplicationDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService()
        {
            return new global::LightSwitchApplication.DataWorkspace().ApplicationData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::ApplicationData.Implementation.ApplicationDataObjectContext>
    {
        public ApplicationDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Rechnungen> InBearbeitung()
        {
            global::System.Linq.IQueryable<global::ApplicationData.Implementation.Rechnungen> query;
            query = global::System.Linq.Queryable.OrderBy(
                global::System.Linq.Queryable.Where(
                    this.GetQuery<global::ApplicationData.Implementation.Rechnungen>("RechnungenSet"),
                    (r) => (r.Status < 5)),
                (r) => r.Bestelldatum);
            return query;
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Rechnungen> AuftragsSammlung()
        {
            global::System.Linq.IQueryable<global::ApplicationData.Implementation.Rechnungen> query;
            query = global::System.Linq.Queryable.OrderBy(
                global::System.Linq.Queryable.Where(
                    this.GetQuery<global::ApplicationData.Implementation.Rechnungen>("RechnungenSet"),
                    (r) => (r.Status == 0)),
                (r) => r.Bestelldatum);
            return query;
        }
    
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::ApplicationData.Implementation.KundenItem))
            {
                return new global::ApplicationData.Implementation.KundenItem();
            }
            if (type == typeof(global::ApplicationData.Implementation.KundengruppenItem))
            {
                return new global::ApplicationData.Implementation.KundengruppenItem();
            }
            if (type == typeof(global::ApplicationData.Implementation.ArtikelstammItem))
            {
                return new global::ApplicationData.Implementation.ArtikelstammItem();
            }
            if (type == typeof(global::ApplicationData.Implementation.Rechnungen))
            {
                return new global::ApplicationData.Implementation.Rechnungen();
            }
            if (type == typeof(global::ApplicationData.Implementation.ArtikellisteItem))
            {
                return new global::ApplicationData.Implementation.ArtikellisteItem();
            }
            if (type == typeof(global::ApplicationData.Implementation.FirmendatenItem))
            {
                return new global::ApplicationData.Implementation.FirmendatenItem();
            }
            if (type == typeof(global::ApplicationData.Implementation.Meine_DatenItem))
            {
                return new global::ApplicationData.Implementation.Meine_DatenItem();
            }
            if (type == typeof(global::ApplicationData.Implementation.AdressenSetItem))
            {
                return new global::ApplicationData.Implementation.AdressenSetItem();
            }
            if (type == typeof(global::ApplicationData.Implementation.BezahlartItem))
            {
                return new global::ApplicationData.Implementation.BezahlartItem();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::ApplicationData.Implementation.ApplicationDataObjectContext CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::ApplicationData.Implementation.ApplicationDataObjectContext(base.GetEntityConnectionString(
                "_IntrinsicData", 
                "res://" + assemblyName + "/ApplicationData.csdl|res://" + assemblyName + "/ApplicationData.ssdl|res://" + assemblyName + "/ApplicationData.msl", 
                "System.Data.SqlClient"));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.KundenItem))
            {
                return new global::ApplicationData.Implementation.KundenItem();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.KundengruppenItem))
            {
                return new global::ApplicationData.Implementation.KundengruppenItem();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.ArtikelstammItem))
            {
                return new global::ApplicationData.Implementation.ArtikelstammItem();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Rechnungen))
            {
                return new global::ApplicationData.Implementation.Rechnungen();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.ArtikellisteItem))
            {
                return new global::ApplicationData.Implementation.ArtikellisteItem();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.FirmendatenItem))
            {
                return new global::ApplicationData.Implementation.FirmendatenItem();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Meine_DatenItem))
            {
                return new global::ApplicationData.Implementation.Meine_DatenItem();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.AdressenSetItem))
            {
                return new global::ApplicationData.Implementation.AdressenSetItem();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.BezahlartItem))
            {
                return new global::ApplicationData.Implementation.BezahlartItem();
            }
            return null;
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.KundenItem) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.KundenItem);
            }
            if (typeof(global::LightSwitchApplication.KundengruppenItem) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.KundengruppenItem);
            }
            if (typeof(global::LightSwitchApplication.ArtikelstammItem) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.ArtikelstammItem);
            }
            if (typeof(global::LightSwitchApplication.Rechnungen) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.Rechnungen);
            }
            if (typeof(global::LightSwitchApplication.ArtikellisteItem) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.ArtikellisteItem);
            }
            if (typeof(global::LightSwitchApplication.FirmendatenItem) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.FirmendatenItem);
            }
            if (typeof(global::LightSwitchApplication.Meine_DatenItem) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.Meine_DatenItem);
            }
            if (typeof(global::LightSwitchApplication.AdressenSetItem) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.AdressenSetItem);
            }
            if (typeof(global::LightSwitchApplication.BezahlartItem) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.BezahlartItem);
            }
            return null;
        }
    }
}

namespace ApplicationData.Implementation
{

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class KundenItem :
        global::LightSwitchApplication.KundenItem.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.KundenItem.DetailsClass.IImplementation.KundengruppenItem
        {
            get
            {
                return this.KundengruppenItem;
            }
            set
            {
                this.KundengruppenItem = (global::ApplicationData.Implementation.KundengruppenItem)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("KundengruppenItem");
                }
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.KundenItem.DetailsClass.IImplementation.Adressen
        {
            get
            {
                return this.Adressen;
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.KundenItem.DetailsClass.IImplementation.Rechnungen
        {
            get
            {
                return this.Rechnungen;
            }
        }
        
        partial void OnKunden_KundengruppeChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("KundengruppenItem");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class KundengruppenItem :
        global::LightSwitchApplication.KundengruppenItem.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.KundengruppenItem.DetailsClass.IImplementation.Kunden
        {
            get
            {
                return this.Kunden;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class ArtikelstammItem :
        global::LightSwitchApplication.ArtikelstammItem.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.ArtikelstammItem.DetailsClass.IImplementation.ArtikellisteItem
        {
            get
            {
                return this.ArtikellisteItem;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Rechnungen :
        global::LightSwitchApplication.Rechnungen.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Rechnungen.DetailsClass.IImplementation.Kunde
        {
            get
            {
                return this.Kunde;
            }
            set
            {
                this.Kunde = (global::ApplicationData.Implementation.KundenItem)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Kunde");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Rechnungen.DetailsClass.IImplementation.BezahlartItem
        {
            get
            {
                return this.BezahlartItem;
            }
            set
            {
                this.BezahlartItem = (global::ApplicationData.Implementation.BezahlartItem)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("BezahlartItem");
                }
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Rechnungen.DetailsClass.IImplementation.ArtikellisteCollection
        {
            get
            {
                return this.ArtikellisteCollection;
            }
        }
        
        partial void OnRechnungen_KundenChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Kunde");
            }
        }
        
        partial void OnRechnungen_BezahlartItemChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("BezahlartItem");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class ArtikellisteItem :
        global::LightSwitchApplication.ArtikellisteItem.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.ArtikellisteItem.DetailsClass.IImplementation.ArtikelstammItem
        {
            get
            {
                return this.ArtikelstammItem;
            }
            set
            {
                this.ArtikelstammItem = (global::ApplicationData.Implementation.ArtikelstammItem)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("ArtikelstammItem");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.ArtikellisteItem.DetailsClass.IImplementation.Rechnungen
        {
            get
            {
                return this.Rechnungen;
            }
            set
            {
                this.Rechnungen = (global::ApplicationData.Implementation.Rechnungen)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Rechnungen");
                }
            }
        }
        
        partial void OnArtikelliste_ArtikelstammChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("ArtikelstammItem");
            }
        }
        
        partial void OnArtikelliste_RechnungenChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Rechnungen");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class FirmendatenItem :
        global::LightSwitchApplication.FirmendatenItem.DetailsClass.IImplementation
    {
    
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Meine_DatenItem :
        global::LightSwitchApplication.Meine_DatenItem.DetailsClass.IImplementation
    {
    
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class AdressenSetItem :
        global::LightSwitchApplication.AdressenSetItem.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.AdressenSetItem.DetailsClass.IImplementation.KundenRechnungsadresse
        {
            get
            {
                return this.KundenRechnungsadresse;
            }
            set
            {
                this.KundenRechnungsadresse = (global::ApplicationData.Implementation.KundenItem)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("KundenRechnungsadresse");
                }
            }
        }
        
        partial void OnKunden_RechnungsadressenChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("KundenRechnungsadresse");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class BezahlartItem :
        global::LightSwitchApplication.BezahlartItem.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.BezahlartItem.DetailsClass.IImplementation.RechnungenCollection
        {
            get
            {
                return this.RechnungenCollection;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}

