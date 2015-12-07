class Object {
  
  PVector _objectLocation;
  PImage _objectImage;
  
  Object (PVector objectLocation, PImage objectImage) {
    _objectLocation = objectLocation;
    _objectImage = objectImage;
  }
  
  void objectDisplay() {
    image(_objectImage, _objectLocation.x, _objectLocation.y);
  }
  
  float objectLocationX () {
    return _objectLocation.x;
  }
  
  float objectLocationY () {
    return _objectLocation.y;
  }
  
  float objectImageWidth () {
    return _objectImage.width;
  }
  
  float objectImageHeight () {
    return _objectImage.height;
  }
}