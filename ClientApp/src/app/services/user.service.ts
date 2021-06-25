import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  readonly APIUrl="https://localhost:5001/api"

  constructor(private http:HttpClient) { }

  getUserDownloads(val:any) {
    return this.http.get(this.APIUrl+'/downloadsbyuser/'+val)
  }


}