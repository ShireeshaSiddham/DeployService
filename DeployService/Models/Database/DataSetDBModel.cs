using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

namespace DeployService.Models.Database
{
    public class DataSetDBModel
    {
        public List<dEmployees> GetEmployees()
        {
            try
            {
                DDataPolicyDataContext dc = new DDataPolicyDataContext();
                List<dEmployees> empList = new List<dEmployees>();
                var query = from Emp in dc.RefEmployees
                            select new
                            {
                                EmpID=Emp.EMPLOYEE_ID,
                                FName=Emp.FIRST_NAME,
                                LName=Emp.LAST_NAME,
                                Email=Emp.EMAIL
                            };
                foreach (var emp in query)
                {
                    empList.Add(new dEmployees()
                    {
                        EmpID=emp.EmpID,
                        FName=emp.FName,
                        LName=emp.LName,
                        Email=emp.Email
                    });
                }
                return empList;
            }
            catch (Exception ex)
            {
                ex.Data.Add("Connection_Error", "Could not connect to Database.");
                throw ex;
            }
        }

        public List<dMapAction> GetMappingActions()
        {
            try
            {
                DDataPolicyDataContext dc = new DDataPolicyDataContext();
                List<dMapAction> mapActionList = new List<dMapAction>();
                var query = from Map in dc.RefMapActions
                            select new
                            {
                                Action = Map.MAP_ACTION,
                                SourceTable = Map.SOURCE_TABLE,
                                SourceField = Map.SOURCE_FIELD,
                                Default = Map.DEFAULT,
                                MappingRule=Map.MAPPING_RULE
                            };
                foreach (var map in query)
                {
                    mapActionList.Add(new dMapAction()
                    {
                        MapAction = map.Action,
                        SourceTable = Convert.ToInt16(map.SourceTable),
                        SourceField = Convert.ToInt16(map.SourceField),
                        Default = Convert.ToInt16(map.Default)
                    });
                }
                return mapActionList;
            }
            catch (Exception ex)
            {
                ex.Data.Add("Connection_Error", "Could not connect to Database.");
                throw ex;
            }
        }

        public List<dObjectType> GetObjectTypes()
        {
            try
            {
                DDataPolicyDataContext dc = new DDataPolicyDataContext();
                List<dObjectType> objectTypeList = new List<dObjectType>();
                var query = from Object in dc.RefObjectTypes
                            select new
                            {
                                SortOrder = Object.SORT_ORDER,
                                ID = Object.OBJECT_TYPE_ID,
                                ObjectType = Object.OBJECT_TYPE,
                                PageID = Object.PAGE_ID,
                                URL = Object.URL
                            };
                foreach (var obj in query)
                {
                    objectTypeList.Add(new dObjectType()
                    {
                        SortOrder = obj.SortOrder,
                        ID= obj.ID,
                        ObjectType = obj.ObjectType,
                        PageID = (Guid) obj.PageID,
                    });
                }
                return objectTypeList;
            }
            catch (Exception ex)
            {
                ex.Data.Add("Connection_Error", "Could not connect to Database.");
                throw ex;
            }
        }

        public List<dPriorityCalc> GetPriorityCalc()
        {
            try
            {
                DDataPolicyDataContext dc = new DDataPolicyDataContext();
                List<dPriorityCalc> objectTypeList = new List<dPriorityCalc>();
                var query = from P in dc.RefPriorityCalculateds
                            select new
                            {
                                RequestVal = P.REQUEST_VALUE,
                                Effort = P.EFFORT,
                                CalculatedPriority = P.CALC_PRIORITY,                           
                            };
                foreach (var obj in query)
                {
                    objectTypeList.Add(new dPriorityCalc()
                    {
                        ReqVal = obj.RequestVal,
                        Effort = obj.Effort,
                        CalcPriority = (int)obj.CalculatedPriority,
                    });
                }
                return objectTypeList;
            }
            catch (Exception ex)
            {
                ex.Data.Add("Connection_Error", "Could not connect to Database.");
                throw ex;
            }
        }

        public List<dStakeholderDivision> GetStakeholderDivision()
        {
            try
            {
                DDataPolicyDataContext dc = new DDataPolicyDataContext();
                List<dStakeholderDivision> objectTypeList = new List<dStakeholderDivision>();
                var query = from P in dc.RefDataStakeholderDivisions
                            select new
                            {
                                Division = P.DIVISION,
                                CreatedBy = P.CREATED_BY,
                                CreatedOn = P.CREATED_ON,
                                ModifiedBy=P.MODIFIED_BY,
                                ModifiedOn=P.MODIFIED_ON
                            };
                foreach (var obj in query)
                {
                    objectTypeList.Add(new dStakeholderDivision()
                    {
                        Division = obj.Division,
                        CreatedBy = obj.CreatedBy,
                        CreatedOn = Convert.ToDateTime(obj.CreatedOn),
                        ModifiedBy = obj.ModifiedBy,
                        ModifiedOn = Convert.ToDateTime(obj.ModifiedOn)
                    });
                }
                return objectTypeList;
            }
            catch (Exception ex)
            {
                ex.Data.Add("Connection_Error", "Could not connect to Database.");
                throw ex;
            }
        }

        public List<dStakeholderDivision> GetStakeholderDept(string strDivision)
        {
            try
            {
                DDataPolicyDataContext dc = new DDataPolicyDataContext();
                List<dStakeholderDivision> objectTypeList = new List<dStakeholderDivision>();
                var query = from P in dc.RefDataStakeholderDepts.Where(k => k.DIVISION ==strDivision)
                            select new
                            {
                                Division = P.DIVISION,
                                Department=P.DEPARTMENT,
                                CreatedBy = P.CREATED_BY,
                                CreatedOn = P.CREATED_ON,
                                ModifiedBy = P.MODIFIED_BY,
                                ModifiedOn = P.MODIFIED_ON
                            };
                foreach (var obj in query)
                {
                    objectTypeList.Add(new dStakeholderDivision()
                    {
                        Division = obj.Division,
                        Dept=obj.Department,
                        CreatedBy = obj.CreatedBy,
                        CreatedOn = Convert.ToDateTime(obj.CreatedOn),
                        ModifiedBy = obj.ModifiedBy,
                        ModifiedOn = Convert.ToDateTime(obj.ModifiedOn)
                    });
                }
                return objectTypeList;
            }
            catch (Exception ex)
            {
                ex.Data.Add("Connection_Error", "Could not connect to Database.");
                throw ex;
            }
        }

    }
}