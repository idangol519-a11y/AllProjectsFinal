
import {add} from "./functions.js"
import {subtract} from "./functions.js"
import {mult} from "./functions.js"
import {div} from "./functions.js"

let num1 = prompt("first number");
let func = prompt("choose action: | + || - || * || / | ")
let num2 = prompt("second number");

let res = -1;

switch(func){
case '+':
    res = add(num1,num2);
    break;
case '-':
    res = subtract(num1,num2);
    break;
case '*':
    res = mult(num1,num2);
    break;
case '/':
    res = div(num1,num2);
    break;
default:
    alert("err");
break;
}
console.log(res);
