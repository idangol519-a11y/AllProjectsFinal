//
export function add(a,b){
return a+b;
}

export function subtract(a,b){
return a-b;
}

export function mult(a,b){
return a*b;
}

export function div(a,b){
if(b==0){
    
    alert("div by zero err");
    return -1;
}else{
    return a/b;
}
}