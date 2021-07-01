import { Component, OnInit } from '@angular/core';
import { Chart } from 'chart.js'
import { map } from 'rxjs/operators';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-data-downloaded-graph',
  templateUrl: './data-downloaded-graph.component.html',
  styleUrls: ['./data-downloaded-graph.component.css']
})
export class DataDownloadedGraphComponent implements OnInit {

  constructor(private service:UserService) { }

  // DayDownloads: any=[];
  HourlyDownloadSize: any=[];

  ngOnInit() {
    const date = new Date();
    let hour = date.getHours();
    let day = date.getDay();
    let month = date.getMonth();
    let year = date.getFullYear();


    // for(let i=0; i<24; i++){
    //   if(hour === 0) {
    //     //set the day equal to previous day
    //     date.setDate(date.getDate() - 1);
    //     day = date.getDay();
    //     month = date.getMonth();
    //     year = date.getFullYear();
    //     hour = 24;
    //   }

    //   this.getHoursDownloads(year, month, day, hour);
    //   hour = hour - 1;
    // }

    // let datasourse = this.HourlyDownloadSize.reverse();
    

    


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
        data: [],
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

  //gets hours downloads, puts into day download array
  // getHoursDownloads(yyyy:number, mm:number, dd:number, hh:number) {

  // }
}