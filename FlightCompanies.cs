using System;
using System.Collections.Generic;
using System.Text;
namespace FlightCompanies.BusinessLayer
{
	public class FlightCompanies: BusinessObjectBase
	{

		#region InnerClass
		public enum FlightCompaniesFields
		{
			CompanyCode,
			CompanyName
		}
		#endregion

		#region Data Members

			int _companyCode;
			string _companyName;

		#endregion

		#region Properties

		public int  CompanyCode
		{
			 get { return _companyCode; }
			 set
			 {
				 if (_companyCode != value)
				 {
					_companyCode = value;
					 PropertyHasChanged("CompanyCode");
				 }
			 }
		}

		public string  CompanyName
		{
			 get { return _companyName; }
			 set
			 {
				 if (_companyName != value)
				 {
					_companyName = value;
					 PropertyHasChanged("CompanyName");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CompanyCode", "CompanyCode"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CompanyName", "CompanyName"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CompanyName", "CompanyName",60));
		}

		#endregion

	}
}
