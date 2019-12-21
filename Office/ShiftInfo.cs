using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Office
{
    public class ShiftInfo
    {
        public enum ShiftType
        {
            تعداد۱ـمدت۲۴ـکاری۱ـاستراحت۲ = 1,
            تعداد۲ـمدت۱۲ـکاری۲ـاستراحت۲ = 2,
            تعداد۲ـمدت8ـکاری3ـاستراحت1 = 3,
            تعداد3ـمدت8ـکاری۲ـاستراحت۲ = 4,
            تعداد۳ـمدت8ـکاری3ـاستراحت3 = 5
        }
        public enum Shift
        {
            صبح = 1,
            عصر = 2,
            شب = 3,
            استراحت = 4,
            روز = 5,
            شبانه_روز = 6
        }

        //Shift Type
        public ShiftType stShiftType;
       
        //Return Number of Shift in Day
        private int intShiftsCountInDay;
        //Return Numner of Every WorkShift 
        private int intWorkShiftsRepeatCount;
        //Return Numner of RestShift 
        private int intRestShiftRepeatCount;
        //Return DateTime of First Morning Shift of Shift 1
        private DateTime dtShiftOrgin;
        //Start Times of Shifts
        public TimeSpan[] tsShiftStartTimes = new TimeSpan[3];
        
        //Return Number of Shifts in Day
        public int intShiftsCountInDayPty
        {
            get
            {
                return this.intShiftsCountInDay;
            }
            set
            {
                if (value > 0 && value < 5)
                {
                    this.intShiftsCountInDay = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public int intPeriodShiftsCountPty
        {
            get
            {
                return this.intShiftsCountInDayPty + 1;
            }
        }
        //Return Numner of Every WorkShift 
        public int intWorkShiftsRepeatCountPty
        {
            get
            {
                return this.intWorkShiftsRepeatCount;
            }
            set
            {
                if (value > 0 && value < 5)
                {
                    this.intWorkShiftsRepeatCount = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        //Return Numner of RestShift 
        public int intRestShiftRepeatCountPty
        {
            get
            {
                return this.intRestShiftRepeatCount;
            }
            set
            {
                if (value > 0 && value < 5)
                {
                    this.intRestShiftRepeatCount = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        //Return DateTime of First Morning Shift of Shift 1
        public DateTime dtShiftOrginPty
        {
            get
            {
                return this.dtShiftOrgin;
            }
            set
            {
                this.dtShiftOrgin = value;
            }
        }
        //Return Days Number in Period
        public int intPeriodLengethPty
        {
            get
            {
                return (this.intShiftsCountInDayPty * this.intWorkShiftsRepeatCountPty) + this.intRestShiftRepeatCountPty;
            }
        }
        //Return Day Number of Total Work Shifts
        public int intWorkShiftsLengethPty
        {
            get
            {
                return this.intShiftsCountInDayPty * this.intWorkShiftsRepeatCountPty;
            }
        }
  
        //Constructor
        public ShiftInfo()
        {

        }
        //Constructor
        public ShiftInfo(Connection cnConnectionArg,ShiftType stShiftTypeArg, DateTime dtShiftOrginArg)
        {
            this.stShiftType = stShiftTypeArg;
            this.dtShiftOrginPty = dtShiftOrginArg;
            GetShiftType(cnConnectionArg);
        }
        private void GetShiftType(Connection cnConnectionArg)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnectionArg.strConnectionStringPty);
            SqlCommand cmShiftType = new SqlCommand("SELECT * FROM tabShiftType WHERE nvcName = '" + this.stShiftType.ToString() + "'", cnSqlConnection);
            cnSqlConnection.Open();
            SqlDataReader drShiftType = cmShiftType.ExecuteReader();
            while (drShiftType.Read())
            {
                //MessageBox.Show(drShiftType["timShiftStartTime1"].ToString());
                this.tsShiftStartTimes[0] = (TimeSpan)drShiftType["timShiftStartTime1"];
                this.tsShiftStartTimes[1] = (TimeSpan)drShiftType["timShiftStartTime2"];
                this.tsShiftStartTimes[2] = (TimeSpan)drShiftType["timShiftStartTime3"];
                this.intShiftsCountInDayPty = (Byte)drShiftType["intShiftsCountInDay"];
                this.intWorkShiftsRepeatCountPty = (Byte)drShiftType["intWorkShiftsRepeatCount"];
                this.intRestShiftRepeatCountPty = (Byte)drShiftType["intRestShiftRepeatCount"];
            }
            drShiftType.Close();
            cnSqlConnection.Close();
        }
        //Calculate Shift of a Group in Period
        public Shift GetShift(DateTime dtDateTimeArg,Int16 intGroupArg)
        {
            Shift shiShiftLoc = 0;
            int intShiftTemp = 0;

            //Calculation of Basic Duration
            TimeSpan tsBasicDuration = dtDateTimeArg - this.dtShiftOrginPty;
            tsBasicDuration = tsBasicDuration.Add(new TimeSpan(1, 0, 0, 0));

            //Calculation of Durations
            int tsEfectiveDuration = tsBasicDuration.Days % this.intPeriodLengethPty;
            int intRemaining = tsEfectiveDuration % this.intWorkShiftsRepeatCountPty;
            int intDivided = tsEfectiveDuration / this.intWorkShiftsRepeatCountPty;
            //Work Shifts
            if (tsEfectiveDuration >= 1 && tsEfectiveDuration <= this.intWorkShiftsLengethPty)
            {
                if (intRemaining != 0)
                {
                    intShiftTemp = intDivided + 1;
                }
                else
                {
                    intShiftTemp = intDivided;
                }
            }
            //Rest Shifts
            else
            {
                   intShiftTemp = this.intShiftsCountInDayPty + 1;
            }
            switch (this.stShiftType)
            {
                case ShiftType.تعداد۱ـمدت۲۴ـکاری۱ـاستراحت۲:
                    intShiftTemp += intGroupArg - 1;
                    intShiftTemp %= this.intPeriodShiftsCountPty;

                    if (intShiftTemp == 1)
                    {
                        shiShiftLoc = Shift.روز;
                    }
                    if (intShiftTemp == 2)
                    {
                        shiShiftLoc = Shift.استراحت;
                    }
                    if (intShiftTemp == 3)
                    {
                        shiShiftLoc = Shift.استراحت;
                    }
                    break;
                case ShiftType.تعداد۲ـمدت۱۲ـکاری۲ـاستراحت۲:
                    intShiftTemp += intGroupArg - 1;
                    intShiftTemp %= this.intPeriodShiftsCountPty;

                    if (intShiftTemp == 1)
                    {
                        shiShiftLoc = Shift.روز;
                    }
                    if (intShiftTemp == 2)
                    {
                        shiShiftLoc = Shift.شب;
                    }
                    if (intShiftTemp == 3)
                    {
                        shiShiftLoc = Shift.استراحت;
                    }
                    break;
                case ShiftType.تعداد3ـمدت8ـکاری۲ـاستراحت۲:
                    intShiftTemp += intGroupArg - 1;
                    intShiftTemp %= this.intPeriodShiftsCountPty;

                    if (intShiftTemp == 1)
                    {
                        shiShiftLoc = Shift.صبح;
                    }
                    if (intShiftTemp == 2)
                    {
                        shiShiftLoc = Shift.عصر;
                    }
                    if (intShiftTemp == 3)
                    {
                        shiShiftLoc = Shift.شب;
                    }
                    if (intShiftTemp == 4)
                    {
                        shiShiftLoc = Shift.استراحت;
                    }
                    break;
                case ShiftType.تعداد۲ـمدت8ـکاری3ـاستراحت1:
                    intShiftTemp += intGroupArg - 1;
                    intShiftTemp %= this.intPeriodShiftsCountPty;

                    if (intShiftTemp == 1)
                    {
                        shiShiftLoc = Shift.صبح;
                    }
                    if (intShiftTemp == 2)
                    {
                        shiShiftLoc = Shift.عصر;
                    }
                    if (intShiftTemp == 3)
                    {
                        shiShiftLoc = Shift.استراحت;
                    }
                    break;
            }

            //Rest Shift
            return shiShiftLoc;

          
        }
        /// <summary>
        /// Return Shift of Intended Time.
        /// </summary>
        /// <param name="tsIntendedArg">Intended Time</param>
        /// <returns></returns>
        public Shift GetShift(TimeSpan tsIntendedArg)
        {
            Shift shiShiftLoc = 0;
            int intShiftLoc = 0;

            TimeSpan[] tsShiftStartTimesLoc = new TimeSpan[this.tsShiftStartTimes.Length +1];
            for (int j=0;j< this.tsShiftStartTimes.Length;j++)
            {
                tsShiftStartTimesLoc[j] = this.tsShiftStartTimes[j];
            }
            tsShiftStartTimesLoc[this.tsShiftStartTimes.Length] = this.tsShiftStartTimes[0];

            for (int i = 0; i < this.intPeriodShiftsCountPty-1; i++)
            {
                if (tsIntendedArg >= tsShiftStartTimesLoc[i] && tsIntendedArg < tsShiftStartTimesLoc[i + 1])
                {
                    intShiftLoc = i + 1;
                }
            }

            if(tsIntendedArg >= tsShiftStartTimesLoc[tsShiftStartTimesLoc.Length-2] || tsIntendedArg < tsShiftStartTimesLoc[0])
            {
                intShiftLoc = this.intShiftsCountInDayPty;
            }
            shiShiftLoc = GetShiftFromInt(intShiftLoc);

            return shiShiftLoc;
        }
        //Calculate Shift of a Group in Period
        public int GetDay(DateTime dtDateTimeArg, Int16 intGroupArg)
        {
             int intShiftDayLoc = 0;

            //Calculation of Basic Duration
            TimeSpan tsBasicDuration = dtDateTimeArg - this.dtShiftOrginPty;
            tsBasicDuration = tsBasicDuration.Add(new TimeSpan(1, 0, 0, 0));

            //Calculation of Durations
            int tsEfectiveDuration = tsBasicDuration.Days % this.intPeriodLengethPty;
            int intRemaining = tsEfectiveDuration % this.intWorkShiftsRepeatCountPty;
            int intDivided = tsEfectiveDuration / this.intWorkShiftsRepeatCountPty;
            //Work Shifts
            if (tsEfectiveDuration >= 1 && tsEfectiveDuration <= this.intWorkShiftsLengethPty)
            {
                if (intRemaining != 0)
                {
                    intShiftDayLoc = intRemaining;
                }
                else
                {
                    intShiftDayLoc = this.intWorkShiftsRepeatCountPty;
                }
            }
            //Rest Shifts
            else
            {
                if (tsEfectiveDuration == 0)
                {
                    intShiftDayLoc = this.intRestShiftRepeatCountPty;
                }
                else
                {
                    intShiftDayLoc = tsEfectiveDuration - this.intWorkShiftsLengethPty;
                }
            }
            
            return intShiftDayLoc;
        }
        private Shift GetShiftFromInt(int intShiftArg)
        {
            Shift shiShiftLoc = 0;

            switch (this.stShiftType)
            {
                case ShiftType.تعداد۱ـمدت۲۴ـکاری۱ـاستراحت۲:
                    if(intShiftArg == 1)
                    {
                        shiShiftLoc = Shift.شبانه_روز;
                    }
                    if (intShiftArg == 2)
                    {
                        shiShiftLoc = Shift.استراحت;
                    }
                    if (intShiftArg == 3)
                    {
                        shiShiftLoc = Shift.استراحت;
                    }
                    break;
                case ShiftType.تعداد۲ـمدت۱۲ـکاری۲ـاستراحت۲:
                    if (intShiftArg == 1)
                    {
                        shiShiftLoc = Shift.صبح;
                    }
                    if (intShiftArg == 2)
                    {
                        shiShiftLoc = Shift.شب;
                    }
                    if (intShiftArg == 3)
                    {
                        shiShiftLoc = Shift.استراحت;
                    }
                    break;
                case ShiftType.تعداد3ـمدت8ـکاری۲ـاستراحت۲:
                    if (intShiftArg == 1)
                    {
                        shiShiftLoc = Shift.صبح;
                    }
                    if (intShiftArg == 2)
                    {
                        shiShiftLoc = Shift.عصر;
                    }
                    if (intShiftArg == 3)
                    {
                        shiShiftLoc = Shift.شب;
                    }
                    if (intShiftArg == 4)
                    {
                        shiShiftLoc = Shift.استراحت;
                    }
                    break;
                case ShiftType.تعداد۲ـمدت8ـکاری3ـاستراحت1:
                    if (intShiftArg == 1)
                    {
                        shiShiftLoc = Shift.صبح;
                    }
                    if (intShiftArg == 2)
                    {
                        shiShiftLoc = Shift.عصر;
                    }
                    if (intShiftArg == 3)
                    {
                        shiShiftLoc = Shift.شب;
                    }
                    break;
            }

            return shiShiftLoc;
        }
        /// <summary>
        /// Return Date as Shift Standard
        /// </summary>
        /// <param name="dtDesiredArg"></param>
        /// <returns></returns>
        public DateTime GetDate(DateTime dtDesiredArg)
        {
            if (dtDesiredArg.TimeOfDay < this.tsShiftStartTimes[0])
            {
                return dtDesiredArg.AddDays(-1);
            }
            else
            {
                return dtDesiredArg;
            }
        }
        /// <summary>
        /// Return Group Number Based on Intended DateTime
        /// </summary>
        /// <param name="dtIntendedArg"></param>
        /// <returns></returns>
        public int GetGroup(DateTime dtIntendedArg)
        {
            int intGroupLoc;
            Shift intShiftGroup1 = GetShift(dtIntendedArg, 1);
            Shift intShift = GetShift(dtIntendedArg.TimeOfDay);

            intGroupLoc = intShift - intShiftGroup1 + 1;
            if (intGroupLoc <= 0)
            {
                intGroupLoc += this.intPeriodShiftsCountPty;
            }
            
            return intGroupLoc;
        }
        public static Shift ConvertTextToShift(String strShiftTypeArg)
        {
            Shift shiShiftTime = Shift.صبح;

            switch (strShiftTypeArg)
            {
                case "صبح":
                    shiShiftTime = Shift.صبح;
                    break;
                case "عصر":
                    shiShiftTime = Shift.عصر;
                    break;
                case "شب":
                    shiShiftTime = Shift.شب;
                    break;
                case "استراحت":
                    shiShiftTime = Shift.استراحت;
                    break;
                case "روز":
                    shiShiftTime = Shift.روز;
                    break;
                case "شبانه روز":
                    shiShiftTime = Shift.شبانه_روز;
                    break;
                default:
                    shiShiftTime = 0;
                    break;
            }

            return shiShiftTime;
        }
        public static string GetNameByDepartmentAndNumber(Connection cnConnection, SubDepartment sdSearchArg)
        {
            String strNameLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmSubDepartments = new SqlCommand();

            cmSubDepartments.Connection = scConnection;
            cmSubDepartments.CommandText = String.Format("SELECT nvcName FROM tabShifts WHERE intDepartment={0}, intNumber={1}",
                sdSearchArg.intDepartmnt, sdSearchArg.intNumber);

            scConnection.Open();
            SqlDataReader drSubDepartment = cmSubDepartments.ExecuteReader();

            if (drSubDepartment.Read())
            {
                strNameLoc = drSubDepartment["nvcName"].ToString();
            }

            drSubDepartment.Close();
            scConnection.Close();

            return strNameLoc;
        }
    }
}
