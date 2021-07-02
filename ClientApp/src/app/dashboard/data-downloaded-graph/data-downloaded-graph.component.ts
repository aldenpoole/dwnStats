import { Component, OnInit } from '@angular/core';
import * as Chart from 'chart.js';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-data-downloaded-graph',
  templateUrl: './data-downloaded-graph.component.html',
  styleUrls: ['./data-downloaded-graph.component.css']
})
export class DataDownloadedGraphComponent implements OnInit {

  HourDownloads: number[] = [];

  constructor(private service:UserService) { }

  ngOnInit() {
    const date = new Date();
    let hour = date.getHours();
    let day = date.getDate();
    let month = date.getMonth() + 1;
    if(month === 13) {
      month = 1;
    }
    let year = date.getFullYear();


    
    //set past 24 hours for chart x axis
    let x = hour;
    const hourLabels = [];
    for(let i=0; i<=24; i++) {
      if(x >= 12) {
        if(x === 12) {
          hourLabels.push(x + "pm");
        } else {
          hourLabels.push(x-12 + "pm");
        }
        x = x - 1;
      } else if (x < 12 && x >= 1) {
        hourLabels.push(x + "am");
        x = x - 1;
      } else {
        hourLabels.push(x+12 + "pm");
        x = 23;
      }
    }
    hourLabels.reverse();
    console.log(hourLabels);


    //set download size for each hour
    let y = hour;
    for(let i=0; i<=24; i++){
      if(y === 0) {
        date.setDate(date.getDate() - 1);
        day = date.getDate();
        month = date.getMonth() + 1;
        if(month === 0) {
          month = 12;
        }
        year = date.getFullYear();
        y = 24;
      }
      this.getHoursDownloads(year, month, day, y);
      y = y - 1;
    }
    
    setTimeout(() => {
      console.log(this.HourDownloads);
    }, 500);
    console.log(this.HourDownloads);

    //create chart
    const data = {
      labels: hourLabels,
      datasets: [{
        label: 'Download in Past 24 Hours',
        data: this.HourDownloads,
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

  //gets hours downloads, puts into hour downloads array
  getHoursDownloads(yyyy:number, mm:number, dd:number, hh:number) {
    this.service.getHourDownloads(yyyy, mm, dd, hh).subscribe( 
      (data) => this.HourDownloads.unshift(parseFloat(data.toString()))
    );
  }
}