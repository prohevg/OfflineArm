﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OfflineARM.Controller.Validators {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ValidatorResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ValidatorResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OfflineARM.Controller.Validators.ValidatorResources", typeof(ValidatorResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Наименование характеристики не может быть пустым!.
        /// </summary>
        internal static string CharacteristicValidator_NameIsNull {
            get {
                return ResourceManager.GetString("CharacteristicValidator_NameIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Не найден объект с Id=&quot;{0}&quot;!.
        /// </summary>
        internal static string CommonErrors_EntityUpdateNotFound {
            get {
                return ResourceManager.GetString("CommonErrors_EntityUpdateNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Не создана модель!.
        /// </summary>
        internal static string CommonErrors_ModelIsNull {
            get {
                return ResourceManager.GetString("CommonErrors_ModelIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Наименование номенклатуры не может быть пустым!.
        /// </summary>
        internal static string NomenclatureValidator_NameIsNull {
            get {
                return ResourceManager.GetString("NomenclatureValidator_NameIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Не указан покупатель!.
        /// </summary>
        internal static string OrderValidator_CustomerIsNull {
            get {
                return ResourceManager.GetString("OrderValidator_CustomerIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Не указана дата доставки!.
        /// </summary>
        internal static string OrderValidator_DeliveryDateIsNull {
            get {
                return ResourceManager.GetString("OrderValidator_DeliveryDateIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Не указан адрес доставки!.
        /// </summary>
        internal static string OrderValidator_DeliveryIsNull {
            get {
                return ResourceManager.GetString("OrderValidator_DeliveryIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Не указана спецификация в заказе!.
        /// </summary>
        internal static string OrderValidator_OrderSpecificationsIsNull {
            get {
                return ResourceManager.GetString("OrderValidator_OrderSpecificationsIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Минимальная оплата заказа 30%!.
        /// </summary>
        internal static string OrderValidator_PaymentLess30 {
            get {
                return ResourceManager.GetString("OrderValidator_PaymentLess30", resourceCulture);
            }
        }
    }
}
