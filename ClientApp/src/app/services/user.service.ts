import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
// import { IDownload } from '../download-size';
// import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  readonly APIUrl="https://localhost:5001/api"

  constructor(private http:HttpClient) { }

  getUserDownloads(val:any) {
    return this.http.get(this.APIUrl+'/downloadsbyuser/'+val);
  }

  getPastDaysDownloads() {
    return this.http.get(this.APIUrl+'/downloadsizes');
  }

}