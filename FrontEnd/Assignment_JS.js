/**
1. We have an object storing salaries of our team
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
    }
    Write the code to sum all salaries and store in the variable sum. Should be 390 in the example above.
**/
function sumSalaries(obj){
    var sum = 0;
    for(let man in obj){
        if(typeof(obj[man]) == "number"){
            sum+=obj[man];
        }
    }
    return sum;
}
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
    }
console.log(sumSalaries(salaries));
/**
2. Create a function multiplyNumeric(obj) that multiplies all numeric properties of obj by 2
// before the call
    let menu = {
        width: 200,
        height: 300,
        title: "My menu"
    };
    multiplyNumeric(menu);
    // after the call
    menu = {
        width: 400,
        height: 600,
        title: "My menu"
    };
Please note that multiplyNumeric does not need to return anything. It should modify the object in-place
**/
function multiplyNumeric(obj){
    for(let man in obj){
        if(typeof(obj[man]) == "number"){
            obj[man]*=2;
        }
    }
}
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};
multiplyNumeric(menu);
console.log(menu);
/** 
3. Write a function checkEmailId(str) that returns true if str contains '@' and ‘.’, otherwise false. Make sure
'@' must come before '.' and there must be some characters between '@' and '.'
The function must be case-insensitive:
**/
function checkEmailID(str){
    var mailFormat = /^.*@.+\..*$/;
    if (str.match(mailFormat)){
        return true;
    }
    return false;
}
var str_a = "abc@com";
var str_b = "@.";
var str_c = "abc@sss.com";
console.log(checkEmailID(str_a));
console.log(checkEmailID(str_b));
console.log(checkEmailID(str_c));
/** 
4. Create a function truncate(str, maxlength) that checks the length of the str and, if it exceeds maxlength
– replaces the end of str with the ellipsis character "...", to make its length equal to maxlength.
The result of the function should be the truncated (if needed) string.
truncate("What I'd like to tell on this topic is:", 20) = "What I'd like to te..."
truncate("Hi everyone!", 20) = "Hi everyone!"
**/
function truncate(str,maxlength){
    if(str.length>maxlength){
        return str.slice(0,19) + "..."
    }
    return str;
}
console.log(truncate("What I'd like to tell on this topic is:", 20))
/** 
5. 5 arrays operations 
**/
var array = ["James","Brennie"];
console.log(array);
array.push("Robert");
console.log(array);
array[parseInt(array.length/2)] = "Calvin";
console.log(array);
array.shift();
console.log(array);
array.splice(0,0,"Rose","Regal");
console.log(array);