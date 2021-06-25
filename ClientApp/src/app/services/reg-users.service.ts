import { Injectable } from "@angular/core";
import { HttpClient, HttpParams } from "@angular/common/http";
import { RegisteredUsers } from "../models/registeredUsers";
import { map } from "rxjs/operators";
import { Observable } from "rxjs";

//need to use directory file instead of localhost
const usersUrl = "https://localhost:5001/api/users";

@Injectable({
  providedIn: "root"
})
export class RegUsersService {
  constructor(private http: HttpClient) {}
  // default get page 1 and sort ascending by id column
  findUsers(_sort = "id", _order = "ASC", _page = 0): Observable<RegisteredUsers[]> {
    return this.http
      .get(usersUrl, {
        params: new HttpParams()
          .set("_sort", _sort)
          .set("_order", _order)
          .set("_page", _page.toString())
      })
      // use the map() operator to return the data property of the response object
      // the operator enables us to map the response of the Observable stream
      // to the data value
      .pipe(map( res =>  res as RegisteredUsers[]));
  }
}
