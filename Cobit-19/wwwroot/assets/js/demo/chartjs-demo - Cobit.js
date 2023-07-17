$(function () {

 
//radar
var ctxR = document.getElementById("radarChartDF1").getContext('2d');
var myRadarChart = new Chart(ctxR, {
type: 'radar',
data: {
labels: ["EDM01", "EDM02", "EDM03", "EDM04", "EDM05", "APO01", "APO02"],
datasets: [{
label: "Resulting relative importance of each governance/management objective",
data: [10, 15, 5, 35, 30, 0, 40],
backgroundColor: [
'rgba(105, 0, 132, .2)',
],
borderColor: [
'rgba(200, 99, 132, .7)',
],
borderWidth: 2
},
 
]
},
options: {
responsive: true
}
});
	







});
