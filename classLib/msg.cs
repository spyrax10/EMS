using System;
using System.Windows.Forms;

namespace classLib
{
    public class msg
    {
        public static string logIn()
        {
            string msg = "Account LogIn";
            return msg;
        }
        public static string logInVC()
        {
            string msg = "Account LogIn Via Code || ";
            return msg;
        }
        public static string logInErr()
        {
            string msg = "Login Error";
            return msg;
        }
        public static string codeReq()
        {
            string msg = "Code Requested || ";
            return msg;
        }
        public static string codeVerified()
        {
            string msg = "Code Verified || ";
            return msg;
        }
        public static string accCreate()
        {
            string msg = "Account Created";
            return msg;
        }
        public static string codeVerify()
        {
            string msg = "Code Verify";
            return msg;
        }
        public static string verified()
        {
            string msg = "VERIFIED";
            return msg;
        }
        public static string nverified()
        {
            string msg = "NOT VERIFIED";
            return msg;
        }
        public static string date()
        {
            string msg = DateTime.Now.ToShortDateString();
            return msg;
        }
        public static string time()
        {
            string msg = DateTime.Now.ToShortTimeString();
            return msg;
        }
        public static string codeNUse()
        {
            string msg = "NOT USED";
            return msg;
        }
        public static string codeUse()
        {
            string msg = "USED";
            return msg;
        }
        public static string netErr()
        {
            string msg = " Network Error";
            return msg;
        }
        public static string suc()
        {
            string msg = " Success";
            return msg;
        }
        public static string inc()
        {
            string msg = " Incomplete";
            return msg;
        }
        public static string err()
        {
            string msg = " Error";
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
        public static void upImg()
        {
            MessageBox.Show("Please Upload a Photo!", err(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void logSuc()
        {
            MessageBox.Show("Login Successful", suc(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void usrErr()
        {
            MessageBox.Show("Incorrect Username / Password Combination!", err(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void invCode()
        {
            MessageBox.Show("Invalid / Expire Code!", err(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void emailVer()
        {
            MessageBox.Show("Email Verified!", suc(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void verMsg()
        {
            MessageBox.Show("Please verify your Email!", err(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void sentMsg()
        {
            MessageBox.Show("Code Successfully Sent!", suc(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void expMsg(string e)
        {
            MessageBox.Show(e, err(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void invEmail()
        {
            MessageBox.Show("Invalid Email Format!", err(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void invCharac()
        {
            MessageBox.Show("Invalid Character!", err(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void incMsg()
        {
            MessageBox.Show("Empty Field/s!", inc(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void accSuc()
        {
            MessageBox.Show("Successfully Saved!", suc(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void serverErr()
        {
            MessageBox.Show("Can't connect to server!", netErr(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void noInt()
        {
            MessageBox.Show("Please check your network and try again..", netErr(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void userNeed()
        {
            MessageBox.Show("Please Enter your Username!", err(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void usrInv()
        {
            MessageBox.Show("Username not found!", err(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void idUse()
        {
            MessageBox.Show("ID already been used!", err(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void numOnly()
        {
            MessageBox.Show("Numbers Only!", err(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void subExits()
        {
            MessageBox.Show("Subject already exits", err(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void emailAbuse()
        {
            MessageBox.Show("Email Can't use again!", err(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void alreadyVer()
        {
            MessageBox.Show("Email Already Verified!", err(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
