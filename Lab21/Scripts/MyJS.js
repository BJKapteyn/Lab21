let mistake = document.getElementById("mistakesMade");
let submit = document.getElementById("submitButt");
let hotOrCold = () => document.getElementById("hotOrCold");



submit.addEventListener('click', function (event) {
    debugger;
    let hotOrColdVal = hotOrCold().value.toUpperCase();
    if (!(hotOrColdVal == "HOT" || hotOrColdVal == "COLD")) {
        event.preventDefault();
        mistake.innerText = "You gotta enter 'hot' or 'cold'";
        setTimeout(function () {
            mistake.innerText = "";
        }, 2000)
    }
});
