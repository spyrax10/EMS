using System;
using System.Windows.Forms;

namespace classLib
{
    public class msg
    {
        public static string date = DateTime.Now.ToShortDateString();
        public static string time = DateTime.Now.ToShortTimeString();
        public static string logIn = "Account LogIn";
        public static string logOut = "Account LogOut";
        public static string logInVC = "Account LogIn Via Code || ";
        public static string logInErr = "Login Error";
        public static string codeReq = "Code Requested || ";
        public static string codeVerified = "Code Verified || ";
        public static string accCreate = "Account Created";
        public static string codeVerify = "Code Verify";
        public static string verified = "VERIFIED";
        public static string nverified = "NOT VERIFIED";
        public static string sysErr = "SYSTEM ERROR";
        public static string sysName = "SYSTEM";
        public static string codeNUse = "NOT USED";
        public static string codeUse = "USED";
        public static string netErr = " Network Error";
        public static string suc = " Success";
        public static string inc = " Incomplete";
        public static string err = " Error";
        public static string sysLog = "SYSTEM LOGS";
        public static string studList = "STUDENT LIST";
        public static string empList = "EMPLOYEE LIST";
        public static string appClose = "Application Shutdown";
        public static string ver = " VERIFY";
        public static string start = "STARTED";
        public static string online = "ONLINE";
        public static string ended = "ENDED";
        public static string offline = "OFFLINE";
        public static string empty = "-----";
        public static string cor = "CORRECT";
        public static string wro = "WRONG";
        public static string tbu = "TBU";
        public static string iden = "Identification";
        public static string enu = "Enumeration";
        public static string mul = "Multiple Choice";
        public static string pass = "PASSED";
        public static string fail = "FAILED";
        public static string testSum = "TEST RECORD SUMMARY";
        public static string score = "SCORE BREAKDOWN";
       
        public static string updEmp(string empId)
        {
            string msg = "Employee Updated || " + empId;
            return msg;
        }
        public static string updStud(string studId)
        {
            string msg = "Student Updated || " + studId;
            return msg;
        }
        public static string addEmp(string empId)
        {
            string msg = "Employee Registered || " + empId;
            return msg;
        }
        public static string addStud(string studId)
        {
            string msg = "Student Registered || " + studId;
            return msg;
        }
        public static string matchErr()
        {
            string msg = "Password Don't Match!";
            return msg;
        }
        public static string valPass()
        {
            string msg = "Invalid Password Format!(e.g. 123Ab)";
            return msg;
        }
        public static void dataEmpty()
        {
            MessageBox.Show("Data Empty!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void upImg()
        {
            MessageBox.Show("Please Upload a Photo!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void logSuc()
        {
            MessageBox.Show("Login Successful", suc, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void usrErr()
        {
            MessageBox.Show("Incorrect Username / Password Combination!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void invCode()
        {
            MessageBox.Show("Invalid / Expire Code!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void emailVer()
        {
            MessageBox.Show("Email Verified!", suc, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void verMsg()
        {
            MessageBox.Show("Please verify your Email!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void sentMsg()
        {
            MessageBox.Show("Code Successfully Sent!", suc, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void expMsg(string e)
        {
            MessageBox.Show(e, err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void invEmail()
        {
            MessageBox.Show("Invalid Email Format!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void invCharac()
        {
            MessageBox.Show("Invalid Character!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void incMsg()
        {
            MessageBox.Show("Empty Field/s!", inc, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void accSuc()
        {
            MessageBox.Show("Successfully Saved!", suc, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void serverErr()
        {
            MessageBox.Show("Can't connect to server!", netErr, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void noInt()
        {
            MessageBox.Show("Please check your network and try again..", netErr, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void userNeed()
        {
            MessageBox.Show("Please Enter your Username!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void usrInv()
        {
            MessageBox.Show("Username / ID not found!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void idUse()
        {
            MessageBox.Show("ID already been used!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void userUse()
        {
            MessageBox.Show("Username already been used!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void numOnly()
        {
            MessageBox.Show("Numbers Only!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void alExits()
        {
            MessageBox.Show("Already Exits!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void emailAbuse()
        {
            MessageBox.Show("Email can't use again!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void schedCon()
        {
            MessageBox.Show("Schedule Conflict!", err, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void codeEmpUse()
        {
            MessageBox.Show("Code Already been Used!", err, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void studSet()
        {
            MessageBox.Show("Student has already been set!", err, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void examUse()
        {
            MessageBox.Show("Exam Already Started!", err, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void examStart()
        {
            MessageBox.Show("Test Started!", suc, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void accAl()
        {
            MessageBox.Show("Account Already LogIn!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void selQues()
        {
            MessageBox.Show("Please Select a Question...", err, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void alAns()
        {
            MessageBox.Show("Duplicate Answer!", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
