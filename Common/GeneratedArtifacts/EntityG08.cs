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
    public sealed partial class BestellStatus : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initialisiert eine neue Instanz der Entität BestellStatus.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public BestellStatus()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public BestellStatus(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.BestellStatus> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.BestellStatus.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void BestellStatus_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void BestellStatus_AllowSaveWithErrors(ref bool result);
    
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
                return global::LightSwitchApplication.BestellStatus.DetailsClass.GetValue(this, global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.BestellStatus.DetailsClass.SetValue(this, global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.Id, value);
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
                return global::LightSwitchApplication.BestellStatus.DetailsClass.GetValue(this, global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.RowVersion);
            }
            set
            {
                global::LightSwitchApplication.BestellStatus.DetailsClass.SetValue(this, global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.RowVersion, value);
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
                return global::LightSwitchApplication.BestellStatus.DetailsClass.GetValue(this, global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.Bezeichnung);
            }
            set
            {
                global::LightSwitchApplication.BestellStatus.DetailsClass.SetValue(this, global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.Bezeichnung, value);
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
        public byte[] Bild
        {
            get
            {
                return global::LightSwitchApplication.BestellStatus.DetailsClass.GetValue(this, global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.Bild);
            }
            set
            {
                global::LightSwitchApplication.BestellStatus.DetailsClass.SetValue(this, global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.Bild, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bild_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bild_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bild_Changed();

        /// <summary>
        /// Keine modellierte Beschreibung verfügbar
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.Rechnungen> Rechnungen
        {
            get
            {
                return global::LightSwitchApplication.BestellStatus.DetailsClass.GetValue(this, global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.Rechnungen);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.Rechnungen> RechnungenQuery
        {
            get
            {
                return global::LightSwitchApplication.BestellStatus.DetailsClass.GetQuery(this, global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.Rechnungen);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.BestellStatus,
                global::LightSwitchApplication.BestellStatus.DetailsClass,
                global::LightSwitchApplication.BestellStatus.DetailsClass.IImplementation,
                global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass>.Entry
                __BestellStatusEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass>.Entry(
                    global::LightSwitchApplication.BestellStatus.DetailsClass.__BestellStatus_CreateNew,
                    global::LightSwitchApplication.BestellStatus.DetailsClass.__BestellStatus_Created,
                    global::LightSwitchApplication.BestellStatus.DetailsClass.__BestellStatus_AllowSaveWithErrors);
            private static global::LightSwitchApplication.BestellStatus __BestellStatus_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.BestellStatus> es)
            {
                return new global::LightSwitchApplication.BestellStatus(es);
            }
            private static void __BestellStatus_Created(global::LightSwitchApplication.BestellStatus e)
            {
                e.BestellStatus_Created();
            }
            private static bool __BestellStatus_AllowSaveWithErrors(global::LightSwitchApplication.BestellStatus e)
            {
                bool result = false;
                e.BestellStatus_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySet Properties
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
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, byte[]> RowVersion
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.RowVersion) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, byte[]>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, string> Bezeichnung
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.Bezeichnung) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, byte[]> Bild
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.Bild) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, byte[]>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, global::LightSwitchApplication.Rechnungen> Rechnungen
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.Rechnungen) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, global::LightSwitchApplication.Rechnungen>;
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
                new byte[] Bild { get; set; }
                new global::System.Collections.IEnumerable Rechnungen { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.BestellStatus.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, int>.Data> c, global::LightSwitchApplication.BestellStatus.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.BestellStatus e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.BestellStatus e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.BestellStatus.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.BestellStatus.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.BestellStatus e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, byte[]>.Entry
                    RowVersion = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, byte[]>.Entry(
                        "RowVersion",
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._RowVersion_Stub,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._RowVersion_Validate,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged);
                private static void _RowVersion_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.BestellStatus.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, byte[]>.Data> c, global::LightSwitchApplication.BestellStatus.DetailsClass d, object sf)
                {
                    c(d, ref d._RowVersion, sf);
                }
                private static bool _RowVersion_ComputeIsReadOnly(global::LightSwitchApplication.BestellStatus e)
                {
                    bool result = false;
                    e.RowVersion_IsReadOnly(ref result);
                    return result;
                }
                private static void _RowVersion_Validate(global::LightSwitchApplication.BestellStatus e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.RowVersion_Validate(r);
                }
                private static byte[] _RowVersion_GetImplementationValue(global::LightSwitchApplication.BestellStatus.DetailsClass d)
                {
                    return d.ImplementationEntity.RowVersion;
                }
                private static void _RowVersion_SetImplementationValue(global::LightSwitchApplication.BestellStatus.DetailsClass d, byte[] v)
                {
                    d.ImplementationEntity.RowVersion = v;
                }
                private static void _RowVersion_OnValueChanged(global::LightSwitchApplication.BestellStatus e)
                {
                    e.RowVersion_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, string>.Entry
                    Bezeichnung = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, string>.Entry(
                        "Bezeichnung",
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Bezeichnung_Stub,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Bezeichnung_ComputeIsReadOnly,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Bezeichnung_Validate,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Bezeichnung_GetImplementationValue,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Bezeichnung_SetImplementationValue,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Bezeichnung_OnValueChanged);
                private static void _Bezeichnung_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.BestellStatus.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, string>.Data> c, global::LightSwitchApplication.BestellStatus.DetailsClass d, object sf)
                {
                    c(d, ref d._Bezeichnung, sf);
                }
                private static bool _Bezeichnung_ComputeIsReadOnly(global::LightSwitchApplication.BestellStatus e)
                {
                    bool result = false;
                    e.Bezeichnung_IsReadOnly(ref result);
                    return result;
                }
                private static void _Bezeichnung_Validate(global::LightSwitchApplication.BestellStatus e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Bezeichnung_Validate(r);
                }
                private static string _Bezeichnung_GetImplementationValue(global::LightSwitchApplication.BestellStatus.DetailsClass d)
                {
                    return d.ImplementationEntity.Bezeichnung;
                }
                private static void _Bezeichnung_SetImplementationValue(global::LightSwitchApplication.BestellStatus.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Bezeichnung = v;
                }
                private static void _Bezeichnung_OnValueChanged(global::LightSwitchApplication.BestellStatus e)
                {
                    e.Bezeichnung_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, byte[]>.Entry
                    Bild = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, byte[]>.Entry(
                        "Bild",
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Bild_Stub,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Bild_ComputeIsReadOnly,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Bild_Validate,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Bild_GetImplementationValue,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Bild_SetImplementationValue,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Bild_OnValueChanged);
                private static void _Bild_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.BestellStatus.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, byte[]>.Data> c, global::LightSwitchApplication.BestellStatus.DetailsClass d, object sf)
                {
                    c(d, ref d._Bild, sf);
                }
                private static bool _Bild_ComputeIsReadOnly(global::LightSwitchApplication.BestellStatus e)
                {
                    bool result = false;
                    e.Bild_IsReadOnly(ref result);
                    return result;
                }
                private static void _Bild_Validate(global::LightSwitchApplication.BestellStatus e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Bild_Validate(r);
                }
                private static byte[] _Bild_GetImplementationValue(global::LightSwitchApplication.BestellStatus.DetailsClass d)
                {
                    return d.ImplementationEntity.Bild;
                }
                private static void _Bild_SetImplementationValue(global::LightSwitchApplication.BestellStatus.DetailsClass d, byte[] v)
                {
                    d.ImplementationEntity.Bild = v;
                }
                private static void _Bild_OnValueChanged(global::LightSwitchApplication.BestellStatus e)
                {
                    e.Bild_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, global::LightSwitchApplication.Rechnungen>.Entry
                    Rechnungen = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, global::LightSwitchApplication.Rechnungen>.Entry(
                        "Rechnungen",
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Rechnungen_Stub,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Rechnungen_GetReferencedEntities,
                        global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties._Rechnungen_GetEntityCollection);
                private static void _Rechnungen_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.BestellStatus.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, global::LightSwitchApplication.Rechnungen>.Data> c, global::LightSwitchApplication.BestellStatus.DetailsClass d, object sf)
                {
                    c(d, ref d._Rechnungen, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Rechnungen> _Rechnungen_GetReferencedEntities(global::LightSwitchApplication.BestellStatus.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.Rechnungen, global::LightSwitchApplication.Rechnungen.DetailsClass>(global::LightSwitchApplication.BestellStatus.DetailsClass.PropertySetProperties.Rechnungen, ref d._Rechnungen);
                }
                private static global::System.Collections.IEnumerable _Rechnungen_GetEntityCollection(global::LightSwitchApplication.BestellStatus.DetailsClass d)
                {
                    return d.ImplementationEntity.Rechnungen;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, byte[]>.Data _RowVersion;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, string>.Data _Bezeichnung;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, byte[]>.Data _Bild;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.BestellStatus, global::LightSwitchApplication.BestellStatus.DetailsClass, global::LightSwitchApplication.Rechnungen>.Data _Rechnungen;
            
        }
    
        #endregion
    }
    
    #endregion
}
