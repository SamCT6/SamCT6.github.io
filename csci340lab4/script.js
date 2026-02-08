

var fact = "";
var corp = "";

$("#GetFact").on("click", function() {
    console.log("number");
    $.get("https://uselessfacts.jsph.pl/api/v2/facts/random", (data, status) =>{
        console.log(data);
        const fact = data.text;
        $(".fact").text(fact)
    });
  });

  $("#GetCorp").on("click", function() {
    console.log("corp");
        $.get("https://corporatebs-generator.sameerkumar.website/", (data, status) => {
        console.log(data);
        const corp = data.phrase;
        console.log(corp);
        $(".corp").text(corp)
       
        });
     });
