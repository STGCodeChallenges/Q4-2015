function printThatWhichMustNotBeSpoken() {
    var a;
    var space = getValue(a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a);
    var lf = getValue(space,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a);
    var lv = getValue(lf,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a);
    var ls = getValue(lv,a);
    var lt = getValue(ls,a,a,a,a,a,a,a);
    var lo = getValue(lt,a,a,a);
    var li = getValue(lo,a,a,a,a,a,a,a,a);
    var lx = getValue(lo,a,a,a);

    return String.fromCharCode(lf, ls, lt, lt, lo, space, li, lo, lx, lt, lv, ++space);
}

function getValue(first) {
    if (first) {
      return first + (--arguments.length);
    }
    return arguments.length;
}

console.log(printThatWhichMustNotBeSpoken());
