/**
 * Ray Hunter
 * Code Challenge 1
 */
var watchThis = function () {    

  var o = Math.round(Math.SQRT2);
  var t = o + o;
  var th = o + t;
  var fo = t * t;
  var fi = fo + o;
  var s = fi + t;
  var e = fo + fo;
  var te = fi + fi;
  var h = te * te;

  var d = String.fromCharCode(te * s + t); // H 72 
  d += String.fromCharCode(h + o); // e 101
  d += String.fromCharCode(h + fi + th); // l 108
  d += String.fromCharCode(h + fi + th); // l 108
  d += String.fromCharCode(h + te + o); // o 111
  d += String.fromCharCode(te * th + t); // space 32
  d += String.fromCharCode(te * e + s); // W 87
  d += String.fromCharCode(h + te + o); // o 111
  d += String.fromCharCode(h + te + fo); // r 114
  d += String.fromCharCode(h + fi + th); // l 108
  d += String.fromCharCode(h); // l 108
  d += String.fromCharCode(te * th + th); // ! 33

  return d;  
};

// print the result
console.log(watchThis());
