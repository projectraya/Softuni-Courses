function solve() {
  let text = document.getElementById("text").value;
  let namingConvention = document.getElementById("naming-convention").value;
  let result = document.getElementById('result');

  let inputAsArray = text.toLowerCase().split(' ');

  if(namingConvention === "Pascal Case")
  {
    inputAsArray = inputAsArray.map(w => w.charAt(0).toUpperCase() + w.slice(1));
    result.textContent = inputAsArray.join('');
  
  }else if(namingConvention === "Camel Case")
  {
    inputAsArray = inputAsArray.map(w => w.charAt(0).toUpperCase() + w.slice(1)).toString();
    inputAsArray = inputAsArray.charAt(0).toLowerCase() + inputAsArray.slice(1);
    inputAsArray = inputAsArray.split(',');
    result.textContent = inputAsArray.join('');
    
  }else{
    
    result.textContent = "Error!";
  }

}