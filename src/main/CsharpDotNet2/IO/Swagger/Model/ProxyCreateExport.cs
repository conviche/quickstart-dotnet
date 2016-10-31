using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ProxyCreateExport {
    /// <summary>
    ///  The currencies that you want to convert transaction amounts into. You can specify any number of currencies. Specify the currencies using their [Foreign Currency Conversion](https://knowledgecenter.zuora.com/CC_Finance/Foreign_Currency_Conversion) enabled to use this field. **Character limit**: **Values**: a list of valid currency codes 
    /// </summary>
    /// <value> The currencies that you want to convert transaction amounts into. You can specify any number of currencies. Specify the currencies using their [Foreign Currency Conversion](https://knowledgecenter.zuora.com/CC_Finance/Foreign_Currency_Conversion) enabled to use this field. **Character limit**: **Values**: a list of valid currency codes </value>
    [DataMember(Name="ConvertToCurrencies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConvertToCurrencies")]
    public string ConvertToCurrencies { get; set; }

    /// <summary>
    ///  Exports a secure version of encrypted data source fields. such as the AchAccountNumber field of the PaymentMethod object and the DefaultPaymentMethod data souce objects. **Character limit**: 5 **Values:** true, false 
    /// </summary>
    /// <value> Exports a secure version of encrypted data source fields. such as the AchAccountNumber field of the PaymentMethod object and the DefaultPaymentMethod data souce objects. **Character limit**: 5 **Values:** true, false </value>
    [DataMember(Name="Encrypted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>
    ///  The ID of the file generated by an export query. This fiel is automatically generated when an Export object is created. Use this file ID when you download the export file. **Character limit**: 32 **Values**: automatically generated 
    /// </summary>
    /// <value> The ID of the file generated by an export query. This fiel is automatically generated when an Export object is created. Use this file ID when you download the export file. **Character limit**: 32 **Values**: automatically generated </value>
    [DataMember(Name="FileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FileId")]
    public string FileId { get; set; }

    /// <summary>
    ///  The format that you want the export file to use. **Character limit**: 4 **Values**: csv, html 
    /// </summary>
    /// <value> The format that you want the export file to use. **Character limit**: 4 **Values**: csv, html </value>
    [DataMember(Name="Format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Format")]
    public string Format { get; set; }

    /// <summary>
    ///  The name of the export. **Character limit**: 255 **Values**: a string of 255 characters or fewer 
    /// </summary>
    /// <value> The name of the export. **Character limit**: 255 **Values**: a string of 255 characters or fewer </value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// optional
    /// </summary>
    /// <value>optional</value>
    [DataMember(Name="Query", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Query")]
    public string Query { get; set; }

    /// <summary>
    ///  The number of records or rows exported. This field value is null until the export status is Completed. **Character limit**: **Values**: automatically generated 
    /// </summary>
    /// <value> The number of records or rows exported. This field value is null until the export status is Completed. **Character limit**: **Values**: automatically generated </value>
    [DataMember(Name="Size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Size")]
    public int? Size { get; set; }

    /// <summary>
    ///  The status of the export. Type: string (enum) **Character limit**: 10 **Values**: automatically generated to be one of the following values:  - Pending - Processing - Completed - Canceled - Failed 
    /// </summary>
    /// <value> The status of the export. Type: string (enum) **Character limit**: 10 **Values**: automatically generated to be one of the following values:  - Pending - Processing - Completed - Canceled - Failed </value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    ///  The reason for the given status. Use this information to help ascertain why an export failed. **Character limi**t: 255 **Values**: automatically generated 
    /// </summary>
    /// <value> The reason for the given status. Use this information to help ascertain why an export failed. **Character limi**t: 255 **Values**: automatically generated </value>
    [DataMember(Name="StatusReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StatusReason")]
    public string StatusReason { get; set; }

    /// <summary>
    ///  Indicates if you want the resulting export file to be compressed into a zip file. **Character limit**: **Values**: true, false (default) 
    /// </summary>
    /// <value> Indicates if you want the resulting export file to be compressed into a zip file. **Character limit**: **Values**: true, false (default) </value>
    [DataMember(Name="Zip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Zip")]
    public bool? Zip { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProxyCreateExport {\n");
      sb.Append("  ConvertToCurrencies: ").Append(ConvertToCurrencies).Append("\n");
      sb.Append("  Encrypted: ").Append(Encrypted).Append("\n");
      sb.Append("  FileId: ").Append(FileId).Append("\n");
      sb.Append("  Format: ").Append(Format).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Query: ").Append(Query).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  StatusReason: ").Append(StatusReason).Append("\n");
      sb.Append("  Zip: ").Append(Zip).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}