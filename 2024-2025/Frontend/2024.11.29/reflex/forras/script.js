let myInterval;     // időzítő
let speed=1000;     // ezredmásodperc
let time_limit=9;  // játékidő másodpercben
let time;           // hátralévő másodperc

function time_start () {
    time=time_limit;
    myInterval=setInterval('tiktak()',speed);
}
function tiktak(){
    document.getElementById("time").innerHTML=time+" mp";
    if (time==0) time_stop();
    else time--;
}
function time_stop(){
    clearInterval(myInterval);
}