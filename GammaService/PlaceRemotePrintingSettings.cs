//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GammaService
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlaceRemotePrintingSettings
    {
        public int PlaceID { get; set; }
        public Nullable<int> ModbusDeviceID { get; set; }
        public Nullable<int> RemotePrinterID { get; set; }
        public Nullable<int> SignalChannelNumber { get; set; }
        public Nullable<int> ConfirmChannelNumber { get; set; }
    
        public virtual ModbusDevices ModbusDevices { get; set; }
        public virtual RemotePrinters RemotePrinters { get; set; }
    }
}