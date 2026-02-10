

var answer = "";
var corp = "";


$("#GetAnswer").on("click", function() {
    console.log("answer");
    $.get("https://yesno.wtf/api", (data, status) =>{
        console.log(data);
        const answer = data.answer;
        $(".answer").text(answer)
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
