'use strict';
function generateField(){
    var field = document.getElementById('battleField');
    field.style.backgroundColor = 'white';
    field.style.backgroundImage = "url('images/snow.jpg')";
    field.style.width = 600 + 'px';
    field.style.height = 600 + 'px';
    field.style.border = '1px solid black'
    field.style.display = 'inline-block';

    function enemyLines() {
        var enemyField = document.getElementById('enemyFront');
        enemyField.style.backgroundColor = 'white';
        enemyField.style.backgroundImage = "url('images/snow.jpg')";
        enemyField.style.width = 600 + 'px';
        enemyField.style.height = 600 + 'px';
        enemyField.style.border = '1px solid black';
        enemyField.style.display = 'inline-block';

        function enemyTanks() {

            var tankCanHeight = 10;
            var tankCount = 5;
            var documentFragment = document.createDocumentFragment();

            //localStorage.setItem("count", tankCount);
            //use this variable to prevent tanks beening one over another
            var tankTop = 0;

            for (var i = 0; i < tankCount; i++) {
                var tank = document.createElement('img');
                tank.style.position = 'absolute';
                tank.style.top = getRandomPosition(screen.height / 2 + 175, tankCanHeight) + 'px';
                tank.style.left = getRandomPosition(screen.width / 2 + 80, screen.width - 230) + 'px';
                tank.setAttribute('id', i);
                //use this check to prevent tanks beening one over another
                if (tank.style.top < tankTop - 50 || tank.style.top > tankTop + 50) {
                    tank.style.left = getRandomPosition(screen.width / 2 + 80, screen.width - 230) + 'px';
                    tank.style.top = getRandomPosition(screen.height / 2 + 175, tankCanHeight) + 'px';
                }
                tankTop = tank.style.top;
                tank.setAttribute('src', 'images/enemyTank.jpg');
                tank.setAttribute('draggable', 'true');
                tank.setAttribute('ondragstart', 'handleDragStart(event)');
                tank.setAttribute('ondragend', 'handleDragEnd(event)');
                tank.setAttribute('width', '50px');
                tank.setAttribute('height', '50px');
                enemyField.appendChild(tank);
            }

            document.body.appendChild(documentFragment);

            function getRandomPosition(start, end) {
                var random = Math.floor((Math.random() * (end - start) + start));

                return random;
            }
        }

        enemyTanks();
    };
    
    enemyLines();
}

var startGame = (function () {
    var gameStart = new Date().getTime() / 1000;
    localStorage.setItem("start", gameStart);

    var tankCanHeight = 10;
    var tankCount = 5;
    var documentFragment = document.createDocumentFragment();

    localStorage.setItem("count", tankCount);

    for (var i = 0; i < tankCount; i++) {
        var tank = document.createElement('img');
        tank.style.position = 'absolute';
        tank.style.top = getRandomPosition(tankCanHeight, screen.height / 2  + 175) + 'px';
        tank.style.left = getRandomPosition(10, screen.width / 2 - 130) + 'px';
        tank.setAttribute('id', i);
        tank.setAttribute('src', 'images/tank.jpg');
        tank.setAttribute('draggable', 'true');
        tank.setAttribute('ondragstart', 'handleDragStart(event)');
        tank.setAttribute('ondragend', 'handleDragEnd(event)');
        tank.setAttribute('width', '50px');
        tank.setAttribute('height', '50px');
        documentFragment.appendChild(tank);
    }
    document.body.appendChild(documentFragment);

    function getRandomPosition(start, end) {
        var random = Math.floor((Math.random() * (end - start) + start));
        return random;
    }

    function explodeBombs() {
        var field = document.getElementById('battleField');
        var explosion = document.createElement('img');
        
        var path = '';
        var path1 = 'images/explode1.jpg';
        var path2 = 'images/explode2.jpg';
        var path3 = 'images/explode3.jpg';
        var explosionPaths = [];
        explosionPaths.push(path1);
        explosionPaths.push(path2);
        explosionPaths.push(path3);
        var randBomb = Math.floor((Math.random() * 3) + 1);
        if (randBomb == 1) {
            path = path1;
        }
        if (randBomb == 2) {
            path = path2;
        }
        if (randBomb == 3) {
            path = path3;
        }

        explosion.setAttribute('src', path);
        explosion.setAttribute('width', '50px');
        explosion.setAttribute('height', '50px');
        explosion.style.top = getRandomPosition(tankCanHeight, screen.height / 2 + 175) + 'px';
        explosion.style.left = getRandomPosition(10, screen.width / 2 - 130) + 'px';
        explosion.style.position = 'absolute';
        field.appendChild(explosion);

        function removeBombs() {
            field.removeChild(explosion);
        }
        setInterval(function () { removeBombs() }, 3000);
    }     

    setInterval(function () { explodeBombs() }, 500);    
});