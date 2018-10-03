const winWidth = window.innerWidth-120;
const winHeight = window.outerHeight-120;
function setup() {
    createCanvas(winWidth, winHeight);
}

function draw() {
    background(0);
    stroke(255);
    strokeWeight(4);
    noFill();

    beginShape();
    let n = map(mouseX, 240, winWidth-240, 0, 36);
    for (let a = 0; a <= n; a++) {
        let x = 250*sin((2*PI*a)/n)+mouseX
        let y = 250*cos((2*PI*a)/n)+mouseY

        vertex(x, y);
    }
    endShape(CLOSE);
}