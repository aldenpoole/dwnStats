import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class RegUsersService {

  constructor(private http:HttpClient) { }

  public regUsers() {
    return this.http.get("https://localhost:5001/api/users");
  }
}
