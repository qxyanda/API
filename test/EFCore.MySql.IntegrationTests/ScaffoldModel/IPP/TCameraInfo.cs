using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TCameraInfo
    {
        public int Id { get; set; }
        public string CameraIndexCode { get; set; }
        public string CameraName { get; set; }
        public string CameraName3 { get; set; }
        public string ChannelNo { get; set; }
        public string Region { get; set; }
        public string Position { get; set; }
        public string Major { get; set; }
        public int? Manufacturer { get; set; }
        public int? CameraType { get; set; }
        public string CameraTypeName { get; set; }
        public string CapabilitySet { get; set; }
        public string Altitude { get; set; }
        public string CapabilitySetName { get; set; }
        public string IntelligentSet { get; set; }
        public string IntelligentSetName { get; set; }
        public string ChannelType { get; set; }
        public string ChannelTypeName { get; set; }
        public string EncodeDevIndexCode { get; set; }
        public string EncodeDevResourceType { get; set; }
        public string EncodeDevResourceTypeName { get; set; }
        public string GbIndexCode { get; set; }
        public string InstallLocation { get; set; }
        public string KeyBoardCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Pixel { get; set; }
        public string Ptz { get; set; }
        public string PtzName { get; set; }
        public string PtzController { get; set; }
        public string PtzControllerName { get; set; }
        public string RecordLocation { get; set; }
        public string RecordLocationName { get; set; }
        public string RegionIndexCode { get; set; }
        public string Statu { get; set; }
        public string StatusName { get; set; }
        public int? TransType { get; set; }
        public string TransTypeName { get; set; }
        public string TreatyType { get; set; }
        public string TreatyTypeName { get; set; }
        public string Viewshed { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
