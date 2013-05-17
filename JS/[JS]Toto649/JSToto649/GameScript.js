function moveSphere() {
	var windowHoles = document.getElementById('sphereHoles');
    style = windowHoles.style;
    style.position = 'absolute';
        
    var degreeToMove = 5;
    //start px positions for the sphere holes
    var top = 180;
    var left = -100; //it is negative because of the start position of the holes

    function animateSphere() {
        var topInRange = top >= 180 && top <= 445;
        var leftInRange = left >= -100 && left <= 545;
                
        if (!topInRange || !leftInRange) {
            degreeToMove = 5;
            top = 180;
            left = -100;
            style.top = 180 + 'px';
            style.left = -100 + 'px';            
        }

         degreeToMove = degreeToMove + 5;
         top = top + degreeToMove;
         left = left + degreeToMove;
         
         style.top = top - degreeToMove + 'px';
         style.left = left + degreeToMove + 'px';
    		
		(function addColor(){
			var c=document.getElementById("ballSphere");
			var ctx=c.getContext("2d");
			var grd=ctx.createLinearGradient(0,0,170,0);
			grd.addColorStop(0,"blue");
			grd.addColorStop(0.5,"#D2F8F8");
			grd.addColorStop(1,"white");
			ctx.fillStyle=grd;
			ctx.fillRect(20,20,150,100);
		})();
    }
			
    setInterval(function () { animateSphere() }, 80);
   		
    return windowHoles;
}

var numberOfBalls = 0;
function winnerBallsChecker(){
	//I use this check to stop picking the balls
	//more than needed six times
	if(numberOfBalls < 6){
	pickNumberBalls();
	}
}

function pickNumberBalls() {
	numberOfBalls++;
	var winnerNumber = Math.floor((Math.random()*49)+1);	
	
	//I have tried to do this with getElementByClassName
    //but this option is still not working properly   
	//on every client (browser)
	var ballContainer = document.getElementById('finalChosenBalls');
	var winnerBall=document.createElement("div");
	var luckyNumber = document.createTextNode(winnerNumber);
	styleWinBall=winnerBall.style;
	styleWinBall.backgroundColor='white';
	styleWinBall.width='85px';
	styleWinBall.height='85px';
	styleWinBall.border = '1px solid black';
	styleWinBall.borderRadius = '50px';
	styleWinBall.display="inline-block"
	styleWinBall.position='relative';
	styleWinBall.textAlign="center";
	ballContainer.fontSize = '40px';
	//luckyNumber.style.marginTop = '50px';
	//luckyNumber.style.top = '50px';
	ballContainer.style.verticalAlign="middle";
	winnerBall.appendChild(luckyNumber);
	ballContainer.appendChild(winnerBall);
	
	//return numberBalls;
}

	//add functionality to the Stop button
	function clearBox(){
		numberOfBalls = 0;
	    var div = document.getElementById('finalChosenBalls');
		while(div.firstChild){
	    div.removeChild(div.firstChild)};
	}

	//add bouncing balls in the rotating sphere		
	function bouncingBalls(){
	var i = 0;
	var sphere = document.getElementById('ballSphere');
	var ball = document.createElement('div');
	var ballTop = 75;
	var ballLeft = 50;
	styleBall = ball.style;	
	styleBall.width ='35px';
	styleBall.height ='35px';
	styleBall.border = '1px solid black';
	styleBall.borderRadius = '15px';		
	styleBall.marginTop = ballTop + 'px';
	styleBall.marginLeft = ballLeft + 'px';
		
	function moveInnerBalls(){
	sphere.appendChild(ball);
	ballTop = ballTop + Math.floor((Math.random()*5)+1) ;	
	ballLeft = ballLeft + Math.floor( (Math.random()* 5) + 1 );
	
	var ballTopInRange = ballTop >= 60 && ballTop <= 165;
    var ballLeftInRange = ballLeft >= 40 && ballLeft <= 165;
                
    if (!ballTopInRange || !ballLeftInRange) {            
            ballTop = 80;
            ballLeft = 50;
            styleBall.marginTop = 80 + 'px';
            styleBall.marginLeft = 50 + 'px';            
        }
	
	styleBall.marginTop = ballTop + ballTop + 'px'; 
	styleBall.marginLeft = ballLeft + ballLeft + 'px';
	}
	setInterval(function () { moveInnerBalls() }, 30);	 
	}
	
	//to-do:
	//fix the font - must be bigger + center
	//add more balls in the sphere