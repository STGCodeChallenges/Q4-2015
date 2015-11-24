function asciiConvert() {
    var space = String.fromCharCode(32);
    var H = String.fromCharCode(72);
    var e = String.fromCharCode(101);
    var l = String.fromCharCode(108);
    var o = String.fromCharCode(111);
    var W = String.fromCharCode(87);
    var r = String.fromCharCode(114);
    var d = String.fromCharCode(100);
    var bang = String.fromCharCode(33);
    return H+e+l+l+o+space+W+o+r+l+d+bang;
}

console.log(asciiConvert())