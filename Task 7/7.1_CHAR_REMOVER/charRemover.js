var text = "У попа была собака";

function removeDoubleChars(str) {
  var separator = ["?", "!", ":", ";", ",", ".", " ", "\t", "\n"];
  var words = [];
  var repeatChar = [];
  var resultStr;
  
  for (let i = 0; i < separator.length; i++) {
    if (text.includes(separator[i])) {
      words = text.split(separator[i]);
    }
  }
  
  for (let j = 0; j < words.length; j++) {
    for (let k = 0; k < words[j].length - 1; k++) {
      for (let m = k + 1; m < words[j].length; m++) {
        if (words[j][k] === words[j][m]) {
          repeatChar.push(words[j][k]);
        }
      }
    }
  }

  resultStr = words.join(' ');

  for (let n = 0; n < repeatChar.length; n++) {
    if (text.includes(repeatChar[n])) {
      resultStr = resultStr.split(repeatChar[n]).join('');
     
    }
  }
  
  console.log(resultStr);
}

removeDoubleChars(text);
