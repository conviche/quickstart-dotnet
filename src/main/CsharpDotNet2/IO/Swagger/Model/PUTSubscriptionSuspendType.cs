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
  public class PUTSubscriptionSuspendType {
    /// <summary>
    /// Applies a credit balance to an invoice.  If the value is `true`, the credit balance is applied to the invoice. If the value is `false`, no action is taken.  Prerequisite: `invoice` must be `true`.   To view the credit balance adjustment, retrieve the details of the invoice using the Get Invoices method. 
    /// </summary>
    /// <value>Applies a credit balance to an invoice.  If the value is `true`, the credit balance is applied to the invoice. If the value is `false`, no action is taken.  Prerequisite: `invoice` must be `true`.   To view the credit balance adjustment, retrieve the details of the invoice using the Get Invoices method. </value>
    [DataMember(Name="applyCreditBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applyCreditBalance")]
    public bool? ApplyCreditBalance { get; set; }

    /// <summary>
    /// Collects an automatic payment for a subscription. The collection generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, the automatic payment is collected. If the value is `false`, no action is taken.  The default value is `false`.  Prerequisite: `invoice` must be `true`.   **Note:** This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` field to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. 
    /// </summary>
    /// <value>Collects an automatic payment for a subscription. The collection generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, the automatic payment is collected. If the value is `false`, no action is taken.  The default value is `false`.  Prerequisite: `invoice` must be `true`.   **Note:** This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` field to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. </value>
    [DataMember(Name="collect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collect")]
    public bool? Collect { get; set; }

    /// <summary>
    /// The date when the customer notifies you that they want to amend their subscription. 
    /// </summary>
    /// <value>The date when the customer notifies you that they want to amend their subscription. </value>
    [DataMember(Name="contractEffectiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractEffectiveDate")]
    public DateTime? ContractEffectiveDate { get; set; }

    /// <summary>
    /// Whether to extend the subscription term by the length of time the suspension is in effect. Values: `true`, `false`. 
    /// </summary>
    /// <value>Whether to extend the subscription term by the length of time the suspension is in effect. Values: `true`, `false`. </value>
    [DataMember(Name="extendsTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extendsTerm")]
    public bool? ExtendsTerm { get; set; }

    /// <summary>
    /// Creates an invoice for a subscription. The invoice generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, an invoice is created. If the value is `false`, no action is taken. The default value is `false`.   **Note:** This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` field to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. 
    /// </summary>
    /// <value>Creates an invoice for a subscription. The invoice generated in this operation is only for this subscription, not for the entire customer account.  If the value is `true`, an invoice is created. If the value is `false`, no action is taken. The default value is `false`.   **Note:** This field is in Zuora REST API version control. Supported minor versions are 196.0 or later. To use this field in the method, you must set the `zuora-version` field to the minor version number in the request header. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. </value>
    [DataMember(Name="invoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice")]
    public bool? Invoice { get; set; }

    /// <summary>
    /// **Note:** This field has been replaced by the `invoice` field and the `collect` field. `invoiceCollect` is available only for backward compatibility.  This field is in Zuora REST API version control. Supported minor versions are 186.0, 187.0, 188.0, 189.0, and 196.0. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. 
    /// </summary>
    /// <value>**Note:** This field has been replaced by the `invoice` field and the `collect` field. `invoiceCollect` is available only for backward compatibility.  This field is in Zuora REST API version control. Supported minor versions are 186.0, 187.0, 188.0, 189.0, and 196.0. See [Zuora REST API Versions](https://knowledgecenter.zuora.com/DC_Developers/REST_API/A_REST_basics#Zuora_REST_API_Versions) for more information. </value>
    [DataMember(Name="invoiceCollect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceCollect")]
    public bool? InvoiceCollect { get; set; }

    /// <summary>
    /// If an invoice is to be generated, the date through which to calculate the charges, as yyyy-mm-dd. 
    /// </summary>
    /// <value>If an invoice is to be generated, the date through which to calculate the charges, as yyyy-mm-dd. </value>
    [DataMember(Name="invoiceTargetDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceTargetDate")]
    public DateTime? InvoiceTargetDate { get; set; }

    /// <summary>
    /// Whether to set when to resume a subscription when creating a suspend amendment. Values: `true`, `false`. 
    /// </summary>
    /// <value>Whether to set when to resume a subscription when creating a suspend amendment. Values: `true`, `false`. </value>
    [DataMember(Name="resume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resume")]
    public bool? Resume { get; set; }

    /// <summary>
    /// The length of the period used to specify when the subscription is resumed. The subscription resumption takes effect after a specified period based on the suspend date or today's date. You must use this field together with the `resumePeriodsType` field to specify the period.  **Note:** This field is only applicable when the `suspendPolicy` field is set to `FixedPeriodsFromToday` or `FixedPeriodsFromSuspendDate`. 
    /// </summary>
    /// <value>The length of the period used to specify when the subscription is resumed. The subscription resumption takes effect after a specified period based on the suspend date or today's date. You must use this field together with the `resumePeriodsType` field to specify the period.  **Note:** This field is only applicable when the `suspendPolicy` field is set to `FixedPeriodsFromToday` or `FixedPeriodsFromSuspendDate`. </value>
    [DataMember(Name="resumePeriods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resumePeriods")]
    public string ResumePeriods { get; set; }

    /// <summary>
    /// The period type used to define when the subscription resumption takes effect. The subscription resumption takes effect after a specified period based on the suspend date or today's date. You must use this field together with the resumePeriods field to specify the period.  Values: `Day`, `Week`, `Month`, `Year`  **Note:** This field is only applicable when the `suspendPolicy` field is set to `FixedPeriodsFromToday` or `FixedPeriodsFromSuspendDate`. 
    /// </summary>
    /// <value>The period type used to define when the subscription resumption takes effect. The subscription resumption takes effect after a specified period based on the suspend date or today's date. You must use this field together with the resumePeriods field to specify the period.  Values: `Day`, `Week`, `Month`, `Year`  **Note:** This field is only applicable when the `suspendPolicy` field is set to `FixedPeriodsFromToday` or `FixedPeriodsFromSuspendDate`. </value>
    [DataMember(Name="resumePeriodsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resumePeriodsType")]
    public string ResumePeriodsType { get; set; }

    /// <summary>
    /// Resume methods. Specify a way to resume a subscription. See [Resume Date](https://knowledgecenter.zuora.com/BC_Subscription_Management/Subscriptions/Resume_a_Subscription#Resume_Date) for more information.  Values:  * `Today`: The subscription resumption takes effect on today's date.  * `FixedPeriodsFromSuspendDate`: The subscription resumption takes effect after a specified period based on the suspend date. You must specify the `resumePeriods` and `resumePeriodsType` fields to define the period.  * `SpecificDate`: The subscription resumption takes effect on a specific date. You must define the specific date in the `resumeSpecificDate` field.  * `FixedPeriodsFromToday`: The subscription resumption takes effect after a specified period based on the today's date. You must specify the `resumePeriods` and `resumePeriodsType` fields to define the period. 
    /// </summary>
    /// <value>Resume methods. Specify a way to resume a subscription. See [Resume Date](https://knowledgecenter.zuora.com/BC_Subscription_Management/Subscriptions/Resume_a_Subscription#Resume_Date) for more information.  Values:  * `Today`: The subscription resumption takes effect on today's date.  * `FixedPeriodsFromSuspendDate`: The subscription resumption takes effect after a specified period based on the suspend date. You must specify the `resumePeriods` and `resumePeriodsType` fields to define the period.  * `SpecificDate`: The subscription resumption takes effect on a specific date. You must define the specific date in the `resumeSpecificDate` field.  * `FixedPeriodsFromToday`: The subscription resumption takes effect after a specified period based on the today's date. You must specify the `resumePeriods` and `resumePeriodsType` fields to define the period. </value>
    [DataMember(Name="resumePolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resumePolicy")]
    public string ResumePolicy { get; set; }

    /// <summary>
    /// A specific date when the subscription resumption takes effect, in the format yyyy-mm-dd.  **Note:** This field is only applicable only when the `resumePolicy` field is set to `SpecificDate`.  The value should not be earlier than the subscription suspension date. 
    /// </summary>
    /// <value>A specific date when the subscription resumption takes effect, in the format yyyy-mm-dd.  **Note:** This field is only applicable only when the `resumePolicy` field is set to `SpecificDate`.  The value should not be earlier than the subscription suspension date. </value>
    [DataMember(Name="resumeSpecificDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resumeSpecificDate")]
    public DateTime? ResumeSpecificDate { get; set; }

    /// <summary>
    /// The length of the period used to specify when the subscription suspension takes effect. The subscription suspension takes effect after a specified period based on today's date. You must use this field together with the `suspendPeriodsType` field to specify the period.  **Note:** This field is only applicable only when the suspendPolicy field is set to FixedPeriodsFromToday. 
    /// </summary>
    /// <value>The length of the period used to specify when the subscription suspension takes effect. The subscription suspension takes effect after a specified period based on today's date. You must use this field together with the `suspendPeriodsType` field to specify the period.  **Note:** This field is only applicable only when the suspendPolicy field is set to FixedPeriodsFromToday. </value>
    [DataMember(Name="suspendPeriods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suspendPeriods")]
    public string SuspendPeriods { get; set; }

    /// <summary>
    /// The period type used to define when the subscription suspension takes effect. The subscription suspension takes effect after a specified period based on today's date. You must use this field together with the suspendPeriods field to specify the period.  Type: string (enum)  Values: `Day`, `Week`, `Month`, `Year`  **Note:** This field is only applicable only when the suspendPolicy field is set to FixedPeriodsFromToday. 
    /// </summary>
    /// <value>The period type used to define when the subscription suspension takes effect. The subscription suspension takes effect after a specified period based on today's date. You must use this field together with the suspendPeriods field to specify the period.  Type: string (enum)  Values: `Day`, `Week`, `Month`, `Year`  **Note:** This field is only applicable only when the suspendPolicy field is set to FixedPeriodsFromToday. </value>
    [DataMember(Name="suspendPeriodsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suspendPeriodsType")]
    public string SuspendPeriodsType { get; set; }

    /// <summary>
    /// Suspend methods. Specify a way to suspend a subscription. See [Suspend Date](https://knowledgecenter.zuora.com/BC_Subscription_Management/Subscriptions/Suspend_a_Subscription#Suspend_Date) for more information.  Value:  * `Today`: The subscription suspension takes effect on today's date. * `EndOfLastInvoicePeriod`: The subscription suspension takes effect at the end of the last invoice period. The suspend date defaults to a date that is one day after the last invoiced period. You can choose this option to avoid any negative invoices (credits) issued back to the customer after the subscription suspension.  * `SpecificDate`: The subscription suspension takes effect on a specific date. You must define the specific date in the `suspendSpecificDate` field. * `FixedPeriodsFromToday`: The subscription suspension takes effect after a specified period based on today's date. You must specify the `suspendPeriods` and `suspendPeriodsType` fields to define the period. 
    /// </summary>
    /// <value>Suspend methods. Specify a way to suspend a subscription. See [Suspend Date](https://knowledgecenter.zuora.com/BC_Subscription_Management/Subscriptions/Suspend_a_Subscription#Suspend_Date) for more information.  Value:  * `Today`: The subscription suspension takes effect on today's date. * `EndOfLastInvoicePeriod`: The subscription suspension takes effect at the end of the last invoice period. The suspend date defaults to a date that is one day after the last invoiced period. You can choose this option to avoid any negative invoices (credits) issued back to the customer after the subscription suspension.  * `SpecificDate`: The subscription suspension takes effect on a specific date. You must define the specific date in the `suspendSpecificDate` field. * `FixedPeriodsFromToday`: The subscription suspension takes effect after a specified period based on today's date. You must specify the `suspendPeriods` and `suspendPeriodsType` fields to define the period. </value>
    [DataMember(Name="suspendPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suspendPolicy")]
    public string SuspendPolicy { get; set; }

    /// <summary>
    /// A specific date when the subscription suspension takes effect, in the format yyyy-mm-dd.  **Note:** This field is only applicable only when the suspendPolicy field is set to SpecificDate.  The value should not be earlier than the subscription contract effective date, later than the subscription term end date, or within a period for which the customer has been invoiced. 
    /// </summary>
    /// <value>A specific date when the subscription suspension takes effect, in the format yyyy-mm-dd.  **Note:** This field is only applicable only when the suspendPolicy field is set to SpecificDate.  The value should not be earlier than the subscription contract effective date, later than the subscription term end date, or within a period for which the customer has been invoiced. </value>
    [DataMember(Name="suspendSpecificDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suspendSpecificDate")]
    public DateTime? SuspendSpecificDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PUTSubscriptionSuspendType {\n");
      sb.Append("  ApplyCreditBalance: ").Append(ApplyCreditBalance).Append("\n");
      sb.Append("  Collect: ").Append(Collect).Append("\n");
      sb.Append("  ContractEffectiveDate: ").Append(ContractEffectiveDate).Append("\n");
      sb.Append("  ExtendsTerm: ").Append(ExtendsTerm).Append("\n");
      sb.Append("  Invoice: ").Append(Invoice).Append("\n");
      sb.Append("  InvoiceCollect: ").Append(InvoiceCollect).Append("\n");
      sb.Append("  InvoiceTargetDate: ").Append(InvoiceTargetDate).Append("\n");
      sb.Append("  Resume: ").Append(Resume).Append("\n");
      sb.Append("  ResumePeriods: ").Append(ResumePeriods).Append("\n");
      sb.Append("  ResumePeriodsType: ").Append(ResumePeriodsType).Append("\n");
      sb.Append("  ResumePolicy: ").Append(ResumePolicy).Append("\n");
      sb.Append("  ResumeSpecificDate: ").Append(ResumeSpecificDate).Append("\n");
      sb.Append("  SuspendPeriods: ").Append(SuspendPeriods).Append("\n");
      sb.Append("  SuspendPeriodsType: ").Append(SuspendPeriodsType).Append("\n");
      sb.Append("  SuspendPolicy: ").Append(SuspendPolicy).Append("\n");
      sb.Append("  SuspendSpecificDate: ").Append(SuspendSpecificDate).Append("\n");
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
