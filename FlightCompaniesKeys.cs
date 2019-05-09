using System;
using System.Collections.Generic;
using System.Text;
namespace FlightCompanies.BusinessLayer
{
	public class FlightCompaniesKeys
	{

		#region Data Members

		int _companyCode;

		#endregion

		#region Constructor

		public FlightCompaniesKeys(int companyCode)
		{
			 _companyCode = companyCode; 
		}

		#endregion

		#region Properties

		public int  CompanyCode
		{
			 get { return _companyCode; }
		}

		#endregion

	}
}
