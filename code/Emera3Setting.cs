//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Пространство имен Sys.Services.Drv
namespace Sys.Services.Drv {
    using System;
    
    
    /// <summary/>
    public partial class Emera3SharedSetting : Sys.Encodeable.IEncodeableObject {
        
        /// <summary>
        /// Поле для свойства Забирать показания по тарифу 1
        /// </summary>
        private bool _enblcountertariff1 = false;
        
        /// <summary>
        /// Поле для свойства Забирать показания по тарифу 2
        /// </summary>
        private bool _enblcountertariff2 = false;
        
        /// <summary>
        /// Поле для свойства Забирать показания по тарифу 3
        /// </summary>
        private bool _enblcountertariff3 = false;
        
        /// <summary>
        /// Поле для свойства Забирать показания по тарифу 4
        /// </summary>
        private bool _enblcountertariff4 = false;
        
        /// <summary>
        /// Поле для свойства Забирать показания по тарифу 5
        /// </summary>
        private bool _enblcountertariff5 = false;
        
        /// <summary>
        /// Поле для свойства Забирать показания по тарифу 6
        /// </summary>
        private bool _enblcountertariff6 = false;
        
        /// <summary>
        /// Поле для свойства Забирать показания по тарифу 7
        /// </summary>
        private bool _enblcountertariff7 = false;
        
        /// <summary>
        /// Поле для свойства Забирать показания по тарифу 8
        /// </summary>
        private bool _enblcountertariff8 = false;
        
        /// <summary>
        /// Поле для свойства Опрос получасов. Если выключен, то запбирать только сутки и месяц.
        /// </summary>
        private bool _enbl30min = true;
        
        /// <summary>
        /// Поле для свойства Включить корректировку времени
        /// </summary>
        private bool _enbltimecorr = true;
        
        /// <summary>
        /// Поле для свойства Включить опрос событий
        /// </summary>
        private bool _enblevents = false;
        
        /// <summary>
        /// Поле для свойства Включить опрос мгновенных значений
        /// </summary>
        private bool _enblim = false;
        
        /// <summary>
        /// Поле для свойства Рассписание синхронизации архивных данных
        /// </summary>
        private Sys.Types.Components.ScheduleDbWrap _arch;
        
        /// <summary>
        /// Поле для свойства Рассписание чтения мгновенных значений
        /// </summary>
        private Sys.Types.Components.ScheduleDbWrap _im;
        
        /// <summary>
        /// Интернал конструктор
        /// </summary>
        internal Emera3SharedSetting(bool enblCounterTariff1, bool enblCounterTariff2, bool enblCounterTariff3, bool enblCounterTariff4, bool enblCounterTariff5, bool enblCounterTariff6, bool enblCounterTariff7, bool enblCounterTariff8, bool enbl30min, bool enblTimeCorr, bool enblEvents, bool enblIm, Sys.Types.Components.ScheduleDbWrap arch, Sys.Types.Components.ScheduleDbWrap im) {
            this.EnblCounterTariff1 = enblCounterTariff1;
            this.EnblCounterTariff2 = enblCounterTariff2;
            this.EnblCounterTariff3 = enblCounterTariff3;
            this.EnblCounterTariff4 = enblCounterTariff4;
            this.EnblCounterTariff5 = enblCounterTariff5;
            this.EnblCounterTariff6 = enblCounterTariff6;
            this.EnblCounterTariff7 = enblCounterTariff7;
            this.EnblCounterTariff8 = enblCounterTariff8;
            this.Enbl30min = enbl30min;
            this.EnblTimeCorr = enblTimeCorr;
            this.EnblEvents = enblEvents;
            this.EnblIm = enblIm;
            this.Arch = arch;
            this.Im = im;
        }
        
        /// <summary>
        /// Публичный конструктор
        /// </summary>
        public Emera3SharedSetting() {
        }
        
        /// <summary>
        /// Свойство Забирать показания по тарифу 1
        /// </summary>
        public virtual bool EnblCounterTariff1 {
            get {
                return _enblcountertariff1;
            }
            set {
                this._enblcountertariff1 = value;
            }
        }
        
        /// <summary>
        /// Свойство Забирать показания по тарифу 2
        /// </summary>
        public virtual bool EnblCounterTariff2 {
            get {
                return _enblcountertariff2;
            }
            set {
                this._enblcountertariff2 = value;
            }
        }
        
        /// <summary>
        /// Свойство Забирать показания по тарифу 3
        /// </summary>
        public virtual bool EnblCounterTariff3 {
            get {
                return _enblcountertariff3;
            }
            set {
                this._enblcountertariff3 = value;
            }
        }
        
        /// <summary>
        /// Свойство Забирать показания по тарифу 4
        /// </summary>
        public virtual bool EnblCounterTariff4 {
            get {
                return _enblcountertariff4;
            }
            set {
                this._enblcountertariff4 = value;
            }
        }
        
        /// <summary>
        /// Свойство Забирать показания по тарифу 5
        /// </summary>
        public virtual bool EnblCounterTariff5 {
            get {
                return _enblcountertariff5;
            }
            set {
                this._enblcountertariff5 = value;
            }
        }
        
        /// <summary>
        /// Свойство Забирать показания по тарифу 6
        /// </summary>
        public virtual bool EnblCounterTariff6 {
            get {
                return _enblcountertariff6;
            }
            set {
                this._enblcountertariff6 = value;
            }
        }
        
        /// <summary>
        /// Свойство Забирать показания по тарифу 7
        /// </summary>
        public virtual bool EnblCounterTariff7 {
            get {
                return _enblcountertariff7;
            }
            set {
                this._enblcountertariff7 = value;
            }
        }
        
        /// <summary>
        /// Свойство Забирать показания по тарифу 8
        /// </summary>
        public virtual bool EnblCounterTariff8 {
            get {
                return _enblcountertariff8;
            }
            set {
                this._enblcountertariff8 = value;
            }
        }
        
        /// <summary>
        /// Свойство Опрос получасов. Если выключен, то запбирать только сутки и месяц.
        /// </summary>
        public virtual bool Enbl30min {
            get {
                return _enbl30min;
            }
            set {
                this._enbl30min = value;
            }
        }
        
        /// <summary>
        /// Свойство Включить корректировку времени
        /// </summary>
        public virtual bool EnblTimeCorr {
            get {
                return _enbltimecorr;
            }
            set {
                this._enbltimecorr = value;
            }
        }
        
        /// <summary>
        /// Свойство Включить опрос событий
        /// </summary>
        public virtual bool EnblEvents {
            get {
                return _enblevents;
            }
            set {
                this._enblevents = value;
            }
        }
        
        /// <summary>
        /// Свойство Включить опрос мгновенных значений
        /// </summary>
        public virtual bool EnblIm {
            get {
                return _enblim;
            }
            set {
                this._enblim = value;
            }
        }
        
        /// <summary>
        /// Свойство Рассписание синхронизации архивных данных
        /// </summary>
        public virtual Sys.Types.Components.ScheduleDbWrap Arch {
            get {
                return _arch;
            }
            set {
                this._arch = value;
            }
        }
        
        /// <summary>
        /// Свойство Рассписание чтения мгновенных значений
        /// </summary>
        public virtual Sys.Types.Components.ScheduleDbWrap Im {
            get {
                return _im;
            }
            set {
                this._im = value;
            }
        }
        
        #region Encode
        /// <summary>
        /// Метод сериализации
        /// </summary>
        public virtual void Encode(Sys.Encodeable.IEncoderObject value) {
            value.PushNamespace("Sys.Services.Drv");
            value.WriteBoolean("EnblCounterTariff1", this.EnblCounterTariff1, false);
            value.WriteBoolean("EnblCounterTariff2", this.EnblCounterTariff2, false);
            value.WriteBoolean("EnblCounterTariff3", this.EnblCounterTariff3, false);
            value.WriteBoolean("EnblCounterTariff4", this.EnblCounterTariff4, false);
            value.WriteBoolean("EnblCounterTariff5", this.EnblCounterTariff5, false);
            value.WriteBoolean("EnblCounterTariff6", this.EnblCounterTariff6, false);
            value.WriteBoolean("EnblCounterTariff7", this.EnblCounterTariff7, false);
            value.WriteBoolean("EnblCounterTariff8", this.EnblCounterTariff8, false);
            value.WriteBoolean("Enbl30min", this.Enbl30min, true);
            value.WriteBoolean("EnblTimeCorr", this.EnblTimeCorr, true);
            value.WriteBoolean("EnblEvents", this.EnblEvents, false);
            value.WriteBoolean("EnblIm", this.EnblIm, false);
            value.WriteEncodeable<Sys.Types.Components.ScheduleDbWrap>("Arch", this.Arch);
            value.WriteEncodeable<Sys.Types.Components.ScheduleDbWrap>("Im", this.Im);
            value.PopNamespace();
        }
        #endregion
        
        /// <summary>
        /// Метод создания Emera3SharedSetting_CreateSys_Types_Components_ScheduleDbWrap
        /// </summary>
        private Sys.Types.Components.ScheduleDbWrap Emera3SharedSetting_CreateSys_Types_Components_ScheduleDbWrap() {
            return new Sys.Types.Components.ScheduleDbWrap();
        }
        
        #region Decode
        /// <summary>
        /// Метод сериализации
        /// </summary>
        public virtual void Decode(Sys.Encodeable.IDecoderObject value) {
            value.PushNamespace("Sys.Services.Drv");
            this.EnblCounterTariff1 = value.ReadBoolean("EnblCounterTariff1", false);
            this.EnblCounterTariff2 = value.ReadBoolean("EnblCounterTariff2", false);
            this.EnblCounterTariff3 = value.ReadBoolean("EnblCounterTariff3", false);
            this.EnblCounterTariff4 = value.ReadBoolean("EnblCounterTariff4", false);
            this.EnblCounterTariff5 = value.ReadBoolean("EnblCounterTariff5", false);
            this.EnblCounterTariff6 = value.ReadBoolean("EnblCounterTariff6", false);
            this.EnblCounterTariff7 = value.ReadBoolean("EnblCounterTariff7", false);
            this.EnblCounterTariff8 = value.ReadBoolean("EnblCounterTariff8", false);
            this.Enbl30min = value.ReadBoolean("Enbl30min", true);
            this.EnblTimeCorr = value.ReadBoolean("EnblTimeCorr", true);
            this.EnblEvents = value.ReadBoolean("EnblEvents", false);
            this.EnblIm = value.ReadBoolean("EnblIm", false);
            this.Arch = value.ReadEncodeableClass<Sys.Types.Components.ScheduleDbWrap>("Arch", this.Emera3SharedSetting_CreateSys_Types_Components_ScheduleDbWrap);
            this.Im = value.ReadEncodeableClass<Sys.Types.Components.ScheduleDbWrap>("Im", this.Emera3SharedSetting_CreateSys_Types_Components_ScheduleDbWrap);
            value.PopNamespace();
        }
        #endregion
    }
    
    /// <summary/>
    public partial class Emera3ContentSetting : Sys.Encodeable.IEncodeableObject {
        
        /// <summary>
        /// Поле для свойства Адресс прибора в сети
        /// </summary>
        private int _address;
        
        /// <summary>
        /// Поле для свойства Пароль по умолчанию
        /// </summary>
        private string _psw = "0000";
        
        /// <summary>
        /// Интернал конструктор
        /// </summary>
        internal Emera3ContentSetting(int address, string psw) {
            this.Address = address;
            this.Psw = psw;
        }
        
        /// <summary>
        /// Публичный конструктор
        /// </summary>
        public Emera3ContentSetting() {
        }
        
        /// <summary>
        /// Свойство Адресс прибора в сети
        /// </summary>
        public virtual int Address {
            get {
                return _address;
            }
            set {
                this._address = value;
            }
        }
        
        /// <summary>
        /// Свойство Пароль по умолчанию
        /// </summary>
        public virtual string Psw {
            get {
                return _psw;
            }
            set {
                this._psw = value;
            }
        }
        
        #region Encode
        /// <summary>
        /// Метод сериализации
        /// </summary>
        public virtual void Encode(Sys.Encodeable.IEncoderObject value) {
            value.PushNamespace("Sys.Services.Drv");
            value.WriteInt32("Address", this.Address);
            value.WriteString("Psw", this.Psw, "0000");
            value.PopNamespace();
        }
        #endregion
        
        #region Decode
        /// <summary>
        /// Метод сериализации
        /// </summary>
        public virtual void Decode(Sys.Encodeable.IDecoderObject value) {
            value.PushNamespace("Sys.Services.Drv");
            this.Address = value.ReadInt32("Address");
            this.Psw = value.ReadString("Psw", "0000");
            value.PopNamespace();
        }
        #endregion
    }
    
    /// <summary/>
    internal partial class Emera3SynchState : Sys.Encodeable.IEncodeableObject {
        
        /// <summary>
        /// Поле для свойства 
        /// </summary>
        private string _serialnumber;
        
        /// <summary>
        /// Интернал конструктор
        /// </summary>
        internal Emera3SynchState(string serialNumber) {
            this.SerialNumber = serialNumber;
        }
        
        /// <summary>
        /// Публичный конструктор
        /// </summary>
        public Emera3SynchState() {
        }
        
        /// <summary>
        /// Свойство 
        /// </summary>
        public virtual string SerialNumber {
            get {
                return _serialnumber;
            }
            set {
                this._serialnumber = value;
            }
        }
        
        #region Encode
        /// <summary>
        /// Метод сериализации
        /// </summary>
        public virtual void Encode(Sys.Encodeable.IEncoderObject value) {
            value.PushNamespace("Sys.Services.Drv");
            value.WriteString("SerialNumber", this.SerialNumber);
            value.PopNamespace();
        }
        #endregion
        
        #region Decode
        /// <summary>
        /// Метод сериализации
        /// </summary>
        public virtual void Decode(Sys.Encodeable.IDecoderObject value) {
            value.PushNamespace("Sys.Services.Drv");
            this.SerialNumber = value.ReadString("SerialNumber");
            value.PopNamespace();
        }
        #endregion
    }
}
