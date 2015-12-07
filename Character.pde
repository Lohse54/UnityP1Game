Object colObject;

class Character {

  PVector _charSpeed;
  PVector _charLocation;
  PVector _gravity;
  PImage _charImage;
  int ok=3;
  PVector _pcharLocation;

  Character () {
    _pcharLocation = new PVector(0, 0);
    _charLocation = new PVector(50, height/2.3);
    _charSpeed = new PVector(6, 10);
    _gravity = new PVector(0, 12);
    _charImage = loadImage("charTest.gif");
  }

  void charDisplay () {
    image(_charImage, _charLocation.x, _charLocation.y);
  }

  void charMove () {
    //Jumping
    if (ok==0 && _charLocation.y > _pcharLocation.y-(_charImage.height/1.5)) {
      _charLocation.y = _charLocation.y - _charSpeed.y;
      if (_charLocation.y < _pcharLocation.y-(_charImage.height/1.5)) {

        ok=2;
      }
    }
    if (ok==2) {
      _charLocation.y = _charLocation.y + _gravity.y;

      if (_charLocation.y >= _pcharLocation.y) {
        _charLocation.y = _pcharLocation.y;
        ok=3;
      }
    }
    
    if (keyPressed) {
      if (keyCode == LEFT || key == 'a') {
        _charLocation.x = _charLocation.x - _charSpeed.x;
      }
      if (keyCode == RIGHT || key == 'd') {
        _charLocation.x = _charLocation.x + _charSpeed.x;
      }

      if (key == 'w' && ok==3) {
        ok=0;
        _pcharLocation.y = _charLocation.y;
        println("pLocatoin"+_pcharLocation.y);
        println("location:"+_charLocation.y);
      }
      if (key == 'd') {
        if (key == 'w') {
          println("forward");
        }
      }
      if (key == 'a' && key == 'w' && ok==3) {
        ok=0;
        _pcharLocation.y = _charLocation.y;
        println("backward");
      }
    }
    //Jumping forward
    if (ok==0 && _charLocation.y > _pcharLocation.y-(_charImage.height/1.5)) {
      _charLocation.y = _charLocation.y - _charSpeed.y;
      if (_charLocation.y < _pcharLocation.y-(_charImage.height/1.5)) {

        ok=2;
      }
    }
    if (ok==2) {
      _charLocation.y = _charLocation.y + _gravity.y;

      if (_charLocation.y >= _pcharLocation.y) {
        _charLocation.y = _pcharLocation.y;
        ok=3;
      }
    }
    //Jumping backward
    if (ok==0 && _charLocation.y > _pcharLocation.y-(_charImage.height/1.5)) {
      _charLocation.y = _charLocation.y - _charSpeed.y;
      if (_charLocation.y < _pcharLocation.y-(_charImage.height/1.5)) {

        ok=2;
      }
    }
    if (ok==2) {
      _charLocation.y = _charLocation.y + _gravity.y;

      if (_charLocation.y >= _pcharLocation.y) {
        _charLocation.y = _pcharLocation.y;
        ok=3;
      }
    }
  }

  float charLocationY() {
    return _charLocation.y;
  }
}