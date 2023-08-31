using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PROG6222POE
{
    class moduleData
    {
        string moduleCode = "", moduleName ="";
        int moduleCredit = 0, classHours = 0; 
        List<string> moduleCodes = new List<string>();//list to store the module codes
        List<string> moduleNames = new List<string>();//list to store the module Names
        List<int> moduleCredits = new List<int>();//list to store the mdoule credits
        List<int>  moduleHours = new List<int>();//list to store the module hours
        
        //function to save the module data
        public void saveModule() 
        {
            Module module = new Module();

             moduleCode = module.modulecode.Text;//program code
                setModuleCode(moduleCode);

             //moduleName = module.modulename.Text;//module name 
               // setModuleName(moduleName);
            // string credit = module.textBox2.Text.ToString();

            int credit = 0;
            if (int.TryParse(module.modulecredits.Text, out credit))
            {
                moduleCredit += credit; // module number of credits
                setModuleCredit(moduleCredit);
            }

            //moduleCredit += int.Parse(module.modulecredits.Text.ToString());//module number of credits//FIX THIS IT IS RECOGNISED AS A STRING
              //  setModuleCredit(moduleCredit);

//            string hour = module.modulehours.Text.ToString();//FIX THIS TO BE AN INTEGER
  //          classHours += int.Parse(hour);//module class hours per week
             //   setClassHours(classHours);

            int hour = 0;
            if(int.TryParse(module.modulehours.Text, out hour)) 
            {
                classHours += hour;
                setClassHours(classHours);
            }

            //ADD THE COLLECTED TO THE LIST
            moduleCodes.Add(getModuleCode());//adding the module code to the list
            moduleNames.Add(getModuleName());//adding the module code to the list
            moduleCredits.Add(getModuleCredit());//adding  the module code to the list
            moduleHours.Add(getClassHours());//adding the class hours to the list
             

        }


        //function to set the module name 
        public string setModuleCode(string code) 
        {
            
            this.moduleCode = code;
            return moduleCode;
        
        }
        //function to retrieve the module code 
        public string getModuleCode() 
        {
            return moduleCode;
        }
        //function to set the module name
        public string setModuleName(string name)
        {
            this.moduleName = name;
            return moduleName;

        }

        //function to retrieve the module name
        public string getModuleName() 
        {
            return moduleName;
        }

        //function to set the module credits
        public int setModuleCredit(int credit) 
        {
        this.moduleCredit = credit;
            return moduleCredit;
        }

        //function to retrieve the module credits
        public int getModuleCredit() 
        {
            return moduleCredit;
        }


        //function to set the class hours per week 
        public int setClassHours(int time) 
        {
            this.classHours = time;
            return classHours;

        }

        //function to retrieve the class hours per week
        public int getClassHours() 
        {
            return classHours;
        }



    }
}
