using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PROG6222POE
{
    /// <summary>
    /// Interaction logic for Semester.xaml
    /// </summary>
    public partial class Semester : Window
    {
        List<int> numberOfWeeks = new List<int>();//this will store the semester number of weeks
        List<string> startDates = new List<string>(); //this list will be storing the start dates 
        public Semester()
        {
            InitializeComponent();
        }
        //function that will be responsible for saving the  semester data
        private void button_Click(object sender, RoutedEventArgs e)
        {
            semesterData semester = new semesterData();

            int weeks = Convert.ToInt32(semesterWeeks.Text);//this will get the semester weeks captured on the form
                semester.setSemesterWeeks(weeks);
            string chosenDay = startDate.Text;
                semester.setSemesterOpening(chosenDay);


            numberOfWeeks.Add(semester.getSemesterWeeks());//adding the semester weeks to the list
            startDates.Add(semester.getSemesterOpening());//adding the semester opening date

        }


        //function to print the list of modules with the number of hours of self study that is required per module
        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

    }

    public class semesterData 
    {
        int semesterWeeks;
        string semesterStartdate;
        //function to set the semester weeks
        public int setSemesterWeeks(int Weeks) 
        {
            this.semesterWeeks = Weeks;
            return semesterWeeks;
        }

       
        public int getSemesterWeeks() 
        {
           return semesterWeeks;
        }

        //function to set the startDates
        public string setSemesterOpening(string Opening) 
        {
            this.semesterStartdate = Opening;
            return semesterStartdate;
        }

        public string getSemesterOpening() 
        {
            return semesterStartdate;
        }




    }

}