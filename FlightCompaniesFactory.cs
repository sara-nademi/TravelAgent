using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using FlightCompanies.BusinessLayer.DataLayer;

namespace FlightCompanies.BusinessLayer
{
    public class FlightCompaniesFactory
    {

        #region data Members

        FlightCompaniesSql _dataObject = null;

        #endregion

        #region Constructor

        public FlightCompaniesFactory()
        {
            _dataObject = new FlightCompaniesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new FlightCompanies
        /// </summary>
        /// <param name="businessObject">FlightCompanies object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(FlightCompanies businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing FlightCompanies
        /// </summary>
        /// <param name="businessObject">FlightCompanies object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(FlightCompanies businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get FlightCompanies by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public FlightCompanies GetByPrimaryKey(FlightCompaniesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all FlightCompaniess
        /// </summary>
        /// <returns>list</returns>
        public List<FlightCompanies> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of FlightCompanies by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<FlightCompanies> GetAllBy(FlightCompanies.FlightCompaniesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(FlightCompaniesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete FlightCompanies by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(FlightCompanies.FlightCompaniesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
