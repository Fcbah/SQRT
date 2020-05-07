using Microsoft.AspNetCore.Mvc;
using System;

namespace trial.Controllers
{
    public class sqrtController : Controller
    {
        public ActionResult CompareSqrt()
        {
          return View();  
        }
        
        [HttpPost]
        public ActionResult CompareSqrt(string first_number, string second_number)
        {
            String result;
            try{
                int firstNo = int.Parse(first_number);
                int secondNo = int.Parse(second_number);

                result = "";
                if(firstNo < 0){
                    result += " Error The first Number entered: "+ firstNo +" is invalid (negative)";
                }
                if(secondNo < 0){
                    result += " Error The second Number entered: "+ secondNo +" is invalid (negative)";
                }
                if(result == ""){
                    double sqrtFirst = Math.Sqrt(firstNo);
                    double sqrtSecond = Math.Sqrt(secondNo);

                    if(sqrtFirst > sqrtSecond){
                        result = "The number "+  firstNo + " with square root " + sqrtFirst + " has a higher square root than the number " + secondNo + " with square root "+ sqrtSecond;
                    }
                    else if( sqrtFirst < sqrtSecond){
                        result = "The number "+  firstNo + " with square root " + sqrtFirst + " has a lower square root than the number " + secondNo + " with square root "+ sqrtSecond;
                    }
                    else{
                        result = "The numbers entered are the same value, please enter another number";
                    }
                }

            }
            catch(Exception e){
                result = "Exception error: "+ e.Message;
            }

            
            ViewBag.result = result;
          return View();  
        }
    }
}