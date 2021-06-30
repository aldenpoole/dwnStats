import { Component, OnInit } from '@angular/core';
import { Chart } from 'chart.js'
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-data-downloaded-graph',
  templateUrl: './data-downloaded-graph.component.html',
  styleUrls: ['./data-downloaded-graph.component.css']
})
export class DataDownloadedGraphComponent implements OnInit {

  // TotalDownloads: any=[];


  constructor(private service:UserService) { }

  ngOnInit() {
    const date = new Date();
    let hour = date.getHours();

    //add download size to an array for every hour based on todays date

    const hourLabels = [];
    for(let i=0; i<=24; i++) {
      if(hour>=12) {
        if(hour===12) {
          hourLabels.push(hour + "pm");
        } else {
          hourLabels.push(hour-12 + "pm");
        }
        hour = hour - 1;
      } else if (hour < 12 && hour >= 1) {
        hourLabels.push(hour + "am");
        hour = hour - 1;
      } else {
        hourLabels.push(hour+12 + "pm");
        hour = 23;
      }
    }
    hourLabels.reverse();
    console.log(hourLabels);

    const data = {
      labels: hourLabels,
      datasets: [{
        label: 'Download in Past 24 Hours',
        //get total downloads from each hour
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

  // getAllDownloads() {
  //   this.service.getAllDownloads().subscribe(data => {
  //     this.TotalDownloads=data;
  //   });
  // }
}