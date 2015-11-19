/**
 * Ray Hunter
 * Code Challenge 1
 */
var watchThis = function () {    

  var one = Math.round(Math.SQRT2);
  var two = one + one;
  var three = one + two;
  var four = two * two;
  var five = four + one;
  var seven = five + two;
  var eight = four + four;
  var ten = five + five;
  var hundred = ten * ten;

  var data = String.fromCharCode(ten * seven + two); // H 72 
  data += String.fromCharCode(hundred + one); // e 101
  data += String.fromCharCode(hundred + five + three); // l 108
  data += String.fromCharCode(hundred + five + three); // l 108
  data += String.fromCharCode(hundred + ten + one); // o 111
  data += String.fromCharCode(ten * three + two); // space 32
  data += String.fromCharCode(ten * eight + seven); // W 87
  data += String.fromCharCode(hundred + ten + one); // o 111
  data += String.fromCharCode(hundred + ten + four); // r 114
  data += String.fromCharCode(hundred + five + three); // l 108
  data += String.fromCharCode(hundred); // l 108
  data += String.fromCharCode(ten * three + three); // ! 33

  return data;  
};

// print the result
console.log(watchThis());
