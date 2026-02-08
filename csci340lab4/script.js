

var number = 0;
var corp = "";

$("#GetNumber").on("click", function() {
    console.log("number");
    $.get("https://api.math.tools/numbers/nod", (data, status) => {
        const number = data.contents.nod.numbers.number;
        console.log(number);
        console.log(data);
    });
  });

  $("#GetCorp").on("click", function() {
    console.log("corp");
        $.get("https://corporatebs-generator.sameerkumar.website/", (data, status) => {
        console.log(data);
        const corp = data.phrase;
        console.log(corp);
        });
    });