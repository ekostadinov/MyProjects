function makeid()
{
  
  var name = "";
   
 var date = new Date();
	
var currDate = date.getDate();
   
 var hours = date.getHours();
	
var min = date.getMinutes();

	var sec = date.getSeconds();
	

	name = currDate +
	     
         ' ' +  hours +
	         
     ' ' + min +
	          
    ' ' + sec;
	
   
 return name;
}