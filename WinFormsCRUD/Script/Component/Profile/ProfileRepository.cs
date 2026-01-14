using Microsoft.Data.SqlClient;
using System.Data;
using WinFormsCRUD.Script.Component.Core;
using WinFormsCRUD.Script.Component.Data;

namespace WinFormsCRUD.Script.Component.Profile;

public class ProfileRepository : ProcedureRepository
{
    public void SaveProfile(Employee user)
    {
        SqlParameter[] tempParams =
            {
                new SqlParameter("@UserID", SqlDbType.Int) { Value = user.UserID },
                new SqlParameter("@Firstname", SqlDbType.VarChar) { Value = user.FirstName },
                new SqlParameter("@Lastname", SqlDbType.VarChar) { Value = user.LastName },
            };

        ExecuteStoredProcedure(
            "sp_Profile_SAVE",
            onSuccess: () => {
                MessageBox.Show(
                    "Saving User Success",
                    "User Actions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                NotifyDataChanged();
            }, //Success

            onFailure: () => {
                MessageBox.Show(
                    "Saving User Failed",
                    "User Actions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }, //Failure
            tempParams //SqlParameters
        );
    }
    public void UpdateProfile(Employee user)
    {
        SqlParameter[] tempParams =
            {
                new SqlParameter("@UserID", SqlDbType.Int) { Value = user.UserID },
                new SqlParameter("@Firstname", SqlDbType.VarChar) { Value = user.FirstName },
                new SqlParameter("@Lastname", SqlDbType.VarChar) { Value = user.LastName },
            };

        ExecuteStoredProcedure(
            "sp_Profile_UPDATE",
            onSuccess: () => {
                MessageBox.Show(
                    "Updating User Success",
                    "User Actions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                NotifyDataChanged();
            }, //Success

            onFailure: () => {
                MessageBox.Show(
                    "Updating User Failed",
                    "User Actions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }, //Failure
            tempParams //SqlParameters
        );
    }

    public void DeleteProfile(Employee user)
    {
        SqlParameter[] tempParams =
            {
                new SqlParameter("@UserID", SqlDbType.Int) { Value = user.UserID },
                new SqlParameter("@Firstname", SqlDbType.VarChar) { Value = user.FirstName },
                new SqlParameter("@Lastname", SqlDbType.VarChar) { Value = user.LastName },
            };

        ExecuteStoredProcedure(
            "sp_Profile_DELETE",
            onSuccess: () => {
                MessageBox.Show(
                    "Deleting User Success",
                    "User Actions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                NotifyDataChanged();
            }, //Success

            onFailure: () => {
                MessageBox.Show(
                    "Deleting User Failed",
                    "User Actions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }, //Failure
            tempParams //SqlParameters
        );
    }

    public IReadOnlyCollection<Employee> GetAllProfile()
    {
        return ExecuteStoredProcedure("sp_GetAllProfile", reader =>
            new Employee(
                UserID: Convert.ToInt32(reader["UserID"]),
                FirstName: reader["FirstName"].ToString(),
                LastName: reader["LastName"].ToString()
            )
        );
    }
}
