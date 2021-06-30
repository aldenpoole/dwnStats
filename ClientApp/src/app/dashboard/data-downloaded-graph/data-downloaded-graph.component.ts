import { Component, OnInit } from '@angular/core';
import { Chart } from 'chart.js'

@Component({
  selector: 'app-data-downloaded-graph',
  templateUrl: './data-downloaded-graph.component.html',
  styleUrls: ['./data-downloaded-graph.component.css']
})
export class DataDownloadedGraphComponent implements OnInit {

  

  constructor() { }

  ngOnInit() {
    const date = new Date();
    let hour = date.getHours();

    const hourLabels = [];
    //loop through hours until comes back around 24;
    for(let i=0; i<=24; i++) {

      if(hour > 12) {
        hour = hour - 12;
      }

      if(hour < 1) {
        hour = hour + 12;
      }

      hourLabels.push(hour);
      hour = hour - 1;
    }

    hourLabels.reverse();

    console.log(hourLabels);

    const data = {
      //have data fill past 24 hours with current hour being last item
      labels: hourLabels,
      datasets: [{
        label: 'Download in Past 24 Hours',
        data: [65, 59, 80, 81, 56, 55, 40, 65, 59, 80, 81, 56, 55, 40,65, 59, 80, 81, 56, 55, 40, 56, 55, 40, 65],
        fill: false,
        borderColor: 'rgb(75, 192, 192)',
        tension: 0.1
      }]
    };

    var myChart = new Chart("myChart", {
      type: 'line',
      data: data
    });
  }
}