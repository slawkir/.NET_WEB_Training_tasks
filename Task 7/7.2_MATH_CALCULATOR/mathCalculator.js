function mathCalculator(str) {

  var result = 0;

  let regexNumbers = /\d+(\.\d+)?/g;
  let numbers = str.match(regexNumbers); 
  
  let regexOperators = /[+\-*/]/g;
  let operators = str.match(regexOperators);  
 
  if (str[0] == '-') {
      result -= Number(numbers[0]);
      operators.shift();
  } else {
      result += Number(numbers[0]);
  }

  for (let i = 1; i < numbers.length; i++) {
    switch (operators[i - 1]) {
      case '-': result -= Number(numbers[i]);
        break;
      case '+': result += Number(numbers[i]);
        break;
      case '*': result *= Number(numbers[i]);
        break;
      case '/': result /= Number(numbers[i]);
        break;
    }
  }

return result;
}

console.log(mathCalculator("3.5 +4*10-5.3 /5 =")); //result = 13.94