using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalLibrary
{
    public static class DBConnector
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["journal"].ConnectionString;

        #region GetUser
        public static bool GetUser(string username, string password)
        {
            bool isauthorised = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "user_login";
                    comm.Parameters.AddWithValue("@username", username);
                    comm.Parameters.AddWithValue("@password", password);
                    SqlParameter param = new SqlParameter("@isauthorised", SqlDbType.Bit);
                    comm.Parameters.Add(param).Direction = ParameterDirection.Output;

                    conn.Open();
                    comm.ExecuteNonQuery();
                    isauthorised = (bool)(param.Value);
                }
            }
            return isauthorised;
        }
        #endregion

        #region GetIfTeacherId
        public static int GetRoleID(string user_id)
        {
            DataTable role_id = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_role_by_user";
                    comm.Parameters.AddWithValue("user_id", user_id);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(role_id);
                }
            }
            DataRow dr = role_id.Rows[0];
            return int.Parse(dr["role_id"].ToString());
        }
        #endregion

        #region GetIfNoteAdded
        public static bool GetIfNoteAdded(int pupil_id,int subject_id,DateTime date)
        {
            bool res = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "check_pupil_subject_date_note";
                    comm.Parameters.AddWithValue("pupil_id", pupil_id);
                    comm.Parameters.AddWithValue("subject_id", subject_id);
                    comm.Parameters.AddWithValue("date", date);
                    SqlParameter resParam = new SqlParameter("@res", SqlDbType.Bit);
                    comm.Parameters.Add(resParam).Direction = ParameterDirection.Output;

                    conn.Open();
                    comm.ExecuteNonQuery();
                    res = (bool)resParam.Value;
                }
            }
            return res;
        }
#endregion

        #region GetTeacherIdByUserID
        public static int GetTeacherIdByUserID(string user_id)
        {
            string teacher_id;
            DataTable user = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_teacherid_by_userid";
                    comm.Parameters.AddWithValue("user_id", user_id);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(user);
                }
            }
            DataRow dr = user.Rows[0];

            return int.Parse(teacher_id = dr["teacher_id"].ToString());

            
        }
        #endregion

        #region GetClassesByTeacherID
        public static DataTable GetClassesByTeacherID(int teacher_id)
        {
            DataTable teacher = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "get_classes_by_teacher_id";
                    comm.Parameters.AddWithValue("@teacher_id", teacher_id);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(teacher);
                }
            }
            return teacher;
        }
        #endregion

        #region GetSubjectsByTeacherID
        public static DataTable GetSubjectsByTeacherID(int teacher_id)
        {
            DataTable teacher = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "get_subjects_by_teacher_id";
                    comm.Parameters.AddWithValue("@teacher_id", teacher_id);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(teacher);
                }
            }
            return teacher;
        }
        #endregion

        #region GetPupilsBySubjectIdAndClassCode
        public static DataTable GetPupilsBySubjectIdAndClassCode(int subject_id,int class_code)
        {
            DataTable pupils = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "get_pupils_by_subjectid_class_code";
                    comm.Parameters.AddWithValue("@subject_id", subject_id);
                    comm.Parameters.AddWithValue("@class_code", class_code);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(pupils);
                }
            }
            return pupils;
        }
        #endregion

        #region GetAcademicYearBySubjectIdAndClassCode
        public static DataTable GetAcademicYearBySubjectIdAndClassCode(int pupil_id,int subject_id, int class_code,int teacher_id,DateTime date)
        {
            DataTable pupils = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_academic_year";
                    comm.Parameters.AddWithValue("@subject_id", subject_id);
                    comm.Parameters.AddWithValue("@class_code", class_code);
                    comm.Parameters.AddWithValue("@pupil_id", pupil_id);
                    comm.Parameters.AddWithValue("@teacher_id", teacher_id);
                    comm.Parameters.AddWithValue("@date", date);


                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(pupils);
                }
            }
            return pupils;
        }
        #endregion

        #region GetAcademicYearByPupilID
        public static DataTable GetAcademicYearByPupilID(int pupil_id,int subject_id,DateTime date)
        {
            DataTable pupils = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "get_academicyear_by_pupilid";
                    comm.Parameters.AddWithValue("@pupil_id", pupil_id);
                    comm.Parameters.AddWithValue("@date", date);
                    comm.Parameters.AddWithValue("@subject_id", subject_id);


                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(pupils);
                }
            }
            return pupils;
        }
        #endregion

        #region GetAllAcademicYearByPupilID
        public static DataTable GetAllAcademicYearByPupilID(int pupil_id)
        {
            DataTable pupils = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "get_all_academicyear_by_pupilid";
                    comm.Parameters.AddWithValue("@pupil_id", pupil_id);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(pupils);
                }
            }
            return pupils;
        }
        #endregion

        #region SelectUsers
        public static DataTable SelectUsers()
        {
            DataTable users = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_user";
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(users);
                }
            }
            return users;
        }
        #endregion

        #region SelectTeachers
        public static DataTable SelectTeachers()
        {
            DataTable teacher = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_teacher";
                  
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(teacher);
                }
            }
            return teacher;
        }
        #endregion

        #region AddUser
        public static void AddUser(string user_id, string password, int teacher_id, int role_id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "add_user";
                    comm.Parameters.AddWithValue("@user_id", user_id);
                    comm.Parameters.AddWithValue("@password", password);
                    comm.Parameters.AddWithValue("@teacher_id", teacher_id);
                    comm.Parameters.AddWithValue("@role_id", role_id);
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region AddAcademicYear
        public static void AddAcademicYear(int subject_id,int class_code,int pupil_id,int teacher_id,int rate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "add_academic_year";
                    comm.Parameters.AddWithValue("@subject_id", subject_id);
                    comm.Parameters.AddWithValue("@class_code", class_code);
                    comm.Parameters.AddWithValue("@teacher_id", teacher_id);
                    comm.Parameters.AddWithValue("@pupil_id", pupil_id);
                    comm.Parameters.AddWithValue("@rate", rate);
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region AddSubjectAtributeValue
        public static void AddSubjectAtributeValue(string atrib_code,string atrib_value)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "add_subject_atribute_value";
                    comm.Parameters.AddWithValue("@atrib_code", atrib_code);
                    comm.Parameters.AddWithValue("@atrib_value", atrib_value);
                  
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region RemoveUser
        public static void RemoveUser(string user_id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "remove_user";
                    comm.Parameters.AddWithValue("@user_id", user_id);

                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region SelectUser
        public static DataTable SelectUser(string user_id)
        {
            DataTable user = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_user";
                    comm.Parameters.AddWithValue("@user_id", user_id);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(user);
                }
            }
            return user;
        }

        #endregion

        #region UpdateUser
        public static void UpdateUser(string user_id, int teacher_id, int role_id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "update_user";
                    comm.Parameters.AddWithValue("@user_id", user_id);
                    //comm.Parameters.AddWithValue("@password", password);
                    comm.Parameters.AddWithValue("@teacher_id", teacher_id);
                    comm.Parameters.AddWithValue("@role_id", role_id);
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region SelectUserWPassword
        public static DataRow SelectUserAll(string user_id)
        {
            DataTable user = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_user_all";
                    comm.Parameters.AddWithValue("@user_id", user_id);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(user);
                }
            }
            return user.Rows[0];
        }
        #endregion

        #region SelectRoles
        public static DataTable SelectRoles()
        {
            DataTable roles = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_roles";
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(roles);
                }
            }
            return roles;
        }
        #endregion

        #region AddTeacher
        public static void AddTeacher(string first_name, string last_name, string personal_id, DateTime birth_date, string contact_number, DateTime job_start_date)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "add_teacher";
                    comm.Parameters.AddWithValue("@first_name", first_name);
                    comm.Parameters.AddWithValue("@last_name", last_name);
                    comm.Parameters.AddWithValue("@personal_id", personal_id);
                    comm.Parameters.AddWithValue("@birth_date", birth_date);
                    comm.Parameters.AddWithValue("@contact_number", contact_number);
                    comm.Parameters.AddWithValue("@job_start_date", job_start_date);
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region SelectPupils
        public static DataTable SelectPupils(int pupil_id = 0)
        {
            DataTable pupils = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_pupil";
                    if (pupil_id != 0)
                    {
                        comm.Parameters.AddWithValue("@pupil_id", pupil_id);
                    }
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(pupils);
                }
            }
            return pupils;
        }
        #endregion

        #region GetPupilsList
        public static DataTable GetPupilsList(int pupil_id = 0)
        {
            DataTable pupils = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "get_pupil_list";
                    comm.Parameters.AddWithValue("@pupil_id", pupil_id);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(pupils);
                }
            }
            return pupils;
        }
        #endregion

        #region SelectPupilsRow
        public static DataRow SelectPupilss(int pupil_id)
        {
            DataTable pupils = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_pupil";
                    comm.Parameters.AddWithValue("@pupil_id", pupil_id);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(pupils);
                }
            }
            return pupils.Rows[0];
        }
        #endregion

        #region SelectPupilByPID
        public static string SelectPupilByPID(string P_ID)
        {
            string pupil_id;
            DataTable pupils = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "get_pupil_by_pid";
                    comm.Parameters.AddWithValue("@personal_id", P_ID);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(pupils);
                }
            }
            DataRow data =  pupils.Rows[0];
            pupil_id = data["pupil_id"].ToString();

            return pupil_id;
        }
        #endregion

        #region RemovePupil
        public static void RemovePupil(int pupil_id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "remove_pupil";
                    comm.Parameters.AddWithValue("@pupil_id", pupil_id);

                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region AddPupil
        public static void AddPupil(string first_name, string last_name, DateTime birth_date, string personal_id, string contact_number, int class_code, string county, string city, string street, int postal_code)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "add_pupil";
                    comm.Parameters.AddWithValue("@first_name", first_name);
                    comm.Parameters.AddWithValue("@last_name", last_name);
                    comm.Parameters.AddWithValue("@birth_date", birth_date);
                    comm.Parameters.AddWithValue("@personal_id", personal_id);
                    comm.Parameters.AddWithValue("@contact_number", contact_number);
                    comm.Parameters.AddWithValue("@class_code", class_code);
                    comm.Parameters.AddWithValue("@country", county);
                    comm.Parameters.AddWithValue("@city", city);
                    comm.Parameters.AddWithValue("@street", street);
                    comm.Parameters.AddWithValue("@postal_code", postal_code);

                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region UpdatePupil
        public static void UpdatePupil(int pupil_id,string first_name,string last_name,DateTime birth_date,string personal_id,string contact_number, int class_code,int address_code,string county, string city , string street, int postal_code)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "update_pupil";

                    comm.Parameters.AddWithValue("pupil_id", pupil_id);
                    comm.Parameters.AddWithValue("first_name",first_name);
                    comm.Parameters.AddWithValue("last_name", last_name);
                    comm.Parameters.AddWithValue("birth_date",birth_date);
                    comm.Parameters.AddWithValue("personal_id",personal_id);
                    comm.Parameters.AddWithValue("contact_number",contact_number);
                    comm.Parameters.AddWithValue("class_code", class_code);
                    comm.Parameters.AddWithValue("address_code",address_code);
                    comm.Parameters.AddWithValue("country",county);
                    comm.Parameters.AddWithValue("city",city);
                    comm.Parameters.AddWithValue("street",street);
                    comm.Parameters.AddWithValue("postal_code",postal_code);

                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region SelectTeacher
        public static DataTable SelectTeacher(int teacher_id=-1)
        {
            DataTable teachers = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_teacher";
                    comm.Parameters.AddWithValue("@teacher_id", teacher_id);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(teachers);
                }
            }
            return teachers;
        }
        #endregion

        #region SelectPupil
        public static DataTable SelectPupil(int pupil_id = -1)
        {
            DataTable pupil = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_pupil";
                    comm.Parameters.AddWithValue("@pupil_id", pupil_id);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(pupil);
                }
            }
            return pupil;
        }
        #endregion

        #region RemoveTeacher
        public static void RemoveTeacher(int teacher_id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "remove_teacher";
                    comm.Parameters.AddWithValue("@teacher_id", teacher_id);

                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region SelectSubjects
        public static DataTable SelectSubjects()
        {
            DataTable subjects = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_subject";
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(subjects);
                }
            }
            return subjects;
        }
        #endregion

        #region SelectSubject
        public static DataTable SelectSubject(int subject_id)
        {
            DataTable subjects = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_subject";
                    comm.Parameters.AddWithValue("subject_id", subject_id);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(subjects);
                }
            }
            return subjects;
        }
        #endregion

        #region SelectSubjectAttributes
        public static DataTable SelectSubjectAttributes(int subject_id)
        {
            DataTable subjects = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_subject_atribute";
                    comm.Parameters.AddWithValue("@subject_id", subject_id);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(subjects);
                }
            }
            return subjects;
        }
        #endregion

        #region GetSubjectByTeacherId
        public static List<int> GetSubjectByTeacherId(int teacher_id)
        {
            List<int> result = new List<int>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_teacher_subject_relation";
                    comm.Parameters.AddWithValue("teacher_id", teacher_id);

                    conn.Open();

                    SqlDataReader res = comm.ExecuteReader();
                    while (res.Read())
                        result.Add(res.GetInt32(1));
                }
            }
            return result;
        }
        #endregion

        #region GetClassByTeacherId
        public static List<int> GetClassByTeacherId(int teacher_id)
        {
            List<int> result = new List<int>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_teacher_class_relation";
                    comm.Parameters.AddWithValue("teacher_id", teacher_id);

                    conn.Open();

                    SqlDataReader res = comm.ExecuteReader();
                    while (res.Read())
                        result.Add(res.GetInt32(0));
                }
            }
            return result;
        }
        #endregion

        #region GetSubjectByPupilId
        public static List<int> GetSubjectByPupilId(int pupil_id)
        {
            List<int> result = new List<int>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_pupil_subject_relation";
                    comm.Parameters.AddWithValue("pupil_id", pupil_id);

                    conn.Open();

                    SqlDataReader res = comm.ExecuteReader();
                    while (res.Read())
                        result.Add(res.GetInt32(0));
                }
            }
            return result;
        }
        #endregion

        #region GetSubjectsByPupilId
        public static DataTable GetSubjectsByPupilId(int pupil_id)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "get_pupils_subjects";
                    comm.Parameters.AddWithValue("@pupil_id", pupil_id);
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);

                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
        #endregion

        #region AddTeacherSubjectRelation
        public static void AddTeacherSubjectRelation(int subject_id, int teacher_id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "add_teacher_subject_relation";

                    comm.Parameters.AddWithValue("@teacher_id", teacher_id);
                    comm.Parameters.AddWithValue("@subject_id", subject_id);

                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region AddTeacherClassRelation
        public static void AddTeacherClassRelation(int class_code, int teacher_id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "add_teacher_class_relation";

                    comm.Parameters.AddWithValue("@teacher_id", teacher_id);
                    comm.Parameters.AddWithValue("@class_code", class_code);

                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region RemoveTeacherSubjectRelation
        public static void RemoveTeacherSubjectRelation(int subject_id, int teacher_id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "remove_teacher_subject_relation";

                    comm.Parameters.AddWithValue("@teacher_id", teacher_id);
                    comm.Parameters.AddWithValue("@subject_id", subject_id);

                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region RemoveTeacherClassRelation
        public static void RemoveTeacherClassRelation(int class_code, int teacher_id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "remove_teacher_class_relation";

                    comm.Parameters.AddWithValue("@teacher_id", teacher_id);
                    comm.Parameters.AddWithValue("@class_code", class_code);

                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region SelectClasses
        public static DataTable SelectClasses()
        {
            DataTable classes = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "select_class";
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(classes);
                }
            }
            return classes;
        }
        #endregion
    }

}



    





