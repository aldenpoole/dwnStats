import { Component, OnInit } from '@angular/core';
import { Chart } from 'chart.js';
import { map, tap } from 'rxjs/operators';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-data-downloaded-graph',
  templateUrl: './data-downloaded-graph.component.html',
  styleUrls: ['./data-downloaded-graph.component.css']
})
export class DataDownloadedGraphComponent implements OnInit {

  item!: number;
  DownloadSizes!: number[];
  labels!: string[];

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
          hourLabels.push(x - 12 + "pm");
        }
        x = x - 1;
      } else if (x < 12 && x >= 1) {
        hourLabels.push(x + "am");
        x = x - 1;
      } else {
        hourLabels.push(x + 12 + "pm");
        x = 23;
      }
    }
    this.labels = hourLabels.reverse();
    console.log(this.labels);


    this.getPastDaysDownloads();
    //console.log(this.DownloadSizes);

  }

  //gets hours downloads, puts into hour downloads array
  getPastDaysDownloads() {
    this.service.getPastDaysDownloads().subscribe(
      data => {
        console.log(data);
        //this.createChart(this.labels, this.DownloadSizes)
      })
    }

  createChart(labels:string[], downloadsSizes:number[]) {
    const data = {
      labels: labels,
      datasets: [{
        label: 'Download in Past 24 Hours',
        data: downloadsSizes,
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