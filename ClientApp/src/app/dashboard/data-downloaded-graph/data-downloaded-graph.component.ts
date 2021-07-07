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
  labels!: string[];
  downloads: any=[];

  constructor(private service:UserService) { }

  ngOnInit() {
    this.service.getPastDaysDownloads().subscribe(
      data => this.downloads = (data)
    );

    setTimeout(() => {
      this.getPastDaysDownloads();
    }, 2000);


    const date = new Date();
    let hour = date.getHours();

    //set past 24 hours for chart x axis
    const hourLabels = [];
    let x = hour;
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
        hourLabels.push(x + 12 + "am");
        x = 23;
      }
    }

    this.labels = hourLabels.reverse();
    console.log(this.labels);
  }

  getPastDaysDownloads() {
    const date = new Date();
    let hour = date.getHours();
    let day = date.getDate();
    let month = date.getMonth() + 1;
    if(month === 13) {
      month = 1;
    }
    let year = date.getFullYear();

    let chartData = [];
    for(let i=0; i<=24; i++) {
      let num = 0.0;
      if(hour === -1) {
        date.setDate(date.getDate() - 1);
        day = date.getDate();
        month = date.getMonth() + 1;
        if(month === 0) {
          month = 12;
        }
        year = date.getFullYear();
        hour = 23;
      }
      for(let j=0; j<this.downloads.length; j++) {
        if(parseFloat(this.downloads[j].time.slice(11, 13))  === hour) {
          num = num + this.downloads[j].downloadSize;
        }
      }
      chartData.push(num);
      hour = hour - 1;
    }
    console.log(chartData);
    this.createChart(this.labels, chartData.reverse());
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