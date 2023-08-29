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

             moduleCode = module.textBox.Text;//program code
                setModuleCode(moduleCode);

             moduleName = module.textBox1.Text;//module name 
                setModuleName(moduleName);

            moduleCredit = Convert.ToInt32(module.textBox2.Text);//module number of credits
                setModuleCredit(moduleCredit);

            classHours = Convert.ToInt32(module.textBox3.Text);//module class hours per week
                setClassHours(classHours);

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
