//Testing
//Variables
int gameState;
PImage backgroundMenu;
PImage backgroundSubMenu;
PImage startButton;
PImage exitButton;
PImage levelsButton;
PImage infoButton;
PImage helpButton;
PImage backButton; //Infamous back-button returns!!
PImage levelDarkButton;
PImage levelAloneButton;
PImage levelKidnapButton;

void setup() {
  size(1920,1080);//size of window 
  backgroundMenu = loadImage("menuBackground.jpg"); //Loading a shit ton of photos! And resizing them to the image
  backgroundMenu.resize(width,height);
  backgroundSubMenu = loadImage("menuBackground2.jpg");
  backgroundSubMenu.resize(width,height);
  startButton = loadImage("startMenu.gif");
  startButton.resize(width/8,height/6);
  exitButton = loadImage("exit.gif");
  exitButton.resize(width/8,height/6);
  levelsButton = loadImage("courses.gif");
  levelsButton.resize(width/8,height/6);
  infoButton = loadImage("info.gif");
  infoButton.resize(width/8,height/6);
  helpButton = loadImage("support.gif");
  helpButton.resize(width/8,height/6);
  backButton = loadImage("back.gif");
  backButton.resize(width/8,height/6);
  levelDarkButton = loadImage("dark.gif");
  levelDarkButton.resize(width/6,height/5);
  levelAloneButton = loadImage("alone.gif");
  levelAloneButton.resize(width/6,height/5);
  levelKidnapButton = loadImage("kidnapping.gif");
  levelKidnapButton.resize(width/6,height/5);
}

void draw(){
  switch(gameState){ //Switch statement for keeping track of placement in game (levels, instructions and so on)
    case 0: //Initial gamestate
    background(backgroundMenu);
    image(startButton,width/2.3,height/1.5);
    image(exitButton,width/2.3,height/1.25);
    if (mousePressed && mouseX > width/2.3 && mouseX < width/2.3 + startButton.width && mouseY > height/1.5 && mouseY < height/1.5 + startButton.height){
      gameState=1;
    }
    if (mousePressed && mouseX > width/2.3 && mouseX < width/2.3 + exitButton.width && mouseY > height/1.25 && mouseY < height/1.25 + exitButton.height){
      exit();
    }
    break;
    case 1: //Sub-menu gamestate
    background(backgroundSubMenu);
    image(levelsButton,width/12,height/3);
    image(infoButton,width/12,height/2.25);
    image(helpButton,width/12,height/1.8);
    image(backButton,width/12,height/1.5);
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + levelsButton.width && mouseY > height/3 && mouseY < height/3 + levelsButton.height){
      gameState=2;
    }
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + infoButton.width && mouseY > height/2.25 && mouseY < height/2.25 + infoButton.height){
      gameState=3;
    }
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + helpButton.width && mouseY > height/1.8 && mouseY < height/1.8 + helpButton.height){
      gameState=4;
    }
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + backButton.width && mouseY > height/1.5 && mouseY < height/1.5 + backButton.height){
      gameState=0;
    }
    break;
    case 2: //Levels gamestate
    background(backgroundSubMenu);
    image(levelsButton,width/12,height/3);
    image(infoButton,width/12,height/2.25);
    image(helpButton,width/12,height/1.8);
    image(backButton,width/12,height/1.5);
    image(levelDarkButton,width/1.8,height/5);
    image(levelAloneButton,width/1.4,height/3);
    image(levelKidnapButton,width/1.8,height/2.2);
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + levelsButton.width && mouseY > height/3 && mouseY < height/3 + levelsButton.height){
      gameState=2;
    }
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + infoButton.width && mouseY > height/2.25 && mouseY < height/2.25 + infoButton.height){
      gameState=3;
    }
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + helpButton.width && mouseY > height/1.8 && mouseY < height/1.8 + helpButton.height){
      gameState=4;
    }
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + backButton.width && mouseY > height/1.5 && mouseY < height/1.5 + backButton.height){
      gameState=0;
    }
    break;
    case 3: //Info gamestate
    background(backgroundSubMenu);
    fill(0);
    text("INFO GAMESTATE",width/2,height/2);
    image(levelsButton,width/12,height/3);
    image(infoButton,width/12,height/2.25);
    image(helpButton,width/12,height/1.8);
    image(backButton,width/12,height/1.5);
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + levelsButton.width && mouseY > height/3 && mouseY < height/3 + levelsButton.height){
      gameState=2;
    }
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + infoButton.width && mouseY > height/2.25 && mouseY < height/2.25 + infoButton.height){
      gameState=3;
    }
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + helpButton.width && mouseY > height/1.8 && mouseY < height/1.8 + helpButton.height){
      gameState=4;
    }
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + backButton.width && mouseY > height/1.5 && mouseY < height/1.5 + backButton.height){
      gameState=0;
    }
    break;
    case 4: //Help gamestate
    background(backgroundSubMenu);
    fill(0);
    text("HELP GAMESTATE",width/2,height/2);
    image(levelsButton,width/12,height/3);
    image(infoButton,width/12,height/2.25);
    image(helpButton,width/12,height/1.8);
    image(backButton,width/12,height/1.5);
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + levelsButton.width && mouseY > height/3 && mouseY < height/3 + levelsButton.height){
      gameState=2;
    }
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + infoButton.width && mouseY > height/2.25 && mouseY < height/2.25 + infoButton.height){
      gameState=3;
    }
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + helpButton.width && mouseY > height/1.8 && mouseY < height/1.8 + helpButton.height){
      gameState=4;
    }
    if (mousePressed && mouseX > width/12 && mouseX < width/12 + backButton.width && mouseY > height/1.5 && mouseY < height/1.5 + backButton.height){
      gameState=0;
    }
    break;
  }
}