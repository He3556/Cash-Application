﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// Keine modellierte Beschreibung verfügbar
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    public sealed partial class Anbieter : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initialisiert eine neue Instanz der Entität Anbieter.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Anbieter()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Anbieter(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Anbieter> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Anbieter.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Anbieter_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Anbieter_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Ruft das Application-Objekt für diese Anwendung ab. Das Application-Objekt stellt Zugriff auf aktive Bildschirme, Methoden zum Öffnen von Bildschirmen sowie Zugriff auf den aktuellen Benutzer bereit.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Ruft den übergeordneten Datenarbeitsbereich ab. Der Datenarbeitsbereich stellt Zugriff auf alle Datenquellen in der Anwendung bereit.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// Keine modellierte Beschreibung verfügbar
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.Anbieter.DetailsClass.GetValue(this, global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.Anbieter.DetailsClass.SetValue(this, global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.Id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// Keine modellierte Beschreibung verfügbar
        /// </summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public byte[] RowVersion
        {
            get
            {
                return global::LightSwitchApplication.Anbieter.DetailsClass.GetValue(this, global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.RowVersion);
            }
            set
            {
                global::LightSwitchApplication.Anbieter.DetailsClass.SetValue(this, global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.RowVersion, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_Changed();

        /// <summary>
        /// Keine modellierte Beschreibung verfügbar
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Bezeichnung
        {
            get
            {
                return global::LightSwitchApplication.Anbieter.DetailsClass.GetValue(this, global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.Bezeichnung);
            }
            set
            {
                global::LightSwitchApplication.Anbieter.DetailsClass.SetValue(this, global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.Bezeichnung, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bezeichnung_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bezeichnung_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bezeichnung_Changed();

        /// <summary>
        /// Keine modellierte Beschreibung verfügbar
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Email
        {
            get
            {
                return global::LightSwitchApplication.Anbieter.DetailsClass.GetValue(this, global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.Email);
            }
            set
            {
                global::LightSwitchApplication.Anbieter.DetailsClass.SetValue(this, global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.Email, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Email_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Email_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Email_Changed();

        /// <summary>
        /// Keine modellierte Beschreibung verfügbar
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.ArtikelstammItem> Artikelstamm
        {
            get
            {
                return global::LightSwitchApplication.Anbieter.DetailsClass.GetValue(this, global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.Artikelstamm);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.ArtikelstammItem> ArtikelstammQuery
        {
            get
            {
                return global::LightSwitchApplication.Anbieter.DetailsClass.GetQuery(this, global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.Artikelstamm);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Anbieter,
                global::LightSwitchApplication.Anbieter.DetailsClass,
                global::LightSwitchApplication.Anbieter.DetailsClass.IImplementation,
                global::LightSwitchApplication.Anbieter.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass>.Entry
                __AnbieterEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass>.Entry(
                    global::LightSwitchApplication.Anbieter.DetailsClass.__Anbieter_CreateNew,
                    global::LightSwitchApplication.Anbieter.DetailsClass.__Anbieter_Created,
                    global::LightSwitchApplication.Anbieter.DetailsClass.__Anbieter_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Anbieter __Anbieter_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Anbieter> es)
            {
                return new global::LightSwitchApplication.Anbieter(es);
            }
            private static void __Anbieter_Created(global::LightSwitchApplication.Anbieter e)
            {
                e.Anbieter_Created();
            }
            private static bool __Anbieter_AllowSaveWithErrors(global::LightSwitchApplication.Anbieter e)
            {
                bool result = false;
                e.Anbieter_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Anbieter.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, byte[]> RowVersion
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.RowVersion) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, byte[]>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, string> Bezeichnung
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.Bezeichnung) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, string> Email
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.Email) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, global::LightSwitchApplication.ArtikelstammItem> Artikelstamm
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.Artikelstamm) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, global::LightSwitchApplication.ArtikelstammItem>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new byte[] RowVersion { get; set; }
                new string Bezeichnung { get; set; }
                new string Email { get; set; }
                new global::System.Collections.IEnumerable Artikelstamm { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Anbieter.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, int>.Data> c, global::LightSwitchApplication.Anbieter.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.Anbieter e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.Anbieter e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.Anbieter.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.Anbieter.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.Anbieter e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, byte[]>.Entry
                    RowVersion = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, byte[]>.Entry(
                        "RowVersion",
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._RowVersion_Stub,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._RowVersion_Validate,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged);
                private static void _RowVersion_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Anbieter.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, byte[]>.Data> c, global::LightSwitchApplication.Anbieter.DetailsClass d, object sf)
                {
                    c(d, ref d._RowVersion, sf);
                }
                private static bool _RowVersion_ComputeIsReadOnly(global::LightSwitchApplication.Anbieter e)
                {
                    bool result = false;
                    e.RowVersion_IsReadOnly(ref result);
                    return result;
                }
                private static void _RowVersion_Validate(global::LightSwitchApplication.Anbieter e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.RowVersion_Validate(r);
                }
                private static byte[] _RowVersion_GetImplementationValue(global::LightSwitchApplication.Anbieter.DetailsClass d)
                {
                    return d.ImplementationEntity.RowVersion;
                }
                private static void _RowVersion_SetImplementationValue(global::LightSwitchApplication.Anbieter.DetailsClass d, byte[] v)
                {
                    d.ImplementationEntity.RowVersion = v;
                }
                private static void _RowVersion_OnValueChanged(global::LightSwitchApplication.Anbieter e)
                {
                    e.RowVersion_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, string>.Entry
                    Bezeichnung = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, string>.Entry(
                        "Bezeichnung",
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Bezeichnung_Stub,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Bezeichnung_ComputeIsReadOnly,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Bezeichnung_Validate,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Bezeichnung_GetImplementationValue,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Bezeichnung_SetImplementationValue,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Bezeichnung_OnValueChanged);
                private static void _Bezeichnung_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Anbieter.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, string>.Data> c, global::LightSwitchApplication.Anbieter.DetailsClass d, object sf)
                {
                    c(d, ref d._Bezeichnung, sf);
                }
                private static bool _Bezeichnung_ComputeIsReadOnly(global::LightSwitchApplication.Anbieter e)
                {
                    bool result = false;
                    e.Bezeichnung_IsReadOnly(ref result);
                    return result;
                }
                private static void _Bezeichnung_Validate(global::LightSwitchApplication.Anbieter e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Bezeichnung_Validate(r);
                }
                private static string _Bezeichnung_GetImplementationValue(global::LightSwitchApplication.Anbieter.DetailsClass d)
                {
                    return d.ImplementationEntity.Bezeichnung;
                }
                private static void _Bezeichnung_SetImplementationValue(global::LightSwitchApplication.Anbieter.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Bezeichnung = v;
                }
                private static void _Bezeichnung_OnValueChanged(global::LightSwitchApplication.Anbieter e)
                {
                    e.Bezeichnung_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, string>.Entry
                    Email = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, string>.Entry(
                        "Email",
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Email_Stub,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Email_ComputeIsReadOnly,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Email_Validate,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Email_GetImplementationValue,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Email_SetImplementationValue,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Email_OnValueChanged);
                private static void _Email_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Anbieter.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, string>.Data> c, global::LightSwitchApplication.Anbieter.DetailsClass d, object sf)
                {
                    c(d, ref d._Email, sf);
                }
                private static bool _Email_ComputeIsReadOnly(global::LightSwitchApplication.Anbieter e)
                {
                    bool result = false;
                    e.Email_IsReadOnly(ref result);
                    return result;
                }
                private static void _Email_Validate(global::LightSwitchApplication.Anbieter e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Email_Validate(r);
                }
                private static string _Email_GetImplementationValue(global::LightSwitchApplication.Anbieter.DetailsClass d)
                {
                    return d.ImplementationEntity.Email;
                }
                private static void _Email_SetImplementationValue(global::LightSwitchApplication.Anbieter.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Email = v;
                }
                private static void _Email_OnValueChanged(global::LightSwitchApplication.Anbieter e)
                {
                    e.Email_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, global::LightSwitchApplication.ArtikelstammItem>.Entry
                    Artikelstamm = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, global::LightSwitchApplication.ArtikelstammItem>.Entry(
                        "Artikelstamm",
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Artikelstamm_Stub,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Artikelstamm_GetReferencedEntities,
                        global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties._Artikelstamm_GetEntityCollection);
                private static void _Artikelstamm_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Anbieter.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, global::LightSwitchApplication.ArtikelstammItem>.Data> c, global::LightSwitchApplication.Anbieter.DetailsClass d, object sf)
                {
                    c(d, ref d._Artikelstamm, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.ArtikelstammItem> _Artikelstamm_GetReferencedEntities(global::LightSwitchApplication.Anbieter.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.ArtikelstammItem, global::LightSwitchApplication.ArtikelstammItem.DetailsClass>(global::LightSwitchApplication.Anbieter.DetailsClass.PropertySetProperties.Artikelstamm, ref d._Artikelstamm);
                }
                private static global::System.Collections.IEnumerable _Artikelstamm_GetEntityCollection(global::LightSwitchApplication.Anbieter.DetailsClass d)
                {
                    return d.ImplementationEntity.Artikelstamm;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, byte[]>.Data _RowVersion;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, string>.Data _Bezeichnung;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, string>.Data _Email;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Anbieter, global::LightSwitchApplication.Anbieter.DetailsClass, global::LightSwitchApplication.ArtikelstammItem>.Data _Artikelstamm;
            
        }
    
        #endregion
    }
    
    #endregion
}
