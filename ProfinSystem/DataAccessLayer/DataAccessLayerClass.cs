using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataAccessLayerClass
{
    public class DataAccessLayerClass
    {
        string connectionString = @"Data Source=PFS-SERVER\PFSLOCAL; Network Library=DBMSSOCN; Initial Catalog=ProfinCRM;User ID=Test;Password=pfs";
        //string smsDatabaseconnectionString = @"Data Source=192.168.10.1; Network Library=DBMSSOCN; Initial Catalog=ProfinSMS;User ID=Test;Password=pfs";

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DataAccessLayerClass()
        {
            // connectionString = @"Data Source=PFS-SERVER\PFSLOCAL; Network Library=DBMSSOCN; Initial Catalog=ProfinDatabaseTesting;User ID=Test;Password=pfs";
        }

        #region Insert Employee
        public int InsertEmployee(EmployeeClass emp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmdSaveEmp = new SqlCommand("INSERT INTO Employee(EmpID, DepartmentID, RaceID, QualificationID, CompanyID, OccDescID, FirstName, LastName, Address, DateOfBirth, Gender, Cell, HomeTel, Email, JobTitle, AppointDate, TerminationDate, HourlyRate, UserName, UserPassword, Fais, AgeGroup,Citizenship, Region, Suburb, Town, PostalCode) VALUES(@EmpID, @DepartmentID, @RaceID, @QualificationID, @CompanyID, @OccDescID, @FirstName, @LastName, @Address, @DateOfBirth, @Gender, @Cell, @HomeTel, @Email, @JobTitle, @AppointDate, @TerminationDate, @HourlyRate, @UserName, @UserPassword, @Fais, @AgeGroup, @Citizenship, @Region, @Suburb, @Town, @PostalCode)", conn);

                cmdSaveEmp.Parameters.Add(new SqlParameter("@EmpID", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@EmpID"].Value = emp.EmpID;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@DepartmentID", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@DepartmentID"].Value = emp.DepartmentID;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@RaceID", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@RaceID"].Value = emp.RaceID;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@QualificationID", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@QualificationID"].Value = emp.QualificationID;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@CompanyID", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@CompanyID"].Value = emp.CompanyID;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@OccDescID", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@OccDescID"].Value = emp.OccDescID;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@FirstName"].Value = emp.FirstName;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@LastName", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@LastName"].Value = emp.LastName;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@Address", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@Address"].Value = emp.Address;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@DateOfBirth", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@DateOfBirth"].Value = emp.DateOfBirth;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@Gender", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@Gender"].Value = emp.Gender;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@Cell", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@Cell"].Value = emp.Cell;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@HomeTel", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@HomeTel"].Value = emp.HomeTel;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@Email", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@Email"].Value = emp.Email;


                cmdSaveEmp.Parameters.Add(new SqlParameter("@JobTitle", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@JobTitle"].Value = emp.JobTitle;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@AppointDate", System.Data.SqlDbType.Date));
                cmdSaveEmp.Parameters["@AppointDate"].Value = emp.AppointDate;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@TerminationDate", System.Data.SqlDbType.Date));
                cmdSaveEmp.Parameters["@TerminationDate"].Value = emp.TerminationDate;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@HourlyRate", System.Data.SqlDbType.Float));
                cmdSaveEmp.Parameters["@HourlyRate"].Value = emp.HourlyRate;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@UserName", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@UserName"].Value = emp.UserName;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@UserPassword", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@UserPassword"].Value = emp.UserPassword;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@Fais", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@Fais"].Value = emp.Fais;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@AgeGroup", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@AgeGroup"].Value = emp.AgeGroup;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@Citizenship", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@Citizenship"].Value = emp.Citizenship;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@Region", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@Region"].Value = emp.Region;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@Suburb", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@Suburb"].Value = emp.Suburb;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@Town", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@Town"].Value = emp.Town;

                cmdSaveEmp.Parameters.Add(new SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar));
                cmdSaveEmp.Parameters["@PostalCode"].Value = emp.PostalCode;

                try
                {
                    conn.Open();
                    return cmdSaveEmp.ExecuteNonQuery();
                }

                catch (SqlException ex)
                {
                    throw new ApplicationException("Error saving SMS" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion Insert Employee

        #region Insert Department
        public int InsertDepartment(DepartmentClass dept)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmdDept = new SqlCommand("INSERT INTO Department(DepartmentID, DepartmentName) VALUES(@DeptID, @DeptName)", conn);

                cmdDept.Parameters.Add(new SqlParameter("@DeptID", System.Data.SqlDbType.NVarChar));
                cmdDept.Parameters["@DeptID"].Value = dept.DepartmentID;

                cmdDept.Parameters.Add(new SqlParameter("@DeptName", System.Data.SqlDbType.NVarChar));
                cmdDept.Parameters["@DeptName"].Value = dept.DepartmentName;

                try
                {
                    conn.Open();
                    return cmdDept.ExecuteNonQuery();
                }

                catch (SqlException ex)
                {
                    throw new ApplicationException("Error inserting department" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion Insert Department

        #region Insert HighestQualification
        public int InsertHighestQualification(HighestQualificationClass dept)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmdQual = new SqlCommand("INSERT INTO HighestQualification(QualificationID, QualificationName) VALUES(@QualID, @QualName)", conn);

                cmdQual.Parameters.Add(new SqlParameter("@QualID", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@QualID"].Value = dept.QualificationID;

                cmdQual.Parameters.Add(new SqlParameter("@QualName", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@QualName"].Value = dept.QualifiactionName;

                try
                {
                    conn.Open();
                    return cmdQual.ExecuteNonQuery();
                }

                catch (SqlException ex)
                {
                    throw new ApplicationException("Error inserting Qualification\n\n" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion Insert HighestQualification

        #region Insert Company
        public int InsertCompany(CompanyClass comp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmdQual = new SqlCommand("INSERT INTO Company(CompanyID, CompanyName, RegistrationNum, FspNum, Title, FirstName, Surname, Initials, Designation, PhoneNo, FaxNo, CellNo, Email, Address, Region, Suburb, Town, PostalCode) VALUES(@CompanyID, @CompanyName, @RegistrationNum, @FspNum, @Title, @FirstName, @Surname, @Initials, @Designation, @PhoneNo, @FaxNo, @CellNo, @Email, @Address, @Region, @Suburb, @Town, @PostalCode)", conn);

                cmdQual.Parameters.Add(new SqlParameter("@CompanyID", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@CompanyID"].Value = comp.CompanyID;

                cmdQual.Parameters.Add(new SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@CompanyName"].Value = comp.CompanyName;

                cmdQual.Parameters.Add(new SqlParameter("@RegistrationNum", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@RegistrationNum"].Value = comp.RegistrationNum;

                cmdQual.Parameters.Add(new SqlParameter("@FspNum", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@FspNum"].Value = comp.FspNum;

                cmdQual.Parameters.Add(new SqlParameter("@Title", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@Title"].Value = comp.Title;

                cmdQual.Parameters.Add(new SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@FirstName"].Value = comp.FirstName;

                cmdQual.Parameters.Add(new SqlParameter("@Surname", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@Surname"].Value = comp.Surname;

                cmdQual.Parameters.Add(new SqlParameter("@Initials", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@Initials"].Value = comp.Initials;

                cmdQual.Parameters.Add(new SqlParameter("@Designation", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@Designation"].Value = comp.Designation;

                cmdQual.Parameters.Add(new SqlParameter("@PhoneNo", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@PhoneNo"].Value = comp.PhoneNo;

                cmdQual.Parameters.Add(new SqlParameter("@FaxNo", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@FaxNo"].Value = comp.FaxNo;

                cmdQual.Parameters.Add(new SqlParameter("@CellNo", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@CellNo"].Value = comp.CellNo;

                cmdQual.Parameters.Add(new SqlParameter("@Email", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@Email"].Value = comp.Email;

                cmdQual.Parameters.Add(new SqlParameter("@Address", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@Address"].Value = comp.Address;

                cmdQual.Parameters.Add(new SqlParameter("@Region", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@Region"].Value = comp.Region;

                cmdQual.Parameters.Add(new SqlParameter("@Suburb", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@Suburb"].Value = comp.Suburb;

                cmdQual.Parameters.Add(new SqlParameter("@Town", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@Town"].Value = comp.Town;
                
                cmdQual.Parameters.Add(new SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar));
                cmdQual.Parameters["@PostalCode"].Value = comp.PostalCode;
                try
                {
                    conn.Open();
                    return cmdQual.ExecuteNonQuery();
                }

                catch (SqlException ex)
                {
                    throw new ApplicationException("Error adding Company\n\n" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion Insert Company

    }
}
